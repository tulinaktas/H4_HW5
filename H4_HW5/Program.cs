using System;
using System.Collections.Generic;

namespace H4_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> _cars = new Dictionary<string,string>();
            _cars.Add("35abc23", "bmw");
            _cars.Add("35abc25", "audi");
           // _cars.Add("35abc25", "audi");
            foreach (var item in _cars)
            {
                Console.WriteLine(item);
            }

            MyDictionary<string,string> cars = new MyDictionary<string,string>();

            cars.Add("35abc23", "bmw");
            cars.Add("35abc25", "audi");
            //cars.Add("35abc25", "audi"); --> aynı key eklenmiyor
            cars.DisplayOfDictionary();
        }
    }

    class MyDictionary<TKey, TValue>
    {
        TKey[] _keys;
        TKey[] tempKeys;

        TValue[] _values;
        TValue[] tempValues;

        Boolean _temp = false;

        public MyDictionary()
        {
            _keys = new TKey[0];
            _values = new TValue[0];

        }

        public void Add(TKey key, TValue value)
        {
            tempKeys = _keys;
            tempValues = _values;

            _keys = new TKey[_keys.Length + 1];
            _values = new TValue[_values.Length + 1];

            for (int i = 0; i < tempKeys.Length; i++)
            {
                if(key.Equals(tempKeys[i]))
                {
                    _temp = true;
                }
            }
            if (_temp.Equals(false))
            {
                for (int i = 0; i < tempKeys.Length; i++)
                {
                    _keys[i] = tempKeys[i];
                    _values[i] = tempValues[i];
                }
                _keys[_keys.Length - 1] = key;
                _values[_values.Length - 1] = value;
            }

        }

        public void DisplayOfDictionary()
        {
            for (int i = 0; i < _keys.Length; i++)
            {
                Console.WriteLine("" + _keys[i] + " " + _values[i]);
            }
        }
    }

    }

