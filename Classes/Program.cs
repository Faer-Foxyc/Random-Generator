using Генератор_случайных_чисел.Classes;

//-------------------------Start program-----------------------------------------------------------------------------\\

while (true)
{
    Console.Write("\n Введите число в диапазоне которого \n будет сгенерировано случайное число(от 0 до ваше число): ");
    string number = Console.ReadLine();
    NumberGenerator numberGenerator = new NumberGenerator(Convert.ToInt32(number));
    int genNumb = numberGenerator.GenerateNumber();
    Console.WriteLine($"\n Сгенерированное число: {genNumb}");

    Console.Write("\n Хотите продолжить? Да(0)/Нет(1): ");
    string answer = Console.ReadLine();
    if (Convert.ToInt32(answer) == 1)
    {
        break;
    }
}

//-------------------------------------------------------------------------------------------------------------------\\
