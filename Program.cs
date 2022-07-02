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



Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

// True
// False
// False
// True


string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1 == value2); // false
Console.WriteLine(value1.Trim() == value2.Trim()); // false
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // true


Console.WriteLine(value1 != value2); // True

Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue1 = "a";
Console.WriteLine(myValue1 != "a");

// False
// True
// True
// False

// Greater than >
// Less than <
// Greater than or equal to >=
// Less than or equal to <=

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// False
// True
// True
// True

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

// True
// False

// madam


Console.WriteLine(pangram.Contains("fox") == false); // False
Console.WriteLine(!pangram.Contains("fox")); // True

Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

// FALSE
//TRUE

int saleAmount = 1001;
int discount = 0;
if (saleAmount > 1000)
{
    discount = 100;
}
else
{
    discount = 50;
}
Console.WriteLine($"Discount: {discount}");


int disocunt1 = saleAmount > 1000 ? 100 : 50;
// true/ false ?  true : false
Console.WriteLine($"Discount: {disocunt1}");

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");


string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}


// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine($"Outside of code block: {value}");

// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine("Outside of code block: " + value);


bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);


// Write a C# Sharp program to check whether a given number is positive or negative. 

int number = -10;

if (number > 0)
{
    Console.WriteLine($"Number is positive : {number}");
}
else
{
    Console.WriteLine($"Number is negative : {number}");
}

// Write a C# Sharp program to find whether a given year is a leap year or not.
//Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.

int year = 2000;

if (year % 4 == 0)
{
    Console.WriteLine($"leap year : {number}");
}
else
{
    Console.WriteLine($"leap not a year : {number}");
}

Console.Write("\n\n");
Console.Write("Check whether a given year is leap year or not:\n");
Console.Write("----------------------------------------------");
Console.Write("\n\n");
Console.Write("Input an year : ");
// cls
int year1 = Convert.ToInt32(Console.ReadLine());

if (year1 % 4 == 0)
{
    Console.WriteLine($"leap year : {year1}");
}
else
{
    Console.WriteLine($"leap not a year : {year1}");
}

bool flag1 = true;
if (flag1)
{
    Console.WriteLine(flag1);
}


if (flag1)
    Console.WriteLine(flag1);

if (flag1) Console.WriteLine(flag1);


string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");

if (name == "bob")
{
    Console.WriteLine("Found Bob");
    Console.WriteLine("User found");
}
else if (name == "steve")
{
    Console.WriteLine("Found Steve");
}
else Console.WriteLine("Found Chuck");

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve")
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");




int[] numbers = { 4, 8, 15, 16, 23, 42 };
int totalSum = 0;
bool found = false;

foreach (int number12 in numbers)
{
    totalSum += number12;
    if (number12 == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {totalSum}");


int point = 20;
string title = "";
switch (point)
{
    case 10:
        title = "You got 10 point";
        break;
    case 20:
        title = "You got 20 point";
        break;
    case 30:
        title = "You got 30 point";
        break;
    default:
        title = "You got nothing";
        break;
}

Console.WriteLine($"Title is {title}");



int employeeLevel = 200;
string employeeName = "John Smith";

string title1 = "";
switch (employeeLevel)
{
    case 100:
        title1 = "Junior Associate";
        break;
    case 250:
    case 200:
        title1 = "Senior Associate";
        break;
    case 300:
        title1 = "Manager";
        break;
    case 400:
        title1 = "Senior Manager";
        break;
    default:
        title1 = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title1}");

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string emailId = "Yogesh@gmail.com";

string[] emailIds = emailId.Split('@');

foreach (string item in product)
{
    Console.WriteLine($"Product item is :: {item}");
}

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}


if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}


Console.WriteLine($"Product: {size} {color} {type}");



// foreach (string item in product)
// {
//     Console.WriteLine($"Product item is :: {item}");
// }

// where start from 1
// where is should end: Increatment 1
// Condition it should be less thn 10

// int i = 0; it always on first time
// i++ start from 2nd statement 
// i < 10 condition to run the loop
for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
}

// 10 9 8 7 ..... 0

for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}


// 3 6 9 12 15 18

for (int i = 3; i <= 20; i += 3)
{
    Console.WriteLine(i);
}


for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

string[] names1 = { "Alex", "Eddie", "David", "Michael" };

// names1[0] names1[1]  names1[2]  names1[3] 

for (int i = 0; i < names1.Length; i++)
{
    Console.WriteLine($"name at {i} and value is {names1[i]}");
}

// FizzBuzz rules:

// Output values from 1 to 100, one number per line.
// When the current value is divisible by 3, print the term Fizz next to the number.
// When the current value is divisible by 5, print the term Buzz next to the number.
// When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.

// 1
// 2
// 3 - Fizz
// 4
// 5 - Buzz
// 6 - Fizz
// 7
// 8
// 9 - Fizz
// 10 - Buzz
// 11
// 12 - Fizz
// 13
// 14
// 15 - FizzBuzz
// 16
// 17
// 18 - Fizz
// 19
// 20 - Buzz
// 21 - Fizz
// 22
// .
// .

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
        Console.WriteLine($"{i}");
}


Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}

Console.WriteLine($"Last number: {current}");

int count = 0;

while (count < 10)
{
    count++;
    Console.WriteLine(count);
}

do
{
    count++;
    Console.WriteLine(count);
} while (count < 10);


int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11); // 1
    monster -= roll; // 9
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11); // 2
    hero -= roll; // 8
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

// Monster was damaged and lost 1 health and now has 9 health.
// Hero was damaged and lost 2 health and now has 8 health.
// Monster was damaged and lost 1 health and now has 8 health.
// Hero was damaged and lost 4 health and now has 4 health.
// Monster was damaged and lost 7 health and now has 1 health.
// Hero was damaged and lost 6 health and now has -2 health.
// Monster wins!


for (int i = 0; i < 10; i++)
{
    if (i == 4)
    {
        continue;
    }
    Console.WriteLine(i);
}


decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float: {myFloat}");

int first = 5;
int second = 7;
string message5 = first.ToString() + second.ToString();
Console.WriteLine(message5);


string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);



int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

string name = "Bob";
Console.WriteLine(int.Parse(name));

//System.FormatException: 'Input string was not in a correct format.'

string value = "102";
int result = 0; // 102
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}



string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}

// Since it is defined outside of the if statement, 
// it can be accessed later in your code.
if (result > 0)
    Console.WriteLine($"Measurement (w/ offset): {50 + result}");



string[] values = { "12.3", "45", "ABC", "11", "DEF" };

// Rule 1: If the value is alphanumeric, concatenate it to form a message

// Rule 2: If the value is numeric, add it to the total

// Message: ABCDEF
// Total: 68.3



// >>Write a C# Sharp program to check whether a given number is positive or negative. 

// int[ ] inventory = { "25" , "1" , "-45 , "27" , "-32" , "45', "6' }
// int sum = 0
// int bin = 0
// foreach (int item in inventory)
// { 
//        int <=0
//        bin++
//      {
//            If (inventory.int {<=0});
//           {
//                 Console.Writeline ($Bin {bin} = {items} Items (Running total : {positive int});
//                       {
//                             else (inventory.int {>0});
//                                 {
//                                            Console.Writeline ($Bin {bin} = {items} Items (Running total : {negative int});
//                                    }
//                         }
//              }
//       }

// }

// tell whether number is positive or negative 
// Int Number : -67
// {
//    Console.WriteLine($"Number is positive : {number}");
// }
// else
// {
//     Console.WriteLine($"Number is negative : {number}");
// }


int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

// Divide value1 by value2, display the result as an int: 2
// Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
// Divide value3 by value1, display the result as a float: 0.3583333

string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Sorted...
// -- A11
// -- A13
// -- B12
// -- B14

// Reversed...
// -- B14
// -- B12
// -- A13
// -- A11