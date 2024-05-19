
string[] linhas = File.ReadAllLines("Files/arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}
