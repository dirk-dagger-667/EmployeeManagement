namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;

    public class Team
    {
        private ICollection<Employee> employees;

        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthTeamName)]
        public string Name { get; set; }

        public int? DepartamentId { get; set; }

        [ForeignKey("DepartamentId")]
        public virtual Departament Departament { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }
    }
}
