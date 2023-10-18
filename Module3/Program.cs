// Module 3: More On Classes
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lesson: Destructors
/*
class Dog
{
    public Dog()
    {
        Console.WriteLine("Constructor");
    }
    ~Dog()
    {
        Console.WriteLine("Destructor");
    }
}

static void Main(string[] args)
{
    Dog d = new Dog();
}
*/

// Coding Practice: Who Won?

/*
Five participants have advanced to the final round of a TV trivia show, and it is time to announce the winner and end the game.
The program you are given defines the array of finalists, takes the index of the winner as input, and creates the FinalRound object.
Complete the FinalRound class by writing the needed code in constructor to take the array and the winner index as parameters and output the corresponding message to show the winner. Then create a destructor to finish the game and output "Game Over".

Sample Input:
2

Sample Output:
Winner is Leyla Brown
Game Over
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] finalists = { "James Van", "John Smith", "Leyla Brown", "Tom Homerton", "Bob Douglas" };

            int winner = Convert.ToInt32(Console.ReadLine());

            // this should show the winner and "Game Over"
            FinalRound finalRound = new FinalRound(finalists, winner);
        }
    }

    class FinalRound
    {
        public FinalRound(string[] finalists, int winner)
        {
            // your code here: complete the constructor
            //Console.WriteLine("Winner is ");
            Console.WriteLine("Winner is " + finalists[winner]);
            Console.WriteLine("Game Over");
        }
        
        // your code here: create destructor => "Game Over"
        ~FinalRound()
        {

        }
    }
}
*/

// Lesson: Static Members
/*
class Cat 
{
    public static int count=0;
    public Cat() 
    {
        count++;
    }
}
class Dog
{   
    public static void Bark()
    {
        Console.WriteLine("Woof");
    }
}
class MathClass
{
    public const int ONE = 1;
}
class SomeClass
{
    public static int X { get; set; }
    public static int Y { get; set; }

    static SomeClass() 
    {
        X = 10;
        Y = 20;
    }
}
static void Main(string[] args)
{
    Cat c1 = new Cat();
    Cat c2 = new Cat();

    Console.WriteLine(Cat.count);
    Dog.Bark();

    Console.Write(MathClass.ONE);
}
*/

// Coding Practice: Grow Your Business

/*
A company has 2 departments and it is growing, so more departments are needed.
The program you are given takes the number of departments to be opened as input, then takes their names and creates Department objects, passing their names as the constructor.
Complete the Department class to have 1 static member depCount with an initial value of 2 for the number of departments and the constructor that will count it and output corresponding message (see sample output).

Sample Input:
2
Finance
Marketing

Sample Output:
Department opened: Finance
Department opened: Marketing
Number of departments: 4

Explanation:
The first input represents the number of departments to be opened, followed by their names.
As a result, the program outputs the corresponding messages (the 1st and the 2nd outputs) and the total number of departments: 2 (initial) + 2 (opened) = 4.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDeps = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            while (count < numOfDeps)
            {
                string depName = Console.ReadLine();
                Department dep = new Department(depName);
                count++;
            }

            Console.WriteLine("Number of departments: " + Department.depCount);
        }
    }
    class Department
    {
        
        public string depName;

        // your code here: declare static depCount member with value of 2
        public static int depCount = 2;

        public Department(string name)
        {
            Console.WriteLine("Department opened: " + name);
            this.depName = name;
            // your code here: complete the constructor
            depCount++;
        }
    }
}
*/

// Lesson: Static Classes
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Pow(2, 3));

            int[] arr = {1, 2, 3, 4};

            Array.Reverse(arr);
            //arr = {4, 3, 2, 1}

            Array.Sort(arr);
            //arr = {1, 2, 3, 4}

            string s1 = "some text";
            string s2 = "another text";

            String.Concat(s1, s2); // combines the two strings
            String.Equals(s1, s2); // returns false

            DateTime.Now; // represents the current date & time
            DateTime.Today; // represents the current day

            DateTime.DaysInMonth(2016, 2); 
            //return the number of days in the specified month 
        }
    }
}
*/

// Coding Practice: Array Sorting

/*
The program you are given takes the N number as the size of an array, followed by N numbers.
Complete the program to sort and output every element of an array, each on a new line.

Sample Input:
4
1
14
3
5

Sample Output:
1
3
5
14
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = Convert.ToInt32(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            // your code goes here
            Array.Sort(numbers);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
*/

// Lesson: this & readonly

/*
readonly string name; // OK
const double PI; // Error

readonly double a = Math.Sin(60); // OK
const double b = Math.Sin(60); // Error! 

namespace SoloLearn
{
    class Person
    {
        private readonly string name = "John";
        public Person(string name) 
        {
            this.name = name;
        }
    }
}
*/

// Coding Practice: All About This

/*
The program you are given takes 2 numbers as input and should calculate and output their average. But something is wrong.
Complete the Avg class by creating the constructor, where the 2 parameters will be assigned to members of the class.

Sample Input:
5.0
4.0

Sample Output:
4.5
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());

            Avg avg = new Avg(num1, num2);

            Console.WriteLine(avg.GetAvg());
        }
    }

    class Avg
    {
        double num1;
        double num2;
        
        // your code here: create the constructor
        public Avg(double n1, double n2)
        {
            this.num1 = n1;
            this.num2 = n2;
        }

        public double GetAvg()
        {
            return (num1 + num2)/2;
        }
    }
}
*/

// Lesson: Indexers
/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            char x = str[4];
            Console.WriteLine(x);
        }
    }

    class Clients {
        private string[] names = new string[10];

        public string this[int index] {
            get {
                return names[index];
            }
            set {
                names[index] = value;
            }
        }
        Clients c = new Clients();
        c[0] = "Dave";
        c[1] = "Bob";

        Console.WriteLine(c[1]);
    }
}
*/

// Coding Practice: Music Selector

/*
The music app you enjoy allows you to choose 5 music genres to follow.
The program you are given takes 5 music genres as input and stores them in the MusicGenres object as an array.
Fix the program by declaring an indexer inside the MusicGenres class so that the given outputs work correctly.

Sample Input:
Blues
Rock
Hip Hop
Country
Soul

Sample Output:
Following: Blues
Following: Rock
Following: Hip Hop
Following: Country
Following: Soul
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicGenres genres = new MusicGenres();

            int count = 0;
            while (count<5)
            {
                genres[count] = Console.ReadLine();
                count++;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Following: " + genres[i]);
            }
        }
    }
    class MusicGenres
    {
        private string[] genres = new string[5];
        
        //declare an indexer
        public string this[int index]{
            get{
                return genres[index];
            }
            set{
                genres[index] = value;
            }
        }
    }
}
*/

// Lesson: Operator Overloading
/*
static void Main(string[] args)
{
    Box b1 = new Box(14, 3);
    Box b2 = new Box(5, 7);
    Box b3 = b1 + b2;

    Console.WriteLine(b3.Height); 
    Console.WriteLine(b3.Width); 
}
class Box
{
    public int Height { get; set; }
    public int Width { get; set; }
    public Box(int h, int w)
    {
        Height = h;
        Width = w;
    }
    public static Box operator+(Box a, Box b)
    {
        int h = a.Height + b.Height;
        int w = a.Width + b.Width;
        Box res = new Box(h, w);
        return res;
    }
}
*/

// Coding Practice: Teamwork Makes the Dream Work

/*
You and your friend are playing a game as one team. Each player must pass 2 rounds and gets points for each round passed.
The program you are given creates two Score objects where each round scores are stored (they are passed to a constructor).
Overload the + operator for the Score class to calculate the team score for every round.
*/

/*
namespace SoloLearn
{
    class Program
    {

        static void Main(string[] args)
        {
            Score tm1 = new Score(2, 3);
            Score tm2 = new Score(4, 2);

            Score finalScores = tm1 + tm2;


            Console.WriteLine("Round 1: " + finalScores.round1Score);
            Console.WriteLine("Round 2: " + finalScores.round2Score);
        }
    }
    class Score
    {
        public int round1Score { get; set; }
        public int round2Score { get; set; }
        public Score(int r1, int r2)
        {
            round1Score = r1;
            round2Score = r2;
        }
        
        // your code goes here
        public static Score operator+(Score s1, Score s2)
        {
            int r1 = s1.round1Score + s2.round1Score;
            int r2 = s1.round2Score + s2.round2Score;

            Score res = new Score(r1,r2);
            return res;
        }
    }
}
*/

// Coding Practice: Dance

/*
In a ballroom dancing competition, each dancer from a pair is evaluated separately, and then their points are summed up to get the total pair score.
The program you are given takes the names and the points of each dancer as input and creates a DancerPoints objects for each dancer, using the taken name and score values as parameters for constructors.
Complete the given class, using overload + operator to return an new object where the names of dancers are in one string (see sample output) and the score is equal to the sum of their points.
The declaration of that object and the output of its points are already written in Main().

Sample Input:
Dave
8
Jessica
7

Sample Output:
Dave & Jessica
15
*/

/*
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            int points1 = Convert.ToInt32(Console.ReadLine());
            string name2 = Console.ReadLine();
            int points2 = Convert.ToInt32(Console.ReadLine());

            DancerPoints dancer1 = new DancerPoints(name1, points1);
            DancerPoints dancer2 = new DancerPoints(name2, points2);

            DancerPoints total = dancer1 + dancer2;
            Console.WriteLine(total.name);
            Console.WriteLine(total.points);
        }
    }

    class DancerPoints
    {
        public string name;
        public int points;
        public DancerPoints(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        // your code here: overload the + operator
        public static DancerPoints operator+ (DancerPoints a, DancerPoints b)
        {
            string name = a.name +" "+"&"+" "+ b.name ;
            int points = a.points + b.points ;
            DancerPoints total = new DancerPoints (name, points);
            return total ;
        }
    }
}
*/