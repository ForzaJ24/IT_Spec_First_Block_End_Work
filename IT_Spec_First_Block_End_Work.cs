//"МТС", "Билайн", "YOTA","Мегафон","ПСБ"
string[] massive1 = new string[5] {"МТС", "Билайн", "YOTA","Мегафон","ПСБ"};
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
void PrintMassive(string[] massive2)
{
    for (int i = 0; i < massive2.Length; i++)
    {
        Console.Write($"{massive2[i]} ");
    }
}
SecondMassive(massive1, massive2);
PrintMassive(massive2);
