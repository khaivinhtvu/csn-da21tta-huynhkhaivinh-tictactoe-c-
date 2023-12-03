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
        }

        private string kytunguoichoi;

        public string Kytunguoichoi5
        {
            get { return kytunguoichoi; }
            set { kytunguoichoi = value; }
        }

        private void frm5x5_Activated(object sender, EventArgs e)
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

        private void btn10_Click(object sender, EventArgs e)
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
        }

        private void btn11_Click(object sender, EventArgs e)
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
        }

        private void btn12_Click(object sender, EventArgs e)
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
        }

        private void btn13_Click(object sender, EventArgs e)
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
        }

        private void btn14_Click(object sender, EventArgs e)
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
        }

        private void btn15_Click(object sender, EventArgs e)
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
        }

        private void btn16_Click(object sender, EventArgs e)
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
        }

        private void btn17_Click(object sender, EventArgs e)
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
        }

        private void btn18_Click(object sender, EventArgs e)
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
        }

        private void btn19_Click(object sender, EventArgs e)
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
        }

        private void btn20_Click(object sender, EventArgs e)
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
        }

        private void btn21_Click(object sender, EventArgs e)
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
        }

        private void btn22_Click(object sender, EventArgs e)
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
        }

        private void btn23_Click(object sender, EventArgs e)
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
        }

        private void btn24_Click(object sender, EventArgs e)
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
        }

        private void btn25_Click(object sender, EventArgs e)
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
        }
    }
}
