using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public class SibalaGame
    {
        public SibalaType Type;
        public int Value;
        public string Output;
        public int MaxDice;
        public SibalaGame(List<int> dices)
        {
            var groupAmount = dices.GroupBy(x => x).Count();

            
            Calculate(dices, groupAmount);
        }

        private void Calculate(List<int> dices, int groupAmount)
        {
            if (groupAmount == 1)
            {
                Type = SibalaType.OneColor;
                Value = dices.First();
                Output = "One Color";
            } 
            else if (groupAmount > 3) 
            {
                Type = SibalaType.NoPoint;
                Value = 0;
                Output = "No Point";
            }
            else if (groupAmount == 2)
            {
                var hasThree = dices.GroupBy(x => x).Where(y => y.Count() == 3);
                var hasTwo = dices.GroupBy(x => x).Where(y => y.Count() == 2);

                if (hasThree.Any())
                {
                    Type = SibalaType.NoPoint;
                    Value = 0;
                    Output = "No Point";
                }
                else
                {
                    Type = SibalaType.NormalPoint;
                    Value = hasTwo.Select(x=>x.Key).Max()*2;
                    Output = Value + " Point";

                }
            }
            else
            {
                var theSame = dices.GroupBy(x => x).Where(y => y.Count() == 1);
                
                Type = SibalaType.NormalPoint;
                Value = theSame.Select(x=>x.Key).Sum();
                if (Value == 3)
                {
                    Output = "BG";
                }
                else
                {
                    Output = Value.ToString() + " Point";

                }
            }
        }
    }


    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }
}
