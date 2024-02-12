namespace Testt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            IsValidPass(password);
        }

        private static void IsValidPass(string password)
        {
            int numberOfDigits = 0;
            foreach (char d in password)
            {
                if (char.IsDigit(d))
                {
                    numberOfDigits++;
                }
            }
            bool isLetterOrDigits = password.All(char.IsLetterOrDigit);

            if ((password.Length >= 6 && password.Length <= 10) &&
                isLetterOrDigits && numberOfDigits >= 2)
            {
                Console.WriteLine("Password is valid");
                return;
            }
            if (!(password.Length >= 6 && password.Length <= 10))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (isLetterOrDigits == false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (numberOfDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}