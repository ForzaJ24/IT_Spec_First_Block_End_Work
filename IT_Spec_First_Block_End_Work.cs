string[] massive1 = new string[3] {"1", "2", "3"};
string[] massive2 = new string[massive1.Length];
void SecondMassive(string[] massive1, string[] massive2)
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
void PrintMassive(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondMassive(massive1, massive2);
PrintMassive(massive2);