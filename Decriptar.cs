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
            if (converter == "Kw" || converter == "Kq" || converter == "Ke") converter = "O";
            if (converter == "Kr" || converter == "Kt" || converter == "Ky") converter = "o";

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

            //U = Cw, Cm, Ce || u = Cr, Cb, Ct
            if (converter == "Cw" || converter == "Cn" || converter == "Ce") converter = "U";
            if (converter == "Cr" || converter == "Cb" || converter == "Ct") converter = "u";

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

            // Ç = **, --, ++ || ç = //, %%, $$
            if (converter == "**" || converter == "--" || converter == "++") converter = "Ç";
            if (converter == "//" || converter == "%%" || converter == "$$") converter = "ç";

            // Lixo = *a, ¨5, 85, 6ç, @9, 0_, *%, [=, 6+, $7, ´9, 9+, !v, 8d, 4o, #7, -*, ?u, C#, ^~, G4, +i};
            if (converter == "*a" || converter == "¨5" || converter == "85" || converter == "6ç" || converter == "@9" || converter == "0_" || converter == "*%"
                || converter == "[=" || converter == "6+" || converter == "$7" || converter == "´9" || converter == "9+" || converter == "!v" || converter == "8d"
                || converter == "4o" || converter == "#7" || converter == "-*" || converter == "?u" || converter == "C#" || converter == "^~"
                || converter == "G4" || converter == "+i") converter = "";

            // 1 = 7A, 78, 7[
            if (converter == "7A" || converter == "78" || converter == "7[") converter = "1";
            // 2 = 4o, 4=, 4y
            if (converter == "4o" || converter == "4=" || converter == "4y") converter = "2";
            // 3 = 16, 19, 1Ç
            if (converter == "16" || converter == "19" || converter == "1Ç") converter = "3";
            // 4 = 83, 8@, 8´
            if (converter == "83" || converter == "8@" || converter == "8´") converter = "4";
            // 5 = 5p, 5i, 5$
            if (converter == "5p" || converter == "5i" || converter == "5$") converter = "5";
            // 6 = 2i, 2p, 29
            if (converter == "2i" || converter == "2p" || converter == "29") converter = "6";
            // 7 = 98, 9), 99
            if (converter == "98" || converter == "9)" || converter == "99") converter = "7";
            // 8 = 6p, 6-, 63
            if (converter == "6p" || converter == "6-" || converter == "63") converter = "8";
            // 9 = 34, 3k, 3r
            if (converter == "34" || converter == "3k" || converter == "3r") converter = "9";
            // 0 = 0e, 0j, 0s
            if (converter == "0e" || converter == "0j" || converter == "0s") converter = "0";

            return converter;
        }
    }
}
