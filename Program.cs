using System;
using System.Collections.Generic;



namespace Shapesvid
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square();
            var shapeList = new List<Ishape>() { new Square(), new Triangle(), new Circle() }; //lista över de klasser vi skapade. en shortcut istället för att skriva massa trötta adds

            for (int i = 0; i < shapeList.Count; i++)
            {
                Console.WriteLine(shapeList[i].GetArea());


            }

        }
    }
}
