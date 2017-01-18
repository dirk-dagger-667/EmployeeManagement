namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Common;

    public class Office
    {
        private ICollection<Employee> employeesOnSite;

        public Office()
        {
            this.EmployeesOnSite = new HashSet<Employee>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthOfficeName)]
        public string Name { get; set; }

        public virtual ICollection<Employee> EmployeesOnSite
        {
            get { return this.employeesOnSite; }
            set { this.employeesOnSite = value; }
        }
    }
}
