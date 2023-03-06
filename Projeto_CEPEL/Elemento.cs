using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_CEPEL
{
    internal class Elemento
    {
        public string tipo { get; set; }
        public string numero { get; set; }  
        public string de { get; set; }
        public string para { get; set; }
        public string linha { get; set; }
        public string barra { get; set; }

        public Elemento(string tipo, string numero, string de, string para, string linha, string barra)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.de = de;
            this.para = para;
            this.linha = linha;
            this.barra = barra;
        }
    }
}
