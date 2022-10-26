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
      Console.WriteLine("What would you like to do? Enter 'triangle' or 'rectangle'. To exit, enter any key.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "triangle" || userResponse == "Triangle")
      {
        Tri();
      }
      else if (userResponse == "rectangle" || userResponse == "Rectangle")
      {
        Rectangle();
      }
      else
      {
        Console.WriteLine("Goodbye!");
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

    static void Tri()
    {
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
      ConfirmOrEditTriangle(tri);
    }

    static void ConfirmOrEditTriangle(Triangle tri)
    {
      Console.WriteLine("Please confirm that you entered in your triangle correctly:");
      Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
      Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
      Console.WriteLine($"Side 3 has a length of {tri.Side3}.");
      Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
      string userInput = Console.ReadLine();  
      if (userInput == "yes")
      {
        CheckType(tri);
      }
      else
      {
        Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again!");
        Console.WriteLine("Please enter a number:");
        string stringNumber1 = Console.ReadLine();  
        Console.WriteLine("Enter another number:");
        string stringNumber2 = Console.ReadLine();  
        Console.WriteLine("Enter a third number:");
        string stringNumber3 = Console.ReadLine();  
        tri.Side1 = int.Parse(stringNumber1);  
        tri.Side2 = int.Parse(stringNumber2);  
        tri.Side3 = int.Parse(stringNumber3); 
        ConfirmOrEditTriangle(tri);
      }
    }

    static void CheckType(Triangle tri)
    {
      string result = tri.CheckType();
      Console.WriteLine("Your result is: " + result + ".");
      Console.WriteLine("What's next?");
      Console.WriteLine("Would you like to check a new triangle (new)?");
      Console.WriteLine("Or would you like to see all triangles (all)?"); 
      Console.WriteLine("Please enter 'new' or 'all'. To exit, enter any key.");
      string userResponse = Console.ReadLine(); 
      if (userResponse == "new" || userResponse == "New")
      {
        Main();
      }
      else if (userResponse == "all" || userResponse == "All")
      {
        SeeAllTriangles();
      }
      else
      {
        Console.WriteLine("Goodbye!");
      }
    }

    static void SeeAllTriangles()
    {
      Console.WriteLine("Here are all of your triangles:");
      foreach (Triangle tri in Triangle.GetAll())
      {
        Console.WriteLine("------------------------------------");
        Console.WriteLine($"Side 1 has a length of {tri.Side1}.");
        Console.WriteLine($"Side 2 has a length of {tri.Side2}.");
        Console.WriteLine($"Side 3 has a length of {tri.Side3}.");
      }
      Console.WriteLine("------------------------------------");
      Main();
    }
  }
}