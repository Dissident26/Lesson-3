double cogusSurfaceArea (double generatrix, double basisRadius )
{
    const double Pi = Math.PI;
    return Pi * basisRadius * (generatrix + basisRadius);
}

double readFromConsole(string message)
{
    Console.WriteLine(message);
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

{
    const string generatrixMessage = "Введите длинну образующей конуса: ";
    const string basisRadiusMessage = "Введите радиус основания конуса: ";

    double generatrixValue = readFromConsole(generatrixMessage);
    double basisValue = readFromConsole(basisRadiusMessage);

    Console.WriteLine("Площадь поверхности конуса равна {0}", cogusSurfaceArea(generatrixValue, basisValue));

    int x = 14, y = 1, z = 5;

    const string stringTemplate = "x = {0}, y = {1}, z = {2}";

    x += y - x++ * z;
    Console.WriteLine(stringTemplate, x, y, z);
    z = --x - y * 5;
    Console.WriteLine(stringTemplate, x, y, z);
    y /= x + 5 % z;
    Console.WriteLine(stringTemplate, x, y, z);
    z = x++ + y * 5;
    Console.WriteLine(stringTemplate, x, y, z);
    x = y - x++ * z;
    Console.WriteLine(stringTemplate, x, y, z);
}

int greatestCommonDivisor (GCD getGCD, params int[] values)
{
    if (values.Length <= 2)
    {
        throw new ArgumentException("At least two arguments should be provided");
    }

    int result = getGCD(values[0], values[1]);

    for (int i = 2; i < values.Length; i++)
    {
        result = getGCD(result, values[i]);
    }

    return result;
}

int GCD(int a, int b)   //пример нод
{
    while (b != 0)
    {
        var temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

int GCDrecursive(int val1, int val2)    //пример нод 2
{
    return val2 == 0 ? val1 : GCDrecursive(val2, val1 % val2);
}

Console.WriteLine("НОД: {0}", greatestCommonDivisor(GCD, 123, 2532, 567));
Console.WriteLine("НОД: {0}", greatestCommonDivisor(GCDrecursive, 123, 2532, 567));

delegate int GCD(int val1, int val2);