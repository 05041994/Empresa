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
    /// Lógica interna para EmpresaWindow.xaml
    /// </summary>
    public partial class EmpresaWindow : Window
    {
        public EmpresaWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            VEmpresa p = new VEmpresa();
            p.id = int.Parse(Idtxt.Text);
            p.nome = Nometxt.Text;
            p.segmento = Segmentotxt.Text;

            NEmpresa.Inserir(p);

            ListarClick(sender, e);

        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listEmpresa.ItemsSource = null;
            listEmpresa.ItemsSource = NEmpresa.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {

            VEmpresa p = new VEmpresa();
            p.id = int.Parse(Idtxt.Text);
            p.nome = Nometxt.Text;
            p.segmento = Segmentotxt.Text;

            NEmpresa.Atualizar(p);

            ListarClick(sender, e);

        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            VEmpresa p = new VEmpresa();
            p.id = int.Parse(Idtxt.Text);

            NEmpresa.Excluir(p);

            ListarClick(sender, e);
        }

        private void listEmpresa_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listEmpresa.SelectedItem != null)
            {
                VEmpresa obj = (VEmpresa)listEmpresa.SelectedItem;

                Idtxt.Text = obj.id.ToString();
                Nometxt.Text = obj.nome;
                Segmentotxt.Text = obj.segmento;
            }
        }
    }
}
