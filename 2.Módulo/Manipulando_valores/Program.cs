using Manipulando_valores.Models;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); // alterando a localização do código

decimal valorMonetario = 1582.40M;
Console.WriteLine($"{valorMonetario:C}");
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // alterando a localização da cultura
Console.WriteLine(valorMonetario.ToString("C8"));

double porcentagem = .7721;
Console.WriteLine(porcentagem.ToString("P"));

int numero = 654321;
Console.WriteLine(numero.ToString("##-##-##"));

DateTime data = DateTime.Now;
Console.WriteLine(data); 
Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // utilizar o H em maiúsculo representa o horário em formato de 24h
Console.WriteLine(data.ToString("dd/MM/yyyy hh:mm")); // utilizar o H em minúsculo representa o horário em formato de 12h
Console.WriteLine(data.ToShortDateString()); // exibe apenas a data
Console.WriteLine(data.ToShortTimeString()); // exibe apenas a hora

DateTime dataConvertida = DateTime.Parse("01/03/1996 11:50"); // converte string para tipo datetime, se o valor for inválido retorna exception
Console.WriteLine(dataConvertida);

string dataString = "2023-03-17 18:00";
bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data2); // não retorna exception em caso de erro
Console.WriteLine(data2);

if (sucesso)
{
    Console.WriteLine($"Conversão realizada com sucesso! Data: {data2}");
}
else
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}


// Pessoa p1 = new Pessoa(nome: "Alane", sobrenome: "Vitória");
// Pessoa p2 = new Pessoa(nome: "Alyne", sobrenome: "Rodrigues");
// Pessoa p3 = new Pessoa(nome: "Luna", sobrenome: "Rodrigues");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ListarAlunos();
