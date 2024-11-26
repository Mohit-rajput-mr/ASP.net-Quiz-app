using System.Collections.Generic;
using System.Linq;

namespace QuizApp.Models
{
    public static class QuestionRepository
    {
        public static List<Question> Questions = new List<Question>
        {
            new Question
            {
                Id = 1,
                QuestionText = "Which are the Baltic countries in Europe?",
                Answers = new List<string> { "Lithuania", "Africa", "Estonia", "China", "Latvia", "Brazil" },
                CorrectAnswerIndexes = new List<int> { 0, 2, 4 }
            },
            new Question
            {
                Id = 2,
                QuestionText = "Which is the largest planet in our Solar System?",
                Answers = new List<string> { "Earth", "Mars", "Jupiter", "Saturn", "Neptune", "Venus" },
                CorrectAnswerIndexes = new List<int> { 2 }
            },
            new Question
            {
                Id = 3,
                QuestionText = "Which of these are primary colors?",
                Answers = new List<string> { "Red", "Green", "Blue", "Yellow", "Purple", "Orange" },
                CorrectAnswerIndexes = new List<int> { 0, 2, 3 }
            },
            new Question
            {
                Id = 4,
                QuestionText = "Which of these animals are mammals?",
                Answers = new List<string> { "Shark", "Elephant", "Whale", "Eagle", "Lizard", "Tiger" },
                CorrectAnswerIndexes = new List<int> { 1, 2, 5 }
            },
            new Question
            {
                Id = 5,
                QuestionText = "What are the official languages of Canada?",
                Answers = new List<string> { "English", "Spanish", "German", "French", "Chinese", "Italian" },
                CorrectAnswerIndexes = new List<int> { 0, 3 }
            },
            new Question
            {
                Id = 6,
                QuestionText = "Which are the colors of the Olympic rings?",
                Answers = new List<string> { "Red", "Green", "Blue", "Yellow", "Black", "White" },
                CorrectAnswerIndexes = new List<int> { 0, 1, 2, 3, 4 }
            },
            new Question
            {
                Id = 7,
                QuestionText = "Which countries are part of the United Kingdom?",
                Answers = new List<string> { "England", "Ireland", "Scotland", "Wales", "Northern Ireland", "Iceland" },
                CorrectAnswerIndexes = new List<int> { 0, 2, 3, 4 }
            },
            new Question
            {
                Id = 8,
                QuestionText = "Which of these elements are noble gases?",
                Answers = new List<string> { "Oxygen", "Neon", "Helium", "Nitrogen", "Argon", "Carbon" },
                CorrectAnswerIndexes = new List<int> { 1, 2, 4 }
            },
            new Question
            {
                Id = 9,
                QuestionText = "Which continents are located entirely in the Southern Hemisphere?",
                Answers = new List<string> { "Africa", "South America", "Antarctica", "Asia", "Australia", "Europe" },
                CorrectAnswerIndexes = new List<int> { 2, 4 }
            },
            new Question
            {
                Id = 10,
                QuestionText = "Which of these fruits are considered citrus fruits?",
                Answers = new List<string> { "Apple", "Banana", "Orange", "Lemon", "Grapefruit", "Strawberry" },
                CorrectAnswerIndexes = new List<int> { 2, 3, 4 }
            },
            new Question
            {
                Id = 11,
                QuestionText = "Which of these are prime numbers?",
                Answers = new List<string> { "2", "3", "4", "5", "6", "7" },
                CorrectAnswerIndexes = new List<int> { 0, 1, 3, 5 }
            },
            new Question
            {
                Id = 12,
                QuestionText = "Which programming languages are statically typed?",
                Answers = new List<string> { "JavaScript", "Python", "C#", "Java", "PHP", "Go" },
                CorrectAnswerIndexes = new List<int> { 2, 3, 5 }
            }
        };

        public static Question GetQuestion(int id)
        {
            return Questions.FirstOrDefault(q => q.Id == id);
        }

        public static void StoreUserAnswer(int id, List<int> userAnswerIndexes)
        {
            var question = GetQuestion(id);
            if (question != null)
            {
                question.UserAnswerIndexes = userAnswerIndexes;
            }
        }
    }
}
