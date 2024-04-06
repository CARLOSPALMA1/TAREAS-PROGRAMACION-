using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora("Casio", "Fx-82");
            Calc_Cientifica calc_ = new Calc_Cientifica("Casio", "Fx-82");

            Console.WriteLine("Datos de la Calculadora");
            Console.WriteLine($"Marca: {Calc.Marca}");
            Console.WriteLine($"Modelo: {Calc.Serie}");f