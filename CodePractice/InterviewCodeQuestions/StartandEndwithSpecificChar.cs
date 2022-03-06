using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.InterviewCodeQuestions
{
    internal class StartandEndwithSpecificChar
    {
        public List<string> findName(string[] names, char start, char end)
        {
            //int len = names.Length-1;
            List<string> list = new List<string>();
            string res = String.Empty;
            foreach(string name in names)
            {
                if (name[0] == start && name[name.Length - 1] == end)
                   
                {
                    //res = name;
                    list.Add(name);
                }
            }
            return list;
        }
        public void callingfindName()
        {
            string[] cities =
            {
                "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"
            };

            char strat = 'R';
            char end = 'E';

           Console.WriteLine( findName(cities,strat,end));
        }
    }
}
