using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
        class MyGenericDictionary<Tkey, TValue>
        {
            Tkey[] keyArray;
            TValue[] valueArray;

            Tkey[] tempKeyArray;
            TValue[] tempValueArray;
            
         public MyGenericDictionary()
            {
                keyArray = new Tkey[0];
                valueArray = new TValue[0];
            }

            public void Add(Tkey key, TValue value)
            {
                tempKeyArray = keyArray;
                tempValueArray = valueArray;

                keyArray = new Tkey[keyArray.Length + 1];
                valueArray = new TValue[valueArray.Length + 1];

                for (int i = 0; i < tempKeyArray.Length; i++)
                {
                    keyArray[i] = tempKeyArray[i];
                    valueArray[i] = tempValueArray[i];
                }

                keyArray[keyArray.Length - 1] = key;
                valueArray[valueArray.Length - 1] = value;
            }

            public Tkey[] Items1
            {
                get { return keyArray; }
            }

            public TValue[] Items2
            {
                get { return valueArray; }
            }

            public void Items()
            {
                for (int i = 0; i < keyArray.Length; i++)
                {
                    Console.WriteLine("Okul Numarası: " + keyArray[i] + " " + "\nÖğrenci İsmi: " + valueArray[i]);
                    Console.WriteLine("----------------------");
                }
            }
            
    }
}
