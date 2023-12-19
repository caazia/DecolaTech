using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploPOO.Models
{
    // sealed é para selar uma classe, nisso ela não vai poder ter classes filhas e a classe não pode ser herdada, só pode herdar de alguma classe.

    public class Professor : Pessoa
    {
        public Professor()
        {
            
        }
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos e tenho o salario de {Salario} reais.");
        }
    }
}