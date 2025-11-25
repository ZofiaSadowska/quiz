using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz
{
    public class QuestionSet
    {
        public List<Question> Questions { get; set; }
    }

    public class Question
    {
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public string Correct { get; set; }
    }
}
