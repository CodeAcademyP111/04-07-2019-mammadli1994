using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Extention
    {
     public static void IndexOf(this string word, char letter)
        {
            int count = 0;
            for (int i = 1; i < word.Length+1; i--)
            {
                if (word[i] == letter)
                {
                    count++;
                }
            }
        }
    }
}
