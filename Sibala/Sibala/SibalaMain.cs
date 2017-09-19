using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sibala
{
    public class SibalaMain
    {
        public int Compare(SibalaGame inputResult1, SibalaGame inputResult2)
        {
            if (inputResult1.Type == inputResult2.Type)
            {
                if (inputResult1.Type == SibalaType.NormalPoint && inputResult1.Points == inputResult2.Points)
                {
                    return inputResult1.MaxPoint - inputResult2.MaxPoint;
                }

                if (inputResult1.Type == SibalaType.NormalPoint)
                {
                    return inputResult1.Points - inputResult2.Points;
                }

                if (inputResult1.Type == SibalaType.OneColor)
                {
                    List<int> diceOrder = new List<int>() { 2, 3, 5, 6, 4, 1 };
                    return diceOrder.IndexOf(inputResult1.Points) - diceOrder.IndexOf(inputResult2.Points);
                }
            }
            
            return inputResult1.Type - inputResult2.Type;

        }
    }
}
