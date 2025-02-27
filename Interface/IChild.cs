using Kids_Pocket_money.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.Interface
{
    interface IChild
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int ChildPoints { get; set; }
        public Score ChildScore { get; set; }
        public int pocketMoneySum { get; set; }
        public string getChildInfo();
        public int updateChildPoints();
        public Score determineChildScore();
        public int calculatePocketMoney(Score childScore);
    }
}
