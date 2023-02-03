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
using System.Linq;

namespace Empresa
{
    /// <summary>
    /// Lógica interna para List_SetorWindow.xaml
    /// </summary>
    public partial class List_SetorWindow : Window
    {
        public List_SetorWindow()
        {
            InitializeComponent();
            listEmpresas.ItemsSource = NEmpresa.Listar();
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            if (listEmpresas.SelectedItem != null)
            {
                VEmpresa t = (VEmpresa)listEmpresas.SelectedItem;
                listSetores.ItemsSource = null;
                listSetores.ItemsSource = NSetor.Listar(t);
            }
            else
                MessageBox.Show("É preciso selecionar uma turma");
        }
    }
}
