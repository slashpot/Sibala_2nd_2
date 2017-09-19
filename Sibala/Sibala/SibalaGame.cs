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

        }
    }


    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }
}
