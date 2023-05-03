class DisplayingDiamonds
{
    static void Main(string[] args)
    {
        int size = 9;
        int mid = size / 2;
        int count = 1;
        int spaces = mid;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < count; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            if (i < mid)
            {
                count += 2;
                spaces--;
            }
            else
            {
                count -= 2;
                spaces++;
            }
        }
    }
    }
}