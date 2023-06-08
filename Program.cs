/* 1. Write a C# Sharp program to print Hello and your name in a separate line. */
/*
    Console.Write("Hello: ");
    Console.WriteLine("Ignacio Correa");
*/
/*2. Write a C# Sharp program to print the sum of two numbers.*/
/*
Console.WriteLine(2 + 2);
*/
/*3. Write a C# Sharp program to print the result of dividing two numbers.*/
/*
Console.WriteLine(4 / 2);
*/
/*4. Write a C# Sharp program to print the results of the specified operations.*/
/*
Console.WriteLine(-1 + 4 * 6);
Console.WriteLine((35 + 5) % 7);
Console.WriteLine(14 + -4 * 6 / 11);
Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
*/
/*5. Write a C# Sharp program to swap two numbers.*/

/*int number1, number2, temp;

number1 = int.Parse(Console.ReadLine());
number2 = int.Parse(Console.ReadLine());

temp = number1;
number1 = number2;
number2= temp;

Console.WriteLine(number1);
Console.WriteLine(number2);
*/

/*6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
*/
/*int number1, number2, number3;

Console.WriteLine("Input the first Number:");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the second Number:");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine("Input the third Number:");
number3 = int.Parse(Console.ReadLine());
Console.WriteLine(number1 * number2 * number3);/*

/*7. Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.*/
/*
int number1, number2;

Console.WriteLine("Enter the first number");
number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
number2 = int.Parse(Console.ReadLine());
Console.WriteLine(number1 + number2);
Console.WriteLine(number1 - number2);
Console.WriteLine(number1 * number2);
Console.WriteLine(number1 / number2);
Console.WriteLine(number1 % number2);
*/

/* 8. Write a C# Sharp program that prints the multiplication table of a number as input.*/

/*int number;

Console.WriteLine("Enter the number that you want to multiply:");
number = int.Parse(Console.ReadLine());

for (int i = 0; i <= 50; i++)
{
    Console.WriteLine($"{number} x {i} = " + number * i);
}
*/

/*9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.*/

/*int number1, number2, number3, number4;

    Console.WriteLine("Input the first number");
    number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the second number");
    number2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the third number");
    number3 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the fourth number");
    number4 = int.Parse(Console.ReadLine());
    Console.WriteLine("The average number is:" + (number1 + number2 + number3 + number4) / 4);
*/

/*10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.*/

/*int number1, number2, number3;

    Console.WriteLine("Input the first number");
    number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the second number");
    number2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Input the third number");
    number3 = int.Parse(Console.ReadLine());
    Console.Write($"The result of ({number1}+{number2}).{number3} =" + (number1 + number2) * number3);
    Console.WriteLine($" and {number1}.{number2} + {number2}.{number3}=" + ((number1 * number2) + (number2 * number3)));
*/
/*11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".*/

/*   int age;

   Console.WriteLine("Input your age:");
   age = int.Parse(Console.ReadLine());

   if(age >25)
   {
       Console.WriteLine($"You look older than {age}");
   } else
   {
       Console.WriteLine($"You look younger than {age}");
   }
*/

/*12. Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice:*/

/*int number;

number = int.Parse(Console.ReadLine());
for(int i = 1; i < 4; i++)
    {
        if(i % 2 == 0)
            {
                Console.WriteLine($"{number} {number} {number} {number}");
            } else
            {
                Console.WriteLine($"{number}{number}{number}{number}");
            }
    }
*/

/*  Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit. */
/*
int number;

number = int.Parse(Console.ReadLine());

Console.WriteLine($"{number}{number}{number}");
for(int i = 0; i <2; i++)
    {
        Console.WriteLine($"{number} {number}");
    }
Console.Write($"{number}{number}{number}");
*/

/*14. Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit.*/

/*
int number;

Console.WriteLine("Insert the celsius number:");
number = int.Parse(Console.ReadLine());
Console.WriteLine($"Farenheit = {(number * 1.8) + 32}");
Console.WriteLine($"Kelvin= {number + 273.15}");
*/

/*15. Write a C# program that removes a specified character from a non-empty string using the index of a character.*/
/*
string myString, newString;
int index = 3;

myString = (Console.ReadLine());

newString = myString.Remove(index, 1);

Console.WriteLine(newString);
*/

/*16. Write a C# program to create a new string from a given string where the first and last characters change their positions.*/
/*
internal class Program
{
    private static void Main(string[] args)
    {
        string myString, newString;

        myString = Console.ReadLine();

        char[] charArray = myString.ToCharArray();

        char firstChar = charArray[0];
        char lastChar = charArray[charArray.Length - 1];

        charArray[0] = lastChar;
        charArray[charArray.Length - 1] = firstChar;

        newString = new string(charArray);

        Console.WriteLine(newString);
    }
}
*/

/*17. Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back.*/
/*
string firstString, endString;

firstString = Console.ReadLine();

if(firstString.Length > 0)
    {
        char [] arrayChar = firstString.ToCharArray();
        char firstChar = arrayChar[0];
        endString = firstChar + firstString + firstChar;
        Console.WriteLine(endString);
    }

*/

/*18. Write a C# program to check a pair of integers and return true if one is negative and one is positive.*/
/*
int firstInt, secondInt;

firstInt = int.Parse(Console.ReadLine());
secondInt = int.Parse(Console.ReadLine());

if((firstInt < 0 && secondInt >= 0 )|| (firstInt >= 0 && secondInt < 0 ))
    {
        Console.WriteLine(true);
    } else
    {
        Console.WriteLine(false);
    }
*/

/*19. Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum.*/
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int firstInt, secondInt;

        firstInt = int.Parse(Console.ReadLine());
        secondInt = int.Parse(Console.ReadLine());

        if (firstInt == secondInt)
        {
            Console.WriteLine((firstInt + secondInt) * 3);
        }
        else
        {
            Console.WriteLine(firstInt + secondInt);
        }
    }
}
*/

/* 20. Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number. */

/*
int firstInt, secondInt, absoluteNumber;

firstInt = int.Parse(Console.ReadLine());
secondInt = int.Parse(Console.ReadLine());

if(firstInt < secondInt)
    {
        absoluteNumber = (firstInt - secondInt) * 2;
        if(absoluteNumber < 0){
            absoluteNumber = absoluteNumber * -1;
        }
        Console.WriteLine(absoluteNumber);
    } else
    {
        absoluteNumber = firstInt - secondInt;
        if(absoluteNumber <0)
        {
            absoluteNumber = absoluteNumber * -1;
            Console.WriteLine(absoluteNumber);
        }
        Console.WriteLine(absoluteNumber);
    }

/*21. Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20.*/
/*
int number1, number2, sum;

number1 = int.Parse(Console.ReadLine());
number2 = int.Parse(Console.ReadLine());

if((number1 == 20 || number2 == 20) || (number1 + number2 == 20))
    {
        Console.WriteLine(true);
    } else
    {
        Console.WriteLine(false);
    }
*/

/*22. Write a C# program to check if the given integer is within 20 of 100 or 200.*/
/*
int number; 

number = int.Parse(Console.ReadLine());

if((number >= 80 && number <=120 ) || (number >= 180 && number <= 220))
    {
        Console.WriteLine(true);
    } else
    {
        Console.WriteLine(false);
    }
*/

/*23. Write a C# program to convert a given string into lowercase.*/
/*
string firstString, newString;

firstString = Console.ReadLine();

newString = firstString.ToLower();

Console.WriteLine(newString);
*/

/*24. Write a C# program to find the longest word in a string.*/
/*
string inputStr;

string longestWord = "";

inputStr = Console.ReadLine();

string [] words = inputStr.Split(" ");

for(int i = 0; i < words.Length; i++)
    {
        if(words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
    }
Console.WriteLine(longestWord);
*/

/*25. Write a C# program to print odd numbers from 1 to 99. Prints one number per line.*/
/*
for(int i = 1; i < 100; i++)
    {
        if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
    }
*/

/* 26. Write a C# program to compute the sum of the first 500 prime numbers */
/*
int primeCount = 0;
int sum = 0;
for (int i = 2; primeCount < 500; i++)
{
    bool isPrime = true;

    for (int divisor = 2; divisor <= Math.Sqrt(i); divisor++)
    {
        if (i % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        sum = sum + i;
        primeCount++;
    }
}

Console.WriteLine(sum);

*/

/*27. Write a C# program and compute the sum of an integer's digits.*/
/*
int number, result;

result = 0;

number = int.Parse(Console.ReadLine());

string numberStr = number.ToString();

int [] numbers = new int[numberStr.Length];

for(int i = 0;i < numbers.Length;i++)
    {
        numbers[i] = int.Parse(numberStr[i].ToString());
    }

for(int j = 0; j <numbers.Length; j++)
    {
        result = result + numbers[j];
    }

Console.WriteLine(result);
*/

/*28. Write a C# program to reverse the words of a sentence.*/

string initialStr;

string finalStr = "";

initialStr = Console.ReadLine();

string[] sentence = initialStr.Split(" ");

if(sentence.Length > 1)
    {
        for(int i = 0; i < sentence.Length; i++)
            {
                finalStr = finalStr + " " + sentence[sentence.Length - (i + 1)];
            }
    }

Console.WriteLine(finalStr);