using System.Collections.Generic;
using System.Linq;
using Sibala.ResultHandler;

namespace Sibala
{
    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }

    internal interface ISibalaResultHandler
    {
        void SetResult();
    }

    public class SibalaGame
    {
        public SibalaGame(List<int> dices)
        {
            Dices = dices;
            Calculate();
        }

        public List<int> Dices { get; }
        public int MaxPoint { get; set; }
        public string Output { get; set; }
        public int Points { get; set; }
        public SibalaType Type { get; set; }

        private void Calculate()
        {
            GetSibalaResultHandler().SetResult();
        }

        private ISibalaResultHandler GetSibalaResultHandler()
        {
            var sameDiceMaxCount = Dices.GroupBy(x => x).Max(g => g.Count());
            Dictionary<int, ISibalaResultHandler> handlerLookup = new Dictionary<int, ISibalaResultHandler>
            {
                {4,  new OneColorHandler(this)},
                {1,  new NoPointHandler(this)},
                {3,  new NoPointHandler(this)},
                {2,  new NormalPointHandler(this)},
            };

            return handlerLookup[sameDiceMaxCount];
        }
    }
}