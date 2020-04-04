using System;
using System.Collections.Generic;
using System.Text;

namespace VectoringProject
{
    class ListofTwoDee
    {
        //exact details on the function of every item are found in the Listofthreedeeitems class
        public List<TwoDeePoints> TwoDeeList = new List<TwoDeePoints>();
        
        public ListofTwoDee()
        {
            FillList();
        }

        public void FillList()
        {
            Random random = new Random();
            int fillCount = 100;
            while (fillCount >= 0)
            {
                int a = random.Next(100);
                int b = random.Next(100);
                var point = new TwoDeePoints(a, b);
                TwoDeeList.Add(point);
                fillCount--;
            }
            foreach(TwoDeePoints A in TwoDeeList)
            {
                Console.WriteLine(A);
            }
        }
        public void EucilidianDistance()
        {

            var Point1 = new TwoDeePoints(0, 0);
            var Point2 = new TwoDeePoints(0, 0);

            double templength = 0;
            double shortestlength = 0;
            var ClosestPoints = new Tuple<TwoDeePoints, TwoDeePoints>(Point1,Point2);
            for(int i = 0; i < TwoDeeList.Count;i++)
            {
                for(int j = 0; j < TwoDeeList.Count;j++)
                {
                    if(TwoDeeList[i].CompareTo(TwoDeeList[j]))
                    {
                        continue;
                    }
                    else
                    {
                        //Math.sqrt((x2 - x1)Sq + (y2 - y1)sq)
                       templength =  Math.Sqrt(Math.Pow(TwoDeeList[j].x - TwoDeeList[i].x,2) + Math.Pow(TwoDeeList[j].y - TwoDeeList[i].y,2));
                        if(templength > shortestlength)
                        {
                            shortestlength = templength;
                            Point1 = TwoDeeList[i];
                            Point2 = TwoDeeList[j];                           
                            ClosestPoints = Tuple.Create<TwoDeePoints, TwoDeePoints>(Point1,Point2);
                        }
                    }
                }

            }
            Console.WriteLine("The closest two points are printed below");
            Console.WriteLine(ClosestPoints);
            
            Console.ReadLine();
        }
    }
}
