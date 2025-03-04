// See https://aka.ms/new-console-template for more information
public class Program {



    static int GetAvarage(int[] num) {
        int a = 0;
        for (int i = 0; i < num.Length; i++)
        {
            a += num[i];
        }
        return a/num.Length;
    }
    public static void Main(string[] args) {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Hello, World!");
        Console.WriteLine(GetAvarage(arr));
    }


    
}

