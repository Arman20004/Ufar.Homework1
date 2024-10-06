// See https://aka.ms/new-console-template for more information

using Ufar.Homework;

//Console.WriteLine("Hello, World!");

//EasyStack<int> easyStack = new EasyStack<int>();
//easyStack.Push(1);
//easyStack.Push(2);
//easyStack.Push(3);
//easyStack.Push(4);


//easyStack.Pop();

//ArrayStack<string> arrayStack = new ArrayStack<string>();

//arrayStack.Push("Hello");
//arrayStack.Push("World");
//arrayStack.Push("!");
//arrayStack.Push("!");
//arrayStack.Push("!");

//arrayStack.Pop();
//arrayStack.Pop();
//arrayStack.Pop(); 

//Console.WriteLine(arrayStack.Peek()); // without removing the element

int[] array = { 64, 34, 25, 12, 22, 11, 90 };

//SortingAlgorithms.BubbleSortRecursive(array);
SortingAlgorithms.SelectionSortRecursive(array);

// Print the sorted array
foreach (var item in array)
{
    Console.WriteLine(item);
}


EasyQueue<string> queue = new EasyQueue<string>();

queue.Push("!");
queue.Push("a");
queue.Push("b");
queue.Push("c");

Console.WriteLine(queue.Peek());

queue.Pop();

Console.WriteLine(queue.Peek());

