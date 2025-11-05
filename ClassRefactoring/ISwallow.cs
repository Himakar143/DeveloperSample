namespace DeveloperSample.ClassRefactoring
{
    public interface ISwallow
    {
        SwallowType Type { get; }
        SwallowLoad Load { get; }
        void ApplyLoad(SwallowLoad load);
        double GetAirspeedVelocity();
    }
}
