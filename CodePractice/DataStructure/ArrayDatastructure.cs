using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.DataStructure
{
    internal class ArrayDatastructure
    {
        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        //https://hackernoon.com/50-data-structure-and-algorithms-interview-questions-for-programmers-b4b1ac61f5b0
        public void arrayElemntCheck(int[] arr,int n)
        {

            //https://www.geeksforgeeks.org/find-all-missing-numbers-from-a-given-sorted-array/

            //How do you find the missing number in a given integer array of 1 to 100
            
            int diff = arr[0] - 0;
            for(int i=0;i<n;i++)
            {
                if(arr[i]-i != diff)
                {
                    while(diff < arr[i]-i)
                    {
                        Console.Write(i + diff + " ");
                        diff++;
                    }
                }
            }
        }

        public void arrayElementCheck2(int []arr)
        {
            //How do you find the duplicate number on a given integer array?
            for(int i=0;i<=arr.Length-1;i++)
            {
                for (int j = i + 1; j <= arr.Length-1; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        Console.WriteLine("same" + arr[i]+"place->"+i);
                    }  
                   
                } 

            }
        }


        public void smallandhighestelementinarray(int [] arr)
        {
            //How do you find the largest and smallest number in an unsorted integer array?
            int pivot = arr[0];
            int pivot2 = arr[0];
            for(int i=0;i<=arr.Length-1;i++)
            {
                
                    if(arr[i]>pivot)
                    {
                        pivot = arr[i];
                        
                    }
                   
            }
            for(int i=0;i<=arr.Length-1;i++)
            {
                if (arr[i] < pivot2)
                {
                    pivot2 = arr[i];
                }
            }
            Console.WriteLine("largest" + pivot);
            Console.WriteLine("smallest" + pivot2);
        }

        public void pairofInteger(int[] arr, int target)
        {
            int temp = 0;
            for(int i=0;i<=arr.Length-1;i++)
            {
                temp = target - arr[i];
                for(int j=i+1;j<=arr.Length-1;j++)
                {
                    if (arr[j] == temp)
                        Console.Write(temp+" "+arr[i]);
                }
            }
        }


        public void movingZero(int[] arr)
        {
            int count = 0;//count of non zero elements

            for(int i=0;i<arr.Length-1;i++)
            {
                if(arr[i]!=0)
                {
                    arr[count++]=arr[i];
                }
            }
            while(count<arr.Length)
            {
                arr[count++] = 0; 
            }

            printArray(arr);
        }
    }
}


