using Tuplas_Operador_Ternário_Desconstrução.Models;

int numero = 20;
bool ehPar;

// IF ternário

ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par.");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é ímpar.");
// }

// Pessoa p1 = new Pessoa("Alyne", "Rodrigues");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");


// Criando uma Tupla - Exemplo 01

// ValueTuple<int, string, string, decimal> tupla1 = (1, "Alyne", "Rodrigues", 1.60M);

// Console.WriteLine($"ID: {tupla1.Item1}");
// Console.WriteLine($"Nome: {tupla1.Item2}");
// Console.WriteLine($"Sobrenome: {tupla1.Item3}");
// Console.WriteLine($"Altura: {tupla1.Item4}");

// Criando uma Tupla - Exemplo 02

// (int ID, string Nome, string Sobrenome, decimal Altura) tupla2 = (1, "Alyne", "Rodrigues", 1.60M);
 
// Console.WriteLine($"ID: {tupla2.Item1}");
// Console.WriteLine($"Nome: {tupla2.Item2}");
// Console.WriteLine($"Sobrenome: {tupla2.Item3}");
// Console.WriteLine($"Altura: {tupla2.Item4}");

// Criando uma Tupla - Exemplo 03

// var tupla3 = (Id: 1, Nome: "Alyne", Altura: 1.60M);

// Console.WriteLine($"ID: {tupla3.Id}, Nome: {tupla3.Nome}, Altura: {tupla3.Altura}");

// Criando uma Tuple - Exemplo 04 - Não precisa passar o tipo

// var tuple4 = Tuple.Create(1, "Alyne", "Rodrigues", 1.60M);
