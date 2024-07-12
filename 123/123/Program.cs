using _123;
class Program
{
    static void Main()
    {
        var crocodileService = new CrocodileService();
        crocodileService.CreateCrocodile("Spike", 300, 4.5, 20, "Male");
        crocodileService.CreateCrocodile("Lizzy", 250, 4.0, 15, "Female");
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Показать всех крокодилов");
            Console.WriteLine("2. Показать крокодила, длиной более 4.2 метра");
            Console.WriteLine("3. Показать самого старого крокодила");
            Console.WriteLine("4. Показать самого тяжеого кродила");
            Console.WriteLine("5. Выход");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("All crocodiles:");
                        crocodileService.GetAllCrocodilesInfo();
                        break;
                    case 2:
                        Console.WriteLine("\nLong crocodiles (length > 4.2 m):");
                        crocodileService.GetLongCrocodilesInfo(4.2);
                        break;
                    case 3:
                        Console.WriteLine("\nOldest crocodiles:");
                        crocodileService.GetOldestCrocodileInfo();
                        break;
                    case 4:
                        Console.WriteLine("\nHeaviest crocodiles:");
                        crocodileService.GetHeaviestCrocodileInfo();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Выход из программы...");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Попробуйте снова.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите число.");
            }
            }
        }
    }
