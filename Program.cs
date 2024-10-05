using System.Collections.Generic;
using System;



// int num1=0;

// System.Console.Write("Enter Number 1: ");
// string temp=System.Console.ReadLine()??"";
// num1=Convert.ToInt32(temp);


// if(num1%2==0){
//     System.Console.WriteLine("Number is even");
// }

// else{
//     System.Console.WriteLine("Number is odd");
// }


// int num=0;
// System.Console.Write("Enter number to generate table:");
// num=Convert.ToInt32(System.Console.ReadLine());


// for(int i=1;i<=10;i++){
//     System.Console.WriteLine("{0} x {1} = {2}",i,num,i*num);
// }

// for(int i=1;i<=15;i++){
//    bool threediv=i%3==0,fivediv=i%5==0;

//     if(threediv&& fivediv){
//         System.Console.WriteLine("Fizz Buzz");
//     } 
//     else if(threediv){
//         System.Console.WriteLine("Fizz");
//     } 
//     else if(fivediv){
//         System.Console.WriteLine("Buzz");
//     }
//     else{
//         System.Console.WriteLine(i);
//     }
// }

// System.Console.WriteLine("Enter password: ");
// string initialpassword=Console.ReadLine()??"";

// System.Console.WriteLine("Enter password again: ");
// string finalpassword=Console.ReadLine()??"";

// if(!string.IsNullOrEmpty(initialpassword) && !string.IsNullOrEmpty(finalpassword)){
//     if(initialpassword.Equals(finalpassword)){
//         System.Console.WriteLine("Password match");
//     }else{
//         System.Console.WriteLine("password donot match");
//     }
// }else{
//     System.Console.WriteLine("Password is empty");
// }

// int[] angles = new int[3];
// int sum = 0;
// for (int i = 0; i < angles.Length; i++)
// {
//     System.Console.WriteLine($"Enter angles {i + 1}:");
//     angles[i] = Convert.ToInt32(System.Console.ReadLine());

// }

// foreach (int angle in angles)
// {
//     sum += angle;
// }

// System.Console.WriteLine(sum == 180 ? "Valid" : "Invalid");


// List<int> even = [];
// List<int> odd = [];


// for (int i = 1; i <= 20; i++)
// {
//     if (i % 2 == 0)
//     {
//         even.Add(i);
//     }
//     else
//     {
//         odd.Add(i);
//     }
// }

// Console.WriteLine("Printing even numbers:");
// foreach (var item in even)
// {
//     Console.Write($"{item} ");
// }
// Console.WriteLine(Environment.NewLine + "Printing odd numbers:");
// foreach (var item in odd)
// {
//     Console.Write($"{item} ");
// }

// static double calculateArea(double width, double height)
// {
//     double area = 0;
//     area = 0.5 * width * height;
//     return area;

// }

// Console.WriteLine("Enter width:");
// double width = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter height:");
// double height = Convert.ToDouble(Console.ReadLine());


// Console.WriteLine(calculateArea(width, height));


int[] numArray = new int[4];
Console.WriteLine("Enter numbers:");

for (int i = 0; i < numArray.Length; i++)
{
    numArray[i] = Convert.ToInt32(Console.ReadLine());
}

static int SumOfNumbers(int[] array)
{
    int sum = 0;
    if (array.Length == 0)
    {
        return -1;
    }

    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }

    return sum;
}

System.Console.WriteLine(SumOfNumbers(numArray));