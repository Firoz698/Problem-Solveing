Console.Write("Plase Enter Your Fibanacci NO :");
int Number =Convert.ToInt32( Console.ReadLine());
int a = 0;
int b = 1;
int c;
Console.WriteLine(a);
Console.WriteLine(b);

for (int i = 0; i < Number; i++)
{
    c = a + b;
    Console.WriteLine(c);
    a = b;
    b = c;


}
Console.WriteLine("hello");