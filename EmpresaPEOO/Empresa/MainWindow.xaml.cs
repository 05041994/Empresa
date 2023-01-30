using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Empresa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Empresa_Click(object sender, RoutedEventArgs e)
        {
            EmpresaWindow w = new EmpresaWindow();
            w.ShowDialog();
        }

        private void Setor_Click(object sender, RoutedEventArgs e)
        {
            SetorWindow w = new SetorWindow();
            w.ShowDialog();
        }

        private void Funcionario_Click(object sender, RoutedEventArgs e)
        {
            FuncionarioWindow w = new FuncionarioWindow();
            w.ShowDialog();
        }

        private void Cadastrarsetor_Click(object sender, RoutedEventArgs e)
        {
            Cad_SetorWindow w = new Cad_SetorWindow();
            w.ShowDialog();
        }

        private void Cadastrarfuncionario_Click(object sender, RoutedEventArgs e)
        {
            Cad_FuncionarioWindow w = new Cad_FuncionarioWindow();
            w.ShowDialog();
        }

        private void Listdesetores_Click(object sender, RoutedEventArgs e)
        {
            List_SetorWindow w = new List_SetorWindow();
            w.ShowDialog();
        }

        private void Listdefuncionarios_Click(object sender, RoutedEventArgs e)
        {
            List_FuncionariosWindow w = new List_FuncionariosWindow();
            w.ShowDialog();
        }
    }
}
