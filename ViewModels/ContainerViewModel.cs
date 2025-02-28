using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Kids_Pocket_money.ViewModels
{
    public class ContainerViewModel : ObservableObject
    {
        private ObservableObject _containerContent;
        public ObservableObject ContainerContent
        {
            get { return _containerContent; }
            set
            {
                _containerContent = value;
                OnPropertyChanged();
            }
        }

        public ContainerViewModel()
        {
            GoToPage(new GoTo(ePages.MainWindow));
        }

        public void GoToPage(GoTo to)
        {
            switch (to.Page)
            {
                case ePages.MainWindow:
                    ContainerContent = new MainViewModel();
                    break;
                case ePages.EditData:
                    var mainVM = (MainViewModel)ContainerContent;
                    ContainerContent = new EditViewModel(mainVM.Children, mainVM.Chores);
                    break;
            }
        }
    }

    public class GoTo
    {
        public ePages Page { get; set; }

        public GoTo(ePages page)
        {
            Page = page;
        }
    }

    public enum ePages
    {
        MainWindow,
        EditData,
        ChoresTracking
    }
}
