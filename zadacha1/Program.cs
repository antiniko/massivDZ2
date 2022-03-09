// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

int rev(int x)
{
    if (x > 9999 && x < 100000)
    {
    int a1 = x % 10;
    int a2 = x / 10 % 10;
    int a3 = x / 100 % 10;
    int a4 = x / 1000 % 10;
    int a5 = x / 10000;
    return  a1 * 10000 + a2 * 1000 + a3 * 100 + a4 * 10 + a5;
    }
    else
    {
    Console.WriteLine("Не верное число");
    return 0;
    ;
    }
}
int chislo;
Console.Write("введите пятизначное число: ");
chislo = Convert.ToInt32(Console.ReadLine());
rev(chislo);
if (chislo == rev(chislo))
{
    Console.WriteLine("чилсло является палиндромом");
}
else
{
    Console.WriteLine("чилсло не является палиндромом");
}


