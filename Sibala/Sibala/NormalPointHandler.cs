using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class NormalPointHandler : ISibalaResultHandler
    {
        private SibalaGame _sibalaGame;

        public NormalPointHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetResult()
        {
            if (IsTwoPair())
            {
                _sibalaGame.Points = _sibalaGame.Dices.Max() * 2;
                _sibalaGame.MaxPoint = _sibalaGame.Dices.Max();
            }
            else
            {
                var singleDices = GetSingleDices();
                _sibalaGame.Points = singleDices.Sum();
                _sibalaGame.MaxPoint = singleDices.Max();
            }
            _sibalaGame.Output = GetOutput();
            _sibalaGame.Type = SibalaType.NormalPoint;
        }

        private string GetOutput()
        {
            if (Is18La()) return "18la";
            if (IsBG()) return "BG";
            return _sibalaGame.Points + " Point";
        }

        private bool IsBG()
        {
            return _sibalaGame.Points == 3;
        }

        private bool Is18La()
        {
            return _sibalaGame.Points == 12;
        }

        private IEnumerable<int> GetSingleDices()
        {
            return _sibalaGame.Dices.GroupBy(x => x).Where(y => y.Count() == 1).Select(x => x.Key);
        }

        private bool IsTwoPair()
        {
            return _sibalaGame.Dices.GroupBy(x => x).Count() == 2;
        }
    }
}