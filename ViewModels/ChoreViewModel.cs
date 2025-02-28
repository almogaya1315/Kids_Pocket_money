using CommunityToolkit.Mvvm.ComponentModel;
using Kids_Pocket_money.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.ViewModels
{
    public class ChoreViewModel : ObservableObject
    {
        private ChoreEntity _entity;

        public ChoreViewModel(ChoreEntity entity)
        {
            _entity = entity;
        }

        public int Id
        {
            get 
            {
                return _entity.Id;
            }
            set 
            {

                _entity.Id = value;
            }
        } 
        public string Name 
        {
            get
            {
                return _entity.Name;
            }
            set
            {
                _entity.Name = value;
            }
        }
        public int Points
        {
            get
            {
                return _entity.Points;
            }
            set
            {
                _entity.Points = value;
            }
        }
        public bool IsCompleted
        {
            get
            {
                return _entity.IsCompleted;
            }
            set
            {
                _entity.IsCompleted = value;
            }
        }
    }
}
