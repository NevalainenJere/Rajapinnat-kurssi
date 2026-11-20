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

        public async Task QuizInfoRequest()
        {
            try
            {
                numberOfQuestions = comboBoxNumberOfQuestions.SelectedItem.ToString();
                category = comboBoxCategory.SelectedValue?.ToString()
                    ?? throw new InvalidOperationException("Please select a category.");
                difficulty = comboBoxDifficulty.SelectedItem.ToString();
                questionType = comboBoxQuestionType.SelectedItem.ToString();

                var endpoint = $"{urlBase}amount={numberOfQuestions}&category={category}&difficulty={difficulty}&type={questionType}";
                var client = new HttpClient();
                var response = await client.GetAsync(endpoint);
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
            const string endpointCategory = "https://opentdb.com/api_category.php";
            using var clientCategory = new HttpClient();
            using var responseCategory = await clientCategory.GetAsync(endpointCategory);
            responseCategory.EnsureSuccessStatusCode();

            var jsonCategory = await responseCategory.Content.ReadAsStringAsync();
            var categoryInfo = JsonSerializer.Deserialize<CategoryInfo>(jsonCategory);
            var categories = categoryInfo?.TriviaCategories
                ?? throw new JsonException("The category response did not contain a trivia_categories list.");

            comboBoxCategory.DisplayMember = nameof(TriviaCategory.Name);
            comboBoxCategory.ValueMember = nameof(TriviaCategory.Id);
            comboBoxCategory.DataSource = categories;
        }
    }
}
