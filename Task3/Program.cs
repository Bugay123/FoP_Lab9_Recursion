internal class Program
{

    /*Реалізувати рекурсивний метод обчислення добутку n
    перших членів ряду
    В методі Main ввести з консоль значення n і викликати метод.
    Результат вивести на консоль.*/

    static double Dob(double n)
    {
        if (n <= 2) return 2; //встановлюємо значення n більше двох, щоб уникнути deadloop.
        else return ((n + 1 / n) * Dob(n / (n - 1))); //виконання методу Dob за формулою
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Введіть n: ");
        double n = double.Parse(Console.ReadLine()); //Зчиттування значення з консолі та запис в змінну n
        Console.WriteLine("Результат: ");
        Console.Write(Dob(n)); //виклик методу Dob за запис результату в консоль
    }
}