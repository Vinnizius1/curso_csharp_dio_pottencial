using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/* A classe Curso tem 2 propriedades, sendo:
 o "Nome" do curso e uma Lista de alunos
 mais 4 métodos */

namespace ExemploExplorando.Models
{
    public class Curso
    {
        // Propriedades
        public string Nome { get; set; }
        // List é uma coleção de um determinado tipo, no caso, tipo Pessoa
        public List<Pessoa> Alunos { get; set; }

        // Métodos
        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}