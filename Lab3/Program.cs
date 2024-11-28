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

//Exercise 3
string IPv4 = "127.0.0.1";
int IPv4ToNumber(string address)
{
    int[] addressElements = Array.ConvertAll<string, int>(address.Split('.'), int.Parse);

    int shifts = 3;
    int result = 0;
    for (int elementIndex = 0; elementIndex < addressElements.Length; elementIndex++)
    {
        for(int i = shifts - elementIndex; i > 0; i--)
        {
            addressElements[elementIndex] = addressElements[elementIndex] << 8;
        }
        result += addressElements[elementIndex];
    }
   return result;
}
Console.Write(IPv4ToNumber(IPv4));

