
using Exam.Domain.Core.Interfaces.Repositories;
namespace Exam.Infrastructure.Core.Repositories
{
    public class ExamRepository : BaseRepository<Exam.Domain.Core.Models.Exam>, IExamRepository
    {
    }
}
