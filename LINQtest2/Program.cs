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

            Console.WriteLine();

            var random = new Random();
            var numbers = new List<int>();
            int length = random.Next(10, 25);
            for(int i=0; i < length; i++)
                numbers.Add(random.Next(100));
            Console.WriteLine($@"Statystyki dla tych {numbers.Count()} liczb:
Pięć pierwszych liczb: {String.Join(", ", numbers.Take(5))}
Pięć ostatnich liczb: {String.Join(", ", numbers.TakeLast(5))}
Pierwsza liczba: {numbers.First()}; ostatnia liczba {numbers.Last()}
Najmniejsza liczba: {numbers.Min()}; ostatnia liczba {numbers.Last()}
Suma: {numbers.Sum()}
Średnia: {numbers.Average():F2}
Liczby: {String.Join(", ", numbers)}");

            Console.WriteLine();

            var listOfObjects = new List<PrintWhenGetting>();
            for(int i=1; i<5; i++)
                listOfObjects.Add(new PrintWhenGetting() { InstanceNumber = i});

            Console.WriteLine("Przygotowanie kwerendy");
            var result =
                from o in listOfObjects
                select o.InstanceNumber;

            Console.WriteLine("Uruchamianie pętli foreach");
            foreach (var number in result)
                Console.WriteLine($"Zapis nr {number}");

            //przetwarzanie odroczone - getter jest wywoływany dopiero po użyciu metody przetwarzającej całą sekwencję
            var immediate = result.ToList();
        }
    }
}
