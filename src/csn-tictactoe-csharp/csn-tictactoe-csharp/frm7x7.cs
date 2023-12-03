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
    }
}
