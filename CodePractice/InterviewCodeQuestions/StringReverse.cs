using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.InterviewCodeQuestions
{
    public class StringReverse
    {
        public void stringReverse()
        {
            string message = "there is a car";
            string reverseString = String.Empty;
            int len = message.Length-1;

            while(len>=0)
            {
                reverseString += message[len];
                len--;
            }
            Console.Write(reverseString);
        }

        public void StringSorting(string[] msg, string []order)
        {
            //Dictionary<int,string> sortingorder = new Dictionary<int,string>();
            //Dictionary<int, string> msgelement = new Dictionary<int, string>();
            //int i = 0;
            //foreach(string s in msg)
            //{
            //    var x = s[0];
            //    foreach (char c in order)
            //    {
            //        sortingorder.Add(i++,c.ToString());
            //    }
            //}
            List<string> list = new List<string>(); 
            for(int i=0;i<order.Length;i++) // for counting elements in order
            {
                for(int j=0;j<msg.Length;j++)// for each element in msg
                {
                    if(msg[j].Substring(0,1)==order[i])
                    {
                            list.Add(msg[j]);
                    }
                }
                
            }
            foreach (string item in list)
            {
                Console.WriteLine( item);
            }
        }
    }
}
