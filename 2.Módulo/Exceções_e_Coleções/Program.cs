using Exceções_e_Coleções.Models;

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(5);
fila.Enqueue(3);
fila.Enqueue(9);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");

foreach (int item in fila)
{
    Console.WriteLine(item);
}

















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
