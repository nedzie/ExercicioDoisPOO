using System;

namespace ExercicioDois.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graus fah = new Graus();
            Console.WriteLine("Informa a temperatura em ºF: \n> ");
            fah.fahrenheit = double.Parse(Console.ReadLine());
            fah.celsius = fah.ConverterFahrenheitCelsius(fah.fahrenheit);
            Console.Clear();
            Console.WriteLine(fah.fahrenheit + "°F, convertidos ficam " + fah.celsius.ToString("#.##") + "°C.");
            Console.ReadKey();
        }
    }
}