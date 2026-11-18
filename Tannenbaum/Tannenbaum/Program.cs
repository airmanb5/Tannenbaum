class Program
{
    static void Main()
    {
        Console.Write("Gib ein, wie hoch der Tannenbaum sein soll: ");
        string inputHeight = Console.ReadLine();

        if (int.TryParse(inputHeight, out int height))
        {
            for (int i = 0; i <= height + 1; i++)
            {
                List<string> currentLayer = GetCurrentChristmasTreeLayer(i, height);

                Console.WriteLine();

                foreach (string layer in currentLayer)
                {
                    Console.Write(layer);
                }
            }
        }

        else
        {
            Console.WriteLine("Invalid Height.");
        }
    }

    public static List<string> GetCurrentChristmasTreeLayer(int layer, int maxLayer)
    {


        int amountOfXes = layer * 2 - 1;

        int amountOfXesOnLastLayer = maxLayer * 2 - 1;

        List<string> finalLayer = new List<string>();

        int amountOfSpaces = amountOfXesOnLastLayer - amountOfXes;

        int amountOfSpacesPerSide = amountOfSpaces / 2;

        if (layer == maxLayer + 1)
        {
            for (int i = 0; i <= amountOfSpacesPerSide + amountOfXesOnLastLayer / 2; i++)
            {
                finalLayer.Add(" ");
            }

            for (int i = 0; i < 1; i++)
            {
                finalLayer.Add("I");
            }

            for (int i = 0; i <= amountOfSpacesPerSide + amountOfXesOnLastLayer / 2; i++)
            {
                finalLayer.Add(" ");
            }
        }
        else
        {
            for (int i = 0; i <= amountOfSpacesPerSide - 1; i++)
            {
                finalLayer.Add(" ");
            }

            for (int i = 0; i <= amountOfXes - 1; i++)
            {
                finalLayer.Add("X");
            }

            for (int i = 0; i < amountOfSpacesPerSide - 1; i++)
            {
                finalLayer.Add(" ");
            }
        }
        return finalLayer;
    }
}

