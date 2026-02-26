namespace PrimeNumber


{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputTal = 1299721;
            bool primFlag = ErPrimtal(inputTal);
//          bool primFlag = ErPrimtalAdvanced(inputTal);


            if (primFlag)
            {
                Console.WriteLine($"\n\n{inputTal} er et primtal");
            }
            else
            {
                Console.WriteLine($"{inputTal} er ikke et primtal");
            }
        }


        static bool ErPrimtal(int tal)
        {
            if (tal <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < tal; i++)
                {
                    if (tal % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }



        static bool ErPrimtalAdvanced(int tal)
        {
            if (tal <= 1)
            {
                return false;
            }

            else if (tal <= 3)
            {
                return true;
            }

            else if (tal % 2 == 0 || tal % 3 == 0)
            {
                return false;
            }

            int i = 5;
            while (i * i <= tal)
            {
                if (tal % i == 0 || tal % (i + 2) == 0)
                {
                    return false;
                }
                i += 6;
            }
            return true;
        }
    }
}
