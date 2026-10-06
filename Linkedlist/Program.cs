// See https://aka.ms/new-console-template for more information
using Linkedlist;


CustomNode checkIsTail(CustomNode checkThisNode)
{
    if (checkThisNode.tail is not null)
    {
        return checkIsTail(checkThisNode.tail);
    }

    return checkThisNode;
}


void Appended(int val){
    if (CustomNode.head is null)
    {
        CustomNode.head = new CustomNode{myNum=val};
        Console.WriteLine($"Appended [{val}]");
        return;
    }

    if (CustomNode.head.tail is null)
    {
        CustomNode.head.tail = new CustomNode{myNum=val};
        Console.WriteLine($"Appended [{val}]");
        return;
    }

    // recursive ?
    var theLast = checkIsTail(CustomNode.head.tail);
    theLast.tail = new CustomNode{myNum=val};
    Console.WriteLine($"Appended [{val}]");
}

void Print()
{
    PrintHelper(CustomNode.head);
}

void PrintHelper(CustomNode printThisNode)
{
    Console.Write($"{printThisNode.myNum}");
    if (printThisNode.tail is not null)
    {
        Console.Write(" -> ");
        PrintHelper(printThisNode.tail);
    }
}

Appended(10);
Appended(5);
Appended(6);
Appended(7);
Appended(2);
Print();