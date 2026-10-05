
void Generate(int maximumNumber)
{

    var numbers = Enumerable.Range(1, maximumNumber).ToList();

    bool IsEnding(int index)
    {
        if (index == maximumNumber - 1)
        {
            return true;
        }
        return false;
    }

    for (int i = 0; i <= maximumNumber - 1; i++)
    {
        if (numbers[i] % 3 == 0 && numbers[i] % 5 == 0)
        {
            Console.Write("foobar");
            if (IsEnding(i))
            {

                continue;

            }
            Console.Write(", ");
            continue;
        }

        if (numbers[i] % 3 == 0)
        {
            Console.Write("foo");
            if (IsEnding(i))
            {
                continue;

            }
            Console.Write(", ");
            continue;
        }

        if (numbers[i] % 5 == 0)
        {
            Console.Write("bar");
            if (IsEnding(i))
            {
                continue;

            }
            Console.Write(", ");
            continue;
        }
        
        if (IsEnding(i))
        {
            Console.Write(numbers[i]);
            continue;

        }
        Console.Write(numbers[i] + ", ");


    }




}

Generate(15);