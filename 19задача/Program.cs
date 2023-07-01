int num, count , sum=0, digit=sum;
Console.Write("Введите пятизначное число:");
num = Convert.ToInt32(Console.ReadLine());
if (num>9999 && num<100000)
{
    for( digit=num; num!=0; num=num/10)
    {
        count=num % 10;
        sum=sum*10+count;
    }
}
else 
{ 
    Console.WriteLine("Введите пятизначное число!");
    }
if (digit== sum)
{
  Console.WriteLine($"{digit} является палиндромом");
}
else 
{
    Console.WriteLine($"{digit} не является палиндромом");
}

