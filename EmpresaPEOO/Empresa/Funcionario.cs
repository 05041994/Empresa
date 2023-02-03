using System;
using System.Collections.Generic;
using System.Text;

namespace Empresa
{
    public class Funcionario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public int idSetor { get; set; }

        public override string ToString()
        {
            return $"id:{id} - Nome: {nome} - Email: {email} - Setor onde ele trabalha: {idSetor}";
        }
    }
}
