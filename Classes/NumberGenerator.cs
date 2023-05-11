
namespace Генератор_случайных_чисел.Classes
{
    internal class NumberGenerator
    {
        int numb = 0;
        int number 
        {
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("\n Вводимое число не может быть отрицательным");
                }
                else
                {
                    number = value;
                }
            }
            get { return numb; }
        }

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
                Console.WriteLine(e.Message);
            }
            return numb;
        }
    }
}
