using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Algorithm
{
    public class MergeSortAlgo
    {
        public void MergeArray(int[] array, int left, int mid, int right )
        {
            int leftArrayLen = mid - left + 1;
            int rightArrayLen = right - mid;
            var leftTempArr = new int[leftArrayLen];
            var rightTempArr = new int[rightArrayLen];
            int i, j;

            for(i=0;i<leftArrayLen;i++)
                leftTempArr[i]=array[left+i];
            for(j=0;j<rightArrayLen;j++)
                rightTempArr[j]=array[mid+1+j];

            i = 0;j = 0;int k = left;
            while(i<leftArrayLen && j<rightArrayLen)
            {
                if(leftTempArr[i]<=rightTempArr[j])
                {
                    array[k++]=leftTempArr[i++];
                }
                else
                    array[k++]=rightTempArr[j++];
            }

            while(i<leftArrayLen)
                array[k++]=leftTempArr[i++];
            while (j < rightArrayLen)
                array[k++] = rightTempArr[j++];

        }

        public int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                MergeArray(array, left, middle, right);
            }
            return array;
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
        public void mainMethodforMerge()
        {
            //var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            var array = GenerateRandomNumber(20000);

            SortArray(array, 0, array.Length - 1);
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
