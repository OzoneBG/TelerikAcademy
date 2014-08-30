using System;

namespace Person
{
    public class Person
    {
        public string name;
        public string age;

        public Person(string name, string age = null)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            if (age == null)
            {
                return "Age: not specified!" + "\n" + "Name: " + this.name;
            }

            return "Age: " + this.age + "\n" + "Name: " + this.name;
        }
    }
}
