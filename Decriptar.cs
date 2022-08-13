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

            //I = Ae, Af, Ai || i = Au, Aw, Al
            if (converter == "Ae" || converter == "Af" || converter == "Ai") converter = "I";
            if (converter == "Au" || converter == "Aw" || converter == "Al") converter = "i";

            //J = Yo, Yb, Yi || j = Yi, Yq, Yu
            if (converter == "Yo" || converter == "Yb" || converter == "Yi") converter = "J";
            if (converter == "Yi" || converter == "Yq" || converter == "Yu") converter = "j";

            //K = Jl, Ja, Jw || k = Je, Jo, Jp
            if (converter == "Jl" || converter == "Ja" || converter == "Jw") converter = "K";
            if (converter == "Je" || converter == "Jo" || converter == "Jp") converter = "k";

            //L = Dr, Do, De || l = Dg, Db, Di
            if (converter == "Dr" || converter == "Do" || converter == "De") converter = "L";
            if (converter == "Dg" || converter == "Db" || converter == "Di") converter = "l";

            //M = Pj, Pw, Pn || m = Po, Pt, Px
            if (converter == "Pj" || converter == "Pw" || converter == "Pn") converter = "M";
            if (converter == "Po" || converter == "Pt" || converter == "Px") converter = "m";

            //N = En, Es, Et || n = Eo, Er, Ez
            if (converter == "En" || converter == "Es" || converter == "Et") converter = "N";
            if (converter == "Eo" || converter == "Er" || converter == "Ez") converter = "n";

            //O = Kw, Kq, Ke || o = Kr, Kt, Ky
            if (converter == "En" || converter == "Es" || converter == "Et") converter = "O";
            if (converter == "Eo" || converter == "Er" || converter == "Ez") converter = "o";

            //P = Iu, Ii, Io || p = Ip, Ia, Is
            if (converter == "Iu" || converter == "Ii" || converter == "Io") converter = "P";
            if (converter == "Ip" || converter == "Ia" || converter == "Is") converter = "p";

            //Q = Gm, Gn, Gv || q = Gb, Gq, GX
            if (converter == "Gm" || converter == "Gn" || converter == "Gv") converter = "Q";
            if (converter == "Gb" || converter == "Gq" || converter == "GX") converter = "q";

            //R = Oz, Ol, Ok || r = Oj, Oh, Og
            if (converter == "Oz" || converter == "Ol" || converter == "Ok") converter = "R";
            if (converter == "Oj" || converter == "Oh" || converter == "Og") converter = "r";

            //S = Mf, Md, Ms || s = Ma, Mp, Mo
            if (converter == "Mf" || converter == "Md" || converter == "Ms") converter = "S";
            if (converter == "Ma" || converter == "Mp" || converter == "Mo") converter = "s";

            //T = Qp, Qo, Qi || t = Qu, Qy, Qt
            if (converter == "Qp" || converter == "Qo" || converter == "Qi") converter = "T";
            if (converter == "Qu" || converter == "Qy" || converter == "Qt") converter = "t";

            //U = Uw, Un, Ue || u = Ur, Ub, Ut
            if (converter == "Uw" || converter == "Un" || converter == "Ue") converter = "U";
            if (converter == "Ur" || converter == "Ub" || converter == "Ut") converter = "u";

            //V = Sl, Sk, Sj || v = Sh, Sg, Ss
            if (converter == "Sl" || converter == "Sk" || converter == "Sj") converter = "V";
            if (converter == "Sh" || converter == "Sg" || converter == "Ss") converter = "v";

            //W = Na, Nb, Ne || w = Nw, Nq, No
            if (converter == "Na" || converter == "Nb" || converter == "Ne") converter = "W";
            if (converter == "Nw" || converter == "Nq" || converter == "No") converter = "w";

            //X = Lz, Lc, Lx || x = Lq, Lo, Lu
            if (converter == "Lz" || converter == "Lc" || converter == "Lx") converter = "X";
            if (converter == "Lq" || converter == "Lo" || converter == "Lu") converter = "x";

            //Y = Bt, Bf, Bx || y = Bp, Bl, Bh
            if (converter == "Bt" || converter == "Bf" || converter == "Bx") converter = "Y";
            if (converter == "Bp" || converter == "Bl" || converter == "Bh") converter = "y";

            //Z = Ha, Hs, Hj || z = Hu, Hi, He
            if (converter == "Ha" || converter == "Hs" || converter == "Hj") converter = "Z";
            if (converter == "Hu" || converter == "Hi" || converter == "He") converter = "z";

            return converter;
        }
    }
}
