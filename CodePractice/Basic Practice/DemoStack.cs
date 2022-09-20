using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Basic_Practice
{
    public  class DemoStack
    {
        public void normalStackmethod()
        {
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < 10; i++)
                numbers.Push(i);

            Console.WriteLine(numbers.ToString());
            Console.WriteLine(numbers.Peek());
        }
        public void stackwithList()
        {
            var x = new List<KeyValuePair<char,int>>();
            int count = 0;
            string msg = "there is a boy";
            foreach(var y in msg)
            {
                count++;
                x.Add(new KeyValuePair<char, int>(y,count ));
            }
            foreach (var element in x)
            {
                if(element.Value %2==0)
                {
                    Console.WriteLine(element);
                }
                
                //Console.WriteLine(element);
            }
        }

    }
}
