using Personen.models;
using System;
using System.Collections.Generic;

namespace Personen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string[] fileContent = System.IO.File.ReadAllLines("C:\\Users\\DCV\\C#\\Personen\\persons.txt");


            for(int i = 0; i < fileContent.Length; i++)
            {
                string[] partArray = fileContent[i].Split(";");
                string name = partArray[0];
                int age = Int32.Parse(partArray[1]);
                string city = partArray[2];
                Person person = new Person(name,age,city);
                persons.Add(person);
            }
            for (int i = 0; i < persons.Count; i++)
            {
                switch (persons[i].name)
                {
                    case "Helga" :persons[i].job = "Coder"; break;
                    case "Hans": persons[i].job = "Coder"; break;
                    default: persons[i].job = "Officer"; break;
                }
            }
            for (int i = 0; i < persons.Count; i++)
            {
                fileContent[i] = persons[i].name + ";" + persons[i].age + ";" + persons[i].city + ";" + persons[i].job;
            }
            System.IO.File.WriteAllLines("C:\\Users\\DCV\\C#\\Personen\\persons1.txt", fileContent);
           

        }
    }
}
