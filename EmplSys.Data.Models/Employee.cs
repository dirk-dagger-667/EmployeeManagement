﻿namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Enums;
    using Common;

    public class Employee
    {
        private ICollection<Employee> subordinates;
        private ICollection<Training> trainings;

        public Employee()
        {
            this.Subordinates = new HashSet<Employee>();
            this.Trainings = new HashSet<Training>();
        }

        public int Id { get; set; }

        [Required]
        public GenderTypes Gender { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmployeeFirstName)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmployeeSurName)]
        public string SurName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmployeeLastName)]
        public string LastName { get; set; }

        [Required]
        [MinLength(ValidationConstants.MinLengthEmployeePhoneNumber)]
        [MaxLength(ValidationConstants.MaxLengthEmployeePhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [Index(IsUnique = true)]
        [MaxLength(ValidationConstants.MaxLengthEmployeeEmail)]
        public string Email { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.SurName + " " + this.LastName;
            }

        }

        [NotMapped]
        public bool IsManager
        {
            get
            {
                if (this.SubordinatesCount != 0)
                {
                    return true;
                }

                return false;
            }
        }

        [NotMapped]
        public int SubordinatesCount
        {
            get { return this.Subordinates.Count; }
        }

        public bool Terminated { get; set; }

        public int? OfficeId { get; set; }

        [ForeignKey("OfficeId")]
        public virtual Office Office { get; set; }

        public int? AdditionalContactInfoId { get; set; }

        [ForeignKey("AdditionalContactInfoId")]
        public virtual AdditionalContactInfo AdditionalContacetInfo { get; set; }

        public int? CorporateHistoryId { get; set; }

        [ForeignKey("CorporateHistoryId")]
        public virtual CorporateHistory CorporateHistory { get; set; }

        public int? ManagerId { get; set; }

        [ForeignKey("ManagerId")]
        public virtual Employee Mananger { get; set; }

        public int? PositionId { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        public int? DepartamentId { get; set; }

        [ForeignKey("DepartamentId")]
        public virtual Departament Departament { get; set; }

        public int? TeamId { get; set; }

        [ForeignKey("TeamId")]
        public virtual Team Team { get; set; }

        public virtual ICollection<Training> Trainings
        {
            get { return this.trainings; }
            set { this.trainings = value; }
        }

        public virtual ICollection<Employee> Subordinates
        {
            get { return this.subordinates; }
            set { this.subordinates = value; }
        }
    }
}
