using System.Collections;

List<int> numbers = new() { 1, 2, 3 };
//Console.WriteLine(numbers[0]);
//Console.WriteLine(numbers.First());

//numbers.Add(4);
//Console.WriteLine(numbers.Last());




//ArrayList coll = new();
//coll.Add(1);
//coll.AddRange(numbers);
//coll.Add("alex");
//coll.Add(true);

//coll.Remove(2);

//Console.WriteLine(coll[3]);
//Console.WriteLine(coll.IndexOf(3));

//foreach (var entry in coll)
//{
//    Console.WriteLine(entry);
//}




//Hashtable hashtable = new Hashtable();
//hashtable.Add(1, "B");
//hashtable.Add("A", 2);
//hashtable.Add("C", DateTime.Now);

//hashtable.Remove("C");

//Console.WriteLine(hashtable["A"]);

//foreach (DictionaryEntry entry in hashtable)
//{
//    Console.WriteLine(entry.Key);
//    Console.WriteLine(entry.Value);
//}




//Dictionary<int, string> dict = new();
//dict.Add(1, "B");
//dict.Add(2, "B");
//dict.Add(3, "C");

//dict.Remove(2);

//Console.WriteLine(dict[1]);

//foreach (KeyValuePair<int, string> entry in dict)
//{
//    Console.WriteLine($"{entry.Key} {entry.Value}");
//}




//Stack stack = new Stack();
//stack.Push(numbers);
//stack.Push(12);
//stack.Push("ABC");
//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Pop());




//Stack<string> stack = new();
//stack.Push("ABC");
//stack.Push("JHG");
//stack.Push("FDD");
//Console.WriteLine(stack.Pop());
//Console.WriteLine(stack.Peek());
//Console.WriteLine(stack.Pop());



//Queue queue = new();
//queue.Enqueue(123);
//queue.Enqueue("AZEE");
//queue.Enqueue(numbers);
//Console.WriteLine(queue.Peek());
//Console.WriteLine(queue.Dequeue());
//Console.WriteLine(queue.Dequeue());
//foreach (var entry in queue) Console.WriteLine($"{entry}");



Queue<string> queue = new();
queue.Enqueue("AZEE");
queue.Enqueue("JHG");
queue.Enqueue("HGFD");
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
foreach (var entry in queue) Console.WriteLine($"{entry}");



