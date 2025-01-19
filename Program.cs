using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            string LowerCaseCharacters = "abcdefghijklmnopqrstuvwxyz";
            string UpperCaseCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string Numbers = "0123456789";
            string SpecialCharacters = "!?-_@#$%^&*/";
            string AllTogether = LowerCaseCharacters + UpperCaseCharacters + Numbers + SpecialCharacters;
            
            int PasswordLength = 8;

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
            else
            {
                Console.WriteLine("Your password is weak");
            }

        }
    }
}