using ArthurYoshikawa_d3_avaliacao.Repositories;
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

namespace ArthurYoshikawa_d3_avaliacao.Views
{
    /// <summary>
    /// Interaction logic for AuthencationPage.xaml
    /// </summary>
    public partial class AuthencationPage : UserControl
    {
        private UserRepository db;

        public AuthencationPage()
        {
            db = new UserRepository();
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var credentials = db.GetByEmail(EmailTextBox.Text);

            if (credentials.Password == PasswordTextBox.Text)
                this.Content = new UserHomePage();
            else
                MessageBox.Show("Incorrect password", "Password does not match");
        }
    }
}
