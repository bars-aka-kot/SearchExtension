namespace SearchExtension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SearchFile.SearchExstension(args[0], args[1], args[2]);

            foreach (var element in SearchFile.list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
