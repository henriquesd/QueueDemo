Queue<string> queueDemo = new Queue<string>();

EnqueueDemo(queueDemo);

DequeueDemo(queueDemo);

PeekDemo(queueDemo);

ContainsDemo(queueDemo);

CountDemo(queueDemo);

static void EnqueueDemo(Queue<string> queueDemo)
{
    queueDemo.Enqueue("Julie");
    queueDemo.Enqueue("Ana");
    queueDemo.Enqueue("Bob");

    Console.WriteLine("Elements in the Queue:");

    foreach (var item in queueDemo) Console.WriteLine(item);

    Console.WriteLine("------------------------------");
}

static void DequeueDemo(Queue<string> queueDemo)
{
    var dequeuedElement = queueDemo.Dequeue();

    Console.WriteLine($"Dequeued element: {dequeuedElement}");

    Console.WriteLine("\nElements in the Queue after Dequeue operation:");

    foreach (var item in queueDemo) Console.WriteLine(item);

    Console.WriteLine("------------------------------");
}

static void PeekDemo(Queue<string> queueDemo)
{
    var firstElement = queueDemo.Peek();

    Console.WriteLine($"First element: {firstElement}");

    Console.WriteLine("------------------------------");
}

static void ContainsDemo(Queue<string> queueDemo)
{
    var containsBob = queueDemo.Contains("Bob");
    var containsSofia = queueDemo.Contains("Sofia");

    Console.WriteLine($"Queue contains Bob: {containsBob}");
    Console.WriteLine($"Queue contains Sofia: {containsSofia}");

    Console.WriteLine("------------------------------");
}

static void CountDemo(Queue<string> queueDemo)
{
    var numberOfelements = queueDemo.Count;

    Console.WriteLine($"Number of elements in the Queue: {numberOfelements}");

    Console.WriteLine("------------------------------");
}