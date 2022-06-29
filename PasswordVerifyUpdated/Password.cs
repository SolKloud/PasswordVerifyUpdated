// See https://aka.ms/new-console-template for more information
using System;
namespace PasswordVerifyUpdated
{
    public class Password
    {
        static int MaxPasswordLength = 8;
        public static void VerifyPassword(string password)
        {
            try
            {
                //TO CHECK PASSWORD LENGTH
                if (password.Length < MaxPasswordLength)
                {
                    throw new Exception("The password is less than 8 digits");
                }

                //TO CHECH PASSWORD NULL OR NOT
                else if (string.IsNullOrWhiteSpace(password))
                {
                    throw new Exception("The password cannot be null");
                }
                //TO CHECK PASSWORD CONTAINS DIGIT

                else if (!password.Any(char.IsDigit))
                {
                    throw new Exception("The password should have atleast one digit");
                }
                //TO CHECK IT CONTAINS UPPER CASE OR NOT
                else if (!password.Any(char.IsUpper))
                {
                    throw new Exception("The password should contain uppercase");
                }
                //TO CHECK IT CONTAINS LOWER CASE OR NOT
                else if (!password.Any(char.IsLower))
                {
                    throw new Exception("The password should contain lower case");

                }
                Console.WriteLine("The password is valid");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

         static void Main(String[] args)
        {
            Console.WriteLine("Enter the Password");
            string password = Console.ReadLine();
            VerifyPassword(password);
        }
    }
}
