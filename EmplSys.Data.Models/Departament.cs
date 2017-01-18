namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Common;

    public class Departament
    {
        private ICollection<Employee> employees;
        private ICollection<Team> teams;

        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthDepartamentName)]
        public string Name { get; set; }

        public virtual ICollection<Employee> Employees
        {
            get { return this.employees; }
            set { this.employees = value; }
        }

        public virtual ICollection<Team> Teams
        {
            get { return this.teams; }
            set { this.teams = value; }
        }
    }
}
