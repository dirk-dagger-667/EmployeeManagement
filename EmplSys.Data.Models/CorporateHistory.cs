namespace EmplSys.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CorporateHistories")]
    public class CorporateHistory
    {
        private IList<Position> oldPositions;
        private IList<Warning> warnings;
        private IList<Recommendation> recommendations;
        private int leaveCount;

        public CorporateHistory()
        {
            this.OldPossition = new List<Position>();
        }

        public int Id { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }

        [Required]
        public DateTime TerminationDate { get; set; }

        public int LeaveCount { get; set; }

        public int? EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        public IList<Position> OldPossition
        {
            get { return this.oldPositions; }
            set { this.oldPositions = value; }
        }

        public virtual IList<Warning> Warnings
        {
            get { return this.warnings; }
            set { this.warnings = value; }
        }

        public virtual IList<Recommendation> Recommendations
        {
            get { return this.recommendations; }
            set { this.recommendations = value; }
        }
    }
}
