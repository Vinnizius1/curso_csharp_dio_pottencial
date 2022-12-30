using ExemplosFundamentos.Models;



// Calculadora
Calculadora calc = new Calculadora();

// calc.Somar(10, 40);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 25);
// calc.Dividir(2, 2);
calc.Potencia(2, 3);










// Switch case
// Console.WriteLine("Digite uma letra:");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         System.Console.WriteLine("Vogal");
//         break;

//     default:
//         System.Console.WriteLine("Não é uma vogal");
//         break;
// }







// Operador Condicional
// int quantidadeEmEstoque = 10;
// int quantidadeCompra = 0;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida.");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }







// O TryParse EVITA quebrar a execução do programa caso dê algum erro de conversão!
// string a = "15--c";
// int b = 110;
// int.TryParse(a, out b); OU posso fazer assim também:
// int.TryParse(a, out int b);

// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");




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





// Pessoa pessoa1 = new Pessoa();

/* ou assim: */
// ExemplosFundamentos.Models.Pessoa pessoa1 = new ExemplosFundamentos.Models.Pessoa();

// pessoa1.Nome = "Vinicius";
// pessoa1

// .Idade = 38;
// pessoa1.Apresentar();