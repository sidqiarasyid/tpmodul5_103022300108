// See https://aka.ms/new-console-template for more information
class HaloGeneric
{
    public static void Main()
    {
        SapaUser("Sidqi Athallah Ar");
    }
    public static void SapaUser<T>(T user)
    {
        Console.WriteLine("Halo User" + user);
    }
}