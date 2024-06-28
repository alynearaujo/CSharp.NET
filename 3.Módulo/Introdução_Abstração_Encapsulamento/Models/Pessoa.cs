using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introdução_Abstração_Encapsulamento.Models
{
    public class Pessoa
    {
        // propriedade
        public string Nome { get; set; }
        public int Idade { get; set; }

        // método
        public void Apresentar()
        {
            Console.WriteLine($" Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}