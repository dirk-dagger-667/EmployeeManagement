namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Infrastructure;

    public class Position
    {
        private ICollection<Employee> employees;

        public Position()
        {
            this.Employees = new HashSet<Employee>();
        }

        [Key]
        public int PositionId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthPositionName)]
        public string Name { get; set; }

        [NotMapped]        
        public string Description { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }
    }
}
