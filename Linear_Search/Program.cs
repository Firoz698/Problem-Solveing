int[] myNumber = { 23, 32, 34, 45, 67, 88, 42, 12, 54 };
Console.Write("Enter Your Number : ");
int SerchNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < myNumber.Length; i++)
{
    if (myNumber[i] == SerchNumber)
    {
        Console.WriteLine($"You Searching {myNumber[i]} ");
    }
}