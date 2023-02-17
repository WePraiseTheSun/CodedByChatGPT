/*
Certainly! Here's an example of how you could implement the producer-consumer pattern using asynchronous and parallel programming in C#:

*/
using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var buffer = new BlockingCollection<int>(boundedCapacity: 100);
        var cts = new CancellationTokenSource();

        var producerTask = Task.Run(() => Produce(buffer, cts.Token));
        var consumerTask = Task.Run(() => Consume(buffer, cts.Token));

        Console.WriteLine("Press enter to exit...");
        Console.ReadLine();

        cts.Cancel();

        Task.WaitAll(producerTask, consumerTask);
    }

    static async Task Produce(BlockingCollection<int> buffer, CancellationToken cancellationToken)
    {
        Random random = new Random();

        while (!cancellationToken.IsCancellationRequested)
        {
            int value = random.Next(100);
            await buffer.AddAsync(value, cancellationToken);
            Console.WriteLine($"Produced {value}");
            await Task.Delay(100);
        }

        buffer.CompleteAdding();
    }

    static async Task Consume(BlockingCollection<int> buffer, CancellationToken cancellationToken)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            int value = await Task.Run(() => buffer.Take(cancellationToken));
            Console.WriteLine($"Consumed {value}");
            await Task.Delay(500);
        }
    }
}
