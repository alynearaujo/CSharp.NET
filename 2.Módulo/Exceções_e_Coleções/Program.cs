using Exceções_e_Coleções.Models;

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("PE", "Pernambuco");
estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("---------------");

// estados.Remove("SP");
// // alteração de valor
// estados["PE"] = "Pernambuco - valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

string chave = "MG";
Console.WriteLine($"Verificando o elemento: {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}


























// Stack<int> pilha = new Stack<int>();

// pilha.Push(1);
// pilha.Push(3);
// pilha.Push(5);
// pilha.Push(7);
// pilha.Push(9);

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// foreach(int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(5);
// fila.Enqueue(3);
// fila.Enqueue(9);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// new ExemploExcecao().Metodo1();

// lê todas as linhas de um arquivo
// string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }


// tratamento de exceção com try catch
// try 
// {
//     string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
    
// } 
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Caminho do arquivo não encontrato. {ex.Message}");
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
// }
// catch(Exception ex)
// {
//     Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("\nBloco finally sempre será executado, independete de ter tido uma exceção.");
// } 
