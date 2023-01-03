using ExemplosFundamentos.Common.Models;


// Sintaxe de uma Lista
List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("GO");
listaString.Add("BA");

System.Console.WriteLine("Percorrendo a lista com o FOR:");
for (int contador = 0; contador < listaString.Count; contador++)
{
    System.Console.WriteLine($"Posição n° {contador + 1} - {listaString[contador]}");
}

System.Console.WriteLine("Percorrendo a lista com o FOREACH:");
int contadorForeach = 0;
foreach (string item in listaString)
{
    System.Console.WriteLine($"Posição n° {contadorForeach + 1} - {item}");
    contadorForeach++;
}







// int[] arrayInteiros = { 72, 64, 50 };

// // Duas formas de "redimensionarmos" o Array
// // Array.Copy( )
// int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

// // Array.Resize( )
// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);


// // Percorrendo o Array com o FOR
// System.Console.WriteLine("Percorrendo o Array com o FOR");
// for (int contador = 0; contador < arrayInteiros.Length; contador++)
// {
//     System.Console.WriteLine($"Posição n° {contador} - {arrayInteiros[contador]}");
// }













// Percorrendo o Array com o FOREACH
// System.Console.WriteLine("Percorrendo o Array com o FOREACH");
// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     System.Console.WriteLine($"Posição n° {contadorForeach} - {valor}");
//     contadorForeach++;
// }












// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Vinicius";
// pessoa1.Idade = 38;
// pessoa1.Apresentar();


// Construindo um menu interativo
// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.Clear();
//     System.Console.WriteLine("Digite a sua opção:");
//     System.Console.WriteLine("1 - Cadastrar cliente");
//     System.Console.WriteLine("2 - Buscar cliente");
//     System.Console.WriteLine("3 - Apagar cliente");
//     System.Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             System.Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             System.Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             System.Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             System.Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             // Environment.Exit(0);
//             break;

//         default:
//             System.Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// System.Console.WriteLine("O programa se encerrou");





// Do While
// int soma = 0, numero = 0;

// do
// {
//     System.Console.WriteLine("Digite um número (0 para sair):");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");





//WHILE
// int numero = 5;
// int contador = 0;

// while (contador <= 10)
// {
//     System.Console.WriteLine($"{contador + 1}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 5)
//     {
//         break;
//     }
// }








//FOR
// int numero = 5;

// for (int contador = 0; contador <= 10; contador = contador + 2)
// {
//     System.Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }







// Calculadora
// Calculadora calc = new Calculadora();

// calc.Somar(10, 40);
// calc.Subtrair(10, 50);
// calc.Multiplicar(15, 25);
// calc.Dividir(2, 2);
// calc.Potencia(2, 3);

// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);

// calc.RaizQuadrada(16);








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