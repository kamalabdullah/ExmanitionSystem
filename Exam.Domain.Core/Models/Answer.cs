//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Exam.Domain.Core.Models
{
    //test pull request
    public partial class Answer
    {
        public int Id { get; set; }
        public string Answer1 { get; set; }
        public int QuestionId { get; set; }
        public bool IsCorrect { get; set; }
    
        public virtual Question Question { get; set; }
    }
}