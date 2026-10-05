List<string> myStack = [];

void Type(string text)
{
    Console.WriteLine($"Typed [{text}] ");
    myStack.Add(text);
}

void Undo()
{

    if (myStack.Count != 0)
    {

        var text = myStack[myStack.Count - 1];
        myStack.RemoveAt(myStack.Count - 1);
        Console.WriteLine($"Undid [{text}] ");
        return;
    }

    Console.WriteLine("Stack Empty ");
}


Type("foo");
Type("bar");
Type("sala");
Type("tiga");

Undo();
Undo();
Undo();
