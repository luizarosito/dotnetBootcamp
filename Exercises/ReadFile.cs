using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetBootcamp.Exercises
{
    public class ReadFile
    {
        public void Read()
        {

            try
            {
                string[] linhas = File.ReadAllLines("Exercises/Files/read.txt");
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Generic exception. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Execution sucessful.");
            }

        }

        public (bool Sucess, string[] Lines, int NumberLines) ReadFiles(string caminho)
        {
            try
            {
                string[] lines = File.ReadAllLines(caminho);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}