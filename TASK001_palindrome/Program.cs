Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);

if (num < 10000 ^ num > 99999)
{
    Console.WriteLine("Это не пятизначное число.");
}
else
{
    int digit1 = num % 10;
    int digit2 = num / 10 % 10;
    int digit3 = num / 100 % 10;
    int digit4 = num / 1000 % 10;
    int digit5 = num / 10000;

    int mun = (digit1 * 10000 + digit2 * 1000 + digit3 * 100 + digit4 * 10 + digit5);

//Я пытался решить изящее, но не осилил, как считать строку,
//полученную таким способом, и преобразовать в число.
// int count = num;

// while(count > 0)
// {
//     Console.Write(count % 10);
//     count = count / 10;
// }
// int mun = int.Parse(Console.ReadLine());

    if(num == mun)
    {
        Console.WriteLine("Это палиндром.");
    }
    else 
    {   
        Console.WriteLine("Это не палиндром.");
        }
}