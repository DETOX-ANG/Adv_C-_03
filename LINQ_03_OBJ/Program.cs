using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_03_OBJ {
    class Program {
        static void Main(string[] args) {

            //Uma manei
            List<Usuario> usuarios = new List<Usuario> {
                new Usuario() { Nome = "AAA", Cidade = "RJ", Idade = 25 },
                new Usuario() { Nome = "BBB", Cidade = "SP", Idade = 25 },
                new Usuario() { Nome = "CCC", Cidade = "RJ", Idade = 35 },
                new Usuario() { Nome = "DDD", Cidade = "SP", Idade = 15 },
                new Usuario() { Nome = "EEE", Cidade = "MT", Idade = 25 },
                new Usuario() { Nome = "FFF", Cidade = "CE", Idade = 45 }
            };

            var ListaFiltrada = usuarios.Where(a => a.Cidade.Equals("RJ"));

            foreach (var item in ListaFiltrada) {

                Console.WriteLine($"Nome: {item.Nome}, Cidade: {item.Cidade}, Idade: {item.Idade}");
            }
            Console.ReadKey();
        }
    }
}
