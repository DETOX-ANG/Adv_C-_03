using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ {
    class Program {
        static void Main(string[] args) {

            //Labda (entrada) => (expressao)
            int[] lista = {2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 40, 60, 80, 100, 35, 45, 21, 50};

            //expressão lambda. O "a" dentro do where representa a lista
            var listafiltrada = lista.Where(a => a > 20 ).OrderBy(a => a);

            foreach (var item in listafiltrada) {

                Console.WriteLine(item);


            }
            Console.ReadKey();
        }
    }
}
