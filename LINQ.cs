using System.Linq;
using System;
static class LinqFunctionalty
{
    public static void LinqMethodsExample()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6 };
        var result = numbers.Where(x => x > 3).Select(x => x * 2);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }

    // det samme som øverst men mere læsbart
    public static void LinqQuerySyntaxExample()
    {
        var numbers = new[] { 1, 2, 3, 4, 5, 6 };
        var result = from n in numbers
                     where n > 3
                     select n * 2;

    }


    public static int WordCount(this string str)
    {
        return str.Split(' ').Length;
    }

    public static void ExtensionMethodsExample()
    {
        string sentence = "Hello World!";
        int count = sentence.WordCount();
        Console.WriteLine($"Word count: {count}"); // Output: Word count: 2
    }
}

