using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosFundamentos.Common.Models
{
    /// <summary>
    /// Representa uma pessoa física.
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade.
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Olá! O meu nome é {Nome} \n\n e tenho {Idade} anos de idade.");

            // Console.WriteLine($"Olá! O meu nome é {Nome}, e tenho {Idade} anos de idade.");

            /* ou: */
            // Console.WriteLine($"Olá! O meu nome é {Nome}," +
            // $" e tenho {Idade} anos de idade.");

        }
    }
}