using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;

        public string Nome
        {
            get => _nome.ToUpper();

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
                /* "value" é o argumento que receberá o "nome" */

                /* BODY EXPRESSION no "set" poderia ser assim (sem o 'if'):
                set => _nome = value;
                 */
            }
        }
        public int Idade { get; set; }

        // método
        public void Apresentar()
        {
            System.Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}