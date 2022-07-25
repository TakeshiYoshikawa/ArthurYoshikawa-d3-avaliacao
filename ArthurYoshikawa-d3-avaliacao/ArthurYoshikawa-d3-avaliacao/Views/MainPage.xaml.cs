using ArthurYoshikawa_d3_avaliacao.Models;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void AccessButton_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new AuthencationPage();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Closing the application");
            Application.Current.Shutdown();
        }


        private void LogDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            AccessInfo accessInfo = new();
            string[] accessInfos;

            DataTable dataTable = new();
            dataTable.Columns.Add("Id", typeof(string));
            dataTable.Columns.Add("Access Time", typeof(string));
            dataTable.Columns.Add("Access Date", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));

            using (StreamReader sr = new(new Logger().filePath))
            {
                while (!sr.EndOfStream)
                {
                    accessInfos = sr.ReadLine().Split(";");

                    accessInfo.LogId = accessInfos[0];
                    accessInfo.AccessTime = accessInfos[1];
                    accessInfo.AccessDate = accessInfos[2];
                    accessInfo.Status = accessInfos[3];

                    dataTable.Rows.Add(accessInfos);
                }
                DataView dataView = new(dataTable);
                LogDataGrid.ItemsSource = dataView;
            }
        }
    }
}
