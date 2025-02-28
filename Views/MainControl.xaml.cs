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
using System.Windows.Shapes;

namespace Kids_Pocket_money.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        public MainControl()
        {
            InitializeComponent();
        }

        private void AssignChore_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditData_Click(object sender, RoutedEventArgs e)
        {
            var container = (Window)VisualTreeHelper.GetParent(this);
            var containerContext = (ContainerViewModel)container.DataContext;

            containerContext.GoToPage(new GoTo(ePages.EditData));
        }

        private void ChoresTracking_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
