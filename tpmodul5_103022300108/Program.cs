// See https://aka.ms/new-console-template for more information
public class DataGeneric<T>
{
    T data;
    public DataGeneric(T data) {
        this.data = data;
    }

    public void printData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }
}
class Run
{
    static void Main()
    {
        DataGeneric<String> data = new DataGeneric<String>("103022300108");
        data.printData();
    }
}

