﻿//**Operator Overloading for Complex Numbers**

//Create a `ComplexNumber` class with properties `Real` and `Imaginary`.
//Overload the `+` operator to add two complex numbers.

using System;

namespace c__Assignment
{
    class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }
        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    //public class Program11
    //{
    //    static void Main()
    //    {
    //        ComplexNumber c1 = new ComplexNumber(1.5, 2.5);
    //        ComplexNumber c2 = new ComplexNumber(3.0, 4.0);

    //        ComplexNumber sum = c1 + c2;

    //        Console.WriteLine($"Sum: {sum}");
    //    }
    //}
}
