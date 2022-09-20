using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.CodeForces
{
    internal class HelpfulMath
    {
        public void helpfulMath(string number)
        {
            char[] chars = number.ToCharArray();
            string newNumber = String.Concat(chars.Where(c=>!c.Equals('+')));

            char[] newChar = newNumber.ToCharArray();

           // foreach(var c in newChar.OrderBy(c=>int.Parse(c.ToString())))
            //{
              //  Console.Write(c+"+");
            //}









            for (int i = 0; i < newChar.Length - 1; i++)
            {
                for (int j = 1; j < newChar.Length - (i + 1); j++)
                {
                    if ((int)Char.GetNumericValue(newChar[j]) > (int)Char.GetNumericValue(newChar[j + 1]))
                    {
                        int temp = (int)Char.GetNumericValue(newChar[j]);
                        //newChar[j] = (int)Char.GetNumericValue(newChar[j + 1]);
                        //newChar[j + 1] = temp;
                    }

                }
            }
            foreach(var a in newChar)
            {
                Console.WriteLine(a);
            }
        }
    }
}
