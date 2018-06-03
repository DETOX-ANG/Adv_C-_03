using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_02 {
    class Program {
        static void Main(string[] args) {

            //Expressão LINQ segunda forma
            int[] lista = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 40, 60, 80, 100, 35, 45, 21, 50, 15 };

            var Listafiltrada = from a in lista where a < 20 orderby a select a;

            foreach (var item in Listafiltrada) {

                Console.WriteLine("-- " + item);
                

            }
            Console.ReadKey();
        }
    }
}
