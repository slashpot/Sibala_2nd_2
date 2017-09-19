using System.Collections.Generic;

namespace Sibala
{
    public class OneColorComparer : IComparer<SibalaGame>
    {
        public int Compare(SibalaGame x, SibalaGame y)
        {
            List<int> diceOrder = new List<int> {2, 3, 5, 6, 4, 1};
            return diceOrder.IndexOf(x.Points) - diceOrder.IndexOf(y.Points);
        }
    }
}