using System.Numerics;

class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T x, T y, T z) where T : IAdditionOperators<T, T, T>
    {
        return x + y + z;
    }

    static void Main(String[] args)
    {
        Console.WriteLine(JumlahTigaAngka<int>(13, 22, 23));
    }
}