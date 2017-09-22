using System.Collections.Generic;

namespace Sibala
{
    public class SibalaComparer
    {
        public int Compare(SibalaGame x, SibalaGame y)
        {
            if (IsSameType(x, y))
            {
                var comparerDictionary = new Dictionary<SibalaType, ISibalaComparer>()
                {
                    {SibalaType.NormalPoint, new NormalPointComparer() },
                    {SibalaType.OneColor, new OneColorComparer() },
                    {SibalaType.NoPoint, new NoPointComparer() }
                };
                return comparerDictionary[x.Type].GetResult(x, y);
            }
            else
            {
                return x.Type - y.Type;
            }
            return x.Type - y.Type;
        }

        private bool IsSameType(SibalaGame inputResult1, SibalaGame inputResult2)
        {
            return inputResult1.Type == inputResult2.Type;
        }
    }

    public interface ISibalaComparer
    {
        int GetResult(SibalaGame x, SibalaGame y);
    }
}