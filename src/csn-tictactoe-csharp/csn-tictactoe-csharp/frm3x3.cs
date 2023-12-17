using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csn_tictactoe_csharp
{
    public partial class frm3x3 : Form
    {
        public frm3x3()
        {
            InitializeComponent();
            khoitao();
        }

        private string kytunguoichoi;
        private string kytumay;
        private int luoc;
        private int[] dichuyenmay;
        Button[,] btns = new Button[3, 3];

        public string Kytunguoichoi3
        {
            get { return kytunguoichoi; }
            set { kytunguoichoi = value; }
        }

        private void khoitao()
        {
            btns[0, 0] = btn1;
            btns[0, 1] = btn2;
            btns[0, 2] = btn3;
            btns[1, 0] = btn4;
            btns[1, 1] = btn5;
            btns[1, 2] = btn6;
            btns[2, 0] = btn7;
            btns[2, 1] = btn8;
            btns[2, 2] = btn9;
        }

        private void datlainut()
        {
            btn1.Text = " ";
            btn2.Text = " ";
            btn3.Text = " ";
            btn4.Text = " ";
            btn5.Text = " ";
            btn6.Text = " ";
            btn7.Text = " ";
            btn8.Text = " ";
            btn9.Text = " ";
        }

        private void Thang(int x, int y, int n, string chu, Button[,] b)
        {
            int dk;
            dk = dieukieuthang.kiemtraThang(x, y, n, chu, b);
            switch (dk)
            {
                case 0:
                    {
                        MessageBox.Show("Hoà!");
                        datlainut();
                        luoc = demluoc.datlailuoc(luoc, kytunguoichoi);
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("X thắng!");
                        datlainut();
                        luoc = demluoc.datlailuoc(luoc, kytunguoichoi);
                        break;
                    }
                case -1:
                    {
                        MessageBox.Show("O thắng!");
                        datlainut();
                        luoc = demluoc.datlailuoc(luoc, kytunguoichoi);
                        break;
                    }
            }
        }

        private void frm3x3_Activated(object sender, EventArgs e)
        {
            switch (kytunguoichoi)
            {
                case "x":
                    {
                        kytumay = "O";
                        lbkytunguoichoi.Text = "X";
                        lbkytunguoichoi.ForeColor = Color.Blue;
                        lbkytumay.Text = "O";
                        lbkytumay.ForeColor = Color.Red;
                        luoc = -1;
                        break;
                    }
                case "o":
                    {
                        kytumay = "X";
                        lbkytunguoichoi.Text = "O";
                        lbkytunguoichoi.ForeColor = Color.Red;
                        lbkytumay.Text = "X";
                        lbkytumay.ForeColor = Color.Blue;
                        luoc = 1;
                        break;
                    }
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn1.Text = "X";
                            btn1.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn1.Text = "O";
                            btn1.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(0, 0, 3, btn1.Text, btns);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn2.Text = "X";
                            btn2.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn2.Text = "O";
                            btn2.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(0, 1, 3, btn2.Text, btns);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn3.Text = "X";
                            btn3.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn3.Text = "O";
                            btn3.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(0, 2, 3, btn3.Text, btns);
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn4.Text = "X";
                            btn4.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn4.Text = "O";
                            btn4.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(1, 0, 3, btn4.Text, btns);
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn5.Text = "X";
                            btn5.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn5.Text = "O";
                            btn5.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(1, 1, 3, btn5.Text, btns);
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn6.Text = "X";
                            btn6.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn6.Text = "O";
                            btn6.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(1, 2, 3, btn6.Text, btns);
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn7.Text = "X";
                            btn7.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn7.Text = "O";
                            btn7.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 0, 3, btn7.Text, btns);
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn8.Text = "X";
                            btn8.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn8.Text = "O";
                            btn8.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 1, 3, btn8.Text, btns);
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (luoc == -1)
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn9.Text = "X";
                            btn9.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn9.Text = "O";
                            btn9.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 2, 3, btn9.Text, btns);
            }
        }

        private void btnmay_Click(object sender, EventArgs e)
        {
            if (luoc == 1)
            {
                dichuyenmay = minimax.Dichuyen(btns, 3, kytumay);
                //btn1
                if (dichuyenmay[0] == 0 && dichuyenmay[1] == 0)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn1.Text = "X";
                                btn1.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn1.Text = "O";
                                btn1.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(0, 0, 3, btn1.Text, btns);
                }
                //btn2
                if (dichuyenmay[0] == 0 && dichuyenmay[1] == 1)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn2.Text = "X";
                                btn2.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn2.Text = "O";
                                btn2.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(0, 1, 3, btn2.Text, btns);
                }
                //btn3
                if (dichuyenmay[0] == 0 && dichuyenmay[1] == 2)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn3.Text = "X";
                                btn3.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn3.Text = "O";
                                btn3.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(0, 2, 3, btn3.Text, btns);
                }
                //btn4
                if (dichuyenmay[0] == 1 && dichuyenmay[1] == 0)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn4.Text = "X";
                                btn4.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn4.Text = "O";
                                btn4.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(1, 0, 3, btn4.Text, btns);
                }
                //btn5
                if (dichuyenmay[0] == 1 && dichuyenmay[1] == 1)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn5.Text = "X";
                                btn5.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn5.Text = "O";
                                btn5.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(1, 1, 3, btn5.Text, btns);
                }
                //btn6
                if (dichuyenmay[0] == 1 && dichuyenmay[1] == 2)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn6.Text = "X";
                                btn6.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn6.Text = "O";
                                btn6.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(1, 2, 3, btn5.Text, btns);
                }
                //btn7
                if (dichuyenmay[0] == 2 && dichuyenmay[1] == 0)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn7.Text = "X";
                                btn7.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn7.Text = "O";
                                btn7.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(2, 0, 3, btn7.Text, btns);
                }
                //btn8
                if (dichuyenmay[0] == 2 && dichuyenmay[1] == 1)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn8.Text = "X";
                                btn8.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn8.Text = "O";
                                btn8.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(2, 1, 3, btn8.Text, btns);
                }
                //btn9
                if (dichuyenmay[0] == 2 && dichuyenmay[1] == 2)
                {
                    switch (kytumay)
                    {
                        case "X":
                            {
                                btn9.Text = "X";
                                btn9.ForeColor = Color.Blue;
                                break;
                            }
                        case "O":
                            {
                                btn9.Text = "O";
                                btn9.ForeColor = Color.Red;
                                break;
                            }
                    }

                    luoc = demluoc.capnhatluoc(luoc);
                    Thang(2, 2, 3, btn9.Text, btns);
                }
            }
        }
    }
}
