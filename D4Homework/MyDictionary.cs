using System;
using System.Collections.Generic;
using System.Text;

namespace D4Homework
{
    class MyDictionary<Tkey, Tvalue>
    {
        Tkey[] _key;
        Tvalue[] _value;

        public MyDictionary()
        {
            _key = new Tkey[0];
            _value = new Tvalue[0];
        }

        public void Add(Tkey item1, Tvalue item2)
        {
            Tkey[] _tempkey = _key;
            Tvalue[] _tempValue = _value;

            _key = new Tkey[_key.Length + 1];
            _value = new Tvalue[_value.Length + 1];

            for (int i = 0; i < _tempkey.Length; i++)
            {
                _key[i] = _tempkey[i];
            }
            _key[_key.Length - 1] = item1;

            for (int j = 0; j < _tempValue.Length; j++)
            {
                _value[j] = _tempValue[j];
            }
            _value[_value.Length - 1] = item2;
        }

        public int Count
        {
            get { return _key.Length; }
        }

        public Tkey[] Item1
        {
            get { return _key; }

        }
        public Tvalue[] Item2
        {
            get { return _value; }
        }
    }
}
