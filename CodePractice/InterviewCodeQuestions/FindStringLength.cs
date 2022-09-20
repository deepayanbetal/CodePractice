using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.InterviewCodeQuestions
{
    internal class FindStringLength
    {
        public void findStringLength(string msg)
        {
            int count = 0;
            foreach(var item in msg)
            {
                if (item != ' ')
                    count++;
            }
            Console.Write(count);
        }

        public void findStringLengthWithLinq(string msg)
        {
            Console.Write(msg.Where(x=>!Char.IsWhiteSpace(x)).Count());
        }
    }
}
