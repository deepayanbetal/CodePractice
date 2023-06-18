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
            if (n <= 0)
            {
                return String.Empty;
            }

            else
            {
                Console.WriteLine(count + ".asd from else" + n);
                count++;
                return printNameNtimes(n - 1);
            }
        }

        public string printnameNtimesfromstart(int i, int n)
        {
            //This starts from the First.
            if (i > n)
                return String.Empty;
            else
            {
                Console.WriteLine("qwerty" + i);
                return printnameNtimesfromstart(i + 1, n); ;
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
                return printnumberNtoone(n - 1);
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
                    path.Add(s.Substring(index, i - index + 1));
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

        //public bool numberpalindromchk(int start, int end, int s)
        //{
        //    while (start <= end)
        //    {
        //        if (s.ToString()[start++] != s.ToString()[end--])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

        /*****************************************************************************/

        //Generating all possible subsequence of numbers
       // https://www.youtube.com/watch?v=AxNNVECce8c&list=PLgUwDviBIf0rGlzIn_7rsaR2FQ5e6ZOL9&index=6
        public void subSequence(int index, List<int> lst, int[] arr, int len)
        {
            if(index==len)              //base condition
            {
                foreach(var x in lst)
                {
                    Console.Write(x);   //printing  the list elements.
                }
                Console.WriteLine("{}");
                return;
            }
            subSequence(index+1,lst,arr,len);   // for not taking elements
            lst.Add(arr[index]);                // taking elements adding in empty list
            subSequence(index+1,lst,arr,len);   // for taking elements
            lst.Remove(arr[index]);             // removing extra added elements while back calling.
        }

        public void subsequenceMain()
        {
            int[] arr = { 3, 1, 2 };
            int len = arr.Length;
            List<int> lst = new List<int>();
            subSequence(0, lst, arr, len);
        }

        /*****************************************************************************/

        // Is Subsequence of string
        //https://leetcode.com/problems/is-subsequence/description/
        public bool IsSubsequence(string s, string t)
        {
            
                if (s == "")
                {
                    Console.WriteLine("true");
                    return true;
                }

                int index = 0;
                for (int i = 0; i < t.Length && index < s.Length; i++)
                {
                    if (t[i] == s[index])
                    {
                        index++;
                    }
                }
                Console.WriteLine(index == s.Length);
                return index == s.Length;
        }

        /*****************************************************************************/

        // Sub sequence with sum k
        //https://www.youtube.com/watch?v=eQCS_v3bw0Q&list=PLgUwDviBIf0rGlzIn_7rsaR2FQ5e6ZOL9&index=7
        public void subsequencewithsum(int index, int s, int sum, int[] ele,List<int> lst,int n)
        {
            if(index==n)
            {
                if(s==sum)
                {
                    foreach(var x in lst)
                    {
                        Console.Write(x);
                    }
                    Console.WriteLine("");
                }
                return;
            }
            lst.Add(ele[index]);
            s += ele[index];
            subsequencewithsum(index+1,s,sum,ele,lst,n);
            s -= ele[index];
            lst.Remove(ele[index]);
            subsequencewithsum(index+1,s,sum,ele,lst,n);
        }

        public void subsequencewithsumMain()
        {
            int index = 0;
            int s = 0;
            int sum = 2;
            int[] ele = { 1, 2, 1 };
            List<int> lst = new List<int>();
            int n = ele.Length;
            subsequencewithsum(index,s,sum,ele,lst,n);
        }

    }
}
