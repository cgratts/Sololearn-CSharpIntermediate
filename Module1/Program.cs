// Module 1: Classes & Objects
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lesson: Classes & Objects
/*
class BankAccount
{
  //variables, methods, etc.
}
*/

// Lesson: Value & Reference Types (No code in this lesson)

// Lesson: Class Example
/*
static void Main(string[] args)
{
    Dog bob = new Dog();
    bob.name = "Bobby";
    bob.age = 3;
  
    Console.WriteLine(bob.age);
}

class Dog
{
    public string name;
    public int age;
}
*/

// Coding Practice: Welcome!

/*
Define a class Welcome which has one public method called WelcomeMessage, and should print "Welcome to OOP" when called.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            // your code here: create a Welcome object with the same name
            Welcome welcome = new Welcome();
            
            welcome.WelcomeMessage();
        }
    }
    
    class Welcome
    {
        // your code here: complete the class, add WelcomeMessage() method
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to OOP");
        }
    }
}
*/

// Lesson: Encapsulation
/*
class BankAccount
{
    private double balance=0;
    public void Deposit(double n)
    {
        balance += n;
    }
    public void Withdraw(double n)
    {
        balance -= n;
    }
    public double GetBalance()
    {
        return balance;
    }
}
*/

// Coding Practice: Calculating Wins

/*
We are developing a profile system for player of our online game.
The program already takes the number of games and wins as input and creates a player object.
Complete the GetWinRate() method inside the given Player class to calculate and output the win rate.

Sample Input:
130
70

Sample Output:
53

Explanation:
Win rate is calculated by this formula: wins*100/games. So, in this case win rate is 70*100/130 = 53 (the final result should be an integer).
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = Convert.ToInt32(Console.ReadLine()); 
            int wins = Convert.ToInt32(Console.ReadLine()); 

            //creating the player object
            Player player1 = new Player();
            player1.games = games;
            player1.wins = wins;

            //output
            player1.GetWinRate();
        }
    }
    
    class Player
    {
        public int games;
        public int wins;
        //winrate is private
        private int winrate;

        //complete the method
        public void GetWinRate()
        {
            // your code here
            Console.WriteLine((wins*100)/games);
        }
    }
}
*/

// Lesson: Constructors
/*
static void Main(string[] args)
{   
    Person p = new Person("David");
    Console.WriteLine(p.getName());
}

class Person
{
    private int age;
    private string name;
    
    public Person(string nm)
    {
        name = nm;
    }
    public string getName()
    {
        return name;
    }
}
*/

// Coding Practice: Creating a Project

/*

Your graphic application needs to report that a new project has been created successfully once the "Create" button has been pressed.
Complete the given class by adding a constructor that will show message "Project created" once the operation is done.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project();
        }
    }
    class Project
    {
        // your code here: create a constructor to show "Project created"
        public Project()
        {
            Console.WriteLine("Project created");
        }
        
    }
}
*/

// Lesson: Properties
/*
static void Main(string[] args)
{
    Person p = new Person();
    p.Name = "Bob";
    Console.WriteLine(p.Name);
}

class Person
{
    private string name; //field
    public string Name //property
    {
        get { return name; }
        set { 
            if(value == "Bob")
                name = value; 
        } // comment this out for "read-only" name
    }
}
*/

// Coding Practice: Card Numbers

/*
The program you are given should output the account number on the bank card.
But something is wrong.
Create a get property to access the corresponding class member and also fix the output.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card1 = new Card();

            //fix the output
            //Console.WriteLine(card1.accountNum);
            Console.WriteLine(card1.getAccountNum);
        }
    }
    class Card
    {
        private string accountNum = "0011592048120";
        // your code here: create a property to get the account
        public string getAccountNum
        {
            get {return accountNum;}
        }  
    }
}
*/

// Auto-Implemented Properties
/*
static void Main(string[] args)
{
    Person p = new Person();
    p.Name = "Bob";
    Console.WriteLine(p.Name);
}
// Outputs "Bob"
class Person
{
    public string Name { get; set; }
}
*/

// Coding Practice: Social Network

/*
You are making a social network application and want to add post creation functionality.
As a user creates a post, the text "New post" should be automatically outputted so that then the user can add the text he/she wants to share.
The program you are given declares a Post class with a text private field, and the ShowPost() method which outputs the content.

Complete the class with:
- a constructor, which outputs "New post" as called,
- Text property, which will allow you to get and set the value of the text field.

Once you have made the changes to the program so that it works correctly, then in main, the program will take the text of the post from the user, create a post object, assign the taken value to the text field and output it.

Sample Input:
Hello!

Sample Output:
New post
Hello!
*/

/*
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string postText = Console.ReadLine();

            Post post = new Post();
            post.Text = postText;
            post.ShowPost();

        }
    }

    class Post
    {
        private string text;
        
        // your code here: write a constructor
        public Post()
        {
            Console.WriteLine("New post");
        }
        public void ShowPost()
        {
            Console.WriteLine(text);
        }
        
        // your code here: write a property for member text
        public string Text
        {
            get {return text;}
            set {text = value;}
        }
    }
}
*/