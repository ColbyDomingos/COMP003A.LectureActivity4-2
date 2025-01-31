//Author: Colby D
//Course: COMP003A
//Faculty: Jonathan Rodrigo Cruz
//Purpose: Practice implementing methods inC#

namespace COMP003A.LectureActivity4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GreetUser();

            //Input two numbers and calculate
            Console.Write("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine()); //Parse user input to an integer

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine()); // parse user input to integer

            int sum = CalculateSum(num1, num2); //Call method and store the result
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");

            //Display the contents of an array
            int[] numbers = { 10, 20, 30, 40, 50 }; //Initialize an array
            Console.WriteLine("Array Contents: ");
            DisplayArray(numbers);
        }



        static void GreetUser()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to the methods activity. ");
        }

        //Summary
        //Calculates the sum of two numbers and returns the result


        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void DisplayArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }




}
