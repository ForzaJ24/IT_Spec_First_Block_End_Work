﻿string [] massive =
{
  "Better","Faster","Stronger","Worse","Slower","Weaker"
};
string[] massive2 = new string[massive.Length];
void SecondMassive(string[] massive, string[] massive2)
{
    int count = 0;
    for (int i = 0; i < massive.Length; i++)
    {
    if(massive[i].Length <= 3)
        {
        massive2[count] = massive[i];
        count++;
        }
    }
}
void PrintArray(string[] massive)
{
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]} ");
    }
    Console.WriteLine();
}
SecondMassive(massive, massive2);
PrintArray(massive2);

