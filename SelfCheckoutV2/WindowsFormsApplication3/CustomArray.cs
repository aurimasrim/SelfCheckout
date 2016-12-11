using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class CustomArray<T> : IEnumerable<T>
    {
        public CustomArray()
        {
            Array = new List<T>();
        }
        public CustomArray(int size)
        {
            Array = new List<T>(size);
        }
        public List<T> Array { get; }

        public T this[int index]
        {
            get { return Array[index]; }
            set { Array[index] = value; }
        }
        public void Read <Product> (DataReader pdr, string path)
        {
            //pdr.ReadData(this, path);
        }
        public int getSize()
        {
            return Array.Count;
        }
        public void Add(T obj)
        {
            Array.Add(obj);
        }
        public void Remove(int index)
        {
            Array.RemoveAt(index);
        }
        public void Swap(int index1, int index2)
        {
            T temp = Array[index1];
            Array[index1] = Array[index2];
            Array[index2] = temp;
        }
        public void Replace(int index, T replacement)
        {
            Array[index] = replacement;
        }
        public void Sort()
        {
            Array.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Array.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
