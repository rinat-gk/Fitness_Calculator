using FitnessCalculator.BL.Controller;
using System;


namespace FitnessCalculator.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Welcome to Fitness Calculator!!!==");

            Console.WriteLine("Please enter your username: ");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your gender:");
            var gender = Console.ReadLine();

            Console.WriteLine("Please enter your date of birth:");
            var birthdate = DateTime.Parse(Console.ReadLine()); // TODO: Rewrite

            Console.WriteLine("Please enter your weight:");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your height:");
            var height = double.Parse(Console.ReadLine());


            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();
        }
    }
}
