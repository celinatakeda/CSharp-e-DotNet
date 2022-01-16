// See https://aka.ms/new-console-template for more information

using System;
using Primeiro;
using Interface;
using Enum;

namespace CSharp
{
    class Program
    {
        static void Main(string[] Args)
        {
            var pessoa = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.João;
            Pessoas pessoa3 = (Pessoas)4;

            Animal animal = new Animal();

            animal.Nome = "Rex";
            animal.NomeDono = "Pedro";
            animal.Especie = "Cachorro";

            Pessoa person = new Pessoa();

            person.Nome = "Celina";
            person.Estado = "SP";
            person.Idade = 48;

            var person2 = new Pessoa();

            person2.Nome = "Julia";
            person2.Estado = "PR";
            person2.Idade = 28;           

            var classe = new Classe();
            var classe2 = new Segundo.Classe();

            Console.WriteLine(pessoa3);
            Console.WriteLine("Hello, World!");

        }
    }
}

