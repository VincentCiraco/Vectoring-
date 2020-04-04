using System;
using System.Collections.Generic;
using System.Text;

namespace VectoringProject
{
    class ThreeDeePoints
    {
        //our fields will contain the data for our structure we created
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public ThreeDeePoints(int X, int Y, int Z)
        {
            //upon creation the struct will have the values the user desires injected. 
            this.x = X;
            this.y = Y;
            this.z = Z;
        }
        public override string ToString()
            //this method overrides the cw command and allows our new "data type' to be printed to the screen
        {
            return $"({x} , {y} , {z})";
        }
        public bool CompareTo(ThreeDeePoints otherPoint)
        {
            //this method overrides the == operator and allows us to decide how to compare our data structure.
            if (this.x == otherPoint.x && this.y == otherPoint.y && this.z == otherPoint.z)
                return true;

            return false;
        }
    }
}
