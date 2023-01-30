using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    public class Empresa
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string segmento { get; set; }

        public override string ToString()
        {
            return $"Id {id} - Nome: {nome} - Segmento de Atuação {segmento}";
        }
    }
}
