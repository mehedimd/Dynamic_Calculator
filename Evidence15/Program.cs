using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Evidence15
{
            //1.	Create a console class to take 3 Input from users
                    // a.	2numbers and One Operator
                    // b.Calculate according to user needs.
                    // c.Display Calculated result
    internal class Program
    {
        public double Number1 {  get; set; }
        public double Number2 { get; set; }
        public char Operator {  get; set; }
        public void Result()
        {
            double result = 0;

            switch(Operator)
            {
                case '-': result = Number1 - Number2;  break;
                case '*': result = Number1 * Number2; break;
                case '+': result = Number1 + Number2; break;
                case '/': result = Number1 / Number2; break;
                case '%': result = Number1 % Number2; break;
                default:
                    Console.WriteLine("Operator is not correct format");
                    return; 
                    
            }
            Console.WriteLine($"Your Result {Number1} {Operator} {Number2} = {result}");

        }
        static void Main(string[] args)
        {
            string input = "";

            do
            {
                try
                {
                    Console.WriteLine("Calculate Two Number According to Your Needs.");

                    // Creating Instance
                    Program p = new Program();

                    // user input
                    Console.WriteLine("Enter First Number:");
                    p.Number1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number:");
                    p.Number2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter Operator ('+' or '-' or '*' or '/' or '%'):");
                    p.Operator = Char.Parse(Console.ReadLine());

                    // print result
                    p.Result();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("Thanks for Visiting");
                    Console.WriteLine("Do you want to continue ? 'yes' / 'no' ");
                    input = Console.ReadLine().ToLower();
                }
            } while (input == "yes");

            

            Console.ReadKey();

        }
    }
}
