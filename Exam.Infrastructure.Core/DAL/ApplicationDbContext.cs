
using Exam.Domain.Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
namespace Examinition.Web.Core.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Exam.Domain.Core.Models.Exam> Exams { get; set; }
        public virtual DbSet<Question> Questions { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}