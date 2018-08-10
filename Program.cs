using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;


namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("You: Welcome to Budget! We have a wide variety of available items!: Apples, Avocados, Bananas, Cherries, and Grapes ");
            ReadLine();

            

            WriteLine("Customer: Hello, my name is Johnathan Davis, I would like to know the price of your items, to start with how much are the apples?");
            ReadLine();

            double apples = 0;
            WriteLine("You: I'm glad you asked, the price of the apples is [ENTER PRICE]: ");
            apples = Convert.ToDouble(ReadLine());

            WriteLine("Customer ${0}? isn't bad, how much are the Avocados?", apples);
            ReadLine();

            double avocados = 0;
            WriteLine("You: The best prices in town, they are: [ENTER PRICE]");
            avocados = Convert.ToDouble(ReadLine());

            WriteLine("Customer: ${0}? That's Fantastic! Mind telling me how much the Bananas are?", avocados);
            ReadLine();

            double bananas = 0;
            WriteLine("You: Oh yeah, they are: [ENTER PRICE]");
            bananas = Convert.ToDouble(ReadLine());

            WriteLine("Customer: Wow! ${0} is so cheap! I need to know the prices of your cherries!", bananas);
            ReadLine();

            double cherries = 0;
            WriteLine("You: We have the best cherries available for the best price of: [ENTER PRICE]");
            cherries = Convert.ToDouble(ReadLine());

            WriteLine("Customer: ${0}? You have got me sold! Last, the price your grapes?", cherries);
            ReadLine();

            double grapes = 0;
            WriteLine("You: A mere price of: [ENTER PRICE]");
            grapes = Convert.ToDouble(ReadLine());

            WriteLine("Customer: Awesome!, and what is my final total?");
            ReadLine();

            double result = (apples + avocados + bananas + cherries + grapes);
            WriteLine("Well before taxes we have: ${0}", result);
            ReadLine();

            double tax = (result * .06);
            double final = (result + tax);
            WriteLine("Our tax here is 6%, so the total tax will be: ${0}, and thus our final with tax is ${1}", tax, final);
            ReadLine();
        }
    }
}
