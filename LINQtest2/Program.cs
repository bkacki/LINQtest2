namespace LINQtest2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sandwiches = new[] { "Szynka i ser", "Salami i majonez", "Indyk i ser", "Kotlet z kurczaka" };

            var sandwichesOnRye =
                from sandwich in sandwiches
                select $"{sandwich} na chlebie ryżowym";

            foreach (var sandwich in sandwichesOnRye)
                Console.WriteLine(sandwich);
        }
    }
}
