using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public class SibalaGame
    {

        public SibalaGame(List<int> dices)
        {
            
        }

        public SibalaResult GetResult()
        {
            return null;
        }
    }

    public class SibalaResult
    {
        public SibalaType type;
        public int value;
    }

    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }
}
