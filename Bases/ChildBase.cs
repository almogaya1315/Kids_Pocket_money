using Kids_Pocket_money.Entities;
using Kids_Pocket_money.Enums;
using Kids_Pocket_money.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kids_Pocket_money
{
    public class ChildBase //: IChild
    {
        //List<Chore> chores = new List<Chore>();

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //public string UserName { get; set; }
        //public string Password { get; set; }
        public int ChildPoints { get; set; }
        public int AddedPoints { get; set; }
        public int pocketMoneySum { get; set; }
        public Score ChildScore { get; set; }
    }
}
