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
    public partial class frm5x5 : Form
    {
        public frm5x5()
        {
            InitializeComponent();
            khoitao();
        }

        private string kytunguoichoi;
        private string kytumay;
        private int luoc;
        private int[] dichuyenmay;
        Button[,] btns = new Button[5, 5];
        private int chieusau = 3;

        private void khoitao()
        {
            btns[0, 0] = btn1;
            btns[0, 1] = btn2;
            btns[0, 2] = btn3;
            btns[0, 3] = btn4;
            btns[0, 4] = btn5;

            btns[1, 0] = btn6;
            btns[1, 1] = btn7;
            btns[1, 2] = btn8;
            btns[1, 3] = btn9;
            btns[1, 4] = btn10;

            btns[2, 0] = btn11;
            btns[2, 1] = btn12;
            btns[2, 2] = btn13;
            btns[2, 3] = btn14;
            btns[2, 4] = btn15;

            btns[3, 0] = btn16;
            btns[3, 1] = btn17;
            btns[3, 2] = btn18;
            btns[3, 3] = btn19;
            btns[3, 4] = btn20;

            btns[4, 0] = btn21;
            btns[4, 1] = btn22;
            btns[4, 2] = btn23;
            btns[4, 3] = btn24;
            btns[4, 4] = btn25;
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
            btn10.Text = " ";

            btn11.Text = " ";
            btn12.Text = " ";
            btn13.Text = " ";
            btn14.Text = " ";
            btn15.Text = " ";

            btn16.Text = " ";
            btn17.Text = " ";
            btn18.Text = " ";
            btn19.Text = " ";
            btn20.Text = " ";

            btn21.Text = " ";
            btn22.Text = " ";
            btn23.Text = " ";
            btn24.Text = " ";
            btn25.Text = " ";
        }

        private void dichuyen()
        {
            if (luoc == 1)
            {
                dichuyenmay = minimax.Dichuyen(btns, 5, chieusau, kytumay);

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (i == dichuyenmay[0] && j == dichuyenmay[1] && btns[i, j].Text == " ")
                        {
                            btns[i, j].Text = kytumay;
                            if (kytumay == "X")
                            {
                                btns[i, j].ForeColor = Color.Blue;
                            }
                            if (kytumay == "O")
                            {
                                btns[i, j].ForeColor = Color.Red;
                            }
                            luoc = demluoc.capnhatluoc(luoc);
                            Thang(i, j, 5, kytumay, btns);
                            break;
                        }
                    }
                }
            }
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
                        if (luoc == 1) { dichuyen(); }
                        break;
                    }
                case 1:
                    {
                        MessageBox.Show("X thắng!");
                        datlainut();
                        luoc = demluoc.datlailuoc(luoc, kytunguoichoi);
                        if (luoc == 1) { dichuyen(); }
                        break;
                    }
                case -1:
                    {
                        MessageBox.Show("O thắng!");
                        datlainut();
                        luoc = demluoc.datlailuoc(luoc, kytunguoichoi);
                        if (luoc == 1) { dichuyen(); }
                        break;
                    }
            }
        }

        public string Kytunguoichoi5
        {
            get { return kytunguoichoi; }
            set { kytunguoichoi = value; }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn1.Text == " ")
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
                Thang(0, 0, 5, btn1.Text, btns);
                dichuyen();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn2.Text == " ")
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
                Thang(0, 1, 5, btn2.Text, btns);
                dichuyen();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn3.Text == " ")
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
                Thang(0, 2, 5, btn3.Text, btns);
                dichuyen();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn4.Text == " ")
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
                Thang(0, 3, 5, btn4.Text, btns);
                dichuyen();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn5.Text == " ")
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
                Thang(0, 4, 5, btn5.Text, btns);
                dichuyen();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn6.Text == " ")
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
                Thang(1, 0, 5, btn6.Text, btns);
                dichuyen();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn7.Text == " ")
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
                Thang(1, 1, 5, btn7.Text, btns);
                dichuyen();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn8.Text == " ")
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
                Thang(1, 2, 5, btn8.Text, btns);
                dichuyen();
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn9.Text == " ")
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
                Thang(1, 3, 5, btn9.Text, btns);
                dichuyen();
            }
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn10.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn10.Text = "X";
                            btn10.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn10.Text = "O";
                            btn10.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(1, 4, 5, btn10.Text, btns);
                dichuyen();
            }
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn11.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn11.Text = "X";
                            btn11.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn11.Text = "O";
                            btn11.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 0, 5, btn11.Text, btns);
                dichuyen();
            }
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn12.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn12.Text = "X";
                            btn12.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn12.Text = "O";
                            btn12.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 1, 5, btn12.Text, btns);
                dichuyen();
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn13.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn13.Text = "X";
                            btn13.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn13.Text = "O";
                            btn13.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 2, 5, btn13.Text, btns);
                dichuyen();
            }
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn14.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn14.Text = "X";
                            btn14.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn14.Text = "O";
                            btn14.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 3, 5, btn14.Text, btns);
                dichuyen();
            }
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn15.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn15.Text = "X";
                            btn15.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn15.Text = "O";
                            btn15.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(2, 4, 5, btn15.Text, btns);
                dichuyen();
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn16.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn16.Text = "X";
                            btn16.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn16.Text = "O";
                            btn16.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 0, 5, btn16.Text, btns);
                dichuyen();
            }
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn17.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn17.Text = "X";
                            btn17.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn17.Text = "O";
                            btn17.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 1, 5, btn17.Text, btns);
                dichuyen();
            }
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn18.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn18.Text = "X";
                            btn18.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn18.Text = "O";
                            btn18.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 2, 5, btn18.Text, btns);
                dichuyen();
            }
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn19.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn19.Text = "X";
                            btn19.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn19.Text = "O";
                            btn19.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 3, 5, btn19.Text, btns);
                dichuyen();
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn20.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn20.Text = "X";
                            btn20.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn20.Text = "O";
                            btn20.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 4, 5, btn20.Text, btns);
                dichuyen();
            }
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn21.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn21.Text = "X";
                            btn21.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn21.Text = "O";
                            btn21.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 0, 5, btn21.Text, btns);
                dichuyen();
            }
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn22.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn22.Text = "X";
                            btn22.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn22.Text = "O";
                            btn22.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 1, 5, btn22.Text, btns);
                dichuyen();
            }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn23.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn23.Text = "X";
                            btn23.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn23.Text = "O";
                            btn23.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 2, 5, btn23.Text, btns);
                dichuyen();
            }
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn24.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn24.Text = "X";
                            btn24.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn24.Text = "O";
                            btn24.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 3, 5, btn24.Text, btns);
                dichuyen();
            }
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn25.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn25.Text = "X";
                            btn25.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn25.Text = "O";
                            btn25.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 4, 5, btn25.Text, btns);
                dichuyen();
            }
        }

        private void frm5x5_Load(object sender, EventArgs e)
        {
            datlainut();
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
                        dichuyen();
                        break;
                    }
            }
        }
    }
}
