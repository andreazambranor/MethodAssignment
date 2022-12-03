using System;

namespace MethodAssignmentSubmisison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("You will enter two values to perform math, enter value number one: ");

            int int1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter parameter number 2.");
            string intA = Console.ReadLine();
            if (intA == "")
            {
                Console.WriteLine("Only one parameter was passed and the result is: " + class1.MethodA(int1));
            }
            else
            {
                int int2 = Convert.ToInt32(intA);
                Console.WriteLine("Two parameters were passed and the result is: " + class1.MethodA(int1, int2));
            }
            Console.ReadLine();

        }
    }
}
