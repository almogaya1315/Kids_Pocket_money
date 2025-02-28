using CommunityToolkit.Mvvm.ComponentModel;
using Kids_Pocket_money.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.ViewModels
{
    public class ChildViewModel : ObservableObject
    {
        public ChildViewModel(string name, int age)
        {
            _childModel = new Child(name, age);
        }
        private Child _childModel;
        public string Name
        {
            get { return _childModel.Name; }
            set { _childModel.Name = value; }
        }
        public int Age 
        {
            get { return _childModel.Age; }
            set { _childModel.Age = value; }
        }
    }
}
