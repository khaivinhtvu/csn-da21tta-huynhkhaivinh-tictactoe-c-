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
        }

        private string kytunguoichoi;
        private int[,] kt = new int[3,3];

        public string Kytunguoichoi3
        {
            get { return kytunguoichoi; }
            set { kytunguoichoi = value; }
        }

        private void frm3x3_Activated(object sender, EventArgs e)
        {
            switch (kytunguoichoi)
            {
                case "x":
                    {
                        lbkytunguoichoi.Text = "X";
                        lbkytunguoichoi.ForeColor = Color.Blue;
                        break;
                    }
                case "o":
                    {
                        lbkytunguoichoi.Text = "O";
                        lbkytunguoichoi.ForeColor = Color.Red;
                        break;
                    }
            }
        }

        private void Thang()
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
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

            Thang();
        }

        private void btn2_Click(object sender, EventArgs e)
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

            Thang();
        }

        private void btn3_Click(object sender, EventArgs e)
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

            Thang();
        }

        private void btn4_Click(object sender, EventArgs e)
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
        }

        private void btn5_Click(object sender, EventArgs e)
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
        }

        private void btn6_Click(object sender, EventArgs e)
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
        }

        private void btn7_Click(object sender, EventArgs e)
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
        }

        private void btn8_Click(object sender, EventArgs e)
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
        }

        private void btn9_Click(object sender, EventArgs e)
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
        }
    }
}
