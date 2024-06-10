using System.Text.RegularExpressions;
namespace PaySky.Application.Common
{
    public static class CountryIdValidation
    {

        public static bool ValidateEgyptID(string id)
        {
            string pattern = @"^[23]\d{13}$";
            return Regex.IsMatch(id, pattern);
        }

        public static bool ValidateUAEID(string id)
        {
            string pattern = @"^\d{3}-\d{4}-\d{7}-\d{1}$";
            return Regex.IsMatch(id, pattern);
        }

        public static bool ValidateSaudiID(string id)
        {
            string pattern = @"^[12]\d{9}$";
            return Regex.IsMatch(id, pattern);
        }
    }
}
