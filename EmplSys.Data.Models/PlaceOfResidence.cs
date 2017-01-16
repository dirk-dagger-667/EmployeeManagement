namespace EmplSys.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Infrastructure;
    using System.Collections.Generic;

    [Table("PlacesOfResidence")]
    public class PlaceOfResidence
    {
        private ICollection<AdditionalContactInfo> additionalEmployeeInfos;

        public PlaceOfResidence()
        {
            this.AdditionalEmployeeInfos = new HashSet<AdditionalContactInfo>();
        }

        [Key]
        public int PlaceOfResidenceId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthPlaceOfResidence)]
        public string Name { get; set; }

        public int? MunicipalityId { get; set; }

        public virtual Municipality Municipality { get; set; }

        public virtual ICollection<AdditionalContactInfo> AdditionalEmployeeInfos
        {
            get { return this.additionalEmployeeInfos; }
            set { this.additionalEmployeeInfos = value; }
        }
    }
}
