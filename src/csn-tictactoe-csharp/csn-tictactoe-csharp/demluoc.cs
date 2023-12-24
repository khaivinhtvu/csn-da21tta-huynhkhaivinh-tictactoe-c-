using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csn_tictactoe_csharp
{
    public static class demluoc
    {
        public static int capnhatluoc(int a)
        {
            if (a == 1)
            {
                a = -1;
                return a;
            }

            if (a == -1)
            {
                a = 1;
                return a;
            }

            return 0;
        }

        public static int datlailuoc(int a, string kytunguoichoi)
        {
            if (kytunguoichoi == "x")
            {
                a = -1;
                return a;
            }

            if (kytunguoichoi == "o")
            {
                a = 1;
                return a;
            }

            return 0;
        }
    }
}
