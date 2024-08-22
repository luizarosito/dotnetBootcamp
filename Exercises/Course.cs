using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.Exercises
{
    public class Course
    {
        
        public string Name { get; set; }
        public List<Person> Students { get; set; }

        public void AddStudent(Person Student) {
            Students.Add(Student);
        }

        public int GetNumberRegistrations() 
        {
            int quantidade = Students.Count;
            return quantidade;
        }

        public bool RemoverStudent(Person Student) 
        {
            return Students.Remove(Student);
        }

        public void ListStudents()
        {
            Console.WriteLine($"Course student: {Name}");

            for(int count = 0; count < Students.Count; count ++) {
                // string text = "Nº" + count + " - " + Students[count].Name;
                string text = $"Nº {count + 1} - {Students[count].Name}";
                Console.WriteLine(text);
            }

            // foreach(Pessoa Student in Students) {
            //     Console.WriteLine(Student.Name);
            // }
        }
    }
}