namespace Sibala
{
    public class NoPointResultHandler : ISibalaHandler
    {
        private SibalaGame _sibalaGame;

        public NoPointResultHandler(SibalaGame sibalaGame)
        {
            _sibalaGame = sibalaGame;
        }

        public void SetResult()
        {
            _sibalaGame.Type = SibalaType.NoPoint;
            _sibalaGame.Value = 0;
            _sibalaGame.Output = "No Point";
            _sibalaGame.MaxDice = _sibalaGame.Value;
        }
    }
}