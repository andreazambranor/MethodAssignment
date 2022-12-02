using System;

namespace MethodAssignmentSubmisison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Class1 one = new Class1();
            Console.WriteLine("You will enter two values to perform math, enter value number one: ");

            one.Value = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("enter parameter number 2.");
            one.Valueb = Convert.ToInt32(Console.ReadLine());
             



            Console.WriteLine("This will return the result of an operation with an optional parameter: " + one.MethodA(one));
            Console.ReadLine();

            

        }
    }
}
