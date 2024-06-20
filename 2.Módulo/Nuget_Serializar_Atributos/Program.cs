using System.Text.Json;
using Nuget_Serializar_Atributos.Models;
using Newtonsoft.Json;

string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach (Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}" + $"Preço: {venda.Preco}, Data: {venda.DataVenda}");
}













// DateTime dataAtual = DateTime.Now;

// // criação da lista de vendas
// List<Venda> listaVendas = new List<Venda>();

// // instanciando objetos Venda
// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// // adicionando as vendas a lista
// listaVendas.Add(v1);
// listaVendas.Add(v2);

// // serialização da lista de vendas para JSON
// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);
// Console.WriteLine(serializado);