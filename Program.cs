
//Arrays
Console.WriteLine("\nARRAY");
// Array of integers
int[] numbers = { 1, 2, 3, 4, 5 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Accessing elements
int firstNumber = numbers[0];   // Accessing the first element (index 0)
Console.WriteLine("First Number: "+firstNumber);
numbers[2] = 10;               // Modifying an element
Console.WriteLine("After modifying 3rd number: ");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}


//---------------------------------------------------------------------------

//List
Console.WriteLine("\nLIST");

// List of strings
List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
foreach (var name in names)
{
    Console.WriteLine(name);
}

// Adding elements
names.Add("David");
Console.WriteLine("After adding David");
foreach (var name in names)
{
    Console.WriteLine(name);
}

// Accessing elements
string firstPerson = names[0];   // Accessing the first element (index 0)
Console.WriteLine("First Person: "+firstPerson);

names[2] = "Eve";               // Modifying an element
Console.WriteLine("After Modifying 3rd name: ");

// Iterating over elements
foreach (var name in names)
{
    Console.WriteLine(name);
}


//------------------------------------------------------------------------

//Dictionary
Console.WriteLine("\nDICTIONARY");

// Dictionary of string keys and int values
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["Alice"] = 30;
ages["Bob"] = 25;
foreach (var person in ages)
{
    Console.WriteLine($"{person.Key} : {person.Value}");
}

// Adding elements
ages.Add("Charlie", 28);

// Accessing elements
int aliceAge = ages["Alice"];   // Accessing value by key
Console.WriteLine("Alice Age: "+aliceAge);

Console.WriteLine("After adding element:");

// Iterating over elements
foreach (var person in ages)
{
    Console.WriteLine($"{person.Key} is {person.Value} years old.");
}

//-------------------------------------------------------------------

//Queue
Console.WriteLine("\nQUEUE");
// Queue of integers
Queue<int> queue = new Queue<int>();

// Enqueue elements (add to the end)
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);
foreach(var q in queue)
{
    Console.WriteLine(q);
}

// Dequeue elements (remove from the beginning)
int firstItem = queue.Dequeue();   // Removes and returns 10
Console.WriteLine("First Item: "+firstItem);

// Peek at the next item without removing it
int nextItem = queue.Peek();       // Returns 20
Console.WriteLine("Next Item: "+nextItem);

Console.WriteLine("Queue after Dequeue first element: ");
foreach (var q in queue)
{
    Console.WriteLine(q);
}

//-------------------------------------------------------------------

//STACK
Console.WriteLine("\nSTACK");

// Stack of strings
Stack<string> stack = new Stack<string>();

// Push elements onto the stack
stack.Push("First");
stack.Push("Second");
stack.Push("Third");

foreach (var st in stack)
{
    Console.WriteLine(st);
}

// Pop elements off the stack
string topItem = stack.Pop();   // Removes and returns "Third"
Console.WriteLine("Top Item: "+topItem);

// Peek at the top item without removing it
string stNextItem = stack.Peek(); // Returns "Second"
Console.WriteLine("Next Item: "+ stNextItem);
Console.WriteLine("Queue after Popping");
foreach (var st in stack)
{
    Console.WriteLine(st);
}


//---------------------------------------------------------

//HASH
Console.WriteLine("\nHASHSET");
HashSet<string> uniqueNames = new HashSet<string>();
uniqueNames.Add("Alice");
uniqueNames.Add("Bob");
foreach(var name in uniqueNames)
{
    Console.WriteLine(name);
}


//----------------------------------------------------------

////ENUM
//Console.WriteLine("\nENUM");
//public enum Days
//{
//    Monday = 1,
//    Tuesday,
//    Wednesday,
//    Thursday,
//    Friday,
//    Saturday,
//    Sunday
//}

//// Using enum
//Days Today = Days.Monday;
//if (today == Days.Friday)
//{
//    Console.WriteLine("TGIF!");
//}


//----------------------------------------------
//STRUCT
//Console.WriteLine("\nSTRUCT");
//public struct Point
//{
//    public int X;
//    public int Y;

//    public Point(int x, int y)
//    {
//        X = x;
//        Y = y;
//    }
//}

//// Usage
//Point p1 = new Point(10, 20);
//Console.WriteLine($"Point coordinates: ({p1.X}, {p1.Y})");

//--------------------------------------------------------

//MultiDimentiional Array
Console.WriteLine("\nMULTIDIMENTIONAL ARRAY");

int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 } };
for(int i = 0; i < grid.GetLength(0); i++)
{
    for (int j = 0; j < grid.GetLength(1); j++)
    {
        Console.WriteLine(grid[i,j]);
    }
}
//-------------------------------------------------
//Boxing and Unboxing

int number2 = 42;            // Value type variable
object boxedNumber = number2;   // Boxing

int unboxedNumber = (int)boxedNumber;  // Unboxing

Console.WriteLine($"Original number: {number2}");
Console.WriteLine($"Boxed number: {boxedNumber}");
Console.WriteLine($"Unboxed number: {unboxedNumber}");

//-------------------------------------------------------

//String Interpolation

Console.WriteLine("String Interpolation");
string name2 = "Jenny";
int age2 = 31;
Console.WriteLine($"\n{name2} is {age2} years old.");

//Composite formatting

Console.WriteLine("Composite formatting");
string student = "Jim";
int class1 = 8;
string message1 = string.Format("\nStudent {0} is studying in {1}th standard.", student, class1);
Console.WriteLine(message1);
