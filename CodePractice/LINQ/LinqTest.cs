using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.LINQ
{
    internal class LinqTest
    {
        public void LinqPractice()
        {
            IEnumerable<string> msg = new List<string>() { "jam","jem","test","nest"};

            string rslt = msg.Select(a => a.Contains("e")).ToString();

            Console.Write(rslt);
        }
    }
}
