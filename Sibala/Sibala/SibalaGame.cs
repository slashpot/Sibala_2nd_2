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
        private readonly OneColorHandler _oneColorHandler;
        private readonly NoPointHandler _noPointHandler;
        private readonly NormalPointHandler _normalPointHandler;

        public SibalaGame(List<int> dices)
        {
            Dices = dices;
            _oneColorHandler = new OneColorHandler(this);
            _noPointHandler = new NoPointHandler(this);
            _normalPointHandler = new NormalPointHandler(this);
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
                _oneColorHandler.SetOneColor();
            }
            else if (IsNoPoint())
            {
                _noPointHandler.SetNoPoint();
            }
            else
            {
                _normalPointHandler.SetNormalPoint();
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
}