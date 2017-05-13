﻿using System;

namespace MathHammer8
{
    internal class RollResult : IEquatable<RollResult>
    {
        public int Value { get; }

        public RollResult(int value)
        {
            Value = value;
        }

        public bool Equals(RollResult other)
        {
            return Value == other.Value;
        }

        public override int GetHashCode()
        {
            return Value;
        }
    }
}
