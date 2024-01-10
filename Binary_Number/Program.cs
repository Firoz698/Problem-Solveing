




Console.Write("Enter Your Number : ");
int myNumber = Convert.ToInt32(Console.ReadLine());

int[] myArray = {34,54,66,78,12,21,46,90,34,23 };

int Left, Right, Mid;
Left = 0;
Right = myArray.Length - 1;

while (Left <= Right)
{
    Mid = (Left + Right) / 2;
    if (myArray[Mid] == myNumber)
    {
        Console.WriteLine(Mid);
    }
    if (myArray[Mid] < myNumber)
    {
        Left = Left + 1;
    }
    else
    {
        Right = Right - 1;
    }
    
}











//for (int i = 0; i < myArray.Length; i++)
//{
//    if (myArray[i] != 0)
//    {
//        Console.WriteLine("Ok");
//    }
//}

























