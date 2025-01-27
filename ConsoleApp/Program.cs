using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            Main3();
        }

        static void Main1()
        {
            string LowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz";
            string UpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Numbers = "0123456789";
            string SpecialCharacters = "!?-_@#$%^&*/";
            string AllTogether = LowerCaseCharacters + UpperCaseCharacters + Numbers + SpecialCharacters;
            
            Console.WriteLine("Enter the number of characters for your password:");
            int PasswordLength = int.Parse(Console.ReadLine());

            Random random = new Random();
            char[] PasswordArray = new char[PasswordLength];
            for (int i = 0; i < PasswordLength; i++)
            {
                PasswordArray[i] = AllTogether[random.Next(AllTogether.Length)];
            }
            string password = new string(PasswordArray);
            Console.WriteLine("Here is your password:");
            Console.WriteLine(password);
            
            bool HasLowerCase = password.Any(char.IsLower);
            bool HasUpperCase = password.Any(char.IsUpper);
            bool HasNumbers = password.Any(char.IsDigit);
            bool HasSpecialCharacters = password.Any(ch => char.IsLetterOrDigit(ch));
            
            if (HasLowerCase && HasUpperCase && HasNumbers && HasSpecialCharacters)
            {
                Console.WriteLine("Your password is strong");
            }
            else if (!HasLowerCase)
            {
                Console.WriteLine("Your password should contain lower case character");
            }
            else if (!HasUpperCase)
            {
                Console.WriteLine("Your password should contain upper case character");
            }
            else if (!HasNumbers)
            {
                Console.WriteLine("Your password should contain a number");
            }
            else if (!HasSpecialCharacters)
            {
                Console.WriteLine("Your password should contain special character");
            }

        }

        static void Main2()
        {
                Console.WriteLine("Please enter your percentage score: ");
                string PercentageScore = Console.ReadLine();
                int Score = int.Parse(PercentageScore);
                
                if (0 <= Score && Score <= 39)
                {
                    Console.WriteLine("You have failed your test ");
                }
                else if (40 <= Score && Score <= 59)
                {
                    Console.WriteLine("You have passed your test ");
                }
                else if (60 <= Score && Score <= 79)
                {
                    Console.WriteLine("Your test score is merit");
                }
                else if (80 <= Score && Score <= 100)
                {
                    Console.WriteLine("Your test score is distinctive");
                }
                else if (0 > Score || Score > 100)
                {
                    Console.WriteLine("Invalid percentage");
                }
                else if (!int.TryParse(Score.ToString(), out Score))
                {
                    Console.WriteLine("Not a number");
                }
        }

        static void Main3()
        {
            Console.WriteLine("Please write your forename");
            string Forename = Console.ReadLine();
            
            Console.WriteLine("Please write your surnname");
            string Surname = Console.ReadLine();
            
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int NumberGen;
            
            Random rand = new Random();

            NumberGen = rand.Next(0, numbers.Length) + rand.Next(0, numbers.Length) + rand.Next(0, numbers.Length);
            string NG = NumberGen.ToString();

            string idcode = Forename[0] + Forename[1] + Surname[0] + Surname[^1].ToString() + NG;
            
            Console.WriteLine("Your student id is" + idcode);
        }
    }
}