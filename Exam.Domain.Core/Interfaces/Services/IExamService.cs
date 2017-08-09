using Exam.Domain.Core.ViewModel;
namespace Exam.Domain.Core.Interfaces.Services
{
    public interface IExamService
    {
       ExamVM AddExam(ExamVM examVM);
       QuestionVM AddQuestion(QuestionVM questionVM);
    }
}
