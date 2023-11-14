using System.Runtime.Versioning;

class ImperativeProgramming
{
    // 1. Variabledeklaration og tildeling
    public static void ImperativeExample()
    {
        int sum = 0;

        // 2. Kontrolstrukturer - for loop
        for (int i = 0; i < 5; i++)
        {
            sum += i; // Tildeling og addition
        }

        // If-sætning
        if (sum > 10)
        {
            Console.WriteLine("summen er større end 10");
        }
        else
        {
            Console.WriteLine("summen er ikke større end 10");
        }

        // Metode definition
        void PrintSum(int value)
        {
            Console.WriteLine($"summen er: {value}");
        }

        // 3. Metodekald
        PrintSum(sum);


    }


    public static void TypehandlingExample()
    {
        int number = 8; // Deklerere en int
        double realNumber = 5.5; // Deklerere en double

        // Implicit typekonverting (fra int til double)
        double result = number + realNumber;

        // Eksplicit typekonvertering (fra double til int)
        int wholeNumber = (int)realNumber;

        // brug af 'var' til implicit variabler
        var myNumber = 42; // systemet siger at det er en int, da det et heltal

        // brug af 'is' og 'as' operatører til typecontrol og typecasting
        object obj = number;
        if (obj is int)
        {
            int retrievedNumber = (int)obj; // typcasting til int; retrievedNumber gemmer den 'int' der hentet fra 'obj'
            Console.WriteLine($"den retrievedeNumber er: {retrievedNumber}");
        }

    }
    public static void NullHandlingExample()
    {
        //Deklarere en variabel med en null-værdi
        string name = null;

        //Brug af null-coalescing operatøren ?? til at give en værdi, hvis værdien er null.
        string safeName = name ?? "Ingen navn sorry";
        Console.WriteLine(safeName); //output: Ingen Navn

        // Brug af nullable værdityper
        int? nullableAge = null;
        int age = nullableAge ?? 25; //hvis nullableAge er null, bliver age sat til 25
        Console.WriteLine($"age er: {age}"); // output: 25

        //Brug af null-conditional operator ?. til at kalde metoder
        Person person = null;
        string personName = person?.GetName();

        // brug af 'is' til at tjekke, om objektet er null
        if (person is null)
        {
            Console.WriteLine("Person er null");
        }
    }

    public static void StringInterpolationExample()
    {
        string name = "John";
        int age = 30;
        double height = 5.9;

        // Brug af stringinterpolation til at kombinere variabler i en streng
        string description = $"Navn: {name}, Alder: {age}, Højde: {height} meter";
        Console.WriteLine(description); // Output: Navn: John, Alder: 30, Højde: 5.9 meter

        // Du kan også bruge formatering inden for krøllede parenteser
        string formattedDescription = $"Navn: {name.ToUpper()}, Alder: {age}, Højde: {height:F1} meter";
        Console.WriteLine(formattedDescription); // Output: Navn: JOHN, Alder: 30, Højde: 5.9 meter

    }

    public static void PatternMatchingExample()
    {
        //for at se hvad for en Værditype det er
        object value = 42;

        switch (value)
        {
            case int i when i > 0:
                Console.WriteLine($"Det er et positivt heltal: {i}");
                break;
            case double d:
                Console.WriteLine($"Det er et kommatal: {d}");
                break;
            case null:
                Console.WriteLine("Det er null!");
                break;
            case string s:
                Console.WriteLine($"Det er en streng: {s}");
                break;
            default:
                Console.WriteLine("Ukendt type");
                break;
        }

        // Output: Det er et positivt heltal: 42

    }
}

internal class Person
{
    internal string GetName()
    {
        throw new NotImplementedException();
    }
}