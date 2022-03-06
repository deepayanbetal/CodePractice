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
    }
}
