namespace EmplSys.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Common;

    [Table("Countries")]
    public class Country
    {
        private ICollection<Municipality> municipalities;
        private ICollection<AdditionalContactInfo> additionalEmployeeInfos;

        public Country()
        {
            this.Municipalities = new HashSet<Municipality>();
            this.AdditionalEmployeeInfos = new HashSet<AdditionalContactInfo>();
        }

        [Key]
        public int CountryId { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthACICountryName)]
        public string Name { get; set; }

        public virtual ICollection<AdditionalContactInfo> AdditionalEmployeeInfos
        {
            get { return this.additionalEmployeeInfos; }
            set { this.additionalEmployeeInfos = value; }
        }
        public virtual ICollection<Municipality> Municipalities
        {
            get { return this.municipalities; }
            set { this.municipalities = value; }
        }
    }
}
