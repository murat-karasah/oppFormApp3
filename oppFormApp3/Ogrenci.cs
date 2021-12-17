using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oppFormApp3
{
    public class Ogrenci
    {
        //kapsülleme içerisine saklmış olduğmuz private bir field'ın önüne koyduğumuz bir porperty sayesinde get ve set kullanarak değer ataması yapabilir ve değer okuyabiliriz.
        private string _Ad,_Soyad;
        private long _Tc;
        public string Ad 
        { get {return _Ad;
            }
            set {_Ad=value.Substring(0,1).ToUpper()+value.Substring(1); 
            }
        }
        public string Soyad { get {return _Soyad; } set {
                string asd = "*";

                //    int sayi = Convert.ToInt32(value.Length)-3;
                for (int i = 0; i < value.Length - 2; i++)
                {
                      asd="*"+asd;
                }
                 _Soyad = asd+value.Substring(value.Length-2,2);

                  }
        }
        public long Tc { get { return _Tc; } set { _Tc = Math.Abs(value);
                  
                    ; } }
    }
}
