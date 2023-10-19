// Module 4: Inheritance & Polymorphism
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Lesson: Inheritance
/*
static void Main(string[] args)
{
    Dog d = new Dog();
    Console.WriteLine(d.Legs);
    
    // Outputs 4
    d.Bark();

    Student s = new Student();
    // Outputs Hi there
    s.Speak();
}

class Animal
{
    public int Legs {get; set;}
    public int Age {get; set;}
}

class Dog : Animal
{
    public Dog()
    {
        Legs = 4;
    }
    public void Bark()
    {
        Console.Write("Woof");
    }
}
class Person
{
    public void Speak()
    {
        Console.WriteLine("Hi there");
    }
}
class Student : Person
{
    int number;
}
*/

// Coding Practice: Make and Model

/*
The program you are given takes the brand and model of the car as input, and defines a Vehicle class with model property and ShowModel() method.
Complete the Car class to inherit the Vehicle class, and add the Model property and ShowModel() method so that the given method call of the car object works correctly(see sample output).

Sample Input:
BMW
5 Series

Sample Output:
Brand: BMW
Model: 5 Series
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string brandName = Console.ReadLine();
            string modelName = Console.ReadLine();

            Car car = new Car();
            car.Brand = brandName;
            car.Model = modelName;

            car.ShowBrand();
            car.ShowModel();
        }
    }
    class Vehicle
    {
        public string Brand { get; set; }

        public void ShowBrand()
        {
            Console.WriteLine("Brand: " + Brand);
        }
    }
    
    // your code here: complete the Car class
    class Car : Vehicle
    {
        public string Model { get; set; }
        
        public void ShowModel()
        {
            Console.WriteLine("Model: " + Model);
        }
    }
}
*/

// Lesson: Protected Members
/*
static void Main(string[] args)
{
    Student s = new Student("David");
    s.Speak();
    //s.Name = "Bob"; //Error
}

class Person
{   protected int Age {get; set;}
    protected string Name {get; set;}
}
class Student : Person
{
    public Student(string nm) 
    {
        Name = nm;
    }
    public void Speak() 
    {
        Console.Write("Name: "+ Name);
    }
}

sealed class Animal 
{
    //some code
}
// class Dog : Animal { } // Error
*/

// Coding Practice: What's My Account Balance?

/*
The program you are given takes an account number and its balance as input.
It defines Account class with 1 member balance and derives User class from it with 1 additional member - the account number, then creates a user object and tries to store the balance and account number in it, and shows the details. But something is wrong.
Fix the program so that it completes the User() constructor, which should assign the parameters to the corresponding members of the User class.
Also, check the access modifier of balance member of Account class.

Sample Input:
005615216
1488.36

Sample Output:
Account N: 005615216
Balance: 1488.36
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string accNumber = Console.ReadLine();
            double balance = Convert.ToDouble(Console.ReadLine());

            User user = new User(accNumber, balance);

            user.ShowDetails();

        }
    }

    class Account
    {
        //private double Balance { get; set; }
        protected double Balance { get; set; }
    }

    class User : Account
    {
        public string AccNumber { get; set; }
        
        // your code here: complete the constructor
        public User(string accNumber, double balance)
        {
            Balance = balance;
            AccNumber = accNumber;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Account N: " + AccNumber);
            Console.WriteLine("Balance: " + Balance);
        }
    }
}
*/

// Lesson: Derived Class Constructor & Destructor
/*
class Animal
{
    public Animal() 
    {
        Console.WriteLine("Animal created");
    }
    ~Animal() 
    {
        Console.WriteLine("Animal deleted");
    }
}
class Dog: Animal 
{
    public Dog() 
    {
        Console.WriteLine("Dog created");
    }
    ~Dog() 
    {
        Console.WriteLine("Dog deleted");
    }
}
*/

// Coding Practice: Where Are The Planes?

/*
You are the airport administrator responsible for setting flight statuses.
At first the flight program was showing only "Registration" and "Closed" statuses, but we need to expand it to give more detailed information.

Derive WayStatus class from Flight class and complete its
1. constructor, to output "On the way"
2. destructor, to output "Landed"
so that the program correctly outputs all the statuses of the flight.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            WayStatus status = new WayStatus();
        }
    }
    class Flight
    {
        public Flight()
        {
            Console.WriteLine("Registration");
        }
        ~Flight()
        {
            Console.WriteLine("Closed");
        }
    }
    // your code here: derive this class from Flight class,
    //define constructor and destructor for it
    class WayStatus: Flight
    {
        public WayStatus()
        {
            Console.WriteLine("On the way");
        }
        ~WayStatus()
        {
            Console.WriteLine("Landed");
        }
    }
}
*/

// Lesson: Polymorphism
/*
static void Main(string[] args) 
{
    Shape c = new Circle();
    c.Draw();

    Shape r = new Rectangle();
    r.Draw();
}

class Circle : Shape 
{
    public override void Draw() 
    {
        // draw a circle...
        Console.WriteLine("Circle Draw");
    }
}
class Rectangle : Shape
 {
    public override void Draw() 
    {
        // draw a rectangle...
        Console.WriteLine("Rect Draw");
    }
}
*/

// Coding Practice: Attack!

/*

In a turn-based strategy game, each unit can attack.
The standard unit attacks with a sword. But there are two more types of units - musketeers and magicians, who attack in their own way.
The program you are given declares Unit class which has a method Attack(). It outputs "Using sword!".
Derive Musketeer and Magician classes from the Unit class and override its Attack() method to output the corresponding messages while attacking:

Musketeer => "Using musket!"
Magician =>"Using magic!"
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit unit1 = new Unit();
            Unit musketeer = new Musketeer();
            Unit magician = new Magician();

            unit1.Attack();
            musketeer.Attack();
            magician.Attack();
        }
    }

    class Unit
    {
        public virtual void Attack()
        {
            Console.WriteLine("Using sword!");
        }
    }
    
    // your code here: derive the class from Unit class
    // and override Attack() method
    class Musketeer : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using musket!");
        }
    }
    // your code here: derive the class from Unit class
    // and override Attack() method
    class Magician : Unit
    {
        public override void Attack()
        {
            Console.WriteLine("Using magic!");
        }
    }
}
*/

// Lesson: Abstract Classes
/*
static void Main(string[] args) 
{
    Shape c = new Circle();
    c.Draw();
}
abstract class Shape 
{
   public abstract void Draw();
}
class Circle : Shape 
{
    public override void Draw() 
    {
        Console.WriteLine("Circle Draw");
    }
}
class Rectangle : Shape 
{
    public override void Draw() 
    {
        Console.WriteLine("Rect Draw");
    }
}*/

// Coding Practice: Perimeter Calculator

/*
The program you are given defines abstract class Figure and derives Rectangle and Triangle classes from it.
Add an abstract method Perimeter to class Figure, than override it in derived classes to calculate perimeters of already created Rectangle and Triangle objects.

Hint:
Perimeter of rectangle with width w and height h => 2*w+2*h.
Perimeter of triangle with sides s1, s2, s3 => s1+s2+s3.
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure rectangle = new Rectangle(5, 6);
            Figure triangle = new Triangle(4, 8, 3);

            Console.WriteLine(rectangle.Perimeter());
            Console.WriteLine(triangle.Perimeter());
        }
    }
    abstract class Figure
    {
        // your code here: define abstract method Perimeter with no body
        public abstract int Perimeter();  
    }
    class Rectangle : Figure
    {
        public int width;
        public int height;
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        //your code here: override Perimeter method for rectangle
        public override int Perimeter() 
        {
            int res = 2*width + 2*height;
            return res;
        }
    }
    class Triangle : Figure
    {
        public int side1;
        public int side2;
        public int side3;
        public Triangle(int s1, int s2, int s3)
        {
            this.side1 = s1;
            this.side2 = s2;
            this.side3 = s3;
        }
        
        // your code here: override Perimeter method for triangle
        public override int Perimeter() 
        {
            return side1+side2+side3;
        }
    }
}
*/

// Lesson: Interfaces
/*
static void Main(string[] args) 
{
    IShape c = new Circle();
    c.Draw();
}
public interface IShape
{
    void Draw();
}
class Circle : IShape 
{
    public void Draw() 
    {
        Console.WriteLine("Circle Draw");
    }
}
*/

// Coding Practice: Online Car Shopping

/*
On the car dealership website, you can pre-order a car by specifying its color and equipment.
The program you are given takes the color and the equipment type as input and pass them to constructor of already declared Car class.
Implement IColor and IEquipment interfaces for the Car class and reimplement their GetColor and GetEquipment methods inside it. Each of them should output corresponding message about color/equipment (see sample output).

Sample Input:
Blue
Standard

Sample Output:
Color: Blue
Equipment: Standard
*/

/*
namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string color = Console.ReadLine();
            string equipment = Console.ReadLine();

            Car car = new Car(color, equipment);

            car.GetColor();
            car.GetEquipment();
        }
    }

    public interface IColor
    {
        void GetColor();
    }

    public interface IEquipment
    {
        void GetEquipment();
    }
    
    // your code here: implement IColor & IEquipment interfaces
    public class Car : IColor, IEquipment
    {
        public string color;
        public string equipment;

        public Car(string color, string equipment)
        {
            this.color = color;
            this.equipment = equipment;
        }
        
        // your code here: reimplement this method
        public void GetColor()
        {
            Console.WriteLine("Color: " + this.color);
        }
        // your code here: reimplement this method
        public void GetEquipment()
        {
            Console.WriteLine("Equipment: " + this.equipment);
        }
    }
}
*/

// Default Implementation
/*
public interface IShape 
{
    void Draw();
    void Finish()
    {
        Console.WriteLine("Done!");
    }
}
class Circle : IShape 
{
    public void Draw() 
    {
        Console.WriteLine("Circle Draw");
    }
}
static void Main(string[] args) 
{
    IShape c = new Circle();
    c.Draw();
    c.Finish();
} 
*/

// Lesson: Nested Classes
/*
class Car 
{
    string name;
    public Car(string nm) 
    {
        name = nm;
        Motor m = new Motor();
    }
  public class Motor 
  {
    // some code
  }
}
*/

// Lesson: Namespaces
/*
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace SoloLearn 
{
    class Program 
    {
        static void Main(string[] args) 
        {

        }
    }
}
*/

// Coding Challenge: Drawing Application

/*
You are creating a drawing application and currently have only 1 tool - a pencil. You want to add brush and spray to the drawing toolbar.
The program you are given declares an IDraw interface with the StartDraw() method, and class Draw, which performs pencil drawing by implementing the IDraw interface. It outputs "Using pencil".
Complete the given Brush and Spray classes by:
- inheriting them from class Draw
- implementing the StartDraw() method for each tool, in order to output:

"Using brush" for Brush, or
"Using spray" for Spray.

The Draw objects and their method calls are provided in Main().
*/

/*
namespace Code_Coach_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Draw brush = new Brush();
            Draw spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();

        }
    }

    
    // Draw => "Using pencil"
    // Brush => "Using brush"
    // Spray => "Using spray"

    public interface IDraw
    {
        void StartDraw();
    }
    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }
    // your code here: inherit this class from the class Draw
    class Brush : Draw
    {
        // your code here: implement the StartDraw() method
        public override void StartDraw()
        {
            Console.WriteLine("Using brush");
        }

    }
    // your code here: inherit this class from the class Draw
    class Spray : Draw
    {
        // your code here: implement the StartDraw() method
        public override void StartDraw()
        {
            Console.WriteLine("Using spray");
        }

    }
}
*/