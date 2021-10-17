using System;
using System.Collections.Generic;

namespace Course_77 {
    class Program {
        static void Main(string[] args) {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Jorge");
            list.Insert(2, "Thiago");
            list.Add("Aninha");

            Listagem(list);

            Console.WriteLine("");
            Console.WriteLine(list.Count);

            Console.WriteLine("----------");
            string find = list.Find(s => s[0] == 'B');
            Console.WriteLine(find);
            string findl = list.FindLast(s => s[0] == 'A');
            Console.WriteLine(findl);
            Console.WriteLine("----------------------");

            int findindex = list.FindIndex(c => c.Length >= 5);
            Console.WriteLine("index first: " + findindex);
            int findlastindex = list.FindLastIndex(c => c.Length >= 5);
            Console.WriteLine("index last: " + findlastindex);
            Console.WriteLine("---------------------");

            List<string> list2 = list.FindAll(str => str[0] == 'A');
            Listagem(list2);

            Console.WriteLine("\n_____________________");
            list.Remove("Jorge");
            Listagem(list);

            list.RemoveAll(str => str.Length < 5);
            Listagem(list);

            list.RemoveAt(1);
            Listagem(list);

            list.Add("Jabulani");
            list.Add("America");
            list.RemoveRange(0, 2);
            Listagem(list);
        }

        static void Listagem(List<string> vs) {
            Console.WriteLine("\nLISTAGEM");
            foreach (string name in vs) {
                Console.WriteLine(name);
            }
        }
    }
}
