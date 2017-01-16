namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Infrastructure;

    [Table("Municipalities")]
    public class Municipality
    {
        private ICollection<AdditionalContactInfo> additionalEmployeeInfos;
        private ICollection<PlaceOfResidence> placesOfResidence;

        public Municipality()
        {
            this.PlacesOfResidence = new HashSet<PlaceOfResidence>();
            this.AdditionalEmployeeInfos = new HashSet<AdditionalContactInfo>();
        }

        [Key]
        public int MunicipalityId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthMunicipalityName)]
        public string Name { get; set; }

        public int? CountryId { get; set; }

        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public virtual ICollection<AdditionalContactInfo> AdditionalEmployeeInfos
        {
            get { return this.additionalEmployeeInfos; }
            set { this.additionalEmployeeInfos = value; }
        }

        public virtual ICollection<PlaceOfResidence> PlacesOfResidence
        {
            get { return this.placesOfResidence; }
            set { this.placesOfResidence = value; }
        }
    }
}
