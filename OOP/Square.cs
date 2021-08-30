using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Square
    {
        //Since a square is the same length on all the sides, only one value, and therefore variable, is needed
        private int a;

        // First constructur for the square
        //public Square(int x)
        //{
        //    this.a = x;
        //}

        //Second, and final constructor which is needed, if we want the sides of the square to be changeable
        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

      

        //Method that calculates the perimeter
        public int GetSquarePerimeter()
        {
            return a * 4;
        }

        //Method that calculates the area
        public int GetSquareArea()
        {
            return a * 2;
        }
    }
}
