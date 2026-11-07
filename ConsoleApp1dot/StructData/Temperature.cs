using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1dot.StructData
{
    readonly struct Temperature
    {
        public double Celsius { get; }

        public Temperature(double celsius) => Celsius = celsius;

        public double Fahrenheit => Celsius * 9.0 / 5.0 + 32.0;

        public override string ToString() => $"{Celsius:F1}°C ({Fahrenheit:F1}°F)";
    }
}
