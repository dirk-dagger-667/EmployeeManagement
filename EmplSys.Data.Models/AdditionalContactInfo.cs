namespace EmplSys.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;

    public class AdditionalContactInfo
    {
        [Key]
        public int AdditionalContactInfoId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthACIAddress)]
        public string Address { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthACIPostalCode)]
        [MinLength(ValidationConstants.MinLengthACIPostalCode)]
        public string PostalCode { get; set; }

        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public int? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public int? MunicipalityId { get; set; }

        [ForeignKey("MunicipalityId")]
        public virtual Municipality Municipality { get; set; }

        public int? PlaceOfResidenceId { get; set; }

        [ForeignKey("PlaceOfResidenceId")]
        public virtual PlaceOfResidence PlaceOfResidence { get; set; }
    }
}
