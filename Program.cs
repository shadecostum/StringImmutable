using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringImmutable
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string s = "haloo";//heap id 1001 destroyed with garbage collection ,remove from stack
            Console.WriteLine(s.GetHashCode());
            s = "hii";//heap id 2002
            Console.WriteLine(s.GetHashCode());
            Console.WriteLine("---------");

            //state can change
            StringBuilder str= new StringBuilder("haloooo");//using stack id same can diffrent value
            Console.WriteLine(str.GetHashCode());
            str.Append("hiiii");
            Console.WriteLine(str.GetHashCode());


        }
    }
}
