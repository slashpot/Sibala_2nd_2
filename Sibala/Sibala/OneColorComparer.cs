using System.Collections.Generic;

namespace Sibala
{
    public class OneColorComparer : ISibalaComparer
    {
        public int GetResult(SibalaGame x, SibalaGame y)
        {
            List<int> diceOrder = new List<int>() { 2, 3, 5, 6, 4, 1 };
            return diceOrder.IndexOf(x.Point) - diceOrder.IndexOf(y.Point);
        }
    }
}