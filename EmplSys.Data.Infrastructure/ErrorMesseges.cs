namespace EmplSys.Data.Infrastructure
{
    public class ErrorMesseges
    {
        public const string FirstNameTooLong = "First Name cannot be more than 25 characters long!";
        public const string SurNameTooLong = "Surname cannot be more than 25 characters long!";
        public const string LastNameTooLong = "Last Name cannot be more than 25 characters long!";
        public const string EmailTooLong = "E-mail cannot be more than 50 characters long!";
        public const string EmailInvalidFormat = "Invalid E-mail address format!";
        public const string TrainingScoreLessThanZero = "The training score cannot be less than 0.";
        public const string TrainingScoreMoreThanAHundred = "The training score cannot be more than 100";
    }
}
