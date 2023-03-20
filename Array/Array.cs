using System.Collections;
using System.Runtime.CompilerServices;

namespace Array
{
    public class Array : ICloneable, IEnumerable
    {
        private Object[] InnerList;
        public int Length => InnerList.Length;
        
        private int Counter = 0;

       

        public Array(int defaultSize = 4)
        {
            InnerList = new Object[defaultSize];
        }

        public Array(params Object[] list) : this(list.Length)
        {
            System.Array.Copy(list, InnerList, list.Length);
        }

        public void Add(Object item)
        {
            InnerList[Counter] = item;
            Counter++;

            if(Counter == InnerList.Length)
            {
                this.DoubleArray();
            }

         
        }
        
        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public IEnumerator GetEnumerator()
        {
            return InnerList.GetEnumerator();
        }

        public Object GetValue(int index)
        {
            if (index >= 0 && index < InnerList.Length)
            {
                return InnerList[index];
            }
            throw new ArgumentOutOfRangeException();
        }

        public void SetValue(int index, Object value)
        {
            if (index >= 0 && index < InnerList.Length)
            {
                InnerList[index] = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException("index");
            }
        }

        private void DoubleArray()
        {
            Object[] tempArr = new Object[InnerList.Length * 2];


            for (int i = 0; i < InnerList.Length; i++)
            {
                tempArr[i] = InnerList[i];
            }

            InnerList = tempArr;


        }
    }
}