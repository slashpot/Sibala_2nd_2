using System.Collections.Generic;
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
        private readonly List<int> _dices;

        public SibalaGame(List<int> dices)
        {
            _dices = dices;
            Calculate();
        }

        public int MaxPoint { get; private set; }
        public string Output { get; private set; }
        public int Points { get; private set; }
        public SibalaType Type { get; private set; }
        private void Calculate()
        {
            if (IsOneColor())
            {
                Type = SibalaType.OneColor;
                Points = _dices.First();
                Output = "One Color";
                MaxPoint = Points;
            }
            else if (IsNoPoint())
            {
                Type = SibalaType.NoPoint;
                Points = 0;
                Output = "No Point";
                MaxPoint = Points;
            }
            else
            {
                if (_dices.GroupBy(x => x).Count() == 2)
                {
                    var hasTwo = _dices.GroupBy(x => x).Where(y => y.Count() == 2);

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
                else
                {
                    var theSame = _dices.GroupBy(x => x).Where(y => y.Count() == 1);

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

        private bool IsAllDifferentPoint()
        {
            return _dices.GroupBy(x => x).Count() > 3;
        }

        private bool IsNoPoint()
        {
            return IsAllDifferentPoint() || IsSamePointWithThree();
        }

        private bool IsOneColor()
        {
            return _dices.GroupBy(x => x).Count() == 1;
        }

        private bool IsSamePointWithThree()
        {
            return _dices.GroupBy(x => x).Where(y => y.Count() == 3).Any();
        }
    }
}