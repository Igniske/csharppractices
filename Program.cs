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

    int age;

    Console.WriteLine("Input your age:");
    age = int.Parse(Console.ReadLine());

    if(age >25)
    {
        Console.WriteLine($"You look older than {age}");
    } else
    {
        Console.WriteLine($"You look younger than {age}");
    }






