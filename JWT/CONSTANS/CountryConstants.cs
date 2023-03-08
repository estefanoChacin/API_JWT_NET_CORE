using JWT.Models;

namespace JWT.CONSTANS
{
    public class CountryConstants
    {
        public static List<CountryModel> ciudades = new List<CountryModel>() { 
           new CountryModel(){ name = "colombia", continent = "america latina"},
           new CountryModel(){ name = "venezuela", continent = "america latina"},
           new CountryModel(){ name = "peru", continent = "america latina"},
           new CountryModel(){ name = "bolivia", continent = "america latina"}

        };
    }
}
