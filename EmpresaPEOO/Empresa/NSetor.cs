using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa
{
    static class NSetor
    {

        private static List<Setor> setores = new List<Setor>();

        public static void Inserir(Setor p)
        {
            Abrir();

            int id = 0;
            foreach (Setor obj in setores)
                if (obj.id > id) id = obj.id;
            p.id = id + 1;
            setores.Add(p);
            Salvar();
        }
        public static List<Setor> Listar()
        {
            Abrir();
            return setores;
        }
        public static void Atualizar(Setor p)
        {
            Abrir();

            foreach (Setor obj in setores)
                if (obj.id == p.id)
                {
                    obj.nome = p.nome;
                    obj.id = p.id;
                    obj.atuação = p.atuação;
                }
            Salvar();
        }
        public static void Excluir(Setor p)
        {
            Abrir();

            Setor x = null;
            foreach (Setor obj in setores)
                if (obj.id == p.id) x = obj;
            if (x != null) setores.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {

                XmlSerializer xml = new XmlSerializer(typeof(List<Setor>));

                f = new StreamReader("./setores.xml");

                setores = (List<Setor>)xml.Deserialize(f);
            }
            catch
            {
                setores = new List<Setor>();
            }

            if (f != null) f.Close();
        }
        public static void Salvar()
        {

            XmlSerializer xml = new XmlSerializer(typeof(List<Setor>));

            StreamWriter f = new StreamWriter("./setores.xml", false);

            xml.Serialize(f, setores);

            f.Close();
        }
        public static void Cadastrar(Setor a, Empresa t)
        {
            a.idEmpresa = t.id;
            Atualizar(a);
        }
        public static List<Setor> Listar(Setor t)
        {
            Abrir();

            List<Setor> diario = new List<Setor>();
            foreach (Setor obj in setores)
                if (obj.id == t.id) diario.Add(obj);
            return diario;
        }

    }
}
