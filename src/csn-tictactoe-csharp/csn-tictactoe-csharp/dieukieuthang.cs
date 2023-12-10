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

        public static int Thang(int x, int y, int n, string kytu, Button[,] a)
        {
            int ketqua = 0;
            int demdong = 0;
            int demcot = 0;
            int cheotren1 = 0;
            int cheotren2 = 0;
            int cheoduoi1 = 0;
            int cheoduoi2 = 0;

            //tim dong
            for (int i = 0; i < n; i++)
            {
                if (i + n - 1 == n - 1)
                {
                    if (a[x, i].Text == kytu && a[x, i + 1].Text == kytu && a[x, i + 2].Text == kytu)
                    {
                        demdong = 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[x, i].Text == kytu && a[x, i + 1].Text == kytu && a[x, i + 2].Text == kytu)
                {
                    demdong = 1;
                    break;
                }
            }

            if (demdong == 1)
            {
                ketqua = 1;
                return ketqua;
            }

            //tim cot
            for (int i = 0; i < n; i++)
            {
                if (i + 2 == n - 1)
                {
                    if (a[i, y].Text == kytu && a[i + 1, y].Text == kytu && a[i + 2, y].Text == kytu)
                    {
                        demcot = 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[i, y].Text == kytu && a[i + 1, y].Text == kytu && a[i + 2, y].Text == kytu)
                {
                    demcot = 1;
                    break;
                }
            }

            if (demcot == 1)
            {
                ketqua = 1;
                return ketqua;
            }

            //tim duong cheo tren
            //tim xuong
            for (int i = 0; i < n; i++)
            {
                if (x + i == n - 1 || y + i == n - 1)
                {
                    if (a[x + i, y + i].Text == kytu)
                    {
                        cheotren1 = cheotren1 + 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[x + i, y + i].Text == kytu)
                {
                    cheotren1 = cheotren1 + 1;
                }
            }

            //tim len 
            for (int i = 0; i > -n; i--)
            {
                if (x + i == 0 || y + i == 0)
                {
                    if (a[x + i, y + i].Text == kytu)
                    {
                        cheotren2 = cheotren2 + 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[x + i, y + i].Text == kytu)
                {
                    cheotren2 = cheotren2 + 1;
                }
            }

            if (cheotren1 == 3 || cheotren2 == 3)
            {
                ketqua = 1;
                return ketqua;
            }

            if (cheotren1 + cheotren2 - 1 == 3)
            {
                ketqua = 1;
                return ketqua;
            }

            //Tim duong cheo duoi tren
            //tim xuong
            for (int i = 0; i < n; i++)
            {
                if (x + i == n - 1 || y - i == 0)
                {
                    if (a[x + i, y - i].Text == kytu)
                    {
                        cheoduoi1 = cheoduoi1 + 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[x + i, y - i].Text == kytu)
                {
                    cheoduoi1 = cheoduoi1 + 1;
                }
            }

            //tim len
            for (int i = 0; i < n; i++)
            {
                if (x - i == 0 || y + i == n - 1)
                {
                    if (a[x - i, y + i].Text == kytu)
                    {
                        cheoduoi2 = cheoduoi2 + 1;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                if (a[x - i, y + i].Text == kytu)
                {
                    cheoduoi2 = cheoduoi2 + 1;
                }
            }

            if (cheoduoi1 == 3 || cheoduoi2 == 3)
            {
                ketqua = 1;
                return ketqua;
            }

            if (cheoduoi1 + cheoduoi2 - 1 == 3)
            {
                ketqua = 1;
                return ketqua;
            }

            return ketqua;
        }
    }
}
