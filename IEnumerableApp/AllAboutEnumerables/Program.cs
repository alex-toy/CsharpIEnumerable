
int[] myArray = new int[] { 1, 2, 3, 4, 5 };

IEnumerable<int> myArrayAsEnumerable = myArray as IEnumerable<int>;

foreach (var item in myArray) Console.WriteLine(item);

foreach (var item in myArrayAsEnumerable) Console.WriteLine(item);

//// we cannot use for loops with indexing on IEnumerables! indexing is not
//// supported by IEnumerable, but it does work for arrays
//for (int i = 0; i < myArray.Length; i++) Console.WriteLine(myArray[i]);

////we can't even get the length of the enumerable!
////for (int i = 0; i < myArrayAsEnumerable.Length; i++) Console.WriteLine(myArrayAsEnumerable[i]);

//List<int> myList = new List<int> { 6, 7, 8, 9, 10 };

//IEnumerable<int> myListAsEnumerable = myList as IEnumerable<int>;

//foreach (var item in myList) Console.WriteLine(item);

//foreach (var item in myListAsEnumerable) Console.WriteLine(item);

////// let's have a quick look at what this means for return types!
//IEnumerable<string> FunctionThatReturnsAnArrayAsEnumerable()
//{
//    return new string[] { "A", "B", "C" };
//}

//IEnumerable<string> FunctionThatReturnsAListAsEnumerable()
//{
//    return new List<string> { "A", "B", "C" };
//}

//// we can use foreach
//Console.WriteLine("Using foreach on the array function...");
//foreach (var item in FunctionThatReturnsAnArrayAsEnumerable())
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Using foreach on the list function...");
//foreach (var item in FunctionThatReturnsAListAsEnumerable())
//{
//    Console.WriteLine(item);
//}

////// why would we want to do this? are there any implications?
////// :) let's find out in the next part!