Task t1 = Task.Run(() =>
{
    Console.WriteLine("début t1");
    Thread.Sleep(3000);
    Console.WriteLine("milieu t1");
    Thread.Sleep(3000);
    Console.WriteLine("fin t1");
});

Task t2 = Task.Run(() =>
{
    Console.WriteLine("début t2");
    Thread.Sleep(3000);
    Console.WriteLine("milieu t2");
    Thread.Sleep(3000);
    Console.WriteLine("fin t2");
});

await Task.WhenAll(t1, t2);