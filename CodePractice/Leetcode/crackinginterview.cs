using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Leetcode
{
    internal class crackinginterview
    {
        public string stringcompression()
        {
            string msg = "aabcccccaaa";
            int count = 0;
            string compstr = String.Empty;

            for(int i=0;i<msg.Length;i++)
            {
                count++;
                if(i+1>=msg.Length || msg[i]!= msg[i+1])
                {
                    compstr += ""+msg[i]+count;
                    count = 0;
                }
            }
            return compstr.Length < msg.Length ? compstr : msg;
        }
    }
}
