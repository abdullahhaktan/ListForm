using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListForm
{
    public class Araba
    {
        string marka;
        string model;
        int yil;
        double fiyat;

        public string MARKA
        {
            get { return marka; }
            set { marka = value; }
        }

        public string MODEL
        {
            get { return model; }
            set { model = value; }
        }

        public int YIL
        {
            get { return yil; }
            set { yil = value; }
        }

        public double FIYAT
        {
            get { return  fiyat; }
            set { fiyat = value; }
        }

    }
}
