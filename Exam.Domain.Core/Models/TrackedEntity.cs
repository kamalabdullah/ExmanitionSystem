using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Exam.Domain.Core.Models
{
    public interface ITrackedEntity
    {
        DateTime? CreationDate { get; set; }
        DateTime? LastModificationDate { get; set; }
    }

    public class TrackedEntity : ITrackedEntity
    {
        /// <summary>
        /// Creation Date.
        /// </summary>
        [Column(TypeName = "datetime2")]
        public DateTime? CreationDate
        {
            get; set;
        }

       


         
        /// <summary>
        /// Last Modification date.
        /// </summary>
        public DateTime? LastModificationDate
        {
            get;
            set;
        }

       

        #region Methods
        /// <summary>
        /// Updates the last modified.
        /// </summary>
        protected void UpdateLastModified()
        {
            this.LastModificationDate = DateTime.UtcNow;
        }
        #endregion
    }
}
