using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.InterviewCodeQuestions
{
    internal class CheckArraySortedorNot
    {
        public static bool checkArray(int[] arr,int len)
        {
            bool flag = false;
            if(len==0|| len==1)
            {
                flag = true;
                return flag;
            }
            if(arr[len-1]<arr[len-2])
            {
                flag = false;
                return flag;
            }
            return checkArray(arr,len-1);
        }

        public static int[] GenerateRandomNumber(int size)
        {
            var array = new int[size];
            var rand = new Random();
            var maxNum = 10000;

            for (int i = 0; i < size; i++)
                array[i] = rand.Next(maxNum + 1);

            return array;
        }
        public static int[] GenerateSortedNumber(int size)
        {
            var array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = i;

            return array;
        }

        public void chkArray()
        {
            //var arr = new int[]{ 1,2,3,4,5,7,6};
            //if (checkArray(arr, 7))
            //    Console.Write("sorted");
            //else
            //    Console.Write("not sorted");

            if(checkArray(GenerateRandomNumber(10),10))
                Console.Write("sorted");
            else
                Console.Write("not sorted");
        }
    }
}
