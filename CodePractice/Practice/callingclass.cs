using CodePractice.Algorithm;
using CodePractice.Basic_Practice;
using CodePractice.CodeForces;
using CodePractice.DataStructure;
using CodePractice.InterviewCodeQuestions;
using CodePractice.Leetcode;
using CodePractice.Music;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Practice
{
    internal class callingclass
    {
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
        public void calling()
        {
            /********************************************************************/

            //InterviewCodeQuestions

            string msg = "new items for test";
            //int[] arr = {1001,5, 3, 4, 4, 7, 3, 6, 11, 8, 2, 5, 11,1000};
            int[] arr = { 6, 7, 10,10, 11,11, 13,10000,8,1 };
            int[] arr1 = { 1, 0, 7, 2, 8, 0, 3, 8, 0 };
            string[] strarr = { "abc","bv", "xyz", "rfv","iuyt" };
            string[] order = { "b","i","r", "a", "x" };



            //Practice
            //clsPractice cp = new clsPractice();
            //cp.mainMethodforMerge();

            /*********************************************************************/
            //FunctionsImplementation FI = new FunctionsImplementation();
            //FI.callMethod();

            //StringReverse sr = new StringReverse();
            //sr.stringReverse();
            //sr.StringSorting(strarr, order);

            // StartandEndwithSpecificChar startandEndwithSpecificChar = new StartandEndwithSpecificChar();
            // startandEndwithSpecificChar.callingfindName();

            //PairwithgivenSum PS = new PairwithgivenSum();
            // PS.callPairwithgivenSum(GenerateSortedNumber(500),600);

            //FindStringLength fsl = new FindStringLength();
            //fsl.findStringLength(msg);
            //fsl.findStringLengthWithLinq(msg);

            //CheckArraySortedorNot checkArray = new CheckArraySortedorNot();
            //checkArray.chkArray();
            /********************************************************************/
            //Algorithm

            //FractionalKnapsack fk = new FractionalKnapsack();
            //fk.callKnapsack();

            //MergeSortAlgo msa = new MergeSortAlgo();
            //msa.mainMethodforMerge();

            /*******************************************************************/
            // CodeForces
            //HelpfulMath HM = new HelpfulMath();
            //HM.helpfulMath("5+2+3");

            /*******************************************************************/
            //Basic practice

            //DemoStack ds = new DemoStack();
            //ds.normalStackmethod();
            //ds.stackwithList();

            //TotalStep TS = new TotalStep();
            //TS.check(arr);

            //TwoSum ts = new TwoSum();
            //foreach(int x in ts.TwoSummethod(arr,20))
            //{
            //    Console.WriteLine("index->"+x);
            //}

            //Console.Write( ts.palindromNumber(101));

            /**********************************************************************/
            //ArrayDatastructure AD = new ArrayDatastructure();
            //AD.arrayElemntCheck(arr,arr.Length);
            //AD.arrayElementCheck2(arr);
            //AD.smallandhighestelementinarray(arr);
            //AD.pairofInteger(arr,9);
            //AD.movingZero(arr);

            LinkedList LD = new LinkedList();
            //LD.insertLinkedList();
            LD.AllOp();


            //RecursionDemo rd = new RecursionDemo();
            //rd.chkpalindrom("madam");
            //rd.printnums(1,10);

            //crackinginterview c = new crackinginterview();
            //Console.WriteLine( c.stringcompression());

            //MusicClass1 mc = new MusicClass1();
            //mc.playMusic();
    }
}
}
