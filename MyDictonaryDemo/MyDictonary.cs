using System;
using System.Collections.Generic;
using System.Text;

namespace Dictonary
{
    class MyDictonary<Tkey, Tvalue>
    {
        Tkey[] keys; // Dictonary veri tipinde index yerine key olduğu için ayrı olarak tutmamız gerekiyor key değerlerini.
        Tvalue[] values; // keylere karşılık gelecek değerler.
        public MyDictonary() // Constructor yapısı
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value) // Ekleme metodu
        {
            Tkey[] tempKey = keys;
            Tvalue[] tempValue = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++) // Hocamızın derste gösterdiği yapı keyler için de tekrarlanıyor tek farkı bu.
            {
                keys[i] = tempKey[i];
            }

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];
            }

            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public int Length // Dictonary length
        {
            get { return Keys.Length; }
        }
        public Tkey[] Keys // get keys
        {
            get { return keys; }
        }
        public Tvalue[] Values // get values
        {
            get { return values; }
        }
    }
}
