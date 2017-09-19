using System.Collections.Generic;

namespace Sibala
{
    public class NoPointComparer : IComparer<SibalaGame>
    {
        public int Compare(SibalaGame x, SibalaGame y)
        {
            return x.Type - y.Type;
        }
    }
}