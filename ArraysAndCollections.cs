using System;
class ArraysAndCollections
{
    public static void ArrayExample()
    {
        // Array
        int[] numbers = { 1, 2, 3, 4 };
        Console.WriteLine(numbers[3]); // Output: 4
    }
    /*
        Java

        int[] numbers = {1, 2, 3, 4}
        System.Out.println(numbers[2]); // Output: 3
    */

    public static void GenericListExample()
    {
        List<string> names = new List<string> { "Alice", "Bob" };
        Console.WriteLine(names[0]); // Output: Alice
    }


    // hører til IndexerExample
    public class MyClass
    {
        private int[] arr = new int[10];
        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    }


    public static void IndexerExample()
    {
        MyClass myObject = new MyClass();
        myObject[3] = 42;
        Console.WriteLine(myObject[3]); // Output: 42
    }

    // Hører til GenericExample
    public class GenericClass<T>
    {
        public T GenericProperty { get; set; }
    }

    public static void GenericExample()
    {
        GenericClass<string> genericString = new GenericClass<string>();
        genericString.GenericProperty = "Hello, Generics!";
        Console.WriteLine(genericString.GenericProperty); // Output: Hello, Generics!

        GenericClass<int> genericInt = new GenericClass<int>();
        genericInt.GenericProperty = 100;
        Console.WriteLine(genericInt.GenericProperty); // Output: 100
    }
}