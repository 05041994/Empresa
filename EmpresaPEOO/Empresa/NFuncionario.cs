using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa
{
    static class NFuncionario
    {
        private static List<Funcionario> Funcionarios = new List<Funcionario>();

        public static void Inserir(Funcionario p)
        {
            Abrir();

            int id = 0;
            foreach (Funcionario obj in Funcionarios)
                if (obj.id > id) id = obj.id;
            p.id = id + 1;
            Funcionarios.Add(p);
            Salvar();
        }
        public static List<Funcionario> Listar()
        {
            Abrir();
            return Funcionarios;
        }
        public static void Atualizar(Funcionario p)
        {
            Abrir();

            foreach (Funcionario obj in Funcionarios)
                if (obj.id == p.id)
                {
                    obj.nome = p.nome;
                    obj.id = p.id;
                    obj.email = p.email;
                }
            Salvar();
        }
        public static void Excluir(Funcionario p)
        {
            Abrir();

            Funcionario x = null;
            foreach (Funcionario obj in Funcionarios)
                if (obj.id == p.id) x = obj;
            if (x != null) Funcionarios.Remove(x);
            Salvar();
        }
        public static void Abrir()
        {
            StreamReader f = null;
            try
            {

                XmlSerializer xml = new XmlSerializer(typeof(List<Funcionario>));

                f = new StreamReader("./Funcionarios.xml");

                Funcionarios = (List<Funcionario>)xml.Deserialize(f);
            }
            catch
            {
                Funcionarios = new List<Funcionario>();
            }

            if (f != null) f.Close();
        }
        public static void Salvar()
        {

            XmlSerializer xml = new XmlSerializer(typeof(List<Funcionario>));

            StreamWriter f = new StreamWriter("./Funcionarios.xml", false);

            xml.Serialize(f, Funcionarios);

            f.Close();
        }
        public static void Cadastrar(Funcionario a, Empresa t)
        {
            a.idSetor = t.id;
            Atualizar(a);
        }
        public static List<Funcionario> Listar(Funcionario t)
        {
            Abrir();

            List<Funcionario> diario = new List<Funcionario>();
            foreach (Funcionario obj in Funcionarios)
                if (obj.id == t.id) diario.Add(obj);
            return diario;
        }
    }
}
