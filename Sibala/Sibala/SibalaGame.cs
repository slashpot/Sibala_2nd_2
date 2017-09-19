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
        public SibalaGame(List<int> dices)
        {
            Dices = dices;
            Calculate();
        }

        public int MaxPoint { get; set; }
        public string Output { get; set; }
        public int Points { get; set; }
        public SibalaType Type { get; set; }

        public List<int> Dices { get; }

        private void Calculate()
        {
            if (IsOneColor())
            {
                ISibalaResultHandler handler = new OneColorHandler(this);
                handler.SetResult();
            }
            else if (IsNoPoint())
            {
                ISibalaResultHandler handler = new NoPointHandler(this);
                handler.SetResult();
            }
            else
            {
                ISibalaResultHandler handler = new NormalPointHandler(this);
                handler.SetResult();
            }
        }

        private bool IsAllDifferentPoint()
        {
            return Dices.GroupBy(x => x).Count() == 4;
        }

        private bool IsNoPoint()
        {
            return IsAllDifferentPoint() || IsSamePointWithThree();
        }

        private bool IsOneColor()
        {
            return Dices.GroupBy(x => x).Count() == 1;
        }

        private bool IsSamePointWithThree()
        {
            return Dices.GroupBy(x => x).Where(y => y.Count() == 3).Any();
        }
    }

    internal interface ISibalaResultHandler
    {
        void SetResult();
    }
}