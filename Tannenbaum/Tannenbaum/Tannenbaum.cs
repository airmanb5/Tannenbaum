public class Tannenbaum
{
    public int _height { get; set; } = 0;

    static void Main()
    {
        Tannenbaum tannenBaum = new Tannenbaum();

        Console.Write("Gib ein, wie hoch der Tannenbaum sein soll: ");
        string inputHeight = Console.ReadLine();

        Console.Write("Star on top (y/n): ");
        string starOnTop = Console.ReadLine();

        if (int.TryParse(inputHeight, out int height))
        {
            tannenBaum._height = height;

            if (starOnTop.ToLower().Equals( "y"))
            {
                for (int i = 0; i <= height + 1; i++)
                {
                    DrawTreeOnConsole(tannenBaum, i, true);
                }

                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i <= height; i++)
                {
                    DrawTreeOnConsole(tannenBaum, i + 1, false);
                }
                Console.WriteLine();
            }
        }

        else
        {
            Console.WriteLine("Invalid Height.");
        }
    }


    public List<string> GetCurrentChristmasTreeLayer(int layer, bool hasStar)
    {
        int amountOfXes = layer * 2 - 1;
        int amountOfXesOnLastLayer = _height * 2 - 1;

        List<string> finalLayer = new List<string>();

        int amountOfSpaces = amountOfXesOnLastLayer - amountOfXes;
        int amountOfSpacesPerSide = amountOfSpaces / 2;

        if (hasStar && layer == 0)
        {
            for (int i = 0; i <= amountOfSpacesPerSide - 2; i++)
            {
                finalLayer.Add(" ");
            }

            for (int i = 0; i < 1; i++)
            {
                finalLayer.Add("*");
            }
        }
        else
        {
            if (layer == _height + 1)
            {
                for (int i = 0; i <= amountOfSpacesPerSide + amountOfXesOnLastLayer / 2; i++)
                {
                    finalLayer.Add(" ");
                }

                for (int i = 0; i < 1; i++)
                {
                    finalLayer.Add("I");
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
            }
        }

        return finalLayer;
    }

    static void DrawTreeOnConsole(Tannenbaum tannenBaum, int height, bool hasStar)
    {
        List<string> currentLayer = tannenBaum.GetCurrentChristmasTreeLayer(height, hasStar);

        Console.WriteLine();

        foreach (string layer in currentLayer)
        {
            Console.Write(layer);
        }
    }
}

