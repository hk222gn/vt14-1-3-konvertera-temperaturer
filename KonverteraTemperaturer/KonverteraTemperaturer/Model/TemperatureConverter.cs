using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KonverteraTemperaturer.Model
{
    public class TemperatureConverter
    {
        public static double CelsiusToFahrenheit(int degreesC)
        {
            double fahrenheit = degreesC * 1.8 + 32;

            return fahrenheit;
        }

        public static double FahrenheitToCelsius(int degreesF)
        {
            double celsius = (degreesF - 32) * 5.0 / 9.0;

            return celsius;
        }
    }
}