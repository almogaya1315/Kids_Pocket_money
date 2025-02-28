﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        public ObservableCollection<ChildViewModel> Children { get; set; }
        public MainViewModel()
        {
            ChildViewModel Yiska = new ChildViewModel("Yiska", 15);
            ChildViewModel Moriya = new ChildViewModel("Moriya", 13);
            ChildViewModel Ariel = new ChildViewModel("Ariel", 11);
            ChildViewModel Yoav = new ChildViewModel("Yoav", 4);
            Children = new ObservableCollection<ChildViewModel> { Yiska,Moriya, Ariel, Yoav };
        }
    }
}
