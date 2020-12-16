using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Year_Chaos
{
    class Solution
    {

        // Complete the minimumBribes function below.
        static void minimumBribes(int[] q)
        {
            int numBribes = 0;
            for (int i = q.Length - 1; i >= 0; i--)
            {
                if (q[i] - (i + 1) > 2)
                {
                    numBribes = -1;
                    break;
                }
                for (int j = Math.Max(0, q[i] - 2); j < i; j++)
                    if (q[j] > q[i]) numBribes++;
            }
            if (numBribes != -1)
                Console.WriteLine(numBribes);
            else Console.WriteLine("Too chaotic!");
        }

        static void Main(string[] args)
        {
            try
            {
                int t = Convert.ToInt32(Console.ReadLine());
                for (int tItr = 0; tItr < t; tItr++)
                {                    
                    int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp));
                    minimumBribes(q);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Input string is not a digit or sequence of digits.");
            }
        }
    }
}
