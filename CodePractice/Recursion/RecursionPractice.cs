using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Recursion
{
    internal class RecursionPractice
    {
        public string printNameNtimes(int n)
        {
            //This starts from the last.
            int count = 0;
            if (n<=0)
            {
                return String.Empty;
            }
                
            else
            {
                Console.WriteLine(count + ".asd from else"+n);
                count++;
                return printNameNtimes(n-1);
            }    
        }

        public string printnameNtimesfromstart(int i, int n)
        {
            //This starts from the First.
            if (i>n)
                return String.Empty;
            else
            {
                Console.WriteLine("qwerty" + i);
                return printnameNtimesfromstart(i + 1,n); ;
            }
        }

        public int printnumberNtoone(int n)
        {
            int i = 0;
            if (i > n)
                return 0;
            else
            {
                
                
                Console.Write(i + ",");
                return printnumberNtoone(n-1);
            }
        }




        /*****************************************************************************/

        //Palindrome Partitioning
        // https://www.youtube.com/watch?v=WBgsABoClE0
        //https://leetcode.com/problems/palindrome-partitioning/solutions/659622/c-simple-recursive-solution/
        public List<List<string>> partition(string s)
        {
            List<List<string>> res = new List<List<string>>(); // this is the output strings
            List<string> path = new List<string>(); // this is substrings
            partitionLogic(0, s, res, path);
            foreach (var obj in res.SelectMany(l => l.Select(o => o))) // this is the code for print list of list
            {
                Console.WriteLine(obj);
            }
            return res;
        }


        public void partitionLogic(int index, string s, List<List<string>> res, List<string> path)
        {
            if (index == s.Length)//base case. when partition reach to the end of the string.
            {
                res.Add(path.ToList());
                return;
            }
            for (int i = index; i < s.Length; i++)
            {
                if (palindromchk(index, i, s))
                {
                        path.Add(s.Substring(index, i-index + 1));
                        partitionLogic(i + 1, s, res, path);
                        path.RemoveAt(path.Count - 1);
                }
            }
        }

        public bool palindromchk(int start, int end, string s)
        {
            while (start <= end)
            {
                if (s[start++] != s[end--])
                {
                    return false;
                }
            }
            return true;
        }



        /*****************************************************************************/

        //check a number is palindrom or not

        public bool numberpalindromchk(int start, int end, int s)
        {
            while (start <= end)
            {
                if (s.ToString()[start++] != s.ToString()[end--])
                {
                    return false;
                }
            }
            
            return true;
        }

    }
}
