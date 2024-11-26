namespace Challenge4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> count = new Dictionary<string, int>();

            string[] input = ["a", "b", "c", "a", "c", "d","f","d"];

            foreach (string s in input)
            {
                if (!count.TryAdd(s, 1))
                {
                    count[s]++;
                }
            }

            //Print dictionary
            Console.WriteLine();
            foreach (KeyValuePair<string, int> kvp in count)
            {
                Console.WriteLine("Key = {0}, Count = {1}",
                    kvp.Key, kvp.Value);
            }


        }
    }
}
