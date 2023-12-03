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
                            frm3x3 to3 = new frm3x3
                            {
                                Kytunguoichoi3 = "x"
                            };
                            to3.Show();
                            break;
                        case "5x5":
                            frm5x5 to5 = new frm5x5 
                            {
                                Kytunguoichoi5 = "x"
                            };
                            to5.Show();
                            break;
                        case "7x7":
                            frm7x7 to7 = new frm7x7 
                            { 
                                Kytunguoichoi7 = "x"
                            };
                            to7.Show();
                            break;
                    }
                }
                else
                {
                    switch (chedochoi)
                    {
                        case "3x3":
                            frm3x3 to3 = new frm3x3
                            {
                                Kytunguoichoi3 = "o"
                            };
                            to3.Show();
                            break;
                        case "5x5":
                            frm5x5 to5 = new frm5x5
                            {
                                Kytunguoichoi5 = "o"
                            };
                            to5.Show();
                            break;
                        case "7x7":
                            frm7x7 to7 = new frm7x7 
                            {
                                Kytunguoichoi7 = "o"
                            };
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
                        frmloi dlg1 = new frmloi
                        {
                            Maloi = 1
                        };
                        dlg1.ShowDialog();
                        break;
                    case 2:
                        frmloi dlg2 = new frmloi
                        {
                            Maloi = 2
                        };
                        dlg2.ShowDialog();
                        break;
                    case 3:
                        frmloi dlg3 = new frmloi
                        {
                            Maloi = 3
                        };
                        dlg3.ShowDialog();
                        break;
                }
            }

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            kytu = "x";
            btnx.BackColor = Color.YellowGreen;
            btno.BackColor = SystemColors.Control;
        }

        private void btno_Click(object sender, EventArgs e)
        {
            kytu = "o";
            btno.BackColor = Color.YellowGreen;
            btnx.BackColor = SystemColors.Control;
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            chedochoi = "3x3";
            btn3x3.BackColor = Color.YellowGreen;
            btn5x5.BackColor = SystemColors.Control;
            btn7x7.BackColor = SystemColors.Control;
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            chedochoi = "5x5";
            btn5x5.BackColor = Color.YellowGreen;
            btn3x3.BackColor = SystemColors.Control;
            btn7x7.BackColor = SystemColors.Control;
        }

        private void btn7x7_Click(object sender, EventArgs e)
        {
            chedochoi = "7x7";
            btn7x7.BackColor = Color.YellowGreen;
            btn5x5.BackColor = SystemColors.Control;
            btn3x3.BackColor = SystemColors.Control;
        }
    }
}
