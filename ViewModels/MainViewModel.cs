using CommunityToolkit.Mvvm.ComponentModel;
using Kids_Pocket_money.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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
            var context = new ChoresContext();

            Children = new ObservableCollection<ChildViewModel>();
            foreach (var child in context.Children)
            {
                var newChild = new ChildViewModel(child);
                Children.Add(newChild);
            }

            Chores = new ObservableCollection<ChoreViewModel>();
            foreach (var chore in context.Chores)
            { 
                var newChore = new ChoreViewModel(chore);
                Chores.Add(newChore);
            }
        }
    }
}
