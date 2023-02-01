internal class Program
{
    // Реалізувати рекурсивний алгоритм обчислення 10 чисел Фібоначчі.
    static int Fibo(int n)
    {
        if (n == 0 || n == 1) return 1; //встановлюємо значення для перших значень рекурсії, щоб уникнути deadlock.
        return Fibo(n - 1) + Fibo(n - 2);//виконуємо рекурсію для знаходження наступного числа Фібоначчі.
    }

    private static void Main(string[] args)
    {
        int num = Fibo(10); //призначаємо змінную значенням якої є виклик методу з параметром 10.
        Console.WriteLine($"Fibo = {num}");
    }
}