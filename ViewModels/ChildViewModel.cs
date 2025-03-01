using CommunityToolkit.Mvvm.ComponentModel;
using Kids_Pocket_money.Entities;
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
        private ChildEntity _entity;

        public ChildViewModel(ChildEntity entity)
        {
            _entity = entity;
        }
        public string Name
        {
            get { return _entity.Name; }
            set { _entity.Name = value; }
        }
        public int Age 
        {
            get { return _entity.Age; }
            set { _entity.Age = value; }
        }
    }
}
