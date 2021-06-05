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
using System.Windows.Shapes;

namespace Financeiro
{
    /// <summary>
    /// Lógica interna para CadastroLogin.xaml
    /// </summary>
    public partial class CadastroLogin : Window
    {
        private static FinanceiroContext financeiroContext = new FinanceiroContext();
        readonly LoginController context;
        public CadastroLogin()
        {
            context = new LoginController(financeiroContext);
            InitializeComponent();
        }

        private void btnGravarLogin_Click(object sender, RoutedEventArgs e)
        {
            
            Login login = new Login();
            login.Usuario = txtUsuarioCadastro.Text.ToString();
            login.Senha = psbSenhaCadastro.ToString();
            Login l = context.Add(login);
            MessageBox.Show("Usuário cadastrado com sucesso!", "Cadastro de Usuário", MessageBoxButton.OK);
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
        }
    }
}
