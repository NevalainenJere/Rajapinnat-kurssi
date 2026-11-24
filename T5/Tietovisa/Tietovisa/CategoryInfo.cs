using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Tietovisa
{
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
