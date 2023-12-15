using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BGT_NTP_15Ara_2
{
    class harcama
    {
        string _islemAdi;
        string _islemTuru;
        int _tutar;

        public string IslemAdi
        {
            get { return _islemAdi; }   
            set { _islemAdi = value;}
        }
        public string IslemTuru
        {
            get { return _islemTuru;}
            set { _islemTuru = value;}  
        }
        public int Tutar
        {
            get { return _tutar; }  
            set { _tutar = value;}  
        }
    }
}
