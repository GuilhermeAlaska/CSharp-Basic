


namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest();
            f.name = "Amazonia";
            f.trees = 96525;
            f.age = 7000;
            f.biome = "Equatorial";

            Console.WriteLine(f.name);
        }
    }
}