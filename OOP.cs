class ObjectOrientedProgramming
{
    // Hører til ClassExample
    class Bil
    {
        // get og set
        public string Model { get; set; }

        // Constructor
        public Bil(string model)
        {
            Model = model;
        }

        // Metode
        public void Kør() { Console.WriteLine("Bilen kører"); }
    }

    public static void ClassExample()
    {
        // laver en ny bil
        Bil nyBil = new Bil("bmw");
        nyBil.Kør();
    }

    // Hører til InheritanceExample
    class Køretøj { public int Hastighed { get; set; } }
    class Fly : Køretøj { public string Model { get; set; } }

    public static void InheritanceExample()
    {
        Fly mitFly = new Fly();
        mitFly.Hastighed = 100;
        mitFly.Model = "Jet";

        Console.WriteLine($"Model: {mitFly.Model}");
    }

    /* Hører til PolymorphismExample
    class Køretøj
    {
        public virtual void Kør() { Console.WriteLine("Køretøjet kører"); }
    }
    class Bil : Køretøj
    {
        public override void Kør() { Console.WriteLine("Bilen kører"); }
    }
    */


    public static void PolymorphismExample()
    {
        /*
        // Opretter en instans af baseklassen
        Køretøj køretøj = new Køretøj();
        køretøj.Kør(); // Output: Køretøjet kører

        // Opretter en instans af den afledte klasse
        Bil bil = new Bil();
        bil.Kør(); // Output: Bilen kører

        // Polymorfisk adgang
        Køretøj polymorfiskKøretøj = new Bil();
        polymorfiskKøretøj.Kør(); // Output: Bilen kører
        */
    }

}