using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoUnidade2.MVC.WEB.Models
{
    public class Telefone
    {
        public int TelefoneID { get; set; }
        public string Numero { get; set; }

        public override string ToString() {
            return Numero;
        }
    }
}