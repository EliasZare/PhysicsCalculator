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

        public double FreeVelocity(double firstV, double lastV, double acceleration, double firstX, double lastX)
        {
            double result = 0;
            if (firstV == 0)
            {
                lastV = Math.Pow(lastV * -1, 2);
                result = lastV * 2 * acceleration * (firstX - lastX);
                result = Math.Sqrt(result);
            }

            if (lastV == 0)
            {
                firstV = Math.Pow(firstV, 2);
                result = firstV * 2 * acceleration * (firstX - lastX);
                result = Math.Sqrt(result);
            }

            if (acceleration == 0)
            {
                firstV = Math.Pow(firstV, 2);
                lastV = Math.Pow(lastV, 2);
                result = lastV * -1 + firstV + 2 * (lastX - firstX);
            }

            if (firstX == 0)
            {
                firstV = Math.Pow(firstV, 2);
                lastV = Math.Pow(lastV * -1, 2);
                result = lastV + firstV / 2 * acceleration + lastX;
            }

            if (lastX == 0)
            {
                firstV = Math.Pow(firstV, 2);
                lastV = Math.Pow(lastV * -1, 2);
                firstX = firstX * -1;
                result = lastV + firstV / 2 * acceleration + firstX;
            }
            return result;
        }
    }
}
