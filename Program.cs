// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// subject 4 number of student 10 ==> 40 variables

int[] marks = new int[3];

// int mark = 10;

marks[0] = 10;
marks[1] = 20;
marks[2] = 40;

Console.WriteLine($"First mark is {marks[0]}");
Console.WriteLine($"Second mark is {marks[1]}");
Console.WriteLine($"Third mark is {marks[2]}");



string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");


string[] colors1 = new string[3];
colors1[0] = "Red";
colors1[1] = "Green";
colors1[2] = "Blue";

string[] colors = { "red", "green", "blue" };

Console.WriteLine($"First: {colors[0]}");
Console.WriteLine($"Second: {colors[1]}");
Console.WriteLine($"Third: {colors[2]}");

Console.WriteLine($"There are {colors.Length} colors");

