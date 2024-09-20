using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistematico.models
{
    internal class Calculo
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        // Constructor
        public Calculo(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        // Método para realizar la operación seleccionada
        public double RealizarOperacion(string operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case "+":
                    resultado = Numero1 + Numero2;
                    break;
                case "-":
                    resultado = Numero1 - Numero2;
                    break;
                case "x":
                    resultado = Numero1 * Numero2;
                    break;
                case "/":
                    if (Numero2 != 0)
                    {
                        resultado = Numero1 / Numero2;
                    }
                    else
                    {
                        throw new DivideByZeroException("No se puede dividir entre cero.");
                    }
                    break;
                default:
                    throw new ArgumentException("Operación no válida.");
            }

            return resultado;
        }
    }
}
