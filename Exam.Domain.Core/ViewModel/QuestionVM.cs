using System.Collections.Generic;
namespace Exam.Domain.Core.ViewModel
{
    public class QuestionVM
    {
        public QuestionVM()
        {
            AnswersList = new List<AnswerVM>();
        }
        public int Id { get; set; }
        public string QuestionTitle { get; set; }
        public List<AnswerVM> AnswersList { get; set; }
    }
}
