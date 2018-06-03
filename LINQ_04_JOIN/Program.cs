using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_04_JOIN {
    class Program {
        static void Main(string[] args) {

            List<Usuario> usuarios = new List<Usuario> {
                new Usuario() { Nome = "AAA", Cidade = "RJ", Idade = 25 },
                new Usuario() { Nome = "BBB", Cidade = "SP", Idade = 25 },
                new Usuario() { Nome = "CCC", Cidade = "RJ", Idade = 35 },
                new Usuario() { Nome = "DDD", Cidade = "SP", Idade = 15 },
                new Usuario() { Nome = "EEE", Cidade = "MT", Idade = 25 },
                new Usuario() { Nome = "FFF", Cidade = "CE", Idade = 45 }
            };

            List<Cidade> cidades = new List<Cidade> {
                new Cidade() {Sigla = "RJ", Descricao = "Rio de Janeiro" },
                new Cidade() {Sigla = "SP", Descricao = "São Paulo" },
                new Cidade() {Sigla = "MT", Descricao = "Mato Grosso do Sul" },
                new Cidade() {Sigla = "CE", Descricao = "Ceará"}
            };

            //Declaração LINQ utilizando o join e criando um
            var listaFiltrada = from users in usuarios join cities in cidades on users.Cidade equals cities.Sigla where users.Idade == 25 select new { users, cities };


            foreach (var item in listaFiltrada) {

                Console.WriteLine($"Nome: {item.users.Nome}, Sigla: {item.cities.Sigla}, Descrição: {item.cities.Descricao}");

            }
            Console.ReadKey();
        }
    }
}
