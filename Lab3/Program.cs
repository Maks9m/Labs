
int Random(int min, int  max)
{
    Random random= new Random();
    return random.Next(min, max);
}
Console.WriteLine(Random(1, 10));

int Random1(int max, int min = 0)
{
    return Random(min, max);
}
Console.WriteLine(Random1(10));

//char characters = 'abcdefghijklmnopqrstuvwxyz0123456789';
