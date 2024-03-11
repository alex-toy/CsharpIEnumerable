int[] dataset = new int[] { 1, 2, 3, 4, 5 };

// function that returns the collection directly
//IEnumerable<int> SimpleEnumerable()
//{
//    return dataset;
//}

//// function that is an "iterator"
//IEnumerable<int> SimpleIterator()
//{
//    foreach (var item in dataset) yield return item;
//}

//foreach (var item in SimpleIterator()) Console.WriteLine(item);


//IEnumerable<int> ConsoleWritingIterator()
//{
//    Console.WriteLine("start of iterator!");
//    foreach (var item in dataset)
//    {
//        Console.WriteLine("before yield return!");
//        yield return item;
//        Console.WriteLine("after yield return!");
//    }

//    Console.WriteLine("end of iterator!");
//}

//foreach (var item in ConsoleWritingIterator()) Console.WriteLine(item);



// properties of iterators : lazy?!
//IEnumerable<int> FunctionThatSleepsFor5SecondsFirst()
//{
//    Thread.Sleep(5000);
//    return dataset;
//}

//Console.WriteLine($"Calling function that sleeps for 5 seconds first: {DateTime.Now}");
//IEnumerable<int> resultA = FunctionThatSleepsFor5SecondsFirst();
//Console.WriteLine($"Finished function that sleeps for 5 seconds first: {DateTime.Now}");

//foreach (var item in resultA) Console.WriteLine(item);





IEnumerable<int> IteratorThatSleepsFor5SecondsFirst()
{
    Thread.Sleep(5000);
    foreach (var item in dataset)
    {
        yield return item;
    }
}

Console.WriteLine($"Calling iterator that sleeps for 5 seconds first: {DateTime.Now}");
IEnumerable<int> resultB = IteratorThatSleepsFor5SecondsFirst();
Console.WriteLine($"Finished iterator that sleeps for 5 seconds first: {DateTime.Now}");

foreach (var item in resultB) Console.WriteLine(item);