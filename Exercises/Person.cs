using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.Exercises
{
    public class Person
    {
        public Person(string name, string lastName) 
        {
            Name = name;
            LastName = lastName;
        }

        public void Deconstruct(out string name, out string lastName)
        {
            name = Name;
            lastName = LastName;
        }
        private string  _name;
        private string _lastName;
        // public allName = name + lastName;
        public string Name { 

            get => _name.ToUpper();

            set {
                if (value == "") {
                    throw new ArgumentException ("The name cant be null");
                }
                _name = value;
            }
        }
        public string LastName { 

            get => _lastName.ToUpper();

            set {
                if (value == "") {
                    throw new ArgumentException ("The lastName cant be null");
                }
                _lastName = value;
            }
        }
        public int Age { get; set; }

        public void Show() 
        {
            Console.WriteLine($"name:  {Name},  Age:  {Age}");
        }
    }
}