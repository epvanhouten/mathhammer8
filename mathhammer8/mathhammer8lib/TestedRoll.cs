using System.Collections.Generic;

namespace MathHammer8
{
    internal class TestedRoll : IRoll
    {
        public int TargetValue { get; }
        public int Modifier { get; }

        public IEnumerable<RollResult> Results { get; }

        public TestedRoll(int targetValue, int modifier, IRoll roll)
        {
            TargetValue = targetValue;
            Modifier = modifier;
        }

        private IEnumerable<RollResult> TestRoll(IRoll rolls)
        {
            foreach(var roll in rolls.Results)
            {
                RollResultDisposition result = roll.Value + Modifier >= TargetValue ? RollResultDisposition.Pass : RollResultDisposition.Fail;
                yield return new RollResult(roll.Value, result);
            }
        }
    }
}
