using System;
using System.Runtime.InteropServices;
using ValueAndRefType;

namespace veri.lab._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var array = new ReferenceType();
            int X = 10;
            int Y = 20;
            int division;
            int multiplacation;
            array.ConvertOut(X, Y, out multiplacation, out division);
            
            array.Convert(ref X, ref Y);

            Console.WriteLine($"X : {X}, Y : {Y}");
            Console.WriteLine($"multiplacation : {multiplacation}, division : {division}");


        }

        public static void Convert(int X, int Y)
        {

            var temp = X;
            X = Y;
            Y = temp;
            
        }


    }
}
