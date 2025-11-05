using System;

namespace DeveloperSample.ClassRefactoring
{
    public class SwallowFactory
    {
        public ISwallow GetSwallow(SwallowType swallowType)
        {
            return swallowType switch
            {
                SwallowType.African => new AfricanSwallow(),
                SwallowType.European => new EuropeanSwallow(),
                _ => throw new InvalidOperationException($"Unknown swallow type: {swallowType}")
            };
        }
    }

    public abstract class BaseSwallow : ISwallow
    {
        public abstract SwallowType Type { get; }
        public SwallowLoad Load { get; private set; } = SwallowLoad.None;

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public abstract double GetAirspeedVelocity();
    }

    public class AfricanSwallow : BaseSwallow
    {
        public override SwallowType Type => SwallowType.African;

        public override double GetAirspeedVelocity()
        {
            return Load switch
            {
                SwallowLoad.None => 22,
                SwallowLoad.Coconut => 18,
                _ => throw new InvalidOperationException($"Invalid load: {Load}")
            };
        }
    }

    public class EuropeanSwallow : BaseSwallow
    {
        public override SwallowType Type => SwallowType.European;

        public override double GetAirspeedVelocity()
        {
            return Load switch
            {
                SwallowLoad.None => 20,
                SwallowLoad.Coconut => 16,
                _ => throw new InvalidOperationException($"Invalid load: {Load}")
            };
        }
    }
}