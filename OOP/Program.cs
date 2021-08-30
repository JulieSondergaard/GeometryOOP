using OOP;
using System;

namespace GeometryOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Square square0 = new Square(5); //Creates a new instantiation of the class Square, called square0
            //Console.WriteLine("The perimeter of square zero is " + square0.GetSquarePerimeter());
            //Console.WriteLine("The area of square zero is " + square0.GetSquareArea());

            Square square1 = new Square(); //Creates another new instantiation of the class Square, called square1
            square1.A = 4; //sets the length of the sides on square1 to 4
            Console.WriteLine("The perimeter of the first square is " + square1.GetSquarePerimeter()); //Writes out the result of the perimeter on the first square using the perimeter method
            Console.WriteLine("The area of the first square is " + square1.GetSquareArea()); //Writes out the result of the area on the first square using the area method


            Square square2 = new Square();  //Another new instantioan of the class Square, called square2 
            square2.A = 6; //Sets the length of the sides on square2 to 6
            Console.WriteLine("The perimeter of the second square is " + square2.GetSquarePerimeter()); //Writes out the result of the perimeter on the second square using the perimeter method
            Console.WriteLine("The area of the second square is " + square2.GetSquareArea()); //Writes out the result of the perimeter on the second square using the perimeter method

            square2.A = 8;
            Console.WriteLine("The second squares sides are now 8 instead of 6 and therefore the perimeter is " + square2.GetSquarePerimeter());
            Console.WriteLine("And the area are now " + square2.GetSquareArea());



        }
    }
}
