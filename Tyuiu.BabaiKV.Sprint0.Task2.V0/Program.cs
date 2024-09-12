using Tyuiu.BabaiKV.Sprint0.Task2.V0.Lib;
namespace Tyuiu.BabaiKV.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Ксения"));
            Console.ReadKey();
        }
    }
}
