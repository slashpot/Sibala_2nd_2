using System.Collections.Generic;
using Sibala.Comparer;

namespace Sibala
{
    public class SibalaComparer : Comparer<SibalaGame>
    {
        public override int Compare(SibalaGame x, SibalaGame y)
        {
            if (IsSameType(x, y))
            {
                return GetComparer(x.Type).Compare(x, y);
            }

            return x.Type - y.Type;
        }

        private static IComparer<SibalaGame> GetComparer(SibalaType sibalaType)
        {
            var comparerLookup = new Dictionary<SibalaType, IComparer<SibalaGame>>
            {
                {SibalaType.NormalPoint, new NormalPointComparer()},
                {SibalaType.NoPoint, new NoPointComparer()},
                {SibalaType.OneColor, new OneColorComparer()},
            };

            return comparerLookup[sibalaType];
        }

        private static bool IsSameType(SibalaGame x, SibalaGame y)
        {
            return x.Type == y.Type;
        }
    }
}