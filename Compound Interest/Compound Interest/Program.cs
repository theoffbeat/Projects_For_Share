using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            CI ci = new CI();

            Console.WriteLine("Calcuate compound interest");
            ci.CalculateInterest();

            Console.ReadLine();
        }
    }

    class CI
    {
        private double GetUserInput()
        {
            double myOut = 0;
            bool isDouble = true;
            do
            {
                string user = Console.ReadLine();
                isDouble = double.TryParse(user, out myOut);
                if (!isDouble)
                {
                    Console.WriteLine("You entered in an incorrect datatype.");
                    Console.WriteLine("Please enter in a number.");
                }

            } while (!isDouble);


            return myOut;
        }

        private double GetAccount()
        {
            Console.WriteLine("Please enter the amount in your bank account: ");
            return GetUserInput();
        }

        private double GetInterest()
        {
            Console.WriteLine("Please enter the interest you are going to earn (integer value): ");
            return GetUserInput() / 100;
        }

        private int GetYears()
        {
            Console.WriteLine("Please enter the number of years in the account: ");
            return (int)GetUserInput();
        }

        public void CalculateInterest()
        {
            double account = GetAccount();
            double interest = GetInterest();
            double years = GetYears();

            double myAccount = (1 + (interest / 12));
            double exponent = 12 * years;
            decimal finalAccount = Convert.ToDecimal(account * Math.Pow(myAccount, exponent));
            Console.WriteLine("After {0} years you will have ${1:0,000.00}", years, finalAccount);
        }




    }
}
