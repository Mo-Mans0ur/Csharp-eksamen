// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;
using System.Text.Encodings.Web;
using static Abstraction;
using System.Threading.Tasks;


class Program
{


    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ImperativeProgramming.ImperativeExample();
        ImperativeProgramming.TypehandlingExample();
        ImperativeProgramming.NullHandlingExample();
        ImperativeProgramming.StringInterpolationExample();
        ImperativeProgramming.PatternMatchingExample();

        MethodAndErrorhandling.MethodExample();
        MethodAndErrorhandling.TupplesAndDeconstructorsExample();
        MethodAndErrorhandling.ExceptionhandlingExample();
        MethodAndErrorhandling.AttributeExample();

        ArraysAndCollections.ArrayExample();
        ArraysAndCollections.GenericListExample();
        ArraysAndCollections.IndexerExample();
        ArraysAndCollections.GenericExample();

        ObjectOrientedProgramming.ClassExample();
        ObjectOrientedProgramming.InheritanceExample();
        ObjectOrientedProgramming.PolymorphismExample();

        Abstraction.InterFaceExample();

        //Delegates
        //definere en metode der passer til signaturen
        SimpleDelegate myDelegate = MyMethod;
        //Kalder metoden
        myDelegate(); // Output: Metode kaldt!

        Abstraction.LambdasExample();


        LinqFunctionalty.LinqMethodsExample();
        LinqFunctionalty.ExtensionMethodsExample();

        await AdvancedTopics.ConcurrentExecutionExample();
        AdvancedTopics.FunctionalProgrammingExample();

    }
}