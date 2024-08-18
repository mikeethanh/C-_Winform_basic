using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tuan1_btvn
{
    internal class phanso
    {
        public int tuso { get; set; }
        public int mauso {  get; set; }

        public phanso(int tuso, int mauso)
        {
            this.tuso = tuso;
            this.mauso = mauso;
        }

        public phanso cong(phanso a, phanso b)
        {
            int tu = a.tuso * b.mauso + b.tuso * a.mauso;
            int mau = a.mauso * b.mauso;

            return new phanso(tu, mau);
        }

        public phanso nhan(phanso a, phanso b)
        {
            int tu = a.tuso * b.tuso;
            int mau = a.mauso*b.mauso;
            return new phanso(tu,mau);
        }
        public phanso tru(phanso a, phanso b)
        {
            int tu = a.tuso * b.mauso + b.tuso * a.mauso;
            int mau = a.mauso * b.mauso;

            return new phanso(tu, mau);
        }

        public phanso chia(phanso a, phanso b)
        {
            int tu = a.tuso * b.mauso;
            int mau = a.mauso * b.tuso;
            return new phanso(tu, mau);
        }

        public override string ToString()
        {
            return $"{tuso}/{mauso}";
        }

    }
}
