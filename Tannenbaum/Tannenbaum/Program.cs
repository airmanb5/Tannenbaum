class Program
{
    static void Main()
    {
        Console.Write("Gib ein, wie hoch der Tannenbaum sein soll: ");
        int height = Convert.ToInt32(Console.ReadLine);

        for (int i = 0; i <= height; i++)
        {
            string[] currentLayer = GetCurrentChristmasTreeLayer(i, height);

            Console.WriteLine();

            foreach (string layer in currentLayer)
            {
                Console.Write(layer);
            }
        }
    }

    public static string[] GetCurrentChristmasTreeLayer(int layer, int maxLayer)
    {
        string[] level = new string[layer * 2 - 1];

        for (int i = 0; i <= level.Length -1; i++)
        {
            
        }

        return level;
    }
}

