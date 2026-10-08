using System;
using System.Collections.Generic;
using System.Text;

namespace ExercíciosMétodos.Classes
{
    public class Calculadora
    {

        // Atributos

        // Métodos

        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public void MostrarResultado(int valor)
        {
            Console.WriteLine("Resultado: " + valor);
        }

    }
}
