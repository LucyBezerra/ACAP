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
using System.Windows.Shapes;

namespace ACAP
{
    /// <summary>
    /// Interaction logic for Pessoa.xaml
    /// </summary>
    public partial class Pessoa : Window
    {
        public Pessoa()
        {
            InitializeComponent();
        }

        private void BTProximo_Click(object sender, RoutedEventArgs e)
        {
            DAL dao = new DAL();
            dao.InserirPessoa(TBNome.Text, TBSobrenome.Text,TBEmail.Text, (bool)CBAssociado.IsChecked);
        }
    }
}
