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
            GetSibalaResultHandler().SetResult();
        }

        private ISibalaResultHandler GetSibalaResultHandler()
        {
            if (IsOneColor())
            {
                return new OneColorHandler(this);
            }
            else if (IsNoPoint())
            {
                return new NoPointHandler(this);
            }
            else
            {
                return new NormalPointHandler(this);
            }
        }

        private bool IsAllDifferentPoint()
        {
            var sameDiceMaxCount = Dices.GroupBy(x => x).Max(g => g.Count());
            return sameDiceMaxCount == 1;
        }

        private bool IsNoPoint()
        {
            return IsAllDifferentPoint() || IsSamePointWithThree();
        }

        private bool IsOneColor()
        {
            var sameDiceMaxCount = Dices.GroupBy(x => x).Max(g => g.Count());
            return sameDiceMaxCount == 4;
        }

        private bool IsSamePointWithThree()
        {
            var sameDiceMaxCount = Dices.GroupBy(x => x).Max(g => g.Count());
            return sameDiceMaxCount == 3;
        }
    }

    internal interface ISibalaResultHandler
    {
        void SetResult();
    }
}