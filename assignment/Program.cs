using System;
using System.ComponentModel;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1 - Write a program that allows the user to enter a number then print it.
            //Console.Write("Enter number = ");
            //string input = Console.ReadLine();
            //int number = Convert.ToInt32(input);
            //Console.WriteLine(number);
            #endregion
            #region 2-Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            //string text = "XY10";   
            //int X = int.Parse(text);   
            //Console.WriteLine("Converted number :" + X);
            // حصل Exception 
            // عشان فيه حروف مش ارقام فقط
            #endregion
            #region 3-Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            //float num1 = 5.5f;
            //float num2 = 2.2f;

            //float S = num1 + num2;
            //Console.WriteLine(" + = " + S);

            //float Sub = num1 - num2;
            //Console.WriteLine(" - = " + Sub);

            //float M = num1 * num2;
            //Console.WriteLine("* = " + M);

            //float D = num1 / num2;
            //Console.WriteLine(" / = " + D);
            #endregion
            // 4 - I didn't understand it
            #region 5-Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int A1 = 10;
            //int B1 = A1;
            //A1 = 20;
            //Console.WriteLine(A1);
            //Console.WriteLine(B1);
            // احنا غيرنا قيمة المتغير الاول تحت ف بالتالي حسبها وحسبش ان ال A1  = 10 حسبها انها هتكون ب 20
            #endregion
            #region 6-Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //Num num1 = new Num(); 
            //num1.Value = 10;
            //Num num2 = num1;      
            //num2.Value = 99;
            //Console.WriteLine("num1.Value: " + num1.Value);  
            //Console.WriteLine("num2.Value: " + num2.Value);
            #endregion
            #region 7-
            //string firstName = "yassen";
            //string lastName = "yasser";           
            //string fullName = firstName+" "+lastName;
            //Console.WriteLine(fullName);
            #endregion
            #region 8-
            //double principal = 300;
            // double rate = 4;
            // double time = 2;
            //double interest = (principal * rate * time) / 100;

            //Console.WriteLine("Simple Interest = " + interest);


            #endregion

            #region 9-
            //Console.Write("Enter weight : ");
            //double weight = double.Parse(Console.ReadLine());

            //Console.Write("Enter height : ");
            //double height = double.Parse(Console.ReadLine());

            //double bmi = weight / (height * height);
            //Console.WriteLine("Your BMI = " + bmi);
            #endregion
            #region 10-
            Console.Write("Enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine()); 
            string result;

            if (temperature < 10)
            {
                result = "Just Cold";
            }
            else if (temperature > 30)
            {
                result = "Just Hot";
            }
            else
            {
                result = "Just Good";
            }
            Console.WriteLine("Temperature is:" + result);
            #endregion
        }
    }
}
class Num
{
    public int Value;
}

// 12 -  C   -13  F   14 -  D   15 -   D