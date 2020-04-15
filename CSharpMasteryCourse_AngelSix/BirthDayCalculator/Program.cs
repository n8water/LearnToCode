using System;
using System.Globalization;

namespace BirthDayCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IntroduceSavvy();

            var usersDateOfBirth = AskForDateOfBirth();
        }

        public static void IntroduceSavvy()
        {
            Console.WriteLine("Hi, I'm Savvy.\n " +
                "I'm really good at guessing the " +
                "day of the week you were born on.");
        }

        public static DateTimeOffset AskForDateOfBirth()
        {
            Console.WriteLine($"Can I start by asking you " +
                $"what your date of birth is? { CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern }");

            var someString = "Some string";
            var someString2 = "Some " + "string";
            var someInt = 4;
            var someString3 = "Some string " + someInt;
            var someString4 = "I earned " +400.ToString() + " today";
            var someString5 = $"I earned { 400 } today";

            // First version of the string
            var someText = "Today is " + DateTimeOffset.UtcNow.ToString() +
                "and the weather outside is " +
                SomeWeatherProvider.GetWeathertoday().ToString() +
                ". The rainfall is expected to be " +
                RainfallData.HeightInInches.ToString() + " inches.";

            // Second version of the string with interpolation
            var someText2 = $"Today is { DateTimeOffset.UtcNow } " +
                $"and the weather outside is { SomeWeatherProvider.GetWeathertoday() } " +
                $". The rainfall is expected to be { RainfallData.HeightInInches } inches.";

            // Third version of the string
            var todaysDate = DateTimeOffset.UtcNow;
            var todaysWeather = SomeWeatherProvider.GetWeathertoday();
            var rainfall = RainfallData.HeightInInches;

            var someText3 = $"Today is { todaysDate } " +
                $"and the weather outside is { todaysWeather } " +
                $". The rainfall is expected to be { rainfall } inches.";


            var someInvalidString = $" { Console.WriteLine() }";

            var userText = Console.ReadLine();

            return DateTimeOffset.Parse(userText);
        }

        public class SomeWeatherProvider
        {
            public static object GetWeathertoday()
            {
                return new object();
            }
                        
        }

        public class RainfallData
        {
            public static float HeightInInches { get; set; }

        }
    }
}
