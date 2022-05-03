using System;
namespace calculator
{
    class program
    {
        static void Main(string[] args)
        {
            //Created the object/instance if calculator class;
            Calc objCalc = new Calc();

            // Taking inputs from user
            Console.WriteLine("Enter 1st number = ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            // Taking inputs from user
            Console.WriteLine("Enter 2nd number = ");
            string num = Console.ReadLine();
            int num2 = Convert.ToInt32(num);

            objCalc.Addition(num1, num2);
            //objCalc.Sub(num1, num2);
            //objCalc.Mul(num1, num2);
            //objCalc.Div(num1, num2);
        }
    }
}
