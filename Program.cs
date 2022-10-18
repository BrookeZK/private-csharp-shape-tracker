using System;
using ShapeTracker.Models;

namespace ShapeTracker 
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to the Shape Tracker app!");
      Console.WriteLine("You can do a few things:");
      Console.WriteLine("- Calculate what type of triangle you have.");
      Console.WriteLine("- Calculate the area of a rectangle.");
      Console.WriteLine("What would you like to do? Enter 'triangle' or 'rectangle'. To exit, enter 'exit'.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "triangle" || userResponse == "Triangle")
      {
        Triangle();
      }
      else if (userResponse == "rectangle" || userResponse == "Rectangle")
      {
        Rectangle();
      }
    }

    static void Rectangle()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("We'll calculate what the area of your rectangle based off of two lengths that you provide.");
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();  
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();  
      int length1 = int.Parse(stringNumber1);  
      int length2 = int.Parse(stringNumber2);  
      Rectangle rect = new Rectangle(length1, length2);
      int result = rect.GetArea();
      Console.WriteLine("The area of your rectangle is: " + result.ToString() + ".");
      Console.WriteLine("Would you like to check the area of a new rectangle? Please enter 'yes' or 'no'.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "yes" || userResponse == "Yes")
      {
        Rectangle();
      }
      else
      {
        Main();
      }
    }

    static void Triangle()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");
      Console.WriteLine("Please enter a number:");
      string stringNumber1 = Console.ReadLine();  
      Console.WriteLine("Enter another number:");
      string stringNumber2 = Console.ReadLine();  
      Console.WriteLine("Enter a third number:");
      string stringNumber3 = Console.ReadLine();  
      int length1 = int.Parse(stringNumber1);  
      int length2 = int.Parse(stringNumber2);  
      int length3 = int.Parse(stringNumber3);  
      Triangle tri = new Triangle(length1, length2, length3);
      string result = tri.CheckType();
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("Would you like to check a new triangle? Please enter 'yes' or 'no'.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "yes" || userResponse == "Yes")
      {
        Triangle();
      }
      else
      {
        Main();
      }
    }
  }
}