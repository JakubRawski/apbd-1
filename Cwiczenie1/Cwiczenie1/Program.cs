// See https://aka.ms/new-console-template for more information
using Cwiczenie1.Classes;

public class Program {

    static void zmienne() {
        int number = 10;
        float fl = 2.4f;
        double d = 2.5;
        bool logical = false;
        char symbol = 'a';
        string text = "trololoo";
        var k = "hello";
        //var j; nie dziala
        //nullable
        //Nullable Maybe Optional
        int? nullable = null;
        nullable = 2137;
        Object? o = null;
        string tekst = "text " + number;
        string tekst2 = $"text: {number}";
        Console.WriteLine(tekst + tekst2);
        String path = "C:\\Users\\s11111\\File.txt";
        String pathButBetter = @"C:\Users\s11111\File.txt";
        char ch = 'a';
        //tablice i kolekcje
        int[] arr = new int[10];
        int[] arr2 = { 1, 2, 3, 4, 5, 6 };
        var list = new List<int>();
        list.Add(1);
        var dict = new Dictionary<int, String>();
        dict.Add(1, "xdd");
        var set = new HashSet<int>();
        set.Add(1);
        set.Add(1);

        // petle
        var lista = new List<int>() {1,2,3,4,5,6,7,8,9};
        foreach (var i in lista) { 
            Console.WriteLine(i);
        }
        for (int i = 0; i < 9; i++) { 
            Console.WriteLine(lista[i]);

        }

    }

    static int GetAvarage(int[] num) {
        int a = 0;
        for (int i = 0; i < num.Length; i++)
        {
            a += num[i];
        }
        return a/num.Length;
    }
    public static void Main(string[] args) {
        zmienne();
        /*
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Hello, World!");
        Console.WriteLine(GetAvarage(arr));
        */
        Classa1 a = new Classa1(1);
        Classa1 b = new BClass(1,2);

        a.SendMessage("XD");
        b.SendMessage("XD");
    }


    
}

