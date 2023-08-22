string[] arrayFirst = new string[5] {"123", "23", "hello", "world", "res"};
string[] arraySecond = new string[arrayFirst.Length];
void SecondArrayWithIF(string[] arrayFirst, string[] arraySecond)
{
    int count = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(arrayFirst, arraySecond);
PrintArray(arraySecond);
