internal class Program
{
    // Реалізувати рекурсивний алгоритм обчислення (2n+1)!, де n>0.
    static double Func(int n)
    {
        if (n <= 0)
        {
            return 1; //перевіряємо, щоб n було додатнім числом та не дорівнювало 0;
        }
       
        return (2 * n + 1) * (2 * Func(n - 1) + 1); //повертаємо результат віконання методу за заданною формулою.
    }
    private static void Main(string[] args)
    {
        Console.WriteLine(Func(5)); //викликаємо метод Func та передаємо параметр 5 в неї.
    }
}