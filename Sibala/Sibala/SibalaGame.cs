using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public class SibalaGame
    {
        public SibalaType Type;
        public int Value;
        public string Output;
        public int MaxDice;
        public SibalaGame(List<int> dices)
        {
            Type = SibalaType.OneColor;
            Value = 6;
            Output = "One Color";
        }
    }


    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }
}
