// See https://aka.ms/new-console-template for more information

static void task1()
{
    Console.WriteLine("Програма яка обчислює відстань між точками з координатами A(x1), B(y1), C(x2), D(y2)");
    Console.WriteLine("Задайте координати A(x1), B(y1), C(x2), D(y2) : ");
    double[] arr = new double[4];
    for (int i = 0; i < arr.Length; ++i)
    {
        arr[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Відстань між двома точками:" + Math.Sqrt(Math.Pow(arr[2] - arr[0], 2) + Math.Pow(arr[3] - arr[1], 2)));
}
static void task2()
{
    Console.WriteLine("Програма яка визначає чи число парне");
    Console.WriteLine("Введіть число:");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number % 2 != 0) Console.WriteLine(number + " - непарне");
    else Console.WriteLine(number + " - парне");
}
static void task3()
{
    double radius1 = 5;
    double radius2 = 10;
    Console.WriteLine("Програма яка визначає чи точка входить до заштрихованої області");
    Console.WriteLine("Введіть координати точки:");
    double x = Convert.ToDouble(Console.ReadLine());
    double y = Convert.ToDouble(Console.ReadLine());
    // Перевірка, чи точка знаходиться в верхній частині системи координат (y > 0)
    if (y <= 0)
    {
        Console.WriteLine("Точка за межами області"); // Точка знаходиться або на вісі або в нижній частині системи координат
    }

    double distanceToCenter = Math.Sqrt(x * x + y * y);

    // Перевірка, чи відстань до точки менша, ніж радіус першого кола
    if (distanceToCenter <= radius1)
    {
        Console.WriteLine("Точка за межами області"); // Точка в середині першого кола
    }

    // Перевірка, чи відстань до точки більша, ніж радіус другого кола
    if (distanceToCenter >= radius2)
    {
        Console.WriteLine("Точка за межами області"); // Точка за межами другого кола
    }

    Console.WriteLine("Точка знаходиться в межах області!"); // Точка між колами
}
static void task4()
{
    Console.WriteLine("Програма для визначення мастi за номером");
    Console.WriteLine("Введiть номер:");
    int suitNumber = Convert.ToInt32(Console.ReadLine());
    string suitName;

    switch (suitNumber)
    {
        case 1:
            suitName = "Пiки";
            break;
        case 2:
            suitName = "Трефи";
            break;
        case 3:
            suitName = "Бубни";
            break;
        case 4:
            suitName = "Черви";
            break;
        default:
            suitName = "Невiдома масть";
            break;
    }

    Console.WriteLine("Ви вибрали: " + suitName);
}
static int Product(int n, int m)
{
    return n * m;
}

static void task5()
{
    Console.WriteLine("Введіть значення n: ");
    int n = int.Parse(Console.ReadLine());

    Console.WriteLine("Введіть значення m: ");
    int m = int.Parse(Console.ReadLine());

    int result = Product(n, m);
    Console.WriteLine($"Добуток чисел {n} та {m} дорівнює {result}");
}
static void task6()
{
    int m = 0, n = 0;
    Console.WriteLine("Програма яка обчислює значення виразу");
    Console.WriteLine("Введіть значення m:");
    m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введіть значення n:");
    n = Convert.ToInt32(Console.ReadLine());
    double res = (n + 1 / (n * n) + (m * m) + 1) - (1 / (m + 1) * (n + 1));
    Console.WriteLine("Ваш результат: " + res);

}
Console.WriteLine("Lab 1!");
Console.WriteLine("Оберiть завдання від 1 до 6:");
int taskNumber = int.Parse(Console.ReadLine());

switch (taskNumber)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break;
    case 3:
        task3();
        break;
    case 4:
        task4();
        break;
    case 5:
        task5();
        break;
    case 6:
        task6();
        break;
    default:
        Console.WriteLine("Такого значення немає ");
        break;
}
