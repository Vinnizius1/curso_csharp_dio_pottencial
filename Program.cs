/* assim: */
using ExemplosFundamentos.Models;


// O TryParse EVITA quebrar a execução do programa caso dê algum erro de conversão!
string a = "15--c";
int b = 0;

int.TryParse(a, out b);

Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso!");




// int x = int.MaxValue;
// long y = x;

// Console.WriteLine(y);

// Cast Implícito
// int a = 10;
// double b = a;
// Console.WriteLine(b);
// Portanto, fazer:
// "double b = Convert.ToDouble(a);" seria REDUNDANTE! O double cabe o inteiro e muito mais.
// Já o inverso dará RUIM, pois o double NÃO CABE no int! Nesse caso devemos fazer a conversão explicitamente:
// int b = Convert.ToInt32(a);



// Cast ou Casting
// int a = Convert.ToInt32("5");
// int a = int.Parse("5");
// int a = Convert.ToInt32(null);
// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);







// DateTime dataAtual = DateTime.Now;
// Console.WriteLine(dataAtual.AddDays(5));
// Console.WriteLine($"{dataAtual.ToString("dd/MM/yyyy")}");
// Console.WriteLine($"{dataAtual.ToString("dd/MM/yyyy HH:mm")}");




// string apresentacao = "Olá, seja bem-vindo";
// int quantidade = 1;
// quantidade = 10;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;
// condicao = false;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Altura: " + altura.ToString("0.00"));
// Console.WriteLine("Preço: " + preco);
// Console.WriteLine("Quantidade e Condição: " + quantidade + " - " + condicao);





Pessoa pessoa1 = new Pessoa();

/* ou assim: */
// ExemplosFundamentos.Models.Pessoa pessoa1 = new ExemplosFundamentos.Models.Pessoa();

pessoa1.Nome = "Vinicius";
pessoa1

.Idade = 38;
// pessoa1.Apresentar();