
using System;
using System.Collections.Generic;
namespace Exam.Domain.Core.ViewModel
{
    public class ExamVM
    {
        public ExamVM()
        {
            this.ExamQuestions = new List<QuestionVM>();
        }

        public int Id { get; set; }
        public string ExamName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<decimal> ExamDuration { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> ExamStartDate { get; set; }

        public virtual ICollection<QuestionVM> ExamQuestions { get; set; }

        public string ApplicationUserId { get; set; }
    }
}
