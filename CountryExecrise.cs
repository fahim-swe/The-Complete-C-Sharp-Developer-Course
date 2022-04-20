using System;

namespace WorldNamespace
{

    class Program{
        static void Main(string[] args)
        {
            Country countryOne = new Country();
            Country countryTwo = new Country();
            CountryLanguages countryLanguages = new CountryLanguages();

            countryLanguages.FirstLanguage = Language.Bengali.ToString();
            countryLanguages.SecondLanguage = Language.English.ToString();

            countryOne.CountryLanguages = countryLanguages;
            countryOne.PlanetName = "Earth";
            countryOne.CountryName = "Canada";
            countryOne.Currency = Currencies.AUD;
           
            countryOne.sayHi();
            countryOne.sayHi(countryOne.CountryName);
            Console.WriteLine($"{countryOne.Currency}");
        }
    }
    abstract class World{
        private string planetName;
        private Continents continents;

        public string PlanetName{
            get{return planetName;}
            set{planetName = value;}
        }

        public Continents Continents{
            get{return continents;}
            set{
                continents = value;
            }
        }

    }

    enum Continents
    {
        Asia, 
        Africa,
        Antarctica,
        Australia,
        Europe,
        NorthAmerica,
        SouthAmerica
    }



    enum Currencies
    {
        USD,
        EUR,
        JPY,
        GBP,
        AUD,
        CAD
    }



    enum Language
    {
        Arabic,
        Azerbaijani,
        Bengali,
        Hindi,
        English, 
        Russian,
        Spanish
    }

    class Country: World{
        private string countryName;
        private string capital;
        private Currencies currency;

        private CountryLanguages countryLanguages;

        public Country(){
            countryName = "unknown";
            capital = "unknown";
        }

        public Country(string countryName, string capitalName){
            this.countryName = countryName;
            this.capital = capitalName;
        }
        public string CountryName{
            get{return countryName;}
            set{countryName = value;}
        }

        public string Capital{
            get{return capital;}
            set{capital = value;}
        }

        public Currencies Currency{
            get{return currency;}
            set{currency = value;}
        }

        public CountryLanguages CountryLanguages{
            get{return countryLanguages;}
            set{countryLanguages = value;}
        }


        public void sayHi()
        {
            Console.WriteLine("Welcome there...");
        }

        public void sayHi(string country)
        {
            Console.WriteLine($"Welcome to {country}");
        }

    }

    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage{
            set{firstLanguage = value;}
            get{return firstLanguage;}
        }
        
        public string SecondLanguage
        {
            set{secondLanguage = value;}
            get{return secondLanguage;}
        }
    }
}