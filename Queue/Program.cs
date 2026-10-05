List<char> queue = [];
void Enqueue(char element)
{
    Console.WriteLine($"Queued {element}");
    queue.Add(element);
}

void Process()
{
    if (queue.Count == 0)
    {
        Console.WriteLine("Queue is empty");
        return;
    }

    Console.WriteLine($"Processed {queue[0]}");
    queue.RemoveAt(0);

}

Enqueue('A');
Enqueue('B');
Process();
Process();
