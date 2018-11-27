using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUnidade2.MVC.WEB.Models
{
    public class Contato
    {
        public int ContatoID { get; set; }
        public string Nome { get; set; }
        public Telefone Telefone { get; set; }
    }
}