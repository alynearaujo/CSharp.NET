﻿using Manipulando_valores.Models;

Pessoa p1 = new Pessoa(nome: "Alane", sobrenome: "Vitória");
Pessoa p2 = new Pessoa(nome: "Alyne", sobrenome: "Rodrigues");
Pessoa p3 = new Pessoa(nome: "Luna", sobrenome: "Rodrigues");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();
