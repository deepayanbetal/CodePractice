using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.HackerrankProbs
{
    internal class Hackerrank
    {
        public  int diagonalDifference(List<List<int>> arr)
        {
            int sum = 0;
            int index = 0;
            int length = arr.Count - 1;
            foreach (var item in arr)
            {
                int temp = item[index] - item[length - index];
                sum += temp;
                index++;
            }
            return Math.Abs(sum);

        }

    }
}
