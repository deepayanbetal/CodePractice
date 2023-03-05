using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.InterviewCodeQuestions
{
    internal class RecursionDemo
    {
        //Prints number using recursion
        public int printnums(int limit,int endlim)
        {
            if(limit > endlim)
                return 0;
            else
            {
                Console.WriteLine(limit);
            }
            return printnums(limit+1,endlim);
        }

        public void additiondemo()
        {

        }
        


        //Given a string, print all possible palindrom partitions
        public Boolean chkpalindrom(string msg)
        {
            
            
                //List<string> list = new List<string>();
                string s=string.Empty;
                for(int i=msg.Length-1;i>=0;i--)
                {
                    s += msg[i];
                }
                if (msg == s)
                    return true;
                else
                    return false;
            
        }
        public void AllPossiblepalindrom(string msg)
        {
            if(chkpalindrom(msg))
            {

            }
        }
    }
}
