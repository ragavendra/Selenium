﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium
{

    // Multiuse attribute.  
    [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Struct, AllowMultiple = true)] // Multiuse attribute.
    public class Author : System.Attribute
    {
        string name;
        public double version;

        public Author(string name)
        {
            this.name = name;

            // Default value.  
            version = 1.0;
        }

        public string GetName()
        {
            return name;
        }
    }

    // Class with the Author attribute.  
    [Author("P. Ackerman")]
    public class FirstClass
    {
        // ...  
    }

    // Class without the Author attribute.  
    public class SecondClass
    {
        // ...  
    }

    // Class with multiple Author attributes.  
    [Author("P. Ackerman"), Author("R. Koch", version = 2.0)]
    public class ThirdClass
    {
        // ...  
    }

    class TestAuthorAttribute
    {
        static void Test()
        {
            PrintAuthorInfo(typeof(FirstClass));
            PrintAuthorInfo(typeof(SecondClass));
            PrintAuthorInfo(typeof(ThirdClass));
        }

        private static void PrintAuthorInfo(System.Type t)
        {
            System.Console.WriteLine("Author information for {0}", t);

            // Using reflection.  
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(t);  // Reflection.  

            // Displaying output.  
            foreach (System.Attribute attr in attrs)
            {
                if (attr is Author)
                {
                    Author a = (Author)attr;
                    System.Console.WriteLine("{0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }
    }
    /* Output:  
        Author information for FirstClass  
           P. Ackerman, version 1.00  
        Author information for SecondClass  
        Author information for ThirdClass  
           R. Koch, version 2.00  
           P. Ackerman, version 1.00  
    */

    //Nested types
    public class Container
    {
        public class Nested
        {
            private Container parent;

            /*
            public Nested()
            {
            }*/

            public Nested(Container parent)
            {
                this.parent = parent;
                var par = new Object[] { 1, "this is me" }; //anonymous types
                var ls = par[0];
            }
        }

        //Container.Nested nest = new Container.Nested();
    }

    public static class Extensions {

        //extension method for string data type
        public static int WordCount(this string str){
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int AasInString(this string str) {    //some dummy method
            return str.Length;
        }

        public static int DecimalCount(this int no) {    //some dummy method
            return no / 100;
        }

        public static int square(this int no) {    //some dummy method
            return no * no;
        }

        public static long sqr(this long no)
        {
            return no * no;
        }

        public class subclass {

            public string vari { get; set; }
            public subclass() { }

            public class sublass2 { 

                public int var1 { get; set; }
            }
        
        }
    }

    public class Mutable
    {
        readonly string str;

        public Mutable(string str)
        {
            this.str = str;
        }

        public string getStr { 
            get { return str; } 
        }

        //OR

        public string GetStr1() {
            return str;
        }

        public string getStr2 => str;
    }


}
