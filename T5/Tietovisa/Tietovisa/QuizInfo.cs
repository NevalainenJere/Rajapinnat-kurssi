using System.Text.Json.Serialization;

namespace Tietovisa
{
    public class QuizInfo
    {
        public int response_code { get; set; }
        public Result[] results { get; set; }
    }

    public class Result
    {
        public string type { get; set; }
        public string difficulty { get; set; }
        public string category { get; set; }
        public string question { get; set; }
        public string correct_answer { get; set; }
        public string[] incorrect_answers { get; set; }
    }

    public class CategoryInfo
    {
        [JsonPropertyName("trivia_categories")]
        public TriviaCategory[]? TriviaCategories { get; set; }
    }

    public class TriviaCategory
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;
    }
}
