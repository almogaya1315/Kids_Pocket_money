using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.ViewModels
{
    public class EditViewModel : ObservableObject
    {
        public ObservableCollection<ChildViewModel> Children { get; set; }
        public ObservableCollection<ChoreViewModel> Chores { get; set; }

        public EditViewModel(ObservableCollection<ChildViewModel> children, ObservableCollection<ChoreViewModel> chores)
        {
            Children = children;
            Chores = chores;
        }
    }
}
