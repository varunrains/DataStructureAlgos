namespace BitManipulation;

class Program
{
    static void Main(string[] args)
    {
        BitManipulation1.SetAthAndBthBit(3, 5);
        BitManipulation1.ToggleIthBit(4, 1);
        BitManipulation1.CheckBit(4, 1);
        BitManipulation1.UnsetIthBit(5, 2);
        BitManipulation1.HelpFromSam(4);
        BitManipulation1.SingleNumber(new List<int>() { 1, 2, 2, 3, 1 });
        BitManipulation1.SingleNumberOutOfThree(new List<int>() { 1, 2, 4, 3, 3, 2, 2, 3, 1, 1 });
        BitManipulation1.TwoIntegersOutOfDuplicates(new List<int>() { 1, 2, 3, 1, 2, 4 });
    }
}
