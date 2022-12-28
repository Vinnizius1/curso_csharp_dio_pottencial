/* assim: */
using ExemplosFundamentos.Models;

string apresentacao = "Olá, seja bem-vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine("Altura: " + altura.ToString("0.00"));
Console.WriteLine("Preço: " + preco);
Console.WriteLine("Quantidade e Condição: " + quantidade + " - " + condicao);





Pessoa pessoa1 = new Pessoa();

/* ou assim: */
// ExemplosFundamentos.Models.Pessoa pessoa1 = new ExemplosFundamentos.Models.Pessoa();

pessoa1.Nome = "Vinicius";
pessoa1

.Idade = 38;
// pessoa1.Apresentar();