namespace EmplSys.Data.Common
{
    public class ValidationConstants
    {
        //Employee
        public const int MaxLengthEmployeeFirstName = 25;
        public const int MaxLengthEmployeeSurName = 25;
        public const int MaxLengthEmployeeLastName = 25;
        public const int MaxLengthEmployeeEmail = 50;
        public const int MaxLengthEmployeePhoneNumber = 13;
        public const int MinLengthEmployeePhoneNumber = 8;

        //Position
        public const int MaxLengthPositionName = 80;

        //AdditionalContactInfo
        public const int MaxLengthACIAddress = 50;
        public const int MaxLengthACIPostalCode = 4;
        public const int MaxLengthACICountryName = 30;
        public const int MaxLengthACIMunicipalityName = 40;
        public const int MaxLengthACIPlaceOfResidence = 25;
        public const int MinLengthACIPostalCode = 4;

        //Office
        public const int MaxLengthOfficeName = 50;

        //Training
        public const int MaxLengthTrainingName = 50;

        //Image
        public const int MaxLengthOriginalFileName = 255;
        public const int MaxLengthFileExtension = 4;

        //Team
        public const int MaxLengthTeamName = 50;

        //Departament
        public const int MaxLengthDepartamentName = 50;
    }
}
