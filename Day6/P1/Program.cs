using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1
{
    /*
     
     Exercise The purpose of this exercise is to illustrate computations with nullable types over simple types such as double.
To do this, implement methods that work like SQL’s aggregate functions. We don’t have a database query at hand, so instead let each method take as argument an List<double?> (generic collection), that is, as sequence of nullable doubles:
• Count should return an int which is the number of non-null values in the enumerable.
• Min should return a double? which is the minimum of the non-null values, and which is null if there are no non-null values in the enumerable.
• Max is similar to Min and there is no point in implementing it.
• Sum should return a double? which is the sum of the non-null values, and which is null if there are no non-null values.
 When/if you test your method definitions, note that null values of any type are converted to the empty string when using  Console.WriteLine.

     
     */

    internal class Program
    {
        //Mahmoud Sayed Youssef
        public static int Count(List<double?> L)
        {
            int counter = 0;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].HasValue)
                    counter++;
            }
            return counter;
        }

        public static double? Min(List<double?> L)
        {
            double? minimum = L[0];
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].HasValue && L[i] < minimum)
                    minimum = L[i];
            }

            return minimum;
        }

        public static double? Max(List<double?> L)
        {
            double? Maximum = L[0];
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].HasValue && L[i] > Maximum)
                    Maximum = L[i];
            }

            return Maximum;
        }

        public static double? Sum(List<double?> L)
        {
            double? sum = 0;
            for (int i = 0; i < L.Count; i++)
            {
                if (L[i].HasValue)
                    sum += L[i];
            }

            return sum;
        }

        static void Main(string[] args)
        {

            List<double?> obj = new List<double?>();
            obj.Add(12.1);
            obj.Add(null);
            obj.Add(40.05);
            obj.Add(null);
            obj.Add(1.5);

            Console.WriteLine(Count(obj));

            Console.WriteLine(Min(obj));

            Console.WriteLine(Max(obj));

            Console.WriteLine(Sum(obj));

            Console.ReadKey();

        }
    }
}
