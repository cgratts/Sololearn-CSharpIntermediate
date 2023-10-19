// Module 6: Generics
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lesson: Generic Methods
/*
static void Swap<T>(ref T a, ref T b) 
{
    T temp = a;
    a = b;
    b = temp;
}

static void Main(string[] args)
 {
    int a = 4, b = 9;
    Swap<int>(ref a, ref b);
    // Now b is 4, a is 9

    string x = "Hello";
    string y = "World";
    Swap<string>(ref x, ref y);
    // Now x is "World", y is "Hello"
}
*/

// Coding Practice: Print To Printer

/*

You are writing a program that can output the value of a variable of any type. It takes a string, an integer, and a double value as input and then it should output them.
Create a generic method Print for a Printer class to execute the given calls correctly.

Sample Input:
Hello
14
7.6

Sample Output:
Showing Hello
Showing 14
Showing 7.6
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());


            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
        }
    }
    class Printer
    {
        // your code goes here
        public static void Print<T>(T data) 
        {
            Console.WriteLine("Showing " + data);
        }
    }
}
*/

// Lesson: Generic Classes

class Stack<T> 
{
    int index=0;
    T[] innerArray = new T[100];
    public void Push(T item) 
    {
        innerArray[index++] = item; 
    }
    public T Pop() 
    {
        return innerArray[--index]; 
    }
    public T Get(int k) { return innerArray[k]; }
}

static void Main(string[] args)
{
    Stack<int> intStack = new Stack<int>();
    intStack.Push(3);
    intStack.Push(6);
    intStack.Push(7);
            
    Console.WriteLine(intStack.Get(1));
}

// Coding Practice: Generic All Around

/*
The class Elems creates a 3-sized array of integers, defines Add() and Show() methods to store the elements into the array, and shows them separated by a space.
Modify the class to make it generic to execute the same actions with string type, given in the Main function.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Elems<string> elems1 = new Elems<string>();
            elems1.Add("John", "Tamara", "David");
            elems1.Show();

            Console.WriteLine();

            Elems<int> elems2 = new Elems<int>();
            elems2.Add(5, 14, 13);
            elems2.Show();

        }
    }
    // your code here: make this class generic
    class Elems<T>
    {
        public T[] elements = new T[3];

        public void Add(T elem1, T elem2, T elem3)
        {
            elements[0] = elem1;
            elements[1] = elem2;
            elements[2] = elem3;
        }

        public void Show()
        {
            foreach (T item in elements)
            {
                Console.Write(item + " ");
            }
        }
    }
}
*/

// Lesson: Collections
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> li = new List<int>();
        }
    }

}
*/

// Lesson: Lists and BitArray

/*
List<int> li = new List<int>();
li.Add(59);
...
li.RemoveAt(1);

Console.Write("\nList: ");
for (int x = 0; x < li.Count; x++)
{
    Console.Write(li[x] + " ");
}
li.Sort();
Console.Write("\nSorted: ");
for (int x = 0; x < li.Count; x++)
{
    Console.Write(li[x] + " ");
}
*/

// Coding Practice: Top Of The Leaderboard

/*
You need to write a program for the game to sort player scores.
The program you are given takes N number as input, which represents the number of players, and defines a score list.
Complete the program to take N count of numbers (the scores) as input, store them in a scores list, sort and output them, each separated by a space.

Sample Input:
3
12
4
5

Sample Output:
4 5 12
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            List<int> scores = new List<int>();
            int count = 0;
            while (count<numOfPlayers)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                // your code goes here
                scores.Add(score);
                count++;
            }

            // your code here: sort the list and output elements
            scores.Sort();
            foreach (int playerScore in scores)
            {
                Console.Write(playerScore + " ");
            }
        }
    }
}
*/

// SortedList<K,V>

/*
SortedList<string, int> sl = new SortedList<string, int>();
sl.Add("Solo", 59);
sl.Add("A", 95);
sl.Add("Learn", 72);
sl.Remove("A");
Console.WriteLine("Sorted List: ");
foreach (string s in sl.Keys)
{
    Console.WriteLine(s + ": " + sl[s]);  // Learn: 72  Solo: 59
}
Console.WriteLine("\nCount: " + sl.Count);  // 2
*/

// BitArray
/*
static void Main(string[] args) 
{
    BitArray ba1 = new BitArray(4);
    BitArray ba2 = new BitArray(4);

    ba1.SetAll(true);
    ba2.SetAll(false);

    ba1.Set(2, false);
    ba2.Set(3, true);

    PrintBarr("ba1", ba1);
    PrintBarr("ba2", ba2);
    Console.WriteLine();
            
    PrintBarr("ba1 AND ba2", ba1.And(ba2));
    PrintBarr("    NOT ba2", ba2.Not());
}

static void PrintBarr(string name, BitArray ba) 
{
    Console.Write(name + " : ");
    for (int x = 0; x < ba.Length; x++)
    {
        Console.Write(ba.Get(x) + " ");
    }
    Console.WriteLine();
}
*/

// Lesson: Stack & Queue
/*
Stack<int> s = new Stack<int>();

s.Push(59);
...
Console.Write("Stack: ");
foreach (int i in s)
{
    Console.Write(i + " ");  // 65  72  59
}
Console.Write("\nCount: " + s.Count);  // 3

Console.Write("\nTop: " + s.Peek());  // 65
Console.Write("\nPop: " + s.Pop());  // 65

Console.Write("\nStack: ");
foreach (int i in s)
{
    Console.Write(i + " ");  // 72  59
}
Console.Write("\nCount: " + s.Count);  // 2
*/

/*
Queue<int> q = new Queue<int>();

q.Enqueue(5);
q.Enqueue(10);
q.Enqueue(15);
Console.Write("Queue: ");
foreach (int i in q)
{
    Console.Write(i + " ");  // 5  10  15
}
Console.Write("\nCount: " + q.Count);  // 3

Console.Write("\nDequeue: " + q.Dequeue()); // 5

Console.Write("\nQueue: ");
foreach (int i in q)
{
    Console.Write(i + " ");  // 10  15
}
Console.Write("\nCount: " + q.Count);  // 2
*/

// Coding Challenge: Queue It Up!

/*
Write a program that will take 3 numbers as input and store them in a defined queue.
Also, add code to output the sorted sequence of elements in the queue, separated by a space.

Sample Input:
6
3
14

Sample Output:
Queue: 6 3 14 
Sorted: 3 6 14 
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            while (q.Count<3)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                // your code goes here
                q.Enqueue(num);
            }

            Console.Write("Queue: ");
            foreach (int i in q)
                Console.Write(i + " ");

            Console.WriteLine();
            
            Console.Write("Sorted: ");
            // your code goes here
            int[] x = q.ToArray();
            Array.Sort(x);

            foreach (int i in x)
                Console.Write(i + " ");
        }
    }
}
*/

// Lesson: Dictionary & HashSet

/*
Dictionary<string, int> d = new Dictionary<string, int>();
d.Add("Uno", 1);
d.Add("One", 1);
...
d.Remove("One");  // Remove key-value pair One, 1
...
Console.WriteLine("Dictionary: ");
foreach (string s in d.Keys)
{
    Console.WriteLine(s + ": " + d[s]);  // Uno: 1  Deux: 2
}
Console.WriteLine("\nCount: {0}", d.Count); // 2 
*/

/*
HashSet<int> hs = new HashSet<int>();

hs.Add(5);
...
Console.Write("\nHashSet: ");
foreach (int i in hs)
{
    Console.Write(i + " ");  // 5  10  15  20  *elements may be in any order
} 
Console.Write("\nCount: " + hs.Count);  // 4

HashSet<int> hs2 = new HashSet<int>();
hs2.Add(15);
hs2.Add(20);
Console.Write("\n{15, 20} is a subset of {5, 10, 15, 20}: " + hs2.IsSubsetOf(hs)); // True
*/

// Coding Practice: Hiring Engineers!

/*

We are hiring programmers on our team. There are 10 candidates, and we need to choose 3 of them.
In the program you are given, you have 10 candidates in a hash set. You need to take 3 names as input, add them to a new hiring hash set and check if they are present in our candidates set.
If they are, the program should output "Starting hiring process", otherwise, "Something is wrong".

Sample Input:
John
Susan
Daniel

Sample Output:
Starting hiring process
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> candidates = new HashSet<string>();

            candidates.Add("John");
            candidates.Add("Amelie");
            candidates.Add("Tom");
            candidates.Add("Richard");
            candidates.Add("Barbara");
            candidates.Add("Susan");
            candidates.Add("Charles");
            candidates.Add("Daniel");
            candidates.Add("Tamara");
            candidates.Add("Donald");

            HashSet<string> hiring = new HashSet<string>();

            while (hiring.Count<3)
            {
                string hire = Console.ReadLine();
                // your code here: add the names to hiring hash set
                hiring.Add(hire);
            }
            // your code goes here
            if(hiring.IsSubsetOf(candidates))
            {
                Console.WriteLine("Starting hiring process");
            }
            else
            {
                Console.WriteLine("Something is wrong");
            }
        }
    }
}
*/

// Coding Practice: Coffee Time

/*
A coffee shop manager is running a promotion and wants to offer a discount for coffee drinks.
The program you are given takes the discount value as input and defines a dictionary, where the names of the coffee drinks are set as keys, and their prices are set as values.
Write a program to discount all of the prices and output a new price list in the format shown below.

Sample Input:
10

Sample Output:
Americano: 45
Latte: 63
Flat White: 54
Espresso: 54
Cappuccino: 72
Mocha: 81
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, double> coffee = new Dictionary<string, double>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);

            // your code goes here
            foreach (KeyValuePair<string, double> entry in coffee)
            {
                Console.WriteLine(entry.Key + ": " + (entry.Value - entry.Value * discount / 100));
            }
        }
    }
}
*/