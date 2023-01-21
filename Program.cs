using ExemploExplorando.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Vinicius";
p1.Sobrenome = "Matos";

Pessoa p2 = new Pessoa();
p2.Nome = "Pâmela";
p2.Sobrenome = "Regina";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();














// Instanciando uma classe Pessoa
// Temos então uma variável "p1" do tipo "Pessoa"
// Pessoa p1 = new Pessoa();

// p1.Nome = "Vinicius";
// p1.Sobrenome = "Matos";
// p1.Idade = 38;
// p1.Apresentar();