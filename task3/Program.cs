// Написать программу копирования массива

void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        collection[i] = new Random().Next(1, 20);
    }
}

void PrintArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(collection[i] + " ");
    }
}

void CopyArray(int[] collect1, int[] collect2)
{
    if (collect1.Length > collect2.Length)
        for (int i = 0; i < collect2.Length; i++)
        {
            collect2[i] = collect1[i];
        }
    else
    {
        for (int i = 0; i < collect1.Length; i++)
        {
            collect2[i] = collect1[i];
        }
    }
}

int[] firstArray = new int[20];
int[] secondArray = new int[20];

FillArray(firstArray);
PrintArray(firstArray);
Console.WriteLine();
CopyArray(firstArray, secondArray);
PrintArray(secondArray);

