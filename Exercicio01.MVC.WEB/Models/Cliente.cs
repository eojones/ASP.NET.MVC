using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercicio01.MVC.WEB.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }

        public Cliente() { }
        public Cliente(int id, string nome, int idade, string telefone, DateTime dtNascimento, string endereco)
        {
            this.ClienteID = id;
            this.Nome = nome;
            this.Idade = idade;
            this.Telefone = telefone;
            this.DataNascimento = dtNascimento;
            this.Endereco = endereco;
        }
    }
}