using System.Collections.Generic;

namespace Sibala.Comparer
{
    public class NoPointComparer : IComparer<SibalaGame>
    {
        public int Compare(SibalaGame x, SibalaGame y)
        {
            return x.Type - y.Type;
        }
    }
}