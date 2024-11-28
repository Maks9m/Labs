//Exercise 1
int Random(int min, int max)
{
    Random random = new Random();
    return random.Next(min, max);
}
Console.WriteLine(Random(1, 10));

int Random1(int max, int min = 0)
{
    return Random(min, max);
}
Console.WriteLine(Random1(10));

//Exercise 2
string characters = "abcdefghijklmnopqrstuvwxyz0123456789";
string generatePassword(int length, string keys)
{
    char[] chars = keys.ToCharArray();//Split string into characters
    char[] password = new char[length];
    Random random = new();
    for (int i = 0; i < length; i++)
    {
        password[i] = chars[random.Next(0, characters.Length - 1)];//pick a random characters from keys
    }
    string result = new string(password);
    return result;
}
Console.WriteLine(generatePassword(10, characters));

