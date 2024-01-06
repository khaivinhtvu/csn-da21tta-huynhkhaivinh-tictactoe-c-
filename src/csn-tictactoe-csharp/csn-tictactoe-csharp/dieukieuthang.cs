using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csn_tictactoe_csharp
{
    public static class dieukieuthang
    {
        public static int kiemtraThang(int x, int y, int n, string chu, Button[,] b)
        {
            int dk;
            int dem = Hoa(n , b);
            dk = Thang(x, y, n, chu, b);

            if (dk == 1 && chu == "X")
            {
                return 1;
            }

            if (dk == 1 && chu == "O")
            {
                return -1;
            }

            if (dem == 0)
            {
                return 0;
            }

            if (dk == 0)
            {
                return 2;
            }

            return 3;
        }

        public static int Thang(int x, int y, int n, string kytu, Button[,] a)
        {
            int ketqua = 0;
            int xtamcheochinh = x;
            int ytamcheochinh = y;
            int xtamcheophu = x;
            int ytamcheophu = y;

            //tim dong
            for (int i = 0; i < n; i++)
            {
                if (i + 2 == n - 1)
                {
                    if (a[x, i].Text == kytu && a[x, i + 1].Text == kytu && a[x, i + 2].Text == kytu)
                    {
                        ketqua = 1;
                        return ketqua;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[x, i].Text == kytu && a[x, i + 1].Text == kytu && a[x, i + 2].Text == kytu)
                {
                    ketqua = 1;
                    return ketqua;
                }
            }

            //tim cot
            for (int i = 0; i < n; i++)
            {
                if (i + 2 == n - 1)
                {
                    if (a[i, y].Text == kytu && a[i + 1, y].Text == kytu && a[i + 2, y].Text == kytu)
                    {
                        ketqua = 1;
                        return ketqua;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[i, y].Text == kytu && a[i + 1, y].Text == kytu && a[i + 2, y].Text == kytu)
                {
                    ketqua = 1;
                    return ketqua;
                }
            }

            //tim duong cheo chinh
            for (int i = 0; i < n; i++)
            {
                if (xtamcheochinh - i == 0 || ytamcheochinh - i == 0)
                {
                    xtamcheochinh = xtamcheochinh - i;
                    ytamcheochinh = ytamcheochinh - i;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (xtamcheochinh + 2 > n - 1 || ytamcheochinh + 2 > n - 1)
                {
                    break;
                }

                if (xtamcheochinh + 2 == n - 1 || ytamcheochinh + 2 == n - 1)
                {
                    if (a[xtamcheochinh, ytamcheochinh].Text == kytu && a[xtamcheochinh + 1, ytamcheochinh + 1].Text == kytu && a[xtamcheochinh + 2, ytamcheochinh + 2].Text == kytu)
                    {
                        ketqua = 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                if (a[xtamcheochinh, ytamcheochinh].Text == kytu && a[xtamcheochinh + 1, ytamcheochinh + 1].Text == kytu && a[xtamcheochinh + 2, ytamcheochinh + 2].Text == kytu)
                {
                    ketqua = 1;
                    break;
                }

                xtamcheochinh++;
                ytamcheochinh++;
            }

            //tim duong cheo phu
            for (int i = 0; i < n; i++)
            {
                if (xtamcheophu - i == 0 || ytamcheophu + i == n - 1)
                {
                    xtamcheophu = xtamcheophu - i;
                    ytamcheophu = ytamcheophu + i;
                    break;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (xtamcheophu + 2 > n - 1 || ytamcheophu - 2 < 0)
                {
                    break;
                }

                if (xtamcheophu + 2 == n - 1 || ytamcheophu - 2 == 0)
                {
                    if (a[xtamcheophu, ytamcheophu].Text == kytu && a[xtamcheophu + 1, ytamcheophu - 1].Text == kytu && a[xtamcheophu + 2, ytamcheophu - 2].Text == kytu)
                    {
                        ketqua = 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }

                if (a[xtamcheophu, ytamcheophu].Text == kytu && a[xtamcheophu + 1, ytamcheophu - 1].Text == kytu && a[xtamcheophu + 2, ytamcheophu - 2].Text == kytu)
                {
                    ketqua = 1;
                    break;
                }

                xtamcheophu++;
                ytamcheophu--;
            }

            return ketqua;
        }

        public static int Hoa(int n, Button[,] b)
        {
            int dem = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (b[i, j].Text != " ")
                    {
                        dem++;
                    }
                }
            }

            if (dem == n * n)
            {
                return 0;
            }

            return 2;
        }
    }
}
