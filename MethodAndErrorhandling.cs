using System;

class MethodAndErrorhandling
{
    public static void MethodExample()
    {
        // En simpel metode, der tager to heltal som parametre og returnerer deres sum
        static int Add(int a, int b) // CPU udfører instruktionen
        {
            return a + b; // returnere resultatet til hukommelsesstakken
        }

        int x = 10; // Allokeret på hukommelsesstakken
        int y = 20; // Allokeret på hukommelsesstakken

        var obj = new { Name = "john" }; // Allokeret på hukommelsesheapen

        int result = Add(x, y); // Kalder funktionen i kode-segmentet

        Console.WriteLine(result); // CPU udfører instruktionen
    }

    public static void TupplesAndDeconstructorsExample()
    {
        // En metode, der returnerer en tuple med to værdier
        static (string, int) HentPersonInfo()
        {
            return ("John", 25); // Returnerer en tuple med navn og alder
        }

        var personInfo = HentPersonInfo();

        //en måde at udpakke værdierne uden deconstructor
        Console.WriteLine($"Navn: {personInfo.Item1}, Alder: {personInfo.Item2}");

        // Bruger dekonstruktor til at pakke tuplens værdier ud
        (string navn, int alder) = personInfo;
        Console.WriteLine($"Navn: {navn}, Alder: {alder}");

    }



    /*
       // klasse!
       public class Person
    {
       public string Navn { get; }
       public int Alder { get; }

       public Person(string navn, int alder)
       {
           Navn = navn;
           Alder = alder;
       }

       // Dekonstruktormetode
       public void Deconstruct(out string navn, out int alder) // sender værdierne tilbage til de variabler, der er brugt
       {
           navn = Navn;
           alder = Alder;
       }
   }


       // Opretter et nyt personobjekt
       var person = new Person("John", 25);

       // Bruger dekonstruktion til at udpakke værdier fra objektet
       (string navn, int alder) = person;

       // Udskriver værdierne
       Console.WriteLine($"Navn: {navn}, Alder: {alder}");

    */


    public static void ExceptionhandlingExample()
    {
        try
        {
            // int result = 10 / 0; // Deling med nul
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Division med nul er ikke tilladt!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("En generel fejl opstod!");
        }
        finally
        {
            Console.WriteLine("Dette vil altid blive udført!");
        }

    }

    [Obsolete("Denne metode er forældet. Brug NyMetode i stedet.")]
    public static void AttributeExample()
    {
        

    }
}








