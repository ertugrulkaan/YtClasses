using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryHw
{
    class MyDictionary<TKey,TValue>
    {
        // TKey tipinde keyler , TValue tipinde de degerlerimiz olacak.
        // Kullanicinin kullanacagi deger ve anahtar arraylari
        TKey[] _keyArray;
        TValue[] _valueArray;
        bool test = false;

        // Constructor
        // Siniftan ornek olusturuldugunda key ve value arrayleri olusturuluyor.
        public MyDictionary()
        {
            _keyArray = new TKey[0];
            _valueArray = new TValue[0];
        }

        // Ekleme methodu anahtar ve degerleri alip _keyArray ve _ValueArray'e ekleyecek.
        public void Add(TKey key, TValue value)
        {
            try
            {
                // Ekleme methodunda gorev yapacak gecici key ve deger arraylari/ Halihazirda olan degerler gecici arraylere aktarildi.
                TKey[] _tempKeyArray = _keyArray;
                TValue[] _tempValueArray = _valueArray;

                // Ana arraylerimizi newledik ve uzunluklarini 1 arttirdik.
                _keyArray = new TKey[_keyArray.Length + 1];
                _valueArray = new TValue[_valueArray.Length + 1];

                for (int i = 0; i < _tempKeyArray.Length; i++)
                {
                    // Yeniledigimizde kaybolan degerleri gecici arrayden geri aldik.
                    _keyArray[i] = _tempKeyArray[i];
                    _valueArray[i] = _tempValueArray[i];
                }
                for (int i = 0; i < _keyArray.Length; i++)
                {
                    if (_keyArray[i].Equals(key))
                    {
                        test = true;
                    }
                }
                // eklenmek isteden anahtar degerini son indexe ekledik. indexler 0 dan basladigi icin -1 yapiyoruz.
                if (!test)
                {
                    _keyArray[_keyArray.Length - 1] = key;
                    _valueArray[_valueArray.Length - 1] = value;
                }
                else
                {
                    // TODO : Olan degerleri tekrar eklemiyor ama newlendiginden son satirda 0 ve bos string tutuyor duzeltmek lazim
                    Console.WriteLine("Olan degerleri tekrar ekleyemezsin!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        // olusturdugumuz Dictionary nin kac elemana sahip oldugunu gostermek icin yaptik.
        public int Count
        {
            get { return _keyArray.Length; } 
        }
        // anahtarlari dondurur
        public TKey[] Keys
        {
            get { return _keyArray; }
        }
        // degerleri dondurur
        public TValue[] Values
        {
            get { return _valueArray; }
        }

    }
}
