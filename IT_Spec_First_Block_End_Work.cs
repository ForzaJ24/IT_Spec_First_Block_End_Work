// "Better","Faster","Stronger","Worse","Slower","Weaker"string [] massive =
string[] massive1 = new string[5] {"Better", "Faster", "Stronger", "Weeker", "Slower"};
string[] massive2 = new string[massive1.Length];
void SecondArrayWithIF(string[] massive1, string[] massive2)
{
    int count = 0;
    for (int i = 0; i < massive1.Length; i++)
    {
    if(massive1[i].Length <= 3)
        {
        massive2[count] = massive1[i];
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
SecondArrayWithIF(massive1, massive2);
PrintArray(massive2);