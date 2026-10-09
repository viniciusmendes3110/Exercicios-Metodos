// Exercício 1

using ExercíciosMétodos.Classes;
using System.Runtime.InteropServices.Marshalling;

//Pessoa ana = new Pessoa();

//ana.Nome = "Ana";

//ana.Cumprimentar();

//ana.CumprimentarAlguem("Bruno");

//string frase = ana.ObterApresentação();
//Console.WriteLine(frase);

//// Exercício 2

//Calculadora calculadora = new Calculadora();

//int soma = calculadora.Soma(10, 5);
//calculadora.MostrarResultado(soma);

//calculadora.MostrarResultado(calculadora.Subtrair(10, 5));

// Exercício 3

Conversor conversor = new Conversor();

double f = conversor.CelsiusParaFahrenheit(25);
Console.WriteLine($"{25}°C = {f}°F");

if (true == conversor.EstaQuente(35))
{
    Console.WriteLine("35°C: está quente!");
}

if (true != conversor.EstaQuente(18))
{
    Console.WriteLine("18°C: não está quente.");
}

// Intermediário

// Exercício 4

