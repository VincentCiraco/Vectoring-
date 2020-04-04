using System;
using System.Collections.Generic;
using System.Text;

namespace VectoringProject
{
    class ListofThreeDeePoints
    {
        public List<ThreeDeePoints> ThreeDeeList = new List<ThreeDeePoints>();
        //the list that will contain our 3d points
        public ListofThreeDeePoints()
        {

            FillList();
        }

        public void FillList()
        {
            //this method will fill the list instantiated above with random x,y,z points. 


            Random random = new Random();
            int fillCount = 1000;
            //this while loop is the specific function that will loop and fill the list 
            while (fillCount >= 0)
            {
                int a = random.Next(1000);
                int b = random.Next(1000);
                int c = random.Next(1000);
                var point = new ThreeDeePoints(a, b, c);
                ThreeDeeList.Add(point);
                fillCount--;
            }
            //now we look at our list to make sure everythung turned out alright before we perform the next function
            foreach (ThreeDeePoints A in ThreeDeeList)
            {
                Console.WriteLine(A);
            }
        }
        public void EucilidianDistanceofThree()
        {//this method ill find the shortest distance between two points in the entire list

            //first we have variables to store the shortest value and current function value
            double templength = 0;
            double shortestlength = 0;
            //now we have values to store the shortest values points 
            var Point1 = new ThreeDeePoints(0,0,0);
            var Point2 = new ThreeDeePoints(0, 0, 0);
            //these variabes store the current x y and z of the function
            double x = 0;
            double y = 0;
            double z = 0;
            //this variable is the pair that will store both points that are the closest
            var ClosestPoints = new Tuple<ThreeDeePoints, ThreeDeePoints>(Point1, Point2);

            //our for loops will loop through each item of the index from zero and compare evey item to every item. 
            //the if statement will catch if the indexes re on the same point and move onto the next point 

            for (int i = 0; i < ThreeDeeList.Count; i++)
            {
                for (int j = 0; j < ThreeDeeList.Count; j++)
                {
                    if (ThreeDeeList[i].CompareTo(ThreeDeeList[j]))
                    {
                        continue;
                    }
                    else
                    {
                        //the first portion of the formula is to subtract xyz of the scond point from the first point 
                        //Math.sqrt((x2 - x1)Sq + (y2 - y1)sq)
                        x = ThreeDeeList[i].x - ThreeDeeList[j].x;
                        x = ThreeDeeList[i].y - ThreeDeeList[j].y;
                        x = ThreeDeeList[i].z - ThreeDeeList[j].z;


                        //not to do the calculation 
                        templength = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y, 2) + Math.Pow(z,2));
                        if (templength > shortestlength)
                        {//after finding our calculations we will store the necessary values if the output is found to be lower than the currentlly stored lowet number
                            shortestlength = templength;
                            Point1 = ThreeDeeList[i];
                            Point2 = ThreeDeeList[j];
                            ClosestPoints = Tuple.Create<ThreeDeePoints, ThreeDeePoints>(Point1, Point2);
                        }
                    }
                }

            }
            //finally we will print the two closest points out 
            Console.WriteLine("The closest two points are printed below");
            Console.WriteLine(ClosestPoints);

            Console.ReadLine();
        }
    }
}
