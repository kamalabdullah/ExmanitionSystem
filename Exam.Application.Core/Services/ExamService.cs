
using Exam.Domain.Core.Interfaces.Repositories;
using Exam.Domain.Core.Interfaces.Services;
using Exam.Domain.Core.Models;
using System.Collections.Generic;
namespace Exam.Application.Core.Services
{
    public class ExamService: IExamService
    {
        IQuestionReposatory questionRepo;
        IExamRepository examRepo;
        public ExamService(IQuestionReposatory _questionRepo, IExamRepository _examRepo )
        {
            this.questionRepo = _questionRepo;
            this.examRepo = _examRepo;
        }
        public Domain.Core.ViewModel.ExamVM AddExam(Domain.Core.ViewModel.ExamVM examVM)
        {
            if (examVM != null)
            {
                if (examVM.ExamQuestions != null)
                {
                    List<Question> questionList = new List<Question>();
                }
            }

            throw new System.NotImplementedException();
        }

        public Domain.Core.ViewModel.QuestionVM AddQuestion(Domain.Core.ViewModel.QuestionVM questionVM)
        {
            
            throw new System.NotImplementedException();
        }
    }
}
