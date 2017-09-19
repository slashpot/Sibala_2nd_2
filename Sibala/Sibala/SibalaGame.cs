﻿using System.Collections.Generic;
using System.Linq;

namespace Sibala
{
    public enum SibalaType
    {
        OneColor = 2,
        NormalPoint = 1,
        NoPoint = 0
    }

    public class SibalaGame
    {
        private readonly List<int> _dices;

        public SibalaGame(List<int> dices)
        {
            _dices = dices;
            Calculate();
        }

        public int MaxPoint { get; private set; }
        public string Output { get; private set; }
        public int Points { get; private set; }
        public SibalaType Type { get; private set; }

        private void Calculate()
        {
            if (IsOneColor())
            {
                Type = SibalaType.OneColor;
                Points = _dices.First();
                Output = "One Color";
                MaxPoint = Points;
            }
            else if (IsNoPoint())
            {
                Type = SibalaType.NoPoint;
                Points = 0;
                Output = "No Point";
                MaxPoint = Points;
            }
            else
            {
                if (IsTwoPair())
                {
                    Points = _dices.Max() * 2;
                    MaxPoint = _dices.Max();
                }
                else
                {
                    var singleDices = GetSingleDices();
                    Points = singleDices.Sum();
                    MaxPoint = singleDices.Max();
                }
                Output = GetOutput();
                Type = SibalaType.NormalPoint;
            }
        }

        private string GetOutput()
        {
            if (Is18La()) return "18la";
            if (IsBG()) return "BG";
            return Points + " Point";
        }

        private bool IsBG()
        {
            return Points == 3;
        }

        private bool Is18La()
        {
            return Points == 12;
        }

        private IEnumerable<int> GetSingleDices()
        {
            var singleDices = _dices.GroupBy(x => x).Where(y => y.Count() == 1).Select(x => x.Key);
            return singleDices;
        }

        private bool IsTwoPair()
        {
            return _dices.GroupBy(x => x).Count() == 2;
        }

        private bool IsAllDifferentPoint()
        {
            return _dices.GroupBy(x => x).Count() == 4;
        }

        private bool IsNoPoint()
        {
            return IsAllDifferentPoint() || IsSamePointWithThree();
        }

        private bool IsOneColor()
        {
            return _dices.GroupBy(x => x).Count() == 1;
        }

        private bool IsSamePointWithThree()
        {
            return _dices.GroupBy(x => x).Where(y => y.Count() == 3).Any();
        }
    }
}