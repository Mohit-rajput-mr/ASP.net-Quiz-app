using Microsoft.AspNetCore.Mvc;
using QuizApp.Models;
using System.Linq;

namespace QuizApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.WelcomeMessage = "Welcome! Start answering the questions!";
            ViewBag.AnsweredCount = QuestionRepository.Questions.Count(q => q.UserAnswerIndexes.Any());
            return View();
        }

        [HttpGet]
        public IActionResult Quiz(int id)
        {
            var question = QuestionRepository.GetQuestion(id);
            if (question == null)
            {
                return RedirectToAction("Summary");
            }

            ViewBag.AnsweredCount = QuestionRepository.Questions.Count(q => q.UserAnswerIndexes.Any());
            ViewBag.IsAnswered = question.UserAnswerIndexes.Any();
            return View(question);
        }

        [HttpPost]
        public IActionResult Quiz(int id, List<int> answer)
        {
            QuestionRepository.StoreUserAnswer(id, answer);
            var question = QuestionRepository.GetQuestion(id);
            if (question.CorrectAnswerIndexes.OrderBy(a => a).SequenceEqual(answer.OrderBy(a => a)))
            {
                ViewBag.Result = "Correct!";
            }
            else
            {
                ViewBag.Result = "Incorrect!";
            }

            ViewBag.AnsweredCount = QuestionRepository.Questions.Count(q => q.UserAnswerIndexes.Any());
            ViewBag.IsAnswered = true;
            return View(question);
        }

        public IActionResult Summary()
        {
            var answeredQuestions = QuestionRepository.Questions.Where(q => q.UserAnswerIndexes.Any()).ToList();
            ViewBag.AnsweredCount = answeredQuestions.Count;
            return View(answeredQuestions);
        }

    }

}