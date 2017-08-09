
namespace Exam.Domain.Core.ViewModel
{
    public class AnswerVM
    {
        public int Id { get; set; }
        public string Answer1 { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
    
    }
}
