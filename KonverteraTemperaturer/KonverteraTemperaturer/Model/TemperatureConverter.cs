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
            return degreesC * 1.8 + 32;
        }

        public static double FahrenheitToCelsius(int degreesF)
        {
            return (degreesF - 32) * 5.0 / 9.0;
        }
    }
}