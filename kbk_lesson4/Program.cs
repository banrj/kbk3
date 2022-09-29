// Богомолв Даниил 13 вариант базовый
try
{
    //Console.WriteLine("Введите число A: ");
    int FirstNumber = 46;
    //int.Parse(Console.ReadLine());
    //Console.WriteLine("Введите число B: ");
    int SecondNumber = 60;
    //int.Parse(Console.ReadLine());
    //Console.WriteLine("Введите число C: ");
    int ThirdNumber = 390;
    //int.Parse(Console.ReadLine());

    if ((FirstNumber < 45 && SecondNumber > 45 && ThirdNumber > 45) ||
        (FirstNumber > 45 && SecondNumber > 45 && ThirdNumber < 45) ||
        (FirstNumber > 45 && SecondNumber < 45 && ThirdNumber > 45))
    {
        Console.WriteLine(true);
    }
    else Console.WriteLine(false);
}

catch
{

}