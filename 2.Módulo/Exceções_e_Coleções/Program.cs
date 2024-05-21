

// lê todas as linhas de um arquivo
// string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

// foreach (string linha in linhas)
// {
//     Console.WriteLine(linha);
// }


// tratamento de exceção com try catch
try 
{
    string[] linhas = File.ReadAllLines("Files/arquivo_Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} catch(Exception ex)
{
    Console.WriteLine($"Ocorreu um exceção genérica. {ex.Message}");
}