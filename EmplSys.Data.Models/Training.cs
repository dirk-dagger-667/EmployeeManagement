namespace EmplSys.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Infrastructure;

    public class Training
    {
        private int score;

        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.MaxLengthTrainingName)]
        public string Name { get; set; }


        [Required]
        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(ErrorMesseges.TrainingScoreLessThanZero);
                }
                else if (value > 100)
                {
                    throw new ArgumentOutOfRangeException(ErrorMesseges.TrainingScoreMoreThanAHundred);
                }

                this.score = value;
            }
        }

        [Required]
        public int PassingScore { get; set; }

        public bool IsComplated
        {
            get
            {
                if(this.Score >= this.PassingScore)
                {
                    return true;
                }

                return false;
            }
        }

        [NotMapped]
        public string Description { get; set; }
    }
}
