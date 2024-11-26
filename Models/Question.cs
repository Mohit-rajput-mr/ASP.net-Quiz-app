using System.Collections.Generic;

namespace QuizApp.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionText { get; set; }
        public List<string> Answers { get; set; }
        public List<int> CorrectAnswerIndexes { get; set; }
        public List<int> UserAnswerIndexes { get; set; } = new List<int>();
    }
}
