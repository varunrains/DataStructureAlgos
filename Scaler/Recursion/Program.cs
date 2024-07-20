namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        Recursion.Print1toA(9);
        Recursion.SumOfDigits(46);
        Recursion2.PrintArrayRec(new List<int> { 6, -10, 0, -4, -1 });
        var ds = Recursion2.Power(71045970, 41535484, 64735492);
        //var dss = Recursion2.DeleteOneToGetMaxiumGCD(new List<int> { 12,15,24,18,30 });
        var dss = Recursion2.DeleteOneToGetMaxiumGCD(new List<int> { 3, 9, 6, 8, 3 });
        // var ds = Recursion.Foo(3, 5);
        var ds2 = Recursion2.ModularSum(new List<int> { 686, 675, 758, 659, 377, 965, 430, 220, 599, 699 } );
        Recursion2.PairSumDivisibleByM(new List<int> { 1, 2, 3, 4, 5 }, 2);
    }
}
