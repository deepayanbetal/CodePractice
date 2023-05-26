using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.Random_Code
{
    internal class RandomCode
    {
        //Third highest number in an array
        public void ThirdHighestNumber()
        {
            int[] arr = {7,10,8,9,21,1,4,5 };
            var arr2 = "25 26 7 8 10 11 79";
            int [] numbers = arr2.Split(new Char[] {' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(item=>int.Parse(item)).ToArray();     

            var y = numbers.OrderByDescending(x => x).Skip(2).Take(1).First();
            Console.WriteLine(y);

        }

        public void ThirdHighestNumber1()
        {
            try
            {
                var arraylen = Convert.ToInt32(Console.ReadLine());
                var numbers = Console.ReadLine();
                var arrayList = Array.ConvertAll(numbers.Split(' '), int.Parse);
                if (arrayList.Length < 3) { throw new Exception("Specified Count < 3"); }
                if (arraylen != arrayList.Length) { throw new Exception("Specified Length != Inputted list"); }
                Array.Sort(arrayList); Array.Reverse(arrayList);
                Console.WriteLine(arrayList[2].ToString());
                Console.ReadLine();
            }
            catch (Exception exception) { throw exception; }
        }

        public void convertallmethod()
        {
            var arraylen = Convert.ToInt32(Console.ReadLine());
            var number = Console.ReadLine();
            var arrayList=Array.ConvertAll(number.Split(' '), int.Parse);
            foreach(var item in arrayList)
            {
                Console.Write(item);
            }
            
        }
    }

        //
    
}
