using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Spencer Henze
//ITM 320
//John Wee
//9/1/2016

namespace Vending_Ver_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayGreeting();
            double myPrice = SelectProduct();
            double myCredit = EnterAmount();
            CalculateChange(myPrice, myCredit);
            Console.ReadLine();
        }  //END MAIN

        public static void DisplayGreeting()  //greet the customer, they like that :)
        {
            Console.WriteLine("Don't Be Hungry, Get A Snack! \n");
        } // End of DisplayGreeting()

        public static double SelectProduct() // define variable "myPrice" based on selection
        {
            double myPrice = 0;  //initiate the myPrice variable
            Console.WriteLine("Make your snack selection: Candy A: $1.50 Candy B: $ 0.55 Candy C: $1.35 \n");
            Char answer = Convert.ToChar(Console.ReadLine());
            if (answer == 'A' || answer == 'a')  //here it's important to specify that both capital and lowercase inputs will work. Otherwise if the user inputs the wrong one, the variable myPrice will default to zero.
            {
                myPrice = 1.50;
            }
            if (answer == 'B' || answer == 'b')
            {
                myPrice = 0.55;
            }
            if (answer == 'C' || answer == 'c')
            {
                myPrice = 1.35;
            }
            return myPrice;
        } // End Of SelectProduct()

        public static double EnterAmount() // User deines the amount for myCredit
        {
            double myCredit = 0;  //initiate the myCredit variable
            Console.WriteLine("\nPlease Enter The Amount You Will Deposit: \n");
            myCredit = Convert.ToDouble(Console.ReadLine());
            return myCredit;  //returns variable myCredit to the main method
        } // End Of EnterAmount()

        public static double CalculateChange(double myPrice, double myCredit) // Calculate change and return the value to the main method (must use double rather than void).
        {
            double change = 0;  //initiate the "change" variable that will be defined using conditional statements below.
            if (myPrice == myCredit)
            {
                Console.WriteLine("\nThank You!");
                Console.WriteLine("See you next time!");

            }
            else if (myPrice < myCredit)  //Don't know if it's necessary to use "else if" but if the first condition is false, program moves on to test this condition next.
            {
                change = (myCredit - myPrice);  //if the above logic is true, this is the value for change.
                Console.WriteLine("\nThank You, Your change is: " + change);
                Console.WriteLine("See you next time!");

            }
            else if (myPrice > myCredit)
            {
                Console.WriteLine("\nPlease insert more money.\n");
            }
            return change;  //return variable change to the main method
        }


    }
}

