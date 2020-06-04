using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace ProductivityTools.Learning.Google.HS
{
    class Program
    {
        class Person {

            public string Name { get; set; }

            public Person(string name)
            {
                this.Name = name;
            }

            public override bool Equals(object obj)
            {
                return this.Name.Equals(((Person)obj).Name);
            }

            public override int GetHashCode()
            {
                var x= this.Name.GetHashCode();
                return x;
            }
        }
        static void Main(string[] args)
        {
            HashSet<int> x = new System.Collections.Generic.HashSet<int>();
            x.Add(1);
            x.Add(2);
            x.Add(1);

            HashSet<Person> p = new HashSet<Person>();
            p.Add(new Person("pawel"));
            p.Add(new Person("pawel"));
            p.Add(new Person("marcin"));
            p.Add(new Person("gosia"));
            p.Add(new Person("magda"));


            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
