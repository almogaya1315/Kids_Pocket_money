using CommunityToolkit.Mvvm.ComponentModel;
using Kids_Pocket_money.ViewModels;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kids_Pocket_money
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Container : Window
    {

        public Container()
        {

            

            //create child instance,run a certain function and return data into a variable
            try
            {

                // DataContext = new MainViewModel ();
                //ContainerContent = new MainViewModel();
                InitializeComponent();

                DataContext = new ContainerViewModel();

                //Children.Add(Yiska);
                //Children.Add(Moriya);
                //Children.Add(Ariel); 
                //Children.Add(Yoav);

                //var CurrentUser = Moriya;
                //var UserInfo = CurrentUser.getChildInfo();
                //CurrentUser.AddedPoints = ChoresHandling.ChoresList[2].Points;
                //CurrentUser.AddedPoints += ChoresHandling.ChoresList[3].Points;
                //CurrentUser.AddedPoints += ChoresHandling.ChoresList[6].Points;
                //CurrentUser.updateChildPoints();
                //CurrentUser.calculatePocketMoney(Moriya.determineChildScore());
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                var Error = ex.Message;
            }



        }

        //private ObservableObject _containerContent;
        //public ObservableObject ContainerContent
        //{
        //    get { return _containerContent; }
        //    set
        //    {
        //        _containerContent = value;
        //        // RaisePropertyChanged(_containerContent, value);
        //    }

        //}
    }
}