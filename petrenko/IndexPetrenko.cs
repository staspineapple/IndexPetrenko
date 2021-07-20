using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petrenko
{
     static public class IndexPetrenko
    {
        
        //calculating index of russian phrase
        public static  double Calculate(string rusword)
        {
            double result = 0;
            int count = 0;
            double index = 0.5;

            for (int i = 0; i < rusword.Length; i++)
            {
                if (Char.IsLetter(rusword[i]))
                {
                    result += index;
                    index += 1;
                    count++;
                }
            }
            return result *= count;
        }

        //calculating indx of eng phrase
        static public double CalculateOfEng(string word)
        {
            int i = 0;
            
            string before= null, after = null;
            while (word[i]!= '|')
            {
                if (Char.IsLetter(word[i]))
                {

                    before += word[i];
                }
                i++;
            }
            while (i<word.Length)
            {
                if (Char.IsLetter(word[i]))
                {
                    after += word[i];
                }
                i++;
            }

            i = 0;
            return Calculate(before)+ Calculate(after);

            

        }
    }
}
