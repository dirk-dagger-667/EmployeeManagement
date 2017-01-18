namespace EmplSys.Data.Models
{
    using EmplSys.Data.Common;
    using System.ComponentModel.DataAnnotations;

    public class Image
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthOriginalFileName)]
        public string OriginalFileName { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthFileExtension)]
        public string FileExtension { get; set; }

        public string UrlPath { get; set; }
    }
}
