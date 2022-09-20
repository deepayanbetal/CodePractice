using CodePractice.Algorithm;
using CodePractice.Basic_Practice;
using CodePractice.CodeForces;
using CodePractice.DataStructure;
using CodePractice.InterviewCodeQuestions;
using CodePractice.Leetcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Practice
{
    internal class callingclass
    {
        public void calling()
        {
            /********************************************************************/

            //InterviewCodeQuestions

            string msg = "new items for test";
            //int[] arr = {1001,5, 3, 4, 4, 7, 3, 6, 11, 8, 2, 5, 11,1000};
            //int[] arr = { 6, 7, 10,10, 11,11, 13,10000 };
            int[] arr = { 1, 0, 7, 2, 8, 0, 3, 8, 0 };

            //Practice
            clsPractice cp = new clsPractice();
            cp.mainMethodforMerge();

            /*********************************************************************/
            //StringReverse sr = new StringReverse();
            //sr.stringReverse();

            // StartandEndwithSpecificChar startandEndwithSpecificChar = new StartandEndwithSpecificChar();
            // startandEndwithSpecificChar.callingfindName();

            //PairwithgivenSum PS = new PairwithgivenSum();
            //PS.callPairwithgivenSum();

            //FindStringLength fsl = new FindStringLength();
            //fsl.findStringLength(msg);
            //fsl.findStringLengthWithLinq(msg);
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

            /**********************************************************************/
            //ArrayDatastructure AD = new ArrayDatastructure();
            //AD.arrayElemntCheck(arr,arr.Length);
            //AD.arrayElementCheck2(arr);
            //AD.smallandhighestelementinarray(arr);
            //AD.pairofInteger(arr,9);
            //AD.movingZero(arr);
        }
    }
}
