using System.Configuration;
using System.Data;
using System.Windows;

namespace Kids_Pocket_money
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Thread.Sleep(2000);
            base.OnStartup(e);
        }
    }
}
