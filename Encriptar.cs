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
               H = X
             
            */


            List<string> codigos = new List<string>();

            string[] letras = new string[] { "Uu", "Zy", "ZZ", "zo", "zb", "Zh", "Zu", "To", "tR", "Tg", "Ta", "tt", "tr", "Rs", "Rj", "rr", "Rc", "Ro", "ri", "Ss", "Sr" ,"su", "St", "Si", "se", "Ue", "Ur", "ur", "uw", "Uq", "Un", 
                                           "Wr", "wi", "Wy", "Wa", "wb", "wç", "Vu", "Vb", "Vg", "Vh", "vp", "vf"};
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
            }

            return converter;
        }
    }
}
