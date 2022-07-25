using ArthurYoshikawa_d3_avaliacao.Models;
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
    /// Interaction logic for UserHomePage.xaml
    /// </summary>
    public partial class UserHomePage : UserControl
    {
        private string activeUser;
        private Logger logger;

        public UserHomePage(string user)
        {
            InitializeComponent();

            activeUser = user;
            logger = new();
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Log out");
            logger.Log(activeUser, "Log out");
            this.Content = new MainPage();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Closing the application");
            Application.Current.Shutdown();
        }
    }
}
