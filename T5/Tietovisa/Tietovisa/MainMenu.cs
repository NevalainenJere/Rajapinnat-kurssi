using System.Collections.Immutable;
using System.ComponentModel;
using System.Text.Json;

namespace Tietovisa
{
    public partial class MainMenu : Form
    {
        string urlBase = "https://opentdb.com/api.php?";
        string numberOfQuestions;
        string category;
        string difficulty;
        string questionType;

        List<int> questionCountListEasy = new();
        List<int> questionCountListMedium = new();
        List<int> questionCountListHard = new();

        public MainMenu()
        {
            InitializeComponent();
            Load += MainMenu_Load;
        }

        private async void MainMenu_Load(object? sender, EventArgs e)
        {
            try
            {
                await ComboBoxItemFetch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load quiz categories: " + ex.Message, "Category Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async void QuizInfoRequest()
        {
            try
            {
                category = comboBoxCategory.SelectedValue?.ToString()?.ToLower()
                    ?? throw new InvalidOperationException("Please select a category.");
                questionType = comboBoxQuestionType.SelectedItem?.ToString()?.ToLower()
                    ?? throw new InvalidOperationException("Please select the question type.");
                difficulty = comboBoxDifficulty.SelectedItem?.ToString()?.ToLower()
                    ?? throw new InvalidOperationException("Please select the difficulty.");
                numberOfQuestions = comboBoxNumberOfQuestions.SelectedItem?.ToString()
                    ?? throw new InvalidOperationException("Please select the amount of questions");

                int numberOfQuestionsInt = Convert.ToInt32(numberOfQuestions);

                if (questionType == "multiple choice")
                {
                    questionType = "multiple";
                }
                else
                {
                    questionType = "boolean";
                }

                var endpoint = $"{urlBase}amount={numberOfQuestions}&category={category}&difficulty={difficulty}&type={questionType}";
                using var client = new HttpClient();
                using var response = await client.GetAsync(endpoint);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var quizInfo = JsonSerializer.Deserialize<QuizInfo>(json);
                    var quizInfoString = quizInfo?.ToString();

                    if (questionType == "multiple")
                    {
                        QuizMultipleChoice quiz = new(quizInfo, numberOfQuestionsInt);
                        quiz.Show();
                        quiz.FormClosed += (_, _) => Show();
                        Hide();
                    }
                    else if (questionType == "boolean")
                    {
                        QuizBoolean quiz = new(quizInfo, numberOfQuestionsInt);
                        quiz.Show();
                        quiz.FormClosed += (_, _) => Show();
                        Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode.ToString(), "API Request Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStartQuiz_Click(object sender, EventArgs e)
        {
            QuizInfoRequest();
        }
        private async Task ComboBoxItemFetch()
        {
            if (comboBoxCategory.Items.Count == 0)
            {
                await CategoryFetch();
            }
            if (comboBoxCategory.SelectedItem != null & comboBoxDifficulty.SelectedItem != null)
            {
                comboBoxNumberOfQuestions.Items.Clear();

                var categoryId = comboBoxCategory.SelectedValue;

                string endpointNumberOfQuestions = "https://opentdb.com/api_count.php?category=" + categoryId;
                using var clientNumberOfQuestions = new HttpClient();
                using var responseNumberOfQuestions = await clientNumberOfQuestions.GetAsync(endpointNumberOfQuestions);
                responseNumberOfQuestions.EnsureSuccessStatusCode();

                var jsonNumberOfQuestions = await responseNumberOfQuestions.Content.ReadAsStringAsync();
                var numberOfQuestionsInfo = JsonSerializer.Deserialize<QuestionCountInfo>(jsonNumberOfQuestions);

                var questionCountEasy = numberOfQuestionsInfo?.category_question_count.total_easy_question_count
                    ?? throw new JsonException("The response did not contain a question count.");
                var questionCountMedium = numberOfQuestionsInfo?.category_question_count.total_medium_question_count
                    ?? throw new JsonException("The response did not contain a question count.");
                var questionCountHard = numberOfQuestionsInfo?.category_question_count.total_hard_question_count
                    ?? throw new JsonException("The response did not contain a question count.");

                if (questionCountEasy > 50)
                {
                    questionCountEasy = 50;
                }
                if (questionCountMedium > 50)
                {
                    questionCountMedium = 50;
                }
                if (questionCountHard > 50)
                {
                    questionCountHard = 50;
                }

                if (difficulty == "easy")
                {
                    for (int i = 1; i < questionCountEasy; i++)
                    {
                        questionCountListEasy.Add(i);
                        comboBoxNumberOfQuestions.Items.Add(i);
                    }
                }
                else if (difficulty == "medium")
                {
                    for (int i = 1; i < questionCountMedium; i++)
                    {
                        questionCountListMedium.Add(i);
                        comboBoxNumberOfQuestions.Items.Add(i);
                    }
                }
                else if (difficulty == "hard")
                {
                    for (int i = 1; i < questionCountHard; i++)
                    {
                        questionCountListHard.Add(i);
                        comboBoxNumberOfQuestions.Items.Add(i);
                    }
                }
                else
                {
                    MessageBox.Show("Hähh?");
                }
            }
        }

        private async Task CategoryFetch()
        {
            const string endpointCategory = "https://opentdb.com/api_category.php";
            using var clientCategory = new HttpClient();
            using var responseCategory = await clientCategory.GetAsync(endpointCategory);
            responseCategory.EnsureSuccessStatusCode();

            var jsonCategory = await responseCategory.Content.ReadAsStringAsync();
            var categoryInfo = JsonSerializer.Deserialize<CategoryInfo>(jsonCategory);
            var categories = categoryInfo?.TriviaCategories
                ?? throw new JsonException("The category response did not contain a 'categories' list.");

            comboBoxCategory.DisplayMember = nameof(TriviaCategory.Name);
            comboBoxCategory.ValueMember = nameof(TriviaCategory.Id);
            comboBoxCategory.DataSource = categories;

        }

        private async void comboBoxDifficulty_SelectedIndexChanged(object sender, EventArgs e)
        {
            difficulty = comboBoxDifficulty.SelectedItem.ToString().ToLower();
            await ComboBoxItemFetch();
        }

        private async void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await ComboBoxItemFetch();
        }
    }
}
