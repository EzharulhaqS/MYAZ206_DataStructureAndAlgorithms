using Microsoft.VisualBasic;
using System;

namespace ValueAndRefType
{
    public class ReferenceType
    {
        private Object[] _array;
       
        public ReferenceType(int defaultSize=4)
        {
            _array = new object[defaultSize];
        }

        public int Length  => _array.Length;
        public ReferenceType(params Object[] list) : this(list.Length)
        {
            System.Array.Copy(list, _array,list.Length);
        }

        public void Convert(ref int x , ref int y)
        {
            var temp = x;
            x = y;
            y = temp;
        }

        public void ConvertOut(int X, int Y, out int multiplacation, out int division)
        {
            multiplacation = X * Y;
            division = X / Y;
        } 

    }

}