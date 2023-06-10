class ProgramOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 7)
            {
                Console.WriteLine("Привет");
            }
        }
    }
