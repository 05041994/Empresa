using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    public class Setor
    {
        public int id { get; set; }
        public string atuação { get; set; }
        public string nome { get; set; }
        public int idEmpresa { get; set; }

        public override string ToString()
        {
            return $"id setor: {id} - Nome: {nome} - Atuação: {atuação} - Id da empresa: {idEmpresa} ";
        }
    }
}
