namespace EmplSys.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Enums;

    public class Recommendation
    {
        public int Id { get; set; }

        [NotMapped]
        public string Description { get; set; }

        [Required]
        public RecommendationType Type { get; set; }

        [Required]
        public Employee Recommender { get; set; }

        public int? CorporateHistoryId { get; set; }

        [ForeignKey("CorporateHistoryId")]
        public virtual CorporateHistory CorporateHistory { get; set; }
    }
}
