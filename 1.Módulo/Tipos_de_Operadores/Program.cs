// Tipos de operadores
// atribuição (=)

// int a = 10;
// int b = 20;
// int c = a + b;

// c += 5;  
// Console.WriteLine(c);

// c -= 5;
// Console.WriteLine(c);

// c *= 5;
// Console.WriteLine(c);

// Convertendo um tipo string para inteiro | existem duas formas: 

// int a = Convert.ToInt32("5");
// Console.WriteLine(a);

// int a = int.Parse("5");
// Console.WriteLine(a);

// int b = Convert.ToInt32(null);
// Console.WriteLine($"{a}, {b}");

//Convertendo um tipo inteiro para string 

// int c = 32;
// string d = c.ToString();
// Console.WriteLine(d);

// Casting implicito

// int a = 5;
// não dá erro pois o double suporta int, daria erro se fosse o contrário pois pode existir um valor de double que o int não suporta (necessário conversão)
// double b = a; 
// Console.WriteLine(b);

// Convertendo de maneira segura

// string x = "15";
// int y = 0;

// int.TryParse(x, out y);
// Console.WriteLine("Conversão realizada!");

// Condicionais

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


// switch case

// Console.WriteLine("Digite uma letra");
// string? letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal.");
//         break;
// }

// Operador lógico || (OR)

// bool maiorDeIdade = false;
// bool possuiAutorizacao = false;

// if (maiorDeIdade || possuiAutorizacao)
// {
//     Console.WriteLine("Entrada liberada.");
// }
// else
// {
//     Console.WriteLine("Entrada não permitida.");
// }

// Operador lógico && (AND)

bool presencaMinima = true;
double media = 7;

if (presencaMinima && media >= 7)
{
    Console.WriteLine("Aprovado.");
}
else 
{
    Console.WriteLine("Reprovado.");
}











