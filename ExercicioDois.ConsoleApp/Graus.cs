using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDois.ConsoleApp
{
    internal class Graus
    {
        public double fahrenheit;
        public double celsius;
        public double ConverterFahrenheitCelsius(double fahrenheit)
        {
            celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }
    }
}
