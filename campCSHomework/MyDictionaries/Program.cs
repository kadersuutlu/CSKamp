using System;

namespace MyDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> kamp = new MyDictionary<string>();
            kamp.Add("C# + ANGULAR");
            kamp.Add("JAVA + REACT");
            kamp.Add("JavaScript");
            Console.WriteLine(kamp.Count);
        }
    }

    class MyDictionary<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyDictionary()
        {
            _array = new T[0];
        }

        public void Add(string item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
        }
        public int Count
        {
            get { return _array.Length; }
        }
    }
}
