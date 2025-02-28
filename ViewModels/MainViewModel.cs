using CommunityToolkit.Mvvm.ComponentModel;
using Kids_Pocket_money.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        public ObservableCollection<ChildViewModel> Children { get; set; }
        public ObservableCollection<ChoreViewModel> Chores { get; set; }
        public MainViewModel()
        {
            ChildViewModel Yiska = new ChildViewModel("Yiska", 15);
            ChildViewModel Moriya = new ChildViewModel("Moriya", 13);
            ChildViewModel Ariel = new ChildViewModel("Ariel", 11);
            ChildViewModel Yoav = new ChildViewModel("Yoav", 4);
            Children = new ObservableCollection<ChildViewModel> { Yiska, Moriya, Ariel, Yoav };

            var context = new ChoresContext();
            Chores = new ObservableCollection<ChoreViewModel>();
            foreach (var chore in context.ChoresList)
            { 
                var newChore = new ChoreViewModel(chore);
                Chores.Add(newChore);
            }
        }
    }
}
