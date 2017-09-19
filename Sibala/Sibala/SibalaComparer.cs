using System.Collections.Generic;

namespace Sibala
{
    public class SibalaComparer : Comparer<SibalaGame>
    {
        public override int Compare(SibalaGame x, SibalaGame y)
        {
            if (IsSameType(x, y))
            {
                if (x.Type == SibalaType.NormalPoint)
                {
                    return NormalPointCompare(x, y);
                }
                else if (x.Type == SibalaType.OneColor)
                {
                    return OneColorCompare(x, y);
                }
                else
                {
                    return NoPointCompare(x, y);
                }
            }

            return x.Type - y.Type;
        }

        private static int NoPointCompare(SibalaGame x, SibalaGame y)
        {
            return x.Type - y.Type;
        }

        private static int OneColorCompare(SibalaGame x, SibalaGame y)
        {
            List<int> diceOrder = new List<int> {2, 3, 5, 6, 4, 1};
            return diceOrder.IndexOf(x.Points) - diceOrder.IndexOf(y.Points);
        }

        private static int NormalPointCompare(SibalaGame x, SibalaGame y)
        {
            if (x.Points == y.Points)
            {
                return x.MaxPoint - y.MaxPoint;
            }

            return x.Points - y.Points;
        }

        private static bool IsSameType(SibalaGame x, SibalaGame y)
        {
            return x.Type == y.Type;
        }
    }
}