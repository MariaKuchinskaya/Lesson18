using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson18
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                string text = "The winter is coming";
                char symbol = 'a';
                var result = GetWords(text, symbol);
                Console.WriteLine(result);

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }


            int[] msv = { 5, 8, 0, -1, 6, 4, -1, -3 };
            var count = msv.Count(n => n > 0);
            var average = msv.Average();

            Console.WriteLine(count);
            Console.WriteLine(average);

            string sentence = "Женя скоро будет свободен, а у вас все только начинается";
            var array = new char[] { 'о' };
            var res = sentence.Where(c => !array.Contains(c)).ToArray();
            string s = new string(res);
            Console.WriteLine(s);

        }

        private static string GetWords (string text, char symbol)
        {
            var spl = text.Split(' ').ToList();

            var count = 0;

            var result = new List<string>();

            foreach (var item in spl)
            {
                if (item.EndsWith(symbol))
                {
                    count++;
                    result.Add(item);
                }
            }
            if (count == 0)
            {
                return null;
            }
            if (count>=2)
            {
                throw new Exception("More than one result");
            }

            return result.First();

            

        }
        
        

    }
}
