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
            Calculate(dices);
        }

        public int MaxPoint { get; private set; }
        public string Output { get; private set; }
        public SibalaType Type { get; private set; }
        public int Points { get; private set; }

        private void Calculate(List<int> dices)
        {
            int groupAmount = dices.GroupBy(x => x).Count();
            if (groupAmount == 1)
            {
                Type = SibalaType.OneColor;
                Points = dices.First();
                Output = "One Color";
                MaxPoint = Points;
            }
            else if (groupAmount > 3)
            {
                Type = SibalaType.NoPoint;
                Points = 0;
                Output = "No Point";
                MaxPoint = Points;
            }
            else if (groupAmount == 2)
            {
                var hasThree = dices.GroupBy(x => x).Where(y => y.Count() == 3);
                var hasTwo = dices.GroupBy(x => x).Where(y => y.Count() == 2);

                if (hasThree.Any())
                {
                    Type = SibalaType.NoPoint;
                    Points = 0;
                    Output = "No Point";
                }
                else
                {
                    Type = SibalaType.NormalPoint;
                    Points = hasTwo.Select(x => x.Key).Max() * 2;
                    if (Points == 12)
                    {
                        Output = "18la";
                    }
                    else
                    {
                        Output = Points + " Point";
                    }
                    MaxPoint = hasTwo.Select(x => x.Key).Max();
                }
            }
            else
            {
                var theSame = dices.GroupBy(x => x).Where(y => y.Count() == 1);

                Type = SibalaType.NormalPoint;
                Points = theSame.Select(x => x.Key).Sum();
                if (Points == 3)
                {
                    Output = "BG";
                }
                else
                {
                    Output = Points.ToString() + " Point";
                }
                MaxPoint = theSame.Select(x => x.Key).Max();
            }
        }
    }
}