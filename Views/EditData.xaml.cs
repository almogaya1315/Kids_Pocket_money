using Kids_Pocket_money.ViewModels;
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

namespace Kids_Pocket_money.Views
{
    /// <summary>
    /// Interaction logic for EditData.xaml
    /// </summary>
    public partial class EditData : UserControl
    {
        public EditData()
        {
            InitializeComponent();
        }

        private void EditChore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteChore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddChore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditKid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteKid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddKid_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            var container = (Window)(VisualTreeHelper.GetParent(this) as ContentPresenter).Parent;
            var containerContext = (ContainerViewModel)container.DataContext;

            containerContext.GoToPage(new GoTo(ePages.MainWindow));
        }
    }
}
