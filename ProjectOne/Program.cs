//Find even or odd number in C# 

Console.Write("Plase Enter Your Number : ");
int Number =Convert.ToInt32(Console.ReadLine());

if (Number%2==0)
{
    Console.WriteLine($"{Number} Even Number");
}
else
{
    Console.WriteLine($"{Number} Odd Number");
}
