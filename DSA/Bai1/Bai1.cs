internal class Bai1
{
    static void MaxMinSumAvg(int a, int b, int c)
    {
        int max = a;
        int min = a;
        int sum = a + b + c;
        double avg = sum / 3.0d;

        if (b > max) max = b;
        else if (c > max) max = c;

        if (b < min) min = b;
        else if (c < min) min = c;

        Console.WriteLine($"MAX: {max}, MIN: {min}, SUM: {sum}, AVG: {avg:F2}");

    }
    
    private static void Mainn(string[] args)
    {
        Console.Write("Enter 1st integer: "); int a = int.Parse(Console.ReadLine());
        Console.Write("Enter 2nd integer: "); int b = int.Parse(Console.ReadLine());
        Console.Write("Enter 3rd integer: "); int c = int.Parse(Console.ReadLine());
        MaxMinSumAvg(a, b, c);
    }
}