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
        int categoryId;

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
                numberOfQuestions = comboBoxNumberOfQuestions.SelectedItem?.ToString()
                    ?? throw new InvalidOperationException("Please select the amount of questions");
                category = comboBoxCategory.SelectedValue?.ToString()
                    ?? throw new InvalidOperationException("Please select a category.");
                difficulty = comboBoxDifficulty.SelectedItem?.ToString()
                    ?? throw new InvalidOperationException("Please select the difficulty.");
                questionType = comboBoxQuestionType.SelectedItem?.ToString()
                    ?? throw new InvalidOperationException("Please select the question type.");

                var endpoint = $"{urlBase}amount={numberOfQuestions}&category={category}&difficulty={difficulty}&type={questionType}";
                using var client = new HttpClient();
                using var response = await client.GetAsync(endpoint);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var quizInfo = JsonSerializer.Deserialize<QuizInfo>(json);
                    Quiz quiz = new();
                    quiz.Show();
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
            await CategoryFetch();
            (HttpClient clientNumberOfQuestions, HttpResponseMessage responseNumberOfQuestions) = await QuestionCountFetch();
            comboBoxNumberOfQuestions.DataSource = questionCountListEasy;
        }

        private async Task<(HttpClient clientNumberOfQuestions, HttpResponseMessage responseNumberOfQuestions)> QuestionCountFetch()
        {
            string endpointNumberOfQuestions = "https://opentdb.com/api_count.php?category=" + comboBoxCategory.ValueMember;
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

            if (difficulty == "easy")
            {
                for (int i = 0; i < questionCountEasy; i++)
                {
                    questionCountListEasy.Add(i);
                }
            }
            if (difficulty == "medium")
            {
                for (int i = 0; i < questionCountMedium; i++)
                {
                    questionCountListMedium.Add(i);
                }
            }
            if (difficulty == "hard")
            {
                for (int i = 0; i < questionCountHard; i++)
                {
                    questionCountListHard.Add(i);
                }
            }

            return (clientNumberOfQuestions, responseNumberOfQuestions);
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
    }
}
