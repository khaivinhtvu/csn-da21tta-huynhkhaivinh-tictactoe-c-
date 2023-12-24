using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csn_tictactoe_csharp
{
    public static class minimax
    {
        private static int MAX = 1000;
        private static int MIN = -1000;

        public static int Minimax(Button[,] mang, int x, int y, int n, bool maxPlayer)
        {
            int values;
            int ketqua1 = dieukieuthang.kiemtraThang(x, y, n, "X", mang);
            int ketqua2 = dieukieuthang.kiemtraThang(x, y, n, "O", mang);

            if (ketqua1 == 1)
            {
                values = ketqua1;
                return values;
            }

            if (ketqua2 == -1)
            {
                values = ketqua2;
                return values;
            }

            if (ketqua1 == ketqua2 && ketqua1 == 0)
            {
                values = ketqua1;
                return values;
            }

            if (maxPlayer == true)
            {
                values = MIN;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mang[i, j].Text == " ")
                        {
                            mang[i, j].Text = "X";
                            values = Math.Max(values, Minimax(mang, i, j, n, false));
                            mang[i, j].Text = " ";
                        }
                    }
                }

                return values;
            }
            else
            {
                values = MAX;

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mang[i, j].Text == " ")
                        {
                            mang[i, j].Text = "O";
                            values = Math.Min(values, Minimax(mang, i, j, n, true));
                            mang[i, j].Text = " ";
                        }
                    }
                }

                return values;
            }
        }

        public static int[] Dichuyen(Button[,] mang, int n, string kytumay)
        {
            int[] dichuyen = new int[2];
            int diem;
            int diemtotnhat = MIN;

            if(kytumay == "X")
            {
                diemtotnhat = MIN;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mang[i, j].Text == " ")
                        {
                            mang[i, j].Text = "X";
                            diem = Minimax(mang, i, j, n, false);
                            mang[i, j].Text = " ";
                            if (diem > diemtotnhat)
                            {
                                diemtotnhat = diem;
                                dichuyen[0] = i;
                                dichuyen[1] = j;
                            }
                        }
                    }
                }
            }
            else
            {
                diemtotnhat = MAX;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (mang[i, j].Text == " ")
                        {
                            mang[i, j].Text = "O";
                            diem = Minimax(mang, i, j, n, true);
                            mang[i, j].Text = " ";
                            if (diem < diemtotnhat)
                            {
                                diemtotnhat = diem;
                                dichuyen[0] = i;
                                dichuyen[1] = j;
                            }
                        }
                    }
                }
            }
            
            
            return dichuyen;
        }
    }
}
