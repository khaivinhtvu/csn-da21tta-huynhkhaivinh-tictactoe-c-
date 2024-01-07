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
    public partial class frm7x7 : Form
    {
        public frm7x7()
        {
            InitializeComponent();
            khoitao();
        }

        private string kytunguoichoi;
        private string kytumay;
        private int luoc;
        private int[] dichuyenmay;
        Button[,] btns = new Button[7, 7];
        private int chieusau = 1;

        private void khoitao()
        {
            btns[0, 0] = btn1;
            btns[0, 1] = btn2;
            btns[0, 2] = btn3;
            btns[0, 3] = btn4;
            btns[0, 4] = btn5;
            btns[0, 5] = btn6;
            btns[0, 6] = btn7;

            btns[1, 0] = btn8;
            btns[1, 1] = btn9;
            btns[1, 2] = btn10;
            btns[1, 3] = btn11;
            btns[1, 4] = btn12;
            btns[1, 5] = btn13;
            btns[1, 6] = btn14;

            btns[2, 0] = btn15;
            btns[2, 1] = btn16;
            btns[2, 2] = btn17;
            btns[2, 3] = btn18;
            btns[2, 4] = btn19;
            btns[2, 5] = btn20;
            btns[2, 6] = btn21;

            btns[3, 0] = btn22;
            btns[3, 1] = btn23;
            btns[3, 2] = btn24;
            btns[3, 3] = btn25;
            btns[3, 4] = btn26;
            btns[3, 5] = btn27;
            btns[3, 6] = btn28;

            btns[4, 0] = btn29;
            btns[4, 1] = btn30;
            btns[4, 2] = btn31;
            btns[4, 3] = btn32;
            btns[4, 4] = btn33;
            btns[4, 5] = btn34;
            btns[4, 6] = btn35;

            btns[5, 0] = btn36;
            btns[5, 1] = btn37;
            btns[5, 2] = btn38;
            btns[5, 3] = btn39;
            btns[5, 4] = btn40;
            btns[5, 5] = btn41;
            btns[5, 6] = btn42;

            btns[6, 0] = btn43;
            btns[6, 1] = btn44;
            btns[6, 2] = btn45;
            btns[6, 3] = btn46;
            btns[6, 4] = btn47;
            btns[6, 5] = btn48;
            btns[6, 6] = btn49;
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
            btn26.Text = " ";
            btn27.Text = " ";
            btn28.Text = " ";

            btn29.Text = " ";
            btn30.Text = " ";
            btn31.Text = " ";
            btn32.Text = " ";
            btn33.Text = " ";
            btn34.Text = " ";
            btn35.Text = " ";
            
            btn36.Text = " ";
            btn37.Text = " ";
            btn38.Text = " ";
            btn39.Text = " ";
            btn40.Text = " ";
            btn41.Text = " ";
            btn42.Text = " ";
            
            btn43.Text = " ";
            btn44.Text = " ";
            btn45.Text = " ";
            btn46.Text = " ";
            btn47.Text = " ";
            btn48.Text = " ";
            btn49.Text = " ";
        }

        private void dichuyen()
        {
            if (luoc == 1)
            {
                dichuyenmay = minimax.Dichuyen(btns, 7, chieusau, kytumay);

                for (int i = 0; i < 7; i++)
                {
                    for (int j = 0; j < 7; j++)
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
                            Thang(i, j, 7, kytumay, btns);
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

        public string Kytunguoichoi7
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
                Thang(0, 0, 7, btn1.Text, btns);
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
                Thang(0, 1, 7, btn2.Text, btns);
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
                Thang(0, 2, 7, btn3.Text, btns);
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
                Thang(0, 3, 7, btn4.Text, btns);
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
                Thang(0, 4, 7, btn5.Text, btns);
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
                Thang(0, 5, 7, btn6.Text, btns);
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
                Thang(0, 6, 7, btn7.Text, btns);
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
                Thang(1, 0, 7, btn8.Text, btns);
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
                Thang(1, 1, 7, btn9.Text, btns);
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
                Thang(1, 2, 7, btn10.Text, btns);
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
                Thang(1, 3, 7, btn11.Text, btns);
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
                Thang(1, 4, 7, btn12.Text, btns);
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
                Thang(1, 5, 7, btn13.Text, btns);
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
                Thang(1, 6, 7, btn14.Text, btns);
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
                Thang(2, 0, 7, btn15.Text, btns);
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
                Thang(2, 1, 7, btn16.Text, btns);
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
                Thang(2, 2, 7, btn17.Text, btns);
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
                Thang(2, 3, 7, btn18.Text, btns);
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
                Thang(2, 4, 7, btn19.Text, btns);
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
                Thang(2, 5, 7, btn20.Text, btns);
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
                Thang(2, 6, 7, btn21.Text, btns);
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
                Thang(3, 0, 7, btn22.Text, btns);
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
                Thang(3, 1, 7, btn23.Text, btns);
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
                Thang(3, 2, 7, btn24.Text, btns);
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
                Thang(3, 3, 7, btn25.Text, btns);
                dichuyen();
            }
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn26.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn26.Text = "X";
                            btn26.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn26.Text = "O";
                            btn26.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 4, 7, btn26.Text, btns);
                dichuyen();
            }
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn27.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn27.Text = "X";
                            btn27.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn27.Text = "O";
                            btn27.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 5, 7, btn27.Text, btns);
                dichuyen();
            }
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn28.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn28.Text = "X";
                            btn28.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn28.Text = "O";
                            btn28.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(3, 6, 7, btn28.Text, btns);
                dichuyen();
            }
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn29.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn29.Text = "X";
                            btn29.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn29.Text = "O";
                            btn29.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 0, 7, btn29.Text, btns);
                dichuyen();
            }
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn30.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn30.Text = "X";
                            btn30.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn30.Text = "O";
                            btn30.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 1, 7, btn30.Text, btns);
                dichuyen();
            }
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn31.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn31.Text = "X";
                            btn31.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn31.Text = "O";
                            btn31.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 2, 7, btn31.Text, btns);
                dichuyen();
            }
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn32.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn32.Text = "X";
                            btn32.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn32.Text = "O";
                            btn32.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 3, 7, btn32.Text, btns);
                dichuyen();
            }
        }

        private void btn33_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn33.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn33.Text = "X";
                            btn33.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn33.Text = "O";
                            btn33.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 4, 7, btn33.Text, btns);
                dichuyen();
            }
        }

        private void btn34_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn34.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn34.Text = "X";
                            btn34.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn34.Text = "O";
                            btn34.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 5, 7, btn34.Text, btns);
                dichuyen();
            }
        }

        private void btn35_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn35.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn35.Text = "X";
                            btn35.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn35.Text = "O";
                            btn35.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(4, 6, 7, btn35.Text, btns);
                dichuyen();
            }
        }

        private void btn36_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn36.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn36.Text = "X";
                            btn36.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn36.Text = "O";
                            btn36.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 0, 7, btn36.Text, btns);
                dichuyen();
            }
        }

        private void btn37_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn37.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn37.Text = "X";
                            btn37.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn37.Text = "O";
                            btn37.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 1, 7, btn37.Text, btns);
                dichuyen();
            }
        }

        private void btn38_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn38.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn38.Text = "X";
                            btn38.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn38.Text = "O";
                            btn38.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 2, 7, btn38.Text, btns);
                dichuyen();
            }
        }

        private void btn39_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn39.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn39.Text = "X";
                            btn39.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn39.Text = "O";
                            btn39.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 3, 7, btn39.Text, btns);
                dichuyen();
            }
        }

        private void btn40_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn40.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn40.Text = "X";
                            btn40.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn40.Text = "O";
                            btn40.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 4, 7, btn40.Text, btns);
                dichuyen();
            }
        }

        private void btn41_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn41.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn41.Text = "X";
                            btn41.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn41.Text = "O";
                            btn41.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 5, 7, btn41.Text, btns);
                dichuyen();
            }
        }

        private void btn42_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn42.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn42.Text = "X";
                            btn42.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn42.Text = "O";
                            btn42.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(5, 6, 7, btn42.Text, btns);
                dichuyen();
            }
        }

        private void btn43_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn43.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn43.Text = "X";
                            btn43.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn43.Text = "O";
                            btn43.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 0, 7, btn43.Text, btns);
                dichuyen();
            }
        }

        private void btn44_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn44.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn44.Text = "X";
                            btn44.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn44.Text = "O";
                            btn44.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 1, 7, btn44.Text, btns);
                dichuyen();
            }
        }

        private void btn45_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn45.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn45.Text = "X";
                            btn45.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn45.Text = "O";
                            btn45.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 2, 7, btn45.Text, btns);
                dichuyen();
            }
        }

        private void btn46_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn46.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn46.Text = "X";
                            btn46.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn46.Text = "O";
                            btn46.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 3, 7, btn46.Text, btns);
                dichuyen();
            }
        }

        private void btn47_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn47.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn47.Text = "X";
                            btn47.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn47.Text = "O";
                            btn47.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 4, 7, btn47.Text, btns);
                dichuyen();
            }
        }

        private void btn48_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn48.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn48.Text = "X";
                            btn48.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn48.Text = "O";
                            btn48.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 5, 7, btn48.Text, btns);
                dichuyen();
            }
        }

        private void btn49_Click(object sender, EventArgs e)
        {
            if (luoc == -1 && btn49.Text == " ")
            {
                switch (kytunguoichoi)
                {
                    case "x":
                        {
                            btn49.Text = "X";
                            btn49.ForeColor = Color.Blue;
                            break;
                        }
                    case "o":
                        {
                            btn49.Text = "O";
                            btn49.ForeColor = Color.Red;
                            break;
                        }
                }

                luoc = demluoc.capnhatluoc(luoc);
                Thang(6, 6, 7, btn49.Text, btns);
                dichuyen();
            }
        }

        private void frm7x7_Load(object sender, EventArgs e)
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
