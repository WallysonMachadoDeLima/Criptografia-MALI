using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia_MALI
{
    public static class Encriptar
    {
        public static string EncriptarTexto(string converter, string numero)
        {
            /* 
             LISTA
             
               A = Zy, ZZ, zo || a = zb, Zh, Zu
               B = To, tR, Tg || b = Ta, tt, tr
               C = Rs, Rj, rr || c = Rc, Ro, ri
               D = Ss, Sr, su || d = St, Si, se
               E = Ue, Ur, ur || e = uw, Uq, Un
               F = Wr, wi, Wy || f = Wa, wb, wç
               G = Vu, Vb, Vg || g = Vh, vp, vf
               H = Xc, Xf, Xw || h = Xj, Xp, Xq
               I = Ae, Af, Ai || i = Au, Aw, Al
               J = Yo, Yb, Yi || j = Yi, Yq, Yu
               K = Jl, Ja, Jw || k = Je, Jo, Jp
               L = Dr, Do, De || l = Dg, Db, Di
               M = Pj, Pw, Pn || m = Po, Pt, Px
               N = En, Es, Et || n = Eo, Er, Ez
               O = Kw, Kq, Ke || o = Kr, Kt, Ky
               P = Iu, Ii, Io || p = Ip, Ia, Is 
               Q = Gm, Gn, Gv || q = Gb, Gq, GX
               R = Oz, Ol, Ok || r = Oj, Oh, Og
               S = Mf, Md, Ms || s = Ma, Mp, Mo
               T = Qp, Qo, Qi || t = Qu, Qy, Qt
               U = Cw, Cm, Ce || u = Cr, Cb, Ct
               V = Sl, Sk, Sj || v = Sh, Sg, Ss
               W = Na, Nb, Ne || w = Nw, Nq, No
               X = Lz, Lc, Lx || x = Lq, Lo, Lu
               Y = Bt, Bf, Bx || y = Bp, Bl, Bh
               Z = Ha, Hs, Hj || z = Hu, Hi, He

             
            */


            List<string> codigos = new List<string>();

            string[] letras = new string[] { "Uu", "Zy", "ZZ", "zo", "zb", "Zh", "Zu", "To", "tR", "Tg", "Ta", "tt", "tr", "Rs", "Rj", "rr", "Rc", "Ro", "ri", "Ss", "Sr" ,"su", "St", "Si", "se", "Ue", "Ur", "ur", "uw", "Uq", "Un", 
                                           "Wr", "wi", "Wy", "Wa", "wb", "wç", "Vu", "Vb", "Vg", "Vh", "vp", "vf","Xc", "Xf", "Xw", "Xj", "Xp", "Xq","Ae", "Af", "Ai", "Au", "Aw", "Al", "Yo", "Yb", "Yi", "Yi", "Yq", "Yu",
                                           "Jl", "Ja", "Jw", "Je", "Jo", "Jp", "Dr", "Do", "De", "Dg", "Db", "Di", "Pj", "Pw", "Pn", "Po", "Pt", "Px", "En", "Es", "Et", "Eo", "Er", "Ez", "Kw", "Kq", "Ke", "Kr", "Kt", "Ky", "Iu", "Ii", "Io", "Ip", "Ia", "Is",
                                           "Gm", "Gn", "Gv", "Gb", "Gq", "GX", "Oz", "Ol", "Ok", "Oj", "Oh", "Og", "Mf", "Md", "Ms", "Ma", "Mp", "Mo", "Qp", "Qo", "Qi", "Qu", "Qy", "Qt","Cw", "Cn", "Ce", "Cr", "Cb", "Ct", "Sl", "Sk", "Sj", "Sh", "Sg", "Ss",
                                           "Na", "Nb", "Ne", "Nw", "Nq", "No", "Lz", "Lc", "Lx", "Lq", "Lo", "Lu", "Bt", "Bf", "Bx", "Bp", "Bl", "Bh", "Ha", "Hs", "Hj", "Hu", "Hi", "He"};
            codigos.AddRange(letras);

            switch (converter)
            {
                case " ":
                    converter = codigos[0];
                    break;
                case "A":
                    converter = codigos[Convert.ToInt32(numero)];
                    break;
                case "a":
                    converter = codigos[Convert.ToInt32(numero) + 3];
                    break;
                case "B":
                    converter = codigos[Convert.ToInt32(numero) + 6];
                    break;
                case "b":
                    converter = codigos[Convert.ToInt32(numero) + 9];
                    break;
                case "C":
                    converter = codigos[Convert.ToInt32(numero) + 12];
                    break;
                case "c":
                    converter = codigos[Convert.ToInt32(numero) + 15];
                    break;
                case "D":
                    converter = codigos[Convert.ToInt32(numero) + 18];
                    break;
                case "d":
                    converter = codigos[Convert.ToInt32(numero) + 21];
                    break;
                case "E":
                    converter = codigos[Convert.ToInt32(numero) + 24];
                    break;
                case "e":
                    converter = codigos[Convert.ToInt32(numero) + 27];
                    break;
                case "F":
                    converter = codigos[Convert.ToInt32(numero) + 30];
                    break;
                case "f":
                    converter = codigos[Convert.ToInt32(numero) + 33];
                    break;
                case "G":
                    converter = codigos[Convert.ToInt32(numero) + 36];
                    break;
                case "g":
                    converter = codigos[Convert.ToInt32(numero) + 39];
                    break;
                case "H":
                    converter = codigos[Convert.ToInt32(numero) + 42];
                    break;
                case "h":
                    converter = codigos[Convert.ToInt32(numero) + 45];
                    break;
                case "I":
                    converter = codigos[Convert.ToInt32(numero) + 48];
                    break;
                case "i":
                    converter = codigos[Convert.ToInt32(numero) + 51];
                    break;
                case "J":
                    converter = codigos[Convert.ToInt32(numero) + 54];
                    break;
                case "j":
                    converter = codigos[Convert.ToInt32(numero) + 57];
                    break;
                case "K":
                    converter = codigos[Convert.ToInt32(numero) + 60];
                    break;
                case "k":
                    converter = codigos[Convert.ToInt32(numero) + 63];
                    break;
                case "L":
                    converter = codigos[Convert.ToInt32(numero) + 66];
                    break;
                case "l":
                    converter = codigos[Convert.ToInt32(numero) + 69];
                    break;
                case "M":
                    converter = codigos[Convert.ToInt32(numero) + 72];
                    break;
                case "m":
                    converter = codigos[Convert.ToInt32(numero) + 75];
                    break;
                case "N":
                    converter = codigos[Convert.ToInt32(numero) + 78];
                    break;
                case "n":
                    converter = codigos[Convert.ToInt32(numero) + 81];
                    break;
                case "O":
                    converter = codigos[Convert.ToInt32(numero) + 84];
                    break;
                case "o":
                    converter = codigos[Convert.ToInt32(numero) + 87];
                    break;
                case "P":
                    converter = codigos[Convert.ToInt32(numero) + 90];
                    break;
                case "p":
                    converter = codigos[Convert.ToInt32(numero) + 93];
                    break;
                case "Q":
                    converter = codigos[Convert.ToInt32(numero) + 96];
                    break;
                case "q":
                    converter = codigos[Convert.ToInt32(numero) + 99];
                    break;
                case "R":
                    converter = codigos[Convert.ToInt32(numero) + 102];
                    break;
                case "r":
                    converter = codigos[Convert.ToInt32(numero) + 105];
                    break;
                case "S":
                    converter = codigos[Convert.ToInt32(numero) + 108];
                    break;
                case "s":
                    converter = codigos[Convert.ToInt32(numero) + 111];
                    break;
                case "T":
                    converter = codigos[Convert.ToInt32(numero) + 114];
                    break;
                case "t":
                    converter = codigos[Convert.ToInt32(numero) + 117];
                    break;
                case "U":
                    converter = codigos[Convert.ToInt32(numero) + 120];
                    break;
                case "u":
                    converter = codigos[Convert.ToInt32(numero) + 123];
                    break;
                case "V":
                    converter = codigos[Convert.ToInt32(numero) + 126];
                    break;
                case "v":
                    converter = codigos[Convert.ToInt32(numero) + 129];
                    break;
                case "W":
                    converter = codigos[Convert.ToInt32(numero) + 132];
                    break;
                case "w":
                    converter = codigos[Convert.ToInt32(numero) + 135];
                    break;
                case "Y":
                    converter = codigos[Convert.ToInt32(numero) + 138];
                    break;
                case "y":
                    converter = codigos[Convert.ToInt32(numero) + 141];
                    break;
                case "Z":
                    converter = codigos[Convert.ToInt32(numero) + 144];
                    break;
                case "z":
                    converter = codigos[Convert.ToInt32(numero) + 147];
                    break;
            }

            return converter;
        }
    }
}
