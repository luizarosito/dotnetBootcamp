using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.Exercises
{
    public class Collections
    {
        public void AddQueue()
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(2);
            q.Enqueue(4);
            q.Enqueue(6);
            q.Enqueue(8);

            foreach (int item in q)
            {
                Console.WriteLine($"Login queue {item}");
            }

            Console.WriteLine($"Element removed: {q.Dequeue()}");

            foreach (int item in q)
            {
                Console.WriteLine(item);
            }

        }

        public void AddStack()
        {
            Stack<int> s = new Stack<int>();
            s.Push(4);
            s.Push(6);
            s.Push(8);
            s.Push(10);

            foreach(int item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removed the element from the stack: {s.Pop()}");

            s.Push(12);

            
            foreach(int item in s)
            {
                Console.WriteLine(item);
            }
        }

        public void AddDictionary()
        {
            Dictionary<string, string> state = new Dictionary<string, string>();

            state.Add("SP", "São Paule");
            state.Add("MG", "Minas Gerais");
            state.Add("RJ", "Rio de Janeiro");

            foreach(var item in state)
            {
                Console.WriteLine($"Key: {item.Key}, value: {item.Value}");

            }

             Console.WriteLine("----------------------");

            //Enter only key to remove or edit the value
            state.Remove("MG");
            state["SP"] = "São Paulo";
            state.Add("Rg", "Rio de Janeiro");


            foreach(var item in state)
            {
                Console.WriteLine($"Key: {item.Key}, value: {item.Value}");

            }
        }

        public void addTuple() 
        {
            (int, string FirstName, string, decimal Height) tuple = (1, "Luiza", "Rosito", 1.6m);

            //Other example
            var tupleCreate = Tuple.Create(1, "Rosito");

            Console.WriteLine($"Id: {tuple.Item1}");
            Console.WriteLine($"First name: {tuple.FirstName}");
            Console.WriteLine($"Last name: {tuple.Item3}");
            Console.WriteLine($"Height: {tuple.Height}");
        }

        
    }
}