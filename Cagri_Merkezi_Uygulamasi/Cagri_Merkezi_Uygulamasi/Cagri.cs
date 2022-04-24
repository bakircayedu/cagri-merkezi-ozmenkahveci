using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public abstract class Cagri
    {
        //Oluşturduğumuz LinkedList'in uzunluğunu tutması için bu değişkeni tanımladık
        public int sira =  0;
        //LinkedList'in head'ını tanımladık
        public Musteri ilkMusteri;
        //Bu fonksiyon LinkedList'i sondan ekleyerek büyütüyor
        public abstract void CagriEkle(int MusteriNo);
        //Bu fonksiyon oluşturulan LinkedList'i yazdırıyor
        public abstract string CagriYazdir(Musteri temp);
        //Bu fonksiyon LinkedList değerlerini SelectionSort ile küçükten büyüğe sıralayıp yazdırıyor
        public abstract string CagriSirala(Musteri curr);
        //Bu fonksiyon girilen Müşteri Numarası değerine ait bir değer LinkedList'te varsa onu hatta bağlıyor
        public abstract bool CagriBaslat(int MusteriNo);

        //Sonuç olarak oluşturduğumuz bu abstract class'da
        //LinkedList oluşturup
        //Selection Sort ile sıralayıp
        //Linear Search ile arama işlemleri yapan fonksiyonlar tanımladık
    }
}
