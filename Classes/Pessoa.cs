using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosMétodos.Classes
{
    public class Pessoa
    {
        // Atributos

        public string Nome;

        // Métodos

        public void Cumprimentar()
        {
            Console.WriteLine($"Olá eu sou o {Nome}");
        }

        public void CumprimentarAlguem(string outraPessoa)
        {
            Console.WriteLine($"Olá {outraPessoa}, meu nome é {Nome}");
        }

        public string ObterApresentação()
        {
            return "Meu nome é " + Nome;
        }

    }
}
