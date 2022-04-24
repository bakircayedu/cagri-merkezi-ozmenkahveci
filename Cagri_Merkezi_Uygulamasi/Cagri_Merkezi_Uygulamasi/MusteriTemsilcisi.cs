using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cagri_Merkezi_Uygulamasi
{
    public class MusteriTemsilcisi: Cagri
    {
        public override bool CagriBaslat(int MusteriNo)
        {
            Musteri curr = ilkMusteri;
            
            while(curr != null)
            {
                if (curr.MusteriNo == MusteriNo)
                {
                    return true;
                }
                curr = curr.sonrakiMusteri;
            }
            return false;
        }

        public override void CagriEkle(int MusteriNo)
        {
            if (ilkMusteri == null)
            {
                ilkMusteri = new Musteri();
                ilkMusteri.MusteriNo = MusteriNo;
                ilkMusteri.sonrakiMusteri = null;
                sira++;
            }
            else
            {
                Musteri temp = new Musteri();
                temp.MusteriNo = MusteriNo;
                Musteri curr = ilkMusteri;
                while (curr.sonrakiMusteri != null)
                {
                    curr = curr.sonrakiMusteri;
                }

                curr.sonrakiMusteri = temp;
                sira++;
            }

        }

        public override string CagriSirala(Musteri curr)
        {
            
            string bilgi = "";
            for (int i = 1; i <= sira; i++)
            {
                for (int j = 0; j < sira-1; j++)
                {
                    if (curr.sonrakiMusteri != null && curr.MusteriNo > curr.sonrakiMusteri.MusteriNo)
                    {
                        int temp = curr.MusteriNo;
                        curr.MusteriNo = curr.sonrakiMusteri.MusteriNo;
                        curr.sonrakiMusteri.MusteriNo = temp;

                    }
                }
                
            }
           
            return bilgi += curr.MusteriNo;

        }

        public override string CagriYazdir(Musteri temp)
        {
                string bilgi = "";
                bilgi +=temp.MusteriNo;            
                return bilgi;
        }
    }
}
