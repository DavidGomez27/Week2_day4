using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Practice2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("PLease enter a name");
            //string name = Console.ReadLine();

            //Console.WriteLine("PLease enter a food");
            //string food = Console.ReadLine();



            //FavoriteFood(name, food);

            //Console.WriteLine("How old are you?");
            //int age = int.Parse(Console.ReadLine());


            //RetirementCalculator(age);

            //problem 3 below

            Console.WriteLine("what is your hourly wage?");
            double hourlyWage = double.Parse(Console.ReadLine());
            Console.WriteLine("How many hours worked this month?");
            double hoursWorked = double.Parse(Console.ReadLine());


           WageCalculator(hourlyWage, hoursWorked);







        }
        //public static void RobotWarning(string name)
        //{

        //    Console.WriteLine("Danger, " + name);
        //    return; }


        //public static string AllCaps(string word)
        //{
        //    return word.ToUpper();

        //}

        //Problem 1 below

        //public static void FavoriteFood(string name, string food)
        //{

        //    Console.WriteLine(name + "'s favorite food is " + food);
        //}

        //Problem 2 below


        //public static void RetirementCalculator(int age)
        //{
        //    int retirementAge = Math.Max(0, 65 - age);

        //    //int retirementAge = 65 - age;

        //    Console.WriteLine("The user will retire in " + retirementAge +" years.");
        //}

        public static void WageCalculator(double hourlyWage, double hoursWorked)
        {
            double monthlyWage = hourlyWage * hoursWorked;

            Console.WriteLine("Your monthly wage is " + monthlyWage);
        }







    }
}
