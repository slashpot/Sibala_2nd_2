using System.Collections.Generic;

namespace Sibala.Comparer
{
    public class NormalPointComparer : IComparer<SibalaGame>
    {
        public int Compare(SibalaGame x, SibalaGame y)
        {
            if (x.Points == y.Points)
            {
                return x.MaxPoint - y.MaxPoint;
            }

            return x.Points - y.Points;
        }
    }
}