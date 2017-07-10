using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methods are a tool for use to create reusable pieces of code. Call the method to reuse the code.

            //Methods are a way of us collecting a series of instructions and then call them when we need them.

            //Methods are ALWAYS part of a class. Methods are ALWAYS children of classes.

            //This means a method will NEVER be created inside another method or member of the class.
            //However, methods are frequently CALLED inside of another class or method.

            //Best practice - methods should be placed BELOW the Main method. 

            //ex. 1 call or invoke the Add method from below

            //Console.WriteLine("Hello. Please enter the first number to be added.");
            //int numberOne = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please enter the second number to be added.");
            //int numberTwo = int.Parse(Console.ReadLine());
            //int answer = Add(numberOne, numberTwo); //these variables names can be different as long as they are ints
            //Console.WriteLine("The sum of your two numbers is " + answer);

            //ex. 2 call or invoke the Add method from below
            //int answer = Add(5, 7);
            //Console.WriteLine(answer);

            //ex. 3 call the robotwarning
            //RobotWarning("Will Robinson");

            //ex. 4 call Useless
            //Useless(); //prints "blah, blah, blah"

            //ex. 5 call Vehicle
            //string myBirthMonth = "September";
            //string myFriendBirthMonth = "December";
            //string myVehicle = Vehicle(myBirthMonth);
            //string myFriendVehicle = Vehicle(myFriendBirthMonth);

            //Console.WriteLine("My future vehicle is {0} and Jordan's future vehicle {1}.", myVehicle, myFriendVehicle);

            //ex. FavoriteFood
            //FavoriteFood("Jay", "ice cream");
            //FavoriteFood("Becky", "cake");

            //ex. RetirementCalculator
            //RetirementCalculator(34);

            //Console.WriteLine("Enter your age: ");
            //int userAge = int.Parse(Console.ReadLine());
            //RetirementCalculator(userAge);

            //ex. WageCalculator
            double hoursWorked = 42.3;
            double hourlyWage = 12.50;
            Console.WriteLine("Your monthly wage is {0}.",  WageCalculator(hoursWorked, hourlyWage));

            
        }

        //Access Modifier - Return Type - Method Name (in Pascal Case) - Parentheses (sometimes with parameters - may function
        //as temporary variables)

        //Return Type - send from public to Main (can be an object, array, or other collection) - we create the method name
        //Return type and parameter types do not need to match, can be int, string, etc.
        //static keyword means you don't have to worry about objects right now.
        public static int Add(int firstNumber, int secondNumber) // this is the method header - tells what to expect
        {
            //Method body - where implementation lives
            //A complete method (header and body) is called a method declaration

            int sum = firstNumber + secondNumber;

            return sum; //return outcome of method
            //The "return" keyword takes whatever value is determined by using this method and sends that value
            //back to where I called my method
            //returned data must be the same data type as the method (ex. int Add must return an int)
            
            //would not want to ask user to enter two numbers, etc. Just do the one thing it's suppose to do.

        }

        //if you have a method that does not have a return value, you would use keyword "void".
        //When we have a "void" return type we DON'T need to use the keyword "return".
        //no calculation, just uses it without taking an action such as add, multiple, etc.
        
        //Example RobotWarning
        public static void RobotWarning(string name)
        {
            Console.WriteLine("Danger, " + name + "!!");
        }

        //Example Useless
        public static void Useless()
        {
            Console.WriteLine("Blah blah blah");
        }

        //Example Vehicle - building a string
        public static string Vehicle(string birthMonth)
        {
            string vehicleFortune;
            if (birthMonth.ToUpper() == "SEPTEMBER" || birthMonth.ToUpper() == "OCTOBER")
            {
                vehicleFortune = "Hoverboard";
            }
            else
            {
                vehicleFortune = "SUV";
            }
            return vehicleFortune;
        }

        //Create a method called FavoriteFood
        //It should take two string parameters. One representing a name, and the other representing a favorite food.
        //The return type should be void.
        //The method should concatenate

        public static void FavoriteFood(string name, string favFood)
        {
            Console.WriteLine(name + " prefers " + favFood);
        }

        //Create a method called RetirementCalculator
        //It should take an int as a parameter representing the user's age
        //The method should calculate how many more years until the user retires using 65 as the age of retirement.
        //The return type should be void
        //Once it calculates the user's retirement age it should print
        //"The user will retire in X years" where x represents the value that was calculated

        public static void RetirementCalculator(int userAge)
        {
            int retireYrs = 65 - userAge;
            Console.WriteLine("The user will retire in " + retireYrs + " years");
            //return retireYrs;
        }

        public static double WageCalculator(double hoursWorkedWeekly, double hourlyWage)
        {
            //This method should calculate the MONTHLY wage
            double monthlyWage = (hoursWorkedWeekly * 52 * hourlyWage) / 12;
            return monthlyWage;

        }

        
    }
}
