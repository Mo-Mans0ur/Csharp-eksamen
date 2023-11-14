using System;
using System.Collections.Generic;
using System.Linq;

class Abstraction
{
    //Hører til InterfaceExample
    public interface IDrawable
    {
        void Draw();
    }

    public class Circle : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }

    public class Square : IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square");
        }
    }
    public static void InterFaceExample()
    {
        IDrawable shape = new Circle();
        shape.Draw(); // Output: Drawing a circle
    }


    //Delegate
    // Deklerere en ny delegate, referere til metoder der ikke retunere noget
    public delegate void SimpleDelegate();

    //definere en metode der passer til signaturen
    public static void MyMethod()
    {
        Console.WriteLine("Metode kaldt!");
    }


    public static void LambdasExample()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var oddNumbers = numbers.Where(n => n % 2 != 0);

        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number); // Output: 1, 3, 5, 7, 9
        }
    }

}
