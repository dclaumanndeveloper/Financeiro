using Financeiro.Domain.Entities;
using Financeiro.Infra.Data;
using Financeiro.Infra.Data.Controllers;
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

namespace Financeiro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         private static FinanceiroContext financeiroContext = new FinanceiroContext();
         readonly LoginController context;
        public MainWindow()
        {
            context = new LoginController(financeiroContext);
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
           CadastroLogin cadastroLogin = new CadastroLogin();
            cadastroLogin.Show();
        }

        private void btnEntrar_Click(object sender, RoutedEventArgs e)
        {
            String usuario = txtUsuario.Text.ToString();
            String senha = psbSenha.Password;
            Login l = new Login();
            l.Usuario = usuario;
            l.Senha = senha;
             bool validacao = context.Valida(l);
            if (validacao == true)
            {

                MessageBox.Show(l.Usuario.ToString(), "Aguarde....", MessageBoxButton.OKCancel);
                TelaInicial telaInicial = new TelaInicial();
                telaInicial.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!", "Login", MessageBoxButton.OKCancel);
            }
            
        }
    }
}
