using PhysicsCalculator;

Console.WriteLine("Welcome to physics calculator");
Console.WriteLine("Operations:");
Console.WriteLine("Speed: S");
Console.WriteLine("Velocity: V");
Console.WriteLine("Velocity by FirstX and LastX: V1");
Console.WriteLine("Change in Velocity: DV");

IOperations _operations = new Operations();

while (true)
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
            Console.Write("Enter ur FirstX : ");
            var FXDV = int.Parse(Console.ReadLine());
            Console.Write("Enter ur LastX : ");
            var LXDV = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ur Velocity: {2 * acceleration * (Math.Abs(LXDV) - Math.Abs(FXDV))}");
            break;
        default:
            Console.WriteLine("This operation is not defined!");
            break;
    }
}