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
    /// Lógica interna para Cad_SetorWindow.xaml
    /// </summary>
    public partial class Cad_SetorWindow : Window
    {
        public Cad_SetorWindow()
        {
            InitializeComponent();
        }

        private void Listar_Click(object sender, RoutedEventArgs e)
        {
            listEmpresas.ItemsSource = null;
            listEmpresas.ItemsSource = NEmpresa.Listar();
            listSetores.ItemsSource = null;
            listSetores.ItemsSource = NSetor.Listar();
        }

        private void Cadastrar_Click(object sender, RoutedEventArgs e)
        {
            if (listEmpresas.SelectedItem != null &&
               listSetores.SelectedItem != null)
            {
                Setor a = (Setor)listSetores.SelectedItem;
                VEmpresa t = (VEmpresa)listEmpresas.SelectedItem;
                NSetor.Cadastrar(a, t);
                Listar_Click(sender, e);
            }
            else
            {
                MessageBox.Show("É preciso selecionar um Setor e um funcionario");
            }
        }
    }
}
