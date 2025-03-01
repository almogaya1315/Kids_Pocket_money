using Kids_Pocket_money.Enums;
using Kids_Pocket_money.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_Pocket_money.Models
{
    public class ChildEntity : ChildBase, IChild
    {
        public ChildEntity(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public string getChildInfo()
        {
            return "Name: " + Name + "\n Age: " + Age;
        }
        public void ResetChildPoints()
        {
            ChildPoints = 0;
        }
        public int calculatePocketMoney(Score childScore)
        {
            if (childScore == Score.Low)
            {
                pocketMoneySum = 0;
                return pocketMoneySum;
            }
            else if (childScore == Score.Medium)
            {
                pocketMoneySum = 10;
                return pocketMoneySum;
            }
            else if (childScore == Score.High)
            {
                pocketMoneySum = 15;
                return pocketMoneySum;
            }
            else
            {
                pocketMoneySum = 20;
                return pocketMoneySum;
            }
        }
        public int updateChildPoints()
        {
            ChildPoints += AddedPoints;
            AddedPoints = 0;
            return ChildPoints;
        }
        public Score determineChildScore()
        {
            if (ChildPoints < 10)
            {
                ChildScore = Score.Low;
                return ChildScore;
            }
            else if (ChildPoints >= 10 && ChildPoints < 20)
            {
                ChildScore = Score.Medium;
                return ChildScore;
            }
            else if (ChildPoints >= 20 && ChildPoints < 30)
            {
                ChildScore = Score.High;
                return ChildScore;
            }
            else
            {
                ChildScore = Score.Extraordinary;
                return ChildScore;
            }
        }
    }
}
