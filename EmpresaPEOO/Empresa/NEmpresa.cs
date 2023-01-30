using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;

namespace Empresa
{
    static class NEmpresa
    {
        private static List<VEmpresa> empresas = new List<VEmpresa>();
        public static void Inserir(VEmpresa t)
        {
            Abrir();
            // Procurar o maior Id
            int id = 0;
            foreach (VEmpresa obj in empresas)
                if (obj.id > id) id = obj.id;
            t.id = id + 1;
            empresas.Add(t);
            Salvar();
        }
        public static List<VEmpresa> Listar()
        {
            Abrir();
            return empresas;
        }
        public static void Atualizar(VEmpresa t)
        {
            Abrir();
            // Percorrer a lista de Empresa procurando o id informado (t.Id)
            foreach (VEmpresa obj in empresas)
                if (obj.id == t.id)
                {
                    obj.nome = t.nome;
                    obj.segmento = t.segmento;
                    obj.id = t.id;
                }
            Salvar();
        }
        public static void Excluir(VEmpresa t)
        {
            Abrir();
            // Percorrer a lista de Empresa procurando o id informado (t.Id)
            VEmpresa x = null;
            foreach (VEmpresa obj in empresas)
                if (obj.id == t.id) x = obj;
            if (x != null) empresas.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {
                // Objeto que serializa (transforma) uma lista de empresas em um texto em XML
                XmlSerializer xml = new XmlSerializer(typeof(List<VEmpresa>));
                // Objeto que abre um texto em um arquivo
                f = new StreamReader("./empresas.xml");
                // Chama a operação de desserialização informando a origem do texto XML
                empresas = (List<VEmpresa>)xml.Deserialize(f);
            }
            catch
            {
                empresas = new List<VEmpresa>();
            }
            // Fecha o arquivo
            if (f != null) f.Close();
        }
        public static void Salvar()
        {
            // Objeto que serializa (transforma) uma lista de empresas em um texto em XML
            XmlSerializer xml = new XmlSerializer(typeof(List<VEmpresa>));
            // Objeto que grava um texto em um arquivo
            StreamWriter f = new StreamWriter("./empresas.xml", false);
            // Chama a operação de serialização informando o destino do texto XML
            xml.Serialize(f, empresas);
            // Fecha o arquivo
            f.Close();
        }
    }
}
