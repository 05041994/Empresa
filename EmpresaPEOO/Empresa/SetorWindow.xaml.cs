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
    /// Lógica interna para SetorWindow.xaml
    /// </summary>
    public partial class SetorWindow : Window
    {
        public SetorWindow()
        {
            InitializeComponent();
        }

        private void InserirClick(object sender, RoutedEventArgs e)
        {
            Setor p = new Setor();
            p.id = int.Parse(Idtxt.Text);
            p.nome = Nometxt.Text;
            p.atuação = Atuacaotxt.Text;

            NSetor.Inserir(p);

            ListarClick(sender, e);
        }

        private void ListarClick(object sender, RoutedEventArgs e)
        {
            listSetores.ItemsSource = null;
            listSetores.ItemsSource = NSetor.Listar();
        }

        private void AtualizarClick(object sender, RoutedEventArgs e)
        {

            Setor p = new Setor();
            p.id = int.Parse(Idtxt.Text);
            p.nome = Nometxt.Text;
            p.atuação = Atuacaotxt.Text;

            NSetor.Atualizar(p);

            ListarClick(sender, e);
        }

        private void ExcluirClick(object sender, RoutedEventArgs e)
        {
            Setor p = new Setor();
            p.id = int.Parse(Idtxt.Text);

            NSetor.Excluir(p);

            ListarClick(sender, e);
        }

        private void listSetores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listSetores.SelectedItem != null)
            {
                Setor obj = (Setor)listSetores.SelectedItem;

                Idtxt.Text = obj.id.ToString();
                Nometxt.Text = obj.nome;
                Atuacaotxt.Text = obj.atuação;
            }
        }
    }
}
