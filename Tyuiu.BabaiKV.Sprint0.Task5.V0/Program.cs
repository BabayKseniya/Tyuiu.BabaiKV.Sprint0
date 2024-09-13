using Tyuiu.BabaiKV.Sprint0.Task5.V0.Lib;
namespace Tyuiu.BabaiKV.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));
            Console.WriteLine("A / b = " + DataService.Division(9, 3));
            Console.ReadKey();
        }
    }
}
