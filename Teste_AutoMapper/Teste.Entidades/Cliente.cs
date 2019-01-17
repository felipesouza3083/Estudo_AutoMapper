using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Entidades
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }

        public Cliente()
        {

        }

        public Cliente(string nome, string sobrenome, DateTime dataNascimento, bool ativo)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Ativo = ativo;
        }

        public override string ToString()
        {
            return $"Cliente:{Nome} {Sobrenome}";
        }
    }
}
