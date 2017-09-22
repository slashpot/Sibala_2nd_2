namespace Sibala
{
    public class NormalPointComparer :ISibalaComparer
    {
        public int GetResult(SibalaGame x, SibalaGame y)
        {
            if (x.Point == y.Point)
            {
                return x.MaxDice - y.MaxDice;
            }
            else
            {
                return x.Point - y.Point;
            }
        }
    }
}