using Tuplas_Operador_Ternário_Desconstrução.Models;

Pessoa p1 = new Pessoa("Alyne", "Rodrigues");

(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");





















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
    
//     foreach(string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo.");
// }


















// Criando uma Tuple - Exemplo 01

// ValueTuple<int, string, string, decimal> tupla1 = (1, "Alyne", "Rodrigues", 1.60M);

// Console.WriteLine($"ID: {tupla1.Item1}");
// Console.WriteLine($"Nome: {tupla1.Item2}");
// Console.WriteLine($"Sobrenome: {tupla1.Item3}");
// Console.WriteLine($"Altura: {tupla1.Item4}");

// Criando uma Tuple - Exemplo 02

// (int ID, string Nome, string Sobrenome, decimal Altura) tupla2 = (1, "Alyne", "Rodrigues", 1.60M);
 
// Console.WriteLine($"ID: {tupla2.Item1}");
// Console.WriteLine($"Nome: {tupla2.Item2}");
// Console.WriteLine($"Sobrenome: {tupla2.Item3}");
// Console.WriteLine($"Altura: {tupla2.Item4}");

// Criando uma Tuple - Exemplo 03

// var tupla3 = (Id: 1, Nome: "Alyne", Altura: 1.60M);

// Console.WriteLine($"ID: {tupla3.Id}, Nome: {tupla3.Nome}, Altura: {tupla3.Altura}");

// Criando uma Tuple - Exemplo 04 - Não precisa passar o tipo

// var tuple4 = Tuple.Create(1, "Alyne", "Rodrigues", 1.60M);
