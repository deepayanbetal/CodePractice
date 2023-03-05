using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Practice
{
    public class clsPractice
    {
        public void mergeArray(int[] arr, int left, int mid, int right)
        {
            int leftArrayLen = mid - left+1;
            int rightArrayLen = right - mid;
            var leftTempArray = new int[leftArrayLen];
            var rightTempArray = new int[rightArrayLen];
            int i, j;

            // seperating the array into temp array

            for(i=0;i<leftArrayLen;i++)
            {
                leftTempArray[i] = arr[left + i];
            }
            for (j = 0; j < rightArrayLen; j++)
                rightTempArray[j] = arr[mid+1+j];

            //check & merge two temp arrays
            i = 0;j = 0;int k = left;// index of marged array
            while(i<leftArrayLen && j<rightArrayLen)
            {
                if (leftTempArray[i] <= rightTempArray[j])
                    arr[k++] = leftTempArray[i++];
                else
                    arr[k++]=rightTempArray[j++];
            }

            // putting rest elements
            while(i<leftArrayLen )
                arr[k++] = leftTempArray[i++];
            while (j < rightArrayLen)
                arr[k++] = rightTempArray[j++];
        }

        public int[] SortArray(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = left + (right - left) / 2;

                SortArray(array, left, middle);
                SortArray(array, middle + 1, right);
                mergeArray(array, left, middle, right);
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
        public static int[] GenerateSortedNumber(int size)
        {
            var array = new int[size];

            for (int i = 0; i < size; i++)
                array[i] = i;

            return array;
        }

        public IEnumerable<object[]> ArrayData()
        {
            yield return new object[] { GenerateRandomNumber(200), 0, 199, "Small Unsorted" };
            yield return new object[] { GenerateRandomNumber(2000), 0, 1999, "Medium Unsorted" };
            yield return new object[] { GenerateRandomNumber(20000), 0, 19999, "Large Unsorted" };
            yield return new object[] { GenerateSortedNumber(200), 0, 199, "Small Sorted" };
            yield return new object[] { GenerateSortedNumber(2000), 0, 1999, "Medium Sorted" };
            yield return new object[] { GenerateSortedNumber(20000), 0, 19999, "Large Sorted" };
        }
        public void mainMethodforMerge()
        {
            //var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            var expected = new int[] { 1, 20, 49, 57, 73, 99, 133 };
            var array = GenerateRandomNumber(20000);

            SortArray(array,0,array.Length-1);
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
