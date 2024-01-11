




int[] myArray = { 12,21,34,56,13,78,97,34,45};

int store = 0;

for (int i = 0;i <myArray.Length;i++)
{
    for (int j = 0;j < myArray.Length;j++)
    {
        if (myArray[i] < myArray[j] )
        {
            store = myArray[i];
            myArray[i] = myArray[j];
            myArray[j] = store;
        }
    }
}
foreach (int i in myArray)
{
    Console.Write(i+" ");
}