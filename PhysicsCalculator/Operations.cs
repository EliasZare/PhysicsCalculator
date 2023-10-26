namespace PhysicsCalculator
{
    public class Operations : IOperations
    {
        public double Velocity(double displacement, double time, double velocity)
        {
            var result = new double();
            if (displacement == 0)
                result = time * velocity;
            else if (time == 0)
                result = displacement / velocity;
            else if (velocity == 0) result = displacement / time;
            return result;
        }

        public double Speed(double distance, double time, double speed)
        {
            var result = new double();
            if (distance == 0)
                result = time * speed;
            else if (time == 0)
                result = distance / speed;
            else if (speed == 0) result = distance / time;
            return result;
        }

        public double VelocityBy(double firstX, double lastX, double time, double velocity)
        {
            var result = new double();

            if (firstX == 0)
            {
                if (velocity > 0)
                {
                    result = Math.Abs(velocity) * time - lastX;
                }
                else
                {
                    result = Math.Abs(velocity) * time - lastX;
                    result = result * -1;
                }
            }
            else if (lastX == 0)
            {
                if (velocity > 0)
                {
                    result = Math.Abs(velocity) * time - firstX;
                }
                else
                {
                    result = Math.Abs(velocity) * time - firstX;
                    result = result * -1;
                }
            }
            else if (time == 0)
            {
                result = (lastX - firstX) / velocity;
            }
            else if (velocity == 0)
            {
                result = (lastX - firstX) / time;
            }

            return result;
        }
    }
}
