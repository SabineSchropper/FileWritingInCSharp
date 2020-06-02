using System;
using System.Collections.Generic;
using System.Text;

namespace Personen.models
{
    class Person
    {
        public string name;
        public int age;
        public string city;
        public string job;

        public Person(string name, int age, string city)
        {
            this.name = name;
            this.age = age;
            this.city = city;
        }
    }
}
