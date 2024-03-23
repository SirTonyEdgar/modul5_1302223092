public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T x, T y, T z)
    {
        T store;
        store = (x + y + z);
    }
}

class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        int x, y, z;
        x = 13;
        y = 2;
        z = 22;

        Console.WriteLine(penjumlahan.JumlahTigaAngka(x, y, z));
    }
}