using System;

namespace VectoringProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls the list of two-D points to be created

            ListofTwoDee List1 = new ListofTwoDee();

            //finds he eucilidian distance of created list

             List1.EucilidianDistance();

            //creates a list of three-D points 

            ListofThreeDeePoints List2 = new ListofThreeDeePoints();

            //calls eucilidian method for tree-D points

            List2.EucilidianDistanceofThree();
        }
    }
}
