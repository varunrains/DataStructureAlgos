// See https://aka.ms/new-console-template for more information

class Program {

    public static void Main(string[] args){
        solve(new List<int>{1,2,4}, 2);
    }
    public static int solve(List<int> A, int B) {
        var arr = A.ToArray();

        for(int i =0,j=1;i<arr.Length && j < arr.Length;i++,j++){
            if(arr[i] + arr[j] == B) return 1;
        }

        return 0;
    }
}