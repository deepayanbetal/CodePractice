using System;

namespace CodePractice.InterviewCodeQuestions
{
    internal class PairwithgivenSum
    {
        public void findPair(int [] arr, int target)
        {
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j=i+1;j<arr.Length;j++)
                {
                    if(arr[i]+arr[j]==target)
                    {
                        Console.WriteLine("pair is"+arr[i]+" "+arr[j]);
                    }
                }
            }
        }

        public void callPairwithgivenSum(int [] arr,int x)
        {
            //int[] arr = { 8,7,2,5,3,5};
            findPair(arr,x);


        // http://www.techiedelight.com/find-pair-with-given-sum-array/
        }
    }
}
