namespace EmplSys.DataTransferModels.Employee
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using Data.Common;
    using Training;

    public class EmployeeDto
    {
        public int EmployeeId { get; set; }

        [Required()]
        [MaxLength(ValidationConstants.MaxLengthEmployeeFirstName, ErrorMessage = ErrorMesseges.FirstNameTooLong)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmployeeSurName, ErrorMessage = ErrorMesseges.SurNameTooLong)]
        public string SurName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmployeeLastName, ErrorMessage = ErrorMesseges.LastNameTooLong)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthEmployeeEmail, ErrorMessage = ErrorMesseges.EmailTooLong)]
        [EmailAddress(ErrorMessage = ErrorMesseges.EmailInvalidFormat)]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string FullName
        {
            get { return this.FirstName + " " + this.SurName + " " + this.LastName; }
        }

        public bool IsManager { get; set; }

        public int SubordinatesCount { get; set; }

        public bool Terminated { get; set; }

        public int? OfficeId { get; set; }

        public int? AdditionalContactInfoId { get; set; }

        public int? CorporateHistoryId { get; set; }

        public int? ManagerId { get; set; }

        public int? PositionId { get; set; }

        public int? DepartamentId { get; set; }

        public int? TeamId { get; set; }

        public IEnumerable<TrainingResponseModel> TrainingsPassed { get; set; }

        public IEnumerable<SubordinateResponseModel> Subordinates { get; set; }
    }
}
