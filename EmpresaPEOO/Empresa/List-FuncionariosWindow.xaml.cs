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
    /// Lógica interna para List_FuncionariosWindow.xaml
    /// </summary>
    public partial class List_FuncionariosWindow : Window
    {
        public List_FuncionariosWindow()
        {
            InitializeComponent();
            listSetores.ItemsSource = NSetor.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listSetores.SelectedItem != null)
            {
                Setor t = (Setor)listSetores.SelectedItem;
                listFuncionarios.ItemsSource = null;
                listFuncionarios.ItemsSource = NFuncionario.Listar(t);
            }
            else
                MessageBox.Show("É preciso selecionar um setor");
        }
    }
}
