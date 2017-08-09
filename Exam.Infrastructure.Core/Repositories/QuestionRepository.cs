
using Exam.Domain.Core.Interfaces.Repositories;
using Exam.Domain.Core.Models;
using Examinition.Web.Core.Models;
namespace Exam.Infrastructure.Core.Repositories
{
    public class QuestionRepository : BaseRepository<Question>, IQuestionReposatory
    {
        public QuestionRepository(ApplicationDbContext dbContext): base(dbContext)
        {

        }
    }
}
