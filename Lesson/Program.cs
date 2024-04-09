class Program
{
    static void Main()
    {
        Console.WriteLine("Введите 4 целых числа через пробел");
        string[] input = Console.ReadLine().Split(' ');
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);
        int w = int.Parse(input[2]);
        int b = int.Parse(input[3]);

        int result = CountArrangements(m, n, w, b);

        Console.WriteLine("Количество мирных растановок: " + result / 4);
    }

     static int CountArrangements(int m, int n, int w, int b)
    {
        int result = 0;
        for (int white = 0; white <= w; white++)
        {
            int black = w - white;
            if(white <= m && black <= n && black <= b)
            {
                int whiteArrangements = CalculateArrangements(m, n, white);
                int blackArrangements = CalculateArrangements(m - white, n, black);
                result += whiteArrangements * blackArrangements;
            } 
        }
        return result;
    }

    static int CalculateArrangements(int m, int n, int k)
    {
        return Factorial(m) / (Factorial(k) * Factorial(m - k)) * Factorial(n) / (Factorial(k) * Factorial(n - k));
    }

    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        else
        {
            return n * Factorial(n - 1);
        }
            
        
        
            
        
    }
}


