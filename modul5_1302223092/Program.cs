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

        SimpleDataBase<string > data = new SimpleDataBase<string>();
        data.addNewData("13");
        data.addNewData("22");
        data.addNewData("23");
        data.printAllData();
    }
}

class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + " yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}