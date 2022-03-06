using CodePractice.Algorithm;
using CodePractice.InterviewCodeQuestions;
using CodePractice.Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            /*******************************************************************/
            //Practice

            //clsPractice practice = new clsPractice();
            //practice.test();

            //call
            callingclass cc = new callingclass();
            cc.calling();

            /********************************************************************/
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

        }
    }
}
