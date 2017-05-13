using System;

namespace MathHammer8
{
    internal class RollResult : IEquatable<RollResult>
    {
        public int Value { get; }
        public RollResultDisposition Result { get; }

        public RollResult(int value)
            : this(value, RollResultDisposition.Untested)
        {
            
        }

        public RollResult(int value, RollResultDisposition result)
        {
            Value = value;
            Result = result;
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
