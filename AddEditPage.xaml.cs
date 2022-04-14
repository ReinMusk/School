using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Service service;
        public AddEditPage(Service Newservice)
        {
            InitializeComponent();


            service = Newservice;
            this.DataContext = service;
            if (service.ID != 0)
            {

            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (service.ID == 0) MainWindow.db.Service.Add(service);

            MainWindow.db.SaveChanges();
        }

        private void AddPhoto_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFile = new OpenFileDialog()
            //{
            //    Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg",


            //};
            //if (openFile.ShowDialog().GetValueOrDefault())
            //{
            //    service.ServicePhoto = File.ReadAllBytes(openFile.FileName);
            //    PhotoProductImg.Source = new BitmapImage(new Uri(openFile.FileName));
            //}
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
