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
