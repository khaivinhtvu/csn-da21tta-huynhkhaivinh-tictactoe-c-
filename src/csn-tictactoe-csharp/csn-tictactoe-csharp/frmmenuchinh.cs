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
    public partial class frmmenuchinh : Form
    {
        public frmmenuchinh()
        {
            InitializeComponent();
        }

        string kytu;
        string chedochoi;
        bool co = false;
        int loi = 0;

        private void btnbatdau_Click(object sender, EventArgs e)
        {
            if ((kytu != null) && (chedochoi != null))
            {
                co = true;
            } 
            else
            {
                if ((kytu == null) && (chedochoi != null))
                {
                    loi = 1;
                    chedochoi = null;
                }
                else
                {
                    if ((kytu != null) && (chedochoi == null))
                    {
                        loi = 2;
                        kytu = null;
                    } else
                    {
                        if((kytu == null) && (chedochoi == null))
                        {
                            loi = 3;
                        }
                    }
                }
            }

            if (co == true)
            {
                if(kytu == "x")
                {
                    switch (chedochoi)
                    {
                        case "3x3":
                            frm3x3 to3 = new frm3x3();
                            to3.Show();
                            break;
                        case "5x5":
                            frm5x5 to5 = new frm5x5();
                            to5.Show();
                            break;
                        case "7x7":
                            frm7x7 to7 = new frm7x7();
                            to7.Show();
                            break;
                    }
                }
                else
                {
                    switch (chedochoi)
                    {
                        case "3x3":
                            frm3x3 to3 = new frm3x3();
                            to3.Show();
                            break;
                        case "5x5":
                            frm5x5 to5 = new frm5x5();
                            to5.Show();
                            break;
                        case "7x7":
                            frm7x7 to7 = new frm7x7();
                            to7.Show();
                            break;
                    }
                }
            }
            else
            {
                switch (loi)
                {
                    case 1:
                        Form dlg1 = new Form();
                        dlg1.ShowDialog();
                        break;
                    case 2:
                        Form dlg2 = new Form();
                        dlg2.ShowDialog();
                        break;
                    case 3:
                        Form dlg3 = new Form();
                        dlg3.ShowDialog();
                        break;
                }
            }

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            kytu = "x";
        }

        private void btno_Click(object sender, EventArgs e)
        {
            kytu = "o";
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            chedochoi = "3x3";
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            chedochoi = "5x5";
        }

        private void btn7x7_Click(object sender, EventArgs e)
        {
            chedochoi = "7x7";
        }
    }
}
