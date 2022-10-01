using avaliacao_d7_interface_de_usuario.Data;
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

namespace avaliacao_d7_interface_de_usuario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly DataContext dataContext;

        public MainWindow(DataContext dataContext)
        {
            this.dataContext = dataContext;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var pass = Password.Password;
            var email = Email.Text;

            var user = this.dataContext.Users.Where(u => u.Email == email && u.Password == pass).ToList();

            if (user.Count > 0)
            {
                MessageBox.Show("Usuário autenticado!");
            }
            else
            {
                MessageBox.Show("Credenciais inválidas!");
                Password.Clear();
                Email.Clear();
                return;
            }

        }
    }
}
