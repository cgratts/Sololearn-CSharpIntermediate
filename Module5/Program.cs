// Module 5: Structs, Enums, Exceptions & Files
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lesson: Structs
/*
struct Book 
{
    public string title;  
    public double price;
    public string author;
}
struct Point 
{
    public int x;
    public int y;
    public Point(int x, int y) 
    {
        this.x = x;
        this.y = y;
    }
}

static void Main(string[] args)
 {
    Book b;
    b.title = "Test";
    b.price = 5.99;
    b.author = "David";

    Console.WriteLine(b.title);

    Point p = new Point(10, 15);
    Console.WriteLine(p.x);
}
*/

// Coding Challenge: Fun With Dimensions

/*
A cuboid is a three-dimensional shape with a length, width, and a height.
The program you are given takes takes those dimensions as inputs, defines Cuboid struct and creates its object. 
Complete the program by creating a constructor, which will take the length, the width, and the height as parameters and assign them to its struct members. 
Also complete Volume() and Perimeter() methods inside the struct, to calculate and return them, so that the given methods calls work correctly.

Sample Input:
5
4
5

Sample Output:
Volume: 100
Perimeter: 56
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());

            Cuboid cuboid = new Cuboid(length, width, height);

            Console.WriteLine("Volume: " + cuboid.Volume());
            Console.WriteLine("Perimeter: " + cuboid.Perimeter());
        }
    }
    struct Cuboid
    {
        public int length;
        public int width;
        public int height;

        // your code here: create a constructor
        public Cuboid(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        
        // your code here: complete this method
        public int Volume()
        {
            return length*width*height;
        }
        // your code here: complete this method
        public int Perimeter()
        {
            return 4*(length+width+height);
        }
    }
}
*/

// Lesson: Enums
/*
enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat }; 
enum TrafficLights { Green, Red, Yellow };

static void Main(string[] args) 
{
    int x = (int)Days.Tue;
    Console.WriteLine(x);

    TrafficLights x = TrafficLights.Red;
    switch (x) 
    {
        case TrafficLights.Green:
        Console.WriteLine("Go!");
        break;
        case TrafficLights.Red:
        Console.WriteLine("Stop!");
        break;
        case TrafficLights.Yellow:
        Console.WriteLine("Caution!");
        break;
    }
}
*/

// Coding Challenge: Accelerate!

/*
A racing video game has 3 difficulty levels: Easy, Medium, and Hard.
Each difficulty level is assigned maximum time to complete the track: the higher the difficulty, the lower the time.
The program you are given defines Player class and Difficulty enum, and creates 3 Player objects with different difficulties as parameter for the constructor.
Complete the Player constructor, which takes the enum as a parameter to check the time for each difficulty option and outputs the corresponding message:

Easy => "You have 3 minutes 45 seconds"
Medium = > "You have 3 minutes 20 seconds"
Hard => "You have 3 minutes"
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {

            Player player1 = new Player(Difficulty.Easy);
            Player player2 = new Player(Difficulty.Medium);
            Player player3 = new Player(Difficulty.Hard);
        }
    }
    
    
    // Easy => "You have 3 minutes 45 seconds"
    // Medium = > "You have 3 minutes 20 seconds"
    // Hard => "You have 3 minutes"
    

    class Player
    {
        public Player(Difficulty x)
        {
            // your code goes here
            switch (x)
            {
                case Difficulty.Easy:
                Console.WriteLine("You have 3 minutes 45 seconds");
                break;
                case Difficulty.Medium:
                Console.WriteLine("You have 3 minutes 20 seconds");
                break;
                case Difficulty.Hard:
                Console.WriteLine("You have 3 minutes");
                break;            
            }
        }
    }
     enum Difficulty
    {
        Easy,
        Medium,
        Hard
    };
}
*/

// Lesson: Exception Handling
/*
try 
{
    int[] arr = new int[] { 4, 5, 8 };
    Console.Write(arr[8]);
}
catch(Exception e) 
{
    Console.WriteLine(e.Message);
}
// Index was outside the bounds of the array.
*/

// Handling Multiple Exceptions
/*
int x, y;

try 
{
    x = Convert.ToInt32(Console.Read());
    y = Convert.ToInt32(Console.Read());
    Console.WriteLine(x / y);
}
catch (DivideByZeroException e) 
{
    Console.WriteLine("Cannot divide by 0");
}
catch(Exception e) 
{
    Console.WriteLine("An error occurred");
}
*/

// Finally
/*
int result=0;
int num1 = 8;
int num2 = 4;

try 
{
    result = num1 / num2;
}
catch (DivideByZeroException e) 
{
    Console.WriteLine("Error");
}
finally 
{
    Console.WriteLine(result);
}
*/

// Coding Practice: Going On Vacation

/*
A tour operator offers package holidays in England, Spain, Italy, Portugal and France.
The program you are given defines an array with those options and takes N number as input.
Write a program to output the package option with N index. If the number is out of range, program should output "Wrong number". Regardless of the option results, the program should output "Goodbye" at the end.

Sample Input:
2

Sample Output:
Italy

Goodbye
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());
            
            // your code goes here
            try
            {
                Console.WriteLine(tours[choice]);
            }
            catch
            {
                Console.WriteLine("Wrong number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}
*/

// Lesson: Working with Files
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Some text";
            File.WriteAllText("test.txt", str);

            string txt = File.ReadAllText("test.txt");
            Console.WriteLine(txt); 
        }
    }
}
*/

// Coding Practice: Robot-barmen

/*
You have a robot-barman and his goal is to neatly arrange drinks on the shelves of the bar. He is very smart and takes as many drinks as are necessary to evenly distribute them on the shelves, but he still has problems with division.
The program installed in the robot takes the number of drinks and the number of the shelves as input.
Complete the program to evenly distribute the drinks on shelves: by dividing the number of drinks by the number of shelves and outputting the result.
The program must also, handle those two possible problems:

1. the divider (the number of shelves) should never be zero
2. both inputs should be integers.

For the first exception, the program should output "At least 1 shelf" and for the second, "Please insert an integer".

Sample Input:
6
two

Sample Output:
Please insert an integer
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                // your code goes here
                int res = drinks / shelves;
                Console.WriteLine(res);
            }
            // 1. DivideByZeroException => "At least 1 shelf"
            // 2. FormatException => "Please insert an integer"
            // your code goes here
            catch (DivideByZeroException e)
            {
                Console.WriteLine("At least 1 shelf");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please insert an integer");
            }
        }
    }
}
*/

