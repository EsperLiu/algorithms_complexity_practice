// See https://aka.ms/new-console-template for more information
using Stack;

Console.WriteLine("Hello, World!");

MyStack s = new MyStack(5);

s.PrintStack();
s.Push(5);
s.Push(4);
s.Push(3);
s.Push(2);
s.Push(1);
s.Push(43);
Console.WriteLine("Peaking: top is " + s.Peak());
s.Pop();
s.Pop();
s.Push(9);
s.Pop();
s.Pop();
s.Pop();
s.Pop();