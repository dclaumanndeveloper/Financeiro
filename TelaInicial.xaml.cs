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

namespace Financeiro
{
    /// <summary>
    /// Lógica interna para TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            MainWindow mainWindows = new MainWindow();
            mainWindows.Close();
            InitializeComponent();
        }

        private void ToolTip_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Lancar lancar = new Lancar();
            lancar.Show();
        }
    }
}
