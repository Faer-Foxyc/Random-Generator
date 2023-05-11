
namespace Генератор_случайных_чисел.Classes
{
    internal class NumberGenerator
    {
        int number { get; set; }

        public NumberGenerator(int _number)
        {
            number = _number;
        }

        public int GenerateNumber()
        {
            int numb = 0;
            try
            {
                Random random = new Random();
                numb = random.Next(number);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка! Отрицательное число + {e.Message}");
            }
            return numb;
        }
    }
}
