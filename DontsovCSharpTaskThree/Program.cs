class ProgramThree
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите числа через пробел: ");
        string input = Console.ReadLine();
        string[] inputNumbers = input.Split(' ');
        List<int> numbers = new List<int>();
        foreach (string number in inputNumbers)
        {
            int parsedNumber;
            if (int.TryParse(number, out parsedNumber))
            {
                numbers.Add(parsedNumber);
            }
        }
        Console.WriteLine("Числа, кратные 3-ем: ");
        foreach (int number in numbers)
        {
            if (number % 3 == 0)
            {
                Console.WriteLine(number);
            }
        }

    }
}
