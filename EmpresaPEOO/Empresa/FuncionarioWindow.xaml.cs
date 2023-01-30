using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Empresa
{
    /// <summary>
    /// Lógica interna para FuncionarioWindow.xaml
    /// </summary>
    public partial class FuncionarioWindow : Window
    {
        public FuncionarioWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Funcionario p = new Funcionario();
            p.id = int.Parse(Idtxt.Text);
            p.nome = Nometxt.Text;
            p.email = Emailtxt.Text;

            NFuncionario.Inserir(p);

            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listFuncionarios.ItemsSource = null;
            listFuncionarios.ItemsSource = NFuncionario.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {
            Funcionario p = new Funcionario();
            p.id = int.Parse(Idtxt.Text);
            p.nome = Nometxt.Text;
            p.email = Emailtxt.Text;

            NFuncionario.Atualizar(p);

            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Funcionario p = new Funcionario();
            p.id = int.Parse(Idtxt.Text);

            NFuncionario.Excluir(p);

            ListarClick(sender, e);
        }

        private void listFuncionarios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listFuncionarios.SelectedItem != null)
            {
                Funcionario obj = (Funcionario)listFuncionarios.SelectedItem;

                Idtxt.Text = obj.id.ToString();
                Nometxt.Text = obj.nome;
                Emailtxt.Text = obj.email;
            }
        }
    }
}
