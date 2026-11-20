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
        }
        public async Task QuizInfoRequest()
        {
            try
            {
                numberOfQuestions = comboBoxNumberOfQuestions.SelectedItem.ToString();
                category = comboBoxCategory.SelectedItem.ToString();
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
    }
}
