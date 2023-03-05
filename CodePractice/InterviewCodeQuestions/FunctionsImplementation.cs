using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.InterviewCodeQuestions
{
    internal class FunctionsImplementation
    {
        public void callMethod()
        {
            String msg = "There is a boy";
            String find = "is";
            String replace = "are";
            char[] f = find.ToCharArray();
            char[] r= replace.ToCharArray();
            //stringLengthCheck(msg);
            replaceElement(msg,f,r);
        }
        public void stringLengthCheck(string msg)
        {
            int i = 0;
            foreach (var s in msg)
            {
                i++;
            }
            Console.Write(i);
        }

        public void replaceElement(String msg,char[] find,char []replace)
        {
            var x = msg.Replace("is","are");
            char [] ch = msg.ToCharArray();
            for(int i=0;i<ch.Length;i++)
            {
                if (ch[i] == find[i])
                    ch[i] = replace[i];
            }
            Console.Write(msg);
        }
    }
}
