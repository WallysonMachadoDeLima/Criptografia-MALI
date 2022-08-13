using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia_MALI
{
    public static class Decriptar
    {
        public static string DecriptarTexto(string converter)
        {
            if (converter == "Uu") converter = " ";

            //A = Zy, ZZ, zo || a = zb, Zh, Zu
            if (converter == "Zy" || converter == "ZZ" || converter == "zo") converter = "A";
            if (converter == "zb" || converter == "Zh" || converter == "Zu") converter = "a";

            //B = To, tR, Tg || b = Ta, tt, tr
            if (converter == "To" || converter == "tR" || converter == "Tg") converter = "B";
            if (converter == "Ta" || converter == "tt" || converter == "tr") converter = "b";

            //C = Rs, Rj, rr || c = Rc, Ro, ri
            if (converter == "Rs" || converter == "Rj" || converter == "rr") converter = "C";
            if (converter == "Rc" || converter == "Ro" || converter == "ri") converter = "c";

            //D = Ss, Sr, su || d = St, Si, se
            if (converter == "Ss" || converter == "Sr" || converter == "su") converter = "D";
            if (converter == "St" || converter == "Si" || converter == "se") converter = "d";

            //E = Ue, Ur, ur || e = uw, Uq, Un
            if (converter == "Ue" || converter == "Ur" || converter == "ur") converter = "E";
            if (converter == "uw" || converter == "Uq" || converter == "Un") converter = "e";

            //F = Wr, wi, Wy || f = Wa, wb, wç
            if (converter == "Wr" || converter == "wi" || converter == "Wy") converter = "F";
            if (converter == "Wa" || converter == "wb" || converter == "wç") converter = "f";

            //H = Xc, Xf, Xw || h = Xj, Xp, Xq
            if (converter == "Xc" || converter == "Xf" || converter == "Xw") converter = "H";
            if (converter == "Xj" || converter == "Xp" || converter == "Xq") converter = "h";

            return converter;
        }
    }
}
