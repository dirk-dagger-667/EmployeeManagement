namespace EmplSys.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Enums;

    public class Warning
    {
        public int Id { get; set; }

        [Required]
        public WarningType Type { get; set; }

        [NotMapped]
        public string Description { get; set; }

        [Required]
        public Employee Warner { get; set; }
    }
}
