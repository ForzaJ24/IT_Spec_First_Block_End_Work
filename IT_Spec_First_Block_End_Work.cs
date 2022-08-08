string [] massive =
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


