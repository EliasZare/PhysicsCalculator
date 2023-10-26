namespace PhysicsCalculator
{
    public interface IOperations
    {
        double Velocity(double displacement, double time, double velocity);
        double Speed(double distance, double time, double speed);
        double VelocityBy(double firstX, double lastX, double time, double velocity);
    }
}
