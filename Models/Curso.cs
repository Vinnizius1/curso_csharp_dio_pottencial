using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }

        // List é uma coleção de um determinado tipo, no caso, tipo Pessoa
        public List<Pessoa> Alunos { get; set; }

        // Método
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }
    }
}