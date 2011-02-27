using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Microsoft.SPOT.Hardware;

namespace Quintus.Lib
{
    public class InputList
    {
        private const int DEFAULT_MAX = 5;
        private const int GROW_FACTOR = 2;

        private object _syncRoot;
        private InterruptPort[] _array { get; set; }
        private int _currentMax;
        private int _currentIndex;

        public InputList() : this(DEFAULT_MAX) { }
        public InputList(int count)
        {
            _syncRoot = new object();
            _array = new InterruptPort[count];
            _currentMax = count;
            _currentIndex = 0;
        }



        public int Add(InterruptPort value)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            _array = new InterruptPort[_currentMax];
            _currentIndex = 0;
        }

        public bool Contains(InterruptPort value)
        {
            return _array.Contains(value);
        }

        public int IndexOf(InterruptPort value)
        {
            for (int i = 0; i < _currentIndex; i++)
            {
                if (value == _array[i]) return i;
            }
            return -1;
        }

        public bool IsFixedSize { get { return false; } }

        public bool IsReadOnly { get { return false; } }

        public InterruptPort this[int index]
        {
            get { return _array[index]; }
            set{_array [index] = value;}
        }

        public void CopyTo(Array array, int index)
        {
            _array.CopyTo(array, index);
        }

        public int Count { get; private set; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();

            InputList il = new InputList();
            il.Add(null);
            foreach (InputPort item in il)
            {
                
            }
        }



    }

}
