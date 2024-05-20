using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_de_Projeto_2.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome) {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string Nome {get; set;}
        private string Sobrenome {get; set;}
    }
}