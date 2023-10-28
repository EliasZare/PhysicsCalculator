using PhysicsCalculator;

Console.WriteLine("Welcome to physics calculator");
Console.WriteLine("Operations:");
Console.WriteLine("Speed: S");
Console.WriteLine("Velocity: V");
Console.WriteLine("Velocity by FirstX and LastX: V1");
Console.WriteLine("Change in Velocity: DV");

IOperations _operations = new Operations();

while (true)
{
    Console.WriteLine();
    Console.WriteLine("--------------------");
    Console.WriteLine();
    Console.Write("Enter a operation: ");
    var operation = Console.ReadLine();

    switch (operation)
    {
        case "S":
            Console.WriteLine("--------------------");
            Console.Write("Enter ur Distance : ");
            var distance = int.Parse(Console.ReadLine());
            Console.Write("Enter ur change in time: ");
            var cit = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ur Speed: {distance / cit}");
            break;
        case "V":
            Console.WriteLine("--------------------");
            Console.Write("Enter ur Displacement | if it's passive set equal to 0: ");
            var displacement = double.Parse(Console.ReadLine());
            Console.Write("Enter ur Time | if it's passive set equal to 0: ");
            var citV = double.Parse(Console.ReadLine());
            Console.Write("Enter ur Velocity | if it's passive set equal to 0 : ");
            var velocity = double.Parse(Console.ReadLine());
            Console.WriteLine(_operations.Velocity(displacement, citV, velocity));
            break;
        case "V1":
            Console.WriteLine("--------------------");
            Console.Write("Enter ur FirstX | if it's passive set equal to 0 : ");
            var FX = double.Parse(Console.ReadLine());
            Console.Write("Enter ur LastX | if it's passive set equal to 0 : ");
            var LX = double.Parse(Console.ReadLine());
            Console.Write("Enter ur change in time | if it's passive set equal to 0 : ");
            var citV1 = double.Parse(Console.ReadLine());
            Console.Write("Enter ur velocity | if it's passive set equal to 0 :");
            var velocityby = double.Parse(Console.ReadLine());
            Console.WriteLine(_operations.VelocityBy(FX, LX, citV1, velocityby));
            break;
        case "DV":
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter ur acceleration");
            var acceleration = int.Parse(Console.ReadLine());
            Console.Write("Enter ur FirstX | if it's passive set equal to 0 : ");
            var firstX = double.Parse(Console.ReadLine());
            Console.Write("Enter ur LastX | if it's passive set equal to 0 : ");
            var lastX = double.Parse(Console.ReadLine());
            Console.Write("Enter ur FirstV | if it's passive set equal to 0 : ");
            var firstV = double.Parse(Console.ReadLine());
            Console.Write("Enter ur LastV | if it's passive set equal to 0 : ");
            var lastV = double.Parse(Console.ReadLine());

            var list = new Dictionary<string, double>();
            list.Add("acceleration", acceleration);
            list.Add("firstX", firstX);
            list.Add("lastX", lastX);
            list.Add("lastV", lastV);
            list.Add("firstV", firstV);
            var name = list.SingleOrDefault(x => x.Value == 0).Key.ToString();
            Console.WriteLine(
                $"Ur {name} :{_operations.FreeVelocity(firstV, lastV, acceleration, firstX, lastX).ToString()} ");

            break;
        default:
            Console.WriteLine("This operation is not defined!");
            break;
    }
}