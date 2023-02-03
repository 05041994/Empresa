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
    /// Lógica interna para Cad_FuncionarioWindow.xaml
    /// </summary>
    public partial class Cad_FuncionarioWindow : Window
    {
        public Cad_FuncionarioWindow()
        {
            InitializeComponent();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listSetores.ItemsSource = null;
            listSetores.ItemsSource = NSetor.Listar();
            listFuncionarios.ItemsSource = null;
            listFuncionarios.ItemsSource = NFuncionario.Listar();
        }

        private void CadastrarClick(object sender, RoutedEventArgs e)
        {
            if (listFuncionarios.SelectedItem != null &&
               listSetores.SelectedItem != null)
            {
                Setor a = (Setor)listSetores.SelectedItem;
                Funcionario t = (Funcionario)listFuncionarios.SelectedItem;
                NFuncionario.Cadastrar(t, a);
                ListarClick(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Setor e uma Empresa");
            }
        }
    }
}
