using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;


class AdvancedTopics
{
    public static async Task ConcurrentExecutionExample()
    {
        Task<int> myTask = Task.Run(() =>
        {
            int sum = 0;
            for (int i = 0; i < 100; i++)
            {
                sum += i;
            }
            return sum;
        });

        int result = await myTask; // Venter på at opgaven bliver færdig og får resultatet

        Console.WriteLine($"Summen er: {result}"); // Udskriver resultatet til konsollen

    }

    public static void FunctionalProgrammingExample()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var evenNumbersQuery = numbers.Where(n => n % 2 == 0);
        var evenNumbersList = evenNumbersQuery.ToList(); // Konverterer til en rigtig liste

        foreach (var number in evenNumbersList)
        {
            Console.WriteLine(number); // Udskriver 2 og 4
        }


    }

}