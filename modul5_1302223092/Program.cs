public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T x, T y, T z) where T : TAdditionOperators<T,T,T>
    {
        return = (x + y + z);
    }

    {
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        int x, y, z;
        x = 13;
        y = 2;
        z = 22;

        Console.WriteLine(JumlahTigaAngka<int>(x, y, z));
    }
}