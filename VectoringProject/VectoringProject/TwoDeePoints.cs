using System;
using System.Collections.Generic;
using System.Text;

namespace VectoringProject
{
    public struct TwoDeePoints
    {
        //exact details on the function of every item in this struct are found in the twodeepoints class
        public int x { get; set; }
        public  int y { get; set; }
        public TwoDeePoints(int x1, int y1)
        {
            this.x = x1;
            this.y = y1;
        }
        public override string ToString()
        {
            return $"({x} , {y})";
        }
        public bool CompareTo(TwoDeePoints otherPoint)
        {
            if (this.x == otherPoint.x && this.y == otherPoint.y)
                return true;

            return false;
        }
    }
   
}
