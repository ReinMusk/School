using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ListPage.xaml
    /// </summary>
    public partial class ListPage : Page
    {
        public static ObservableCollection<Service> services { get; set; }
        public ListPage()
        {
            InitializeComponent();
            services = new ObservableCollection<Service>(bd_connection.connection.Service.ToList());

            this.DataContext = this;
        }

        private void prod_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddEditPage(new Service));

        }

        private void edit_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void del_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
