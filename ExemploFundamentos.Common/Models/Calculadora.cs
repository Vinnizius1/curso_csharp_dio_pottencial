using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        /// Realiza a soma de dois números.
        /// </summary>
        /// <param name="x">O primeiro número inteiro para somar</param>
        /// <param name="y">O segundo número inteiro para somar</param>
        public void Somar(int x, int y)
        {
            System.Console.WriteLine($"{x} + {y} = {x + y}");
        }

        /// <summary>
        /// Realiza a subtração de dois números
        /// </summary>
        /// <param name="x">O primeiro número inteiro para subtrair</param>
        /// <param name="y">O segundo número inteiro para subtrair</param>
        /// <returns>Retorna a subtração de x e y</returns>
        public int Subtrair(int x, int y)
        {
            System.Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
        }
        public void Multiplicar(int x, int y)
        {
            System.Console.WriteLine($"{x} x {y} = {x * y}");
        }
        public void Dividir(int x, int y)
        {
            System.Console.WriteLine($"{x} / {y} = {x / y}");
        }
        public void Potencia(int x, int y)
        {
            double pot = Math.Pow(x, y);
            System.Console.WriteLine($"{x}^{y} = {pot}");
        }

        public void Seno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            System.Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            System.Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }
        public void Tangente(double angulo)
        {
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            System.Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            double raiz = Math.Sqrt(x);
            System.Console.WriteLine($"Raiz quadrada de {x} = {raiz}");
        }
    }
}