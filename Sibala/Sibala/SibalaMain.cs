using System.Collections.Generic;

namespace Sibala
{
    public class SibalaMain
    {
        public int Compare(SibalaGame inputResult1, SibalaGame inputResult2)
        {
            if (inputResult1.Type == inputResult2.Type)
            {
                if (inputResult1.Type == SibalaType.NormalPoint && inputResult1.Value == inputResult2.Value)
                {
                    return inputResult1.MaxDice - inputResult2.MaxDice;
                }

                if (inputResult1.Type == SibalaType.NormalPoint)
                {
                    return inputResult1.Value - inputResult2.Value;
                }

                if (inputResult1.Type == SibalaType.OneColor)
                {
                    List<int> diceOrder = new List<int>() { 2, 3, 5, 6, 4, 1 };
                    return diceOrder.IndexOf(inputResult1.Value) - diceOrder.IndexOf(inputResult2.Value);
                }
            }

            return inputResult1.Type - inputResult2.Type;
        }
    }
}