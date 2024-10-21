

    // Task 1
    string name = "John Doe";
    int age = 25;
    bool isAdmin = true;

    Console.WriteLine($"Name: {name}, Age: {age}, Is Admin: {isAdmin}");

    Task2();

    // Task 2
    static void Task2()
    {
        Console.Write(" Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        { Console.WriteLine("Even"); }
        else
        {
            Console.WriteLine("Odd");
        }
        Task3();
    }

    // Task 3
    static void Task3()
    {
        Console.WriteLine("Numbers from 1 to 10:");

        for (int i = 1; i <= 10; i++)
            Console.WriteLine(i);

        Task4();
    }

    // Task 4
    static void Task4()
    {
        int[] numbers = { 2, 4, 6, 8, 10 };
        int sum = 0;

        Console.WriteLine(" Elements in the array:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sum += num;
        }

        Console.WriteLine(" Sum of array elements: " + sum);

        Task5();
    }

    // Task 5
    static void Task5()
    {
        Greet("Alice");
    }

    static void Greet(string name)
    {
        Console.WriteLine(" Hello, " + name + "!");
    }

    Console.ReadLine();
