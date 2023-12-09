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
        }

        private string kytunguoichoi;

        public string Kytunguoichoi7
        {
            get { return kytunguoichoi; }
            set { kytunguoichoi = value; }
        }

        private void frm7x7_Activated(object sender, EventArgs e)
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

        private void btn26_Click(object sender, EventArgs e)
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
        }

        private void btn27_Click(object sender, EventArgs e)
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
        }

        private void btn28_Click(object sender, EventArgs e)
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
        }

        private void btn29_Click(object sender, EventArgs e)
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
        }

        private void btn30_Click(object sender, EventArgs e)
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
        }

        private void btn31_Click(object sender, EventArgs e)
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
        }

        private void btn32_Click(object sender, EventArgs e)
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
        }

        private void btn33_Click(object sender, EventArgs e)
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
        }

        private void btn34_Click(object sender, EventArgs e)
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
        }

        private void btn35_Click(object sender, EventArgs e)
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
        }

        private void btn36_Click(object sender, EventArgs e)
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
        }

        private void btn37_Click(object sender, EventArgs e)
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
        }

        private void btn38_Click(object sender, EventArgs e)
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
        }

        private void btn39_Click(object sender, EventArgs e)
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
        }

        private void btn40_Click(object sender, EventArgs e)
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
        }

        private void btn41_Click(object sender, EventArgs e)
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
        }

        private void btn42_Click(object sender, EventArgs e)
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
        }

        private void btn43_Click(object sender, EventArgs e)
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
        }

        private void btn44_Click(object sender, EventArgs e)
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
        }

        private void btn45_Click(object sender, EventArgs e)
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
        }

        private void btn46_Click(object sender, EventArgs e)
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
        }

        private void btn47_Click(object sender, EventArgs e)
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
        }

        private void btn48_Click(object sender, EventArgs e)
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
        }

        private void btn49_Click(object sender, EventArgs e)
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
        }
    }
}
