//Exercise 1
using System.Collections;
using System.IO.Compression;
using System.Security.Cryptography;

int SumFor(params int[] x)
{
    int result = 0;
    for (int i = 0; i < x.Length; i++) result += x[i];
    return result;
}
Console.WriteLine(SumFor(0, 2, 4, -5));

//Exercise 2
int SumForeach(params int[] x)
{
    int result = 0;
    foreach (int i in x) result += i;
    return result;
}
Console.WriteLine(SumForeach(0, 2, 4, -5));

//Exercise 3
int SumWhile(params int[] x)
{
    int result = 0;
    int counter = 0;
    while (counter < x.Length) result += x[counter++];
    return result;
}
Console.WriteLine(SumWhile(0, 2, 4, -5));

//Exercise 4
int SumDoWhile(params int[] x)
{
    int result = 0;
    int counter = 0;
    do result += x[counter++]; 
    while (counter < x.Length);
    return result;
}
Console.WriteLine(SumDoWhile(0, 2, 4, -5));

//Exercise 5
/*
    const sum = (...args) => args.reduce((a, b) => (a + b), 0);
    Dont have '.reduce()' function in C#
*/

//Exercise 6
int[,] numbers = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
int MaxValue(int[,] x)
{
    int result = x[0, 0];
    foreach (int i in x)
    {
        if(i > result) result = i;
    }
    return result;
}
Console.WriteLine(MaxValue(numbers));

//Exercise 7
var people = new Dictionary<string, Person>
{
    {"Lenin", new Person { born = 1870, died = 1924 }},
    {"Mao", new Person { born = 1893, died = 1976 }},
    {"Gandhi", new Person { born = 1869, died = 1948 }},
    {"Hirohito", new Person { born = 1901, died = 1989 }},
};

void Ages(Dictionary<string, Person> people)
{
    foreach(var person in people)
    {
        person.Value.age = person.Value.died - person.Value.born;
        Console.WriteLine($"{person.Key}: {person.Value.age}");
    }
}

Ages(people);
class Person
{
    public  int born { get; set; }
    public int died { get; set; }
    public int age { get; set; }
}

