using System.Linq;

namespace Sibala
{
    public class NormalPointResultHandler : ISibalaHandler
    {
        private SibalaGame _sibalaGame;

        public NormalPointResultHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetResult()
        {
            if (IsTwoPair())
            {
                _sibalaGame.Point = _sibalaGame.Dices.Max() * 2;
                _sibalaGame.MaxDice = _sibalaGame.Dices.Max();
            }
            else
            {
                var differentDices = _sibalaGame.Dices.GroupBy(x => x).Where(y => y.Count() == 1);
                _sibalaGame.Point = differentDices.Select(x => x.Key).Sum();
                _sibalaGame.MaxDice = differentDices.Select(x => x.Key).Max();
            }
            _sibalaGame.Type = SibalaType.NormalPoint;
            _sibalaGame.Output = GetOutput();
        }

        private bool IsTwoPair()
        {
            return _sibalaGame.Dices.GroupBy(x => x).Count() == 2;
        }

        private string GetOutput()
        {
            if (_sibalaGame.Point == 3) return "BG";
            if (_sibalaGame.Point == 12) return "18la";
            return _sibalaGame.Point + " Point";
        }
    }
}