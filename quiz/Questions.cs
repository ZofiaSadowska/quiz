using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace quiz
{
    public class QuestionSet
    {
        [JsonPropertyName("questions")]
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        [JsonPropertyName("question")]
        public string QuestionText { get; set; }

        [JsonPropertyName("answers")]
        public List<string> Answers { get; set; }

        [JsonPropertyName("correct")]
        public string Correct { get; set; }
    }
}
