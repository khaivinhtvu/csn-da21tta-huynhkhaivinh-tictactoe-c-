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
    }
}
