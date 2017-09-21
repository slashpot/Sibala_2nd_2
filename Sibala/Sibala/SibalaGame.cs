using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public class SibalaGame
    {
        public SibalaType Type;
        public int Value;
        public string Output;
        public int MaxDice;

        public List<int> Dices { get; }

        public SibalaGame(List<int> dices)
        {
            Dices = dices;
            Calculate();
        }

        private void Calculate()
        {
            var isSameDiceMax = Dices.GroupBy(x => x).Max(x => x.Count());
            var handlerDictionray = new Dictionary<int, ISibalaHandler>()
            {
                {1, new NoPointResultHandler(this)},
                {2, new NormalPointResultHandler(this) },
                {3, new NoPointResultHandler(this) },
                {4, new SameColorHandler(this) }
            };
            handlerDictionray[isSameDiceMax].SetResult();
        }
    }

    public interface ISibalaHandler
    {
        void SetResult();
    }

    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }
}