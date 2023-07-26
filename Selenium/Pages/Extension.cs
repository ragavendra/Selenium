using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Selenium;
//{
    public static class TestClass {

        public static void main()
        {
            string s = "Hello Extension Methods";

            //extension method for string
            int i = s.WordCount(); //from class Extension in Attribute.cs file

            int p = s.AasInString();

            int aaa = 300;
            //aaa.square
            int q = aaa.DecimalCount();

            q = aaa.square();

            long lon = 11111;
            lon.sqr();

            Console.WriteLine(q);

            //string type is immutable meaning every value assignment
            // to it creates new memory
            string test = "this is sample str";

        }
    }

//}
