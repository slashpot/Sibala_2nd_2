﻿using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }

    public class SibalaGame
    {
        public SibalaGame(List<int> dices)
        {
            var groupAmount = dices.GroupBy(x => x).Count();

            Calculate(dices, groupAmount);
        }

        public int MaxDice { get; private set; }
        public string Output { get; private set; }
        public SibalaType Type { get; private set; }
        public int Value { get; private set; }

        private void Calculate(List<int> dices, int groupAmount)
        {
            if (groupAmount == 1)
            {
                Type = SibalaType.OneColor;
                Value = dices.First();
                Output = "One Color";
                MaxDice = Value;
            }
            else if (groupAmount > 3)
            {
                Type = SibalaType.NoPoint;
                Value = 0;
                Output = "No Point";
                MaxDice = Value;
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
                    Value = hasTwo.Select(x => x.Key).Max() * 2;
                    if (Value == 12)
                    {
                        Output = "18la";
                    }
                    else
                    {
                        Output = Value + " Point";
                    }
                    MaxDice = hasTwo.Select(x => x.Key).Max();
                }
            }
            else
            {
                var theSame = dices.GroupBy(x => x).Where(y => y.Count() == 1);

                Type = SibalaType.NormalPoint;
                Value = theSame.Select(x => x.Key).Sum();
                if (Value == 3)
                {
                    Output = "BG";
                }
                else
                {
                    Output = Value.ToString() + " Point";
                }
                MaxDice = theSame.Select(x => x.Key).Max();
            }
        }
    }
}