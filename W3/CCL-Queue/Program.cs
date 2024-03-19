// See https://aka.ms/new-console-template for more information
using CCL_Queue;

Console.WriteLine("Hello, World!");

// create and initiate a queue
IQueue myQueue = new CircularLinkedList();

// create objects to store in the queue;
bool aBoolean = true;
char aCharacter = 'c';
int anInteger = 123;
double aDouble = 3.14;
string aString = "hello world!";

// use method Enqueue to add items into the queue
myQueue.Enqueue(aBoolean);
myQueue.Enqueue(aCharacter);
myQueue.Enqueue(anInteger);
myQueue.Enqueue(aDouble);
myQueue.Enqueue(aString);

// use method IsFull to check if the queue is full
if (myQueue.IsFull())
    Console.WriteLine("The queue is full!");
else
    Console.WriteLine("The queue is not full!");


// use method Head to get the head item in the queue
Object obj = myQueue.Head();
Console.WriteLine("Head item: " + obj);

// use method Pop to remove the objects from the stack
while (!myQueue.IsEmpty())
    Console.WriteLine(myQueue.Dequeue());