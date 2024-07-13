namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        Recursion.Print1toA(9);
        Recursion.SumOfDigits(46);
        Recursion2.PrintArrayRec(new List<int> { 6, -10, 0, -4, -1 });
        var ds = Recursion2.Power(71045970, 41535484, 64735492);
       // var ds = Recursion.Foo(3, 5);
    }
}
