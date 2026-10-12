internal partial class Program
{
    static void TwoMaxValue(int[] arr, int n)
    {
        if (n < 2)
        {
            Console.WriteLine("NO"); return;
        }

        int temp;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1]) { temp = arr[j]; arr[j] = arr[j + 1]; arr[j + 1] = temp; }
            }
        }
        int max1 = arr[n - 1];
        int? max2 = null;
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] < max1)
            {
                max2 = arr[i];
                break;
            }
        }
        if (max2.HasValue) Console.WriteLine($"{max1}, {max2}");
        else Console.WriteLine("NO");
    }
    private static void Main(string[] args)
    {
        Console.Write("Enter n (integer): "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: "); arr[i] = int.Parse(Console.ReadLine());
        }
        TwoMaxValue(arr, n);
    }
}