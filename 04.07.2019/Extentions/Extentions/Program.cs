using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //Group p111 = new Group("P111", 17);
            //Student reshad = new Student("Reshad", "Gozelov");

            //p111[0] = reshad;
            //Console.WriteLine(p111[0].Name);
            #endregion

            string str = "kamran@code.edu.az";
            str.IsEmail();

            int a = 2;
            Console.WriteLine(a.Pow(3));
        }
    }
}
