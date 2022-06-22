﻿// See https://aka.ms/new-console-template for more information
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

Console.WriteLine("***************** 22-06-2022 *******************");

string[] names = { "Bob", "Conrad", "Grant", "red", "green", "blue" }; // array name is "names" and it has six element "Bob", "Conrad", "Grant" , "red", "green", "blue"

foreach (string abc in names)
{
    Console.WriteLine(abc);
}

int[] inventory = { 200, 450, 700, 175, 250 };

foreach (int item in inventory)
{
    Console.WriteLine(item);
}


int sum = 0;

foreach (int item in inventory)
{
    sum += item; // sum = sum + item;
}

Console.WriteLine($"We have {sum} items in inventory.");


int total = 0;
int bin = 0;
foreach (int items in inventory)
{
    total += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {total})");
}
Console.WriteLine($"We have {total} items in inventory.");


int total1 = 0;
int bin1 = 0;
foreach (int items in inventory)
{
    if (items > 300)
    {
        total1 += items;
        bin1++;
        Console.WriteLine($"Bin {bin1} = {items} items (Running total: {total1})");
    }

}
Console.WriteLine($"We have {total1} items in inventory.");



string name5 = "BOB";

if (name5.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}


string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };


foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith("B"))
    {
        Console.WriteLine(orderID);
    }
}

// thisIsCamelCase;

// char userOption;

// int gameScore;

// float particlesPerMillion;

// bool processedCustomer;

/*
This is a long comment 
  that spans multiple lines
  just to prove that it can
  be done.
  */

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/




/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";
// chars[] strChar = {"T", "h", "e"};
char[] message = originalMessage.ToCharArray(); // string to char array
Array.Reverse(message);
int letterCount = 0;
foreach (char letter in message)
{
    // Console.WriteLine(msg);
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");