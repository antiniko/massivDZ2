// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
int chislo;
Console.Write("введите число: ");
chislo = Convert.ToInt32(Console.ReadLine());
int n = 0;
while(chislo >= n)
{
 Console.Write(Math.Pow(n,3));
 Console.Write("");
 n++;
}




