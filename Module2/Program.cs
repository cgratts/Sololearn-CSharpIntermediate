// Module 2: Arrays and Strings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lesson: Arrays
/*
static void Main(string[] args)
{
    int[ ] myArray = new int[5];
    myArray[0] = 23;

    string[ ] names = {"John", "Mary", "Jessica"};
    double[ ] prices = {3.6, 9.8, 6.4, 5.9};

    int[ ] b = {11, 45, 62, 70, 88};
    Console.WriteLine(b[2]);
    Console.WriteLine(b[3]);
}
*/

// Coding Practice: Solve The Puzzle

/*
A game machine has 5 games installed on it:
string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" }; 

Write a program to take N number as input and output the corresponding game with N index from the array.
If user enters an invalid number that is out of array range, the program should output "Invalid number".

Sample Input:
3

Sample Output:
Puzzle
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] games = { "Alien Shooter", "Tic Tac Toe", "Snake", "Puzzle", "Football" };

            // your code goes here
            int n = Convert.ToInt32(Console.ReadLine());

            if(n > 4)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                Console.WriteLine(games[n]);
            }
        }
    }
}
*/

// Lesson: Using Arrays in Loops
/*
static void Main(string[] args)
{
    int[ ] a = new int[10];
    
    for (int k = 0; k < 10; k++)
    {
        a[k] = k*2;
    }

    int[ ] arr = {11, 35, 62, 555, 989};
    int sum = 0; 

    foreach (int x in arr)
    {
        sum += x;
    }

    Console.WriteLine(sum);
}
*/

// Coding Practice: Only The Evens!

/*
The program you are given takes 5 numbers as input and stores them in an array.
Complete the program to go through the array and output the the sum of even numbers.

Sample Input:
10
890
15
3699
14

Sample Output:
914

Hint:
An integer is even if it is divisible by two, so it means that n number is even if n%2 equals 0.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            int count = 0;
            while (count <5)
            {
                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
            // your code goes here
            int evenSum = 0;
            
            foreach(int x in numbers)
            {
                if(x % 2 == 0)
                {
                    evenSum += x;
                }
            }

            Console.WriteLine(evenSum);
        }
    }
}
*/

// Lesson: Multidimensional Arrays
/*
static void Main(string[] args)
{
    int[ , ] someNums = { {2, 3}, {5, 6}, {4, 6} };

    for (int k = 0; k < 3; k++) 
    {
        for (int j = 0; j < 2; j++) 
        {
            Console.Write(someNums[k, j]+" ");
        }
        Console.WriteLine();
    }
}
*/

// Coding Practice: Array to Table

/*
Follow multidimensional array that is given:
int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; 

Complete the program to output this array in the form of a table (without separation):
123
456
789
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            //your code goes here
            for (int k = 0; k < 3; k++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    Console.Write(num[k,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
*/

// Lesson: Jagged Arrays
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ ][ ] jaggedArr = new int[ ][ ] 
            {
                new int[ ] {1,8,2,7,9},
                new int[ ] {2,4,6},
                new int[ ] {33,42}

                int x = jaggedArr[2][1]; //42
            };
        }
    }
}
*/

// Coding Practice: Qualifying For The Olympics

/*

The qualifiers for the Olympiad lasts 3 days, and one winner is selected each qualifying day.
The jagged array you are given represents the list of all participants, divided by the number of days
(there are 3 arrays inside the main one, each representing the participants who took part on that day).

string[][] olympiad = new string[][]
{
    //day 1 => 5 participants
    new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
    //day 2 => 7 participants
    new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
    //day 3 => 4 participants
    new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana",}
}; 

Write a program to take the numbers of each day's winners as input and output them.

Sample Input:
2
3
4

Sample Output:
Bridgette Ramona
Fran Mayur
Kristian Dana

Explanation:
Day 1 winner is Bridgette Ramona (the 2nd participant of day 1)
Day 2 winner is Fran Mayur (the 3rd participant of day 2)
Day 3 winner is Kristian Dana (the 4th participant of day 3)
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int day1Winner = Convert.ToInt32(Console.ReadLine());
            int day2Winner = Convert.ToInt32(Console.ReadLine());
            int day3Winner = Convert.ToInt32(Console.ReadLine());


            string[][] olympiad = new string[][]
            {
                //day 1 - 5 participants
                new string[] { "Jill Yan", "Bridgette Ramona", "Sree Sanda", "Jareth Charlene", "Carl Soner" },
                //day 2 - 7 participants
                new string[] { "Anna Hel", "Mariette Vedrana", "Fran Mayur", "Drake Hilmar", "Nikolay Brooks", "Eliana Vlatko", "Villem Mario" },
                //day 3 - 4 participants
                new string[] { "Hieremias Zavia", "Ziya Ollie", "Christoffel Casper", "Kristian Dana", }

            };
            // your code goes here
            Console.WriteLine($"{olympiad[0][day1Winner-1]}");
            Console.WriteLine($"{olympiad[1][day2Winner-1]}");
            Console.WriteLine($"{olympiad[2][day3Winner-1]}");
        }
    }
}
*/

// Lesson: Array Properties & Methods
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[ ] arr = {2, 4, 7, 1};
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());

            for(int k=0; k<arr.Length; k++)
            {
                Console.WriteLine(arr[k]);
            }
        }
    }
}
*/

// Coding Practice: Maximum And Minimum

/*
Write a program to take 5 numbers as input, then calculate and output the sum of the maximum and the minimum inputted values.

Sample Input:
5
6
14
2
1

Sample Output:
15

Explanation:
The minimum value is 1, the maximum is 14. So 14+1 = 15 should be output.

Hint:
Create an array, use while loop to store the inputted numbers in it, and then do the calculations.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // your code goes here
            int i1 = Convert.ToInt32(Console.ReadLine());
            int i2 = Convert.ToInt32(Console.ReadLine());
            int i3 = Convert.ToInt32(Console.ReadLine());
            int i4 = Convert.ToInt32(Console.ReadLine());
            int i5 = Convert.ToInt32(Console.ReadLine());

            int[] arr = {i1, i2, i3, i4, i5};

            Console.WriteLine(arr.Max() + arr.Min());
        }
    }
}
*/

// Lesson: Working with Strings
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "some text";
            Console.WriteLine(a[2]);
            //Outputs "m"

            Console.WriteLine(a.Length);
            //Outputs 9

            Console.WriteLine(a.IndexOf('t'));
            //Outputs 5

            a = a.Insert(0, "This is ");
            Console.WriteLine(a);
            //Outputs "This is some text"

            a = a.Replace("This is", "I am");
            Console.WriteLine(a);
            //Outputs "I am some text"

            if(a.Contains("some"))
                Console.WriteLine("found");
                //Outputs "found"

            a = a.Remove(4);
            Console.WriteLine(a);
            //Outputs "I am"

            a = a.Substring(2);
            Console.WriteLine(a);
            //Outputs "am"
        }
    }
}
*/

// Coding Practice: Password Rules

/*
You are creating an authentication system.

The password shouldn't contain any of these symbols:
char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' }; 

The given program takes the password as input.

Task:
Write a program to output "Invalid", if  it contains any disallowed symbols.
If the password requirement is satisfied, program shouldn't output anything.

Sample Input:
yl1893!dm$

Sample Output:
Invalid

Hint:
The message should be output only once regardless of how many disallowed symbols the password contains.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            char[] notAllowedSymbols = { '!', '#', '$', '%', '&', '(', ')', '*', ',', '+', '-' };

            // your code goes here
           for(int i= 0; i<notAllowedSymbols.Length; i++)
           {
               if(password.Contains(notAllowedSymbols[i]))
               {
                   Console.WriteLine("Invalid");
                   break;
               }
               else
               {

               }
           }
        }
    }
}
*/

// Working with Strings
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is some text about a dog. The word dog appears in this text a number of times. This is the end.";
            text = text.Replace("dog", "cat");
            text = text.Substring(0, text.IndexOf(".")+1);
            
            Console.WriteLine(text);
        }
    }
}
*/

// Coding Practice: Words

/*

The program you are given defines an array with 10 words and takes a letter as input.
Write a program to iterate through the array and output words containing the taken letter.
If there is no such word, the program should output "No match".

Sample Input:
u

Sample Output:
fun
*/

/*
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;
            
            // your code goes here
            for(int i = 0; i < words.Length; i++)
            {
                if(words[i].Contains(letter))
                {
                    Console.WriteLine($"{words[i]}");
                    count++;
                }
            }

            if(count == 0)
            {
                Console.WriteLine("No match");
            }
        }
    }
}
*/