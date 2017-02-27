using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your birth year: ");
            var birthYear = Console.ReadLine();

            Console.Write("What is your birth month: ");
            var birthMonth = Console.ReadLine();

            Console.Write("What is your birth day: ");
            var birthDay = Console.ReadLine();

            try
            {
                var strBirthDate = birthDay + "/" + birthMonth + "/" + birthYear;
                var birthDate = DateTime.ParseExact(strBirthDate, "dd/MM/yyyy", null);
                DateTime currDate = DateTime.Now;
                int ageYear = currDate.Year - birthDate.Year;

                if ((currDate < birthDate.AddYears(ageYear)))
                {
                    Console.Write("You are " + ageYear + " years old.");
                }
                else if (ageYear < 0)
                {
                    Console.Write("It's not possible to be less than 0 years old");
                }
                else if (ageYear > 135)
                {
                    Console.Write("It's very unlikely that you are " + ageYear + " years old");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An exception occured: " + ex.Message);
            }
            Console.Read();
            
        }
    }
}
