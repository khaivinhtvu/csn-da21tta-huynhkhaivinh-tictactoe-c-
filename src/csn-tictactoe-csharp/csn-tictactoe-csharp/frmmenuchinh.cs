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
                        MessageBox.Show("Chọn ký tự của bạn");
                        btnx.BackColor = Color.White;
                        btno.BackColor = Color.White;
                        btn3x3.BackColor = Color.White;
                        btn5x5.BackColor = Color.White;
                        btn7x7.BackColor = Color.White;
                        break;
                    case 2:
                        MessageBox.Show("Chọn chế độ chơi");
                        btnx.BackColor = Color.White;
                        btno.BackColor = Color.White;
                        btn3x3.BackColor = Color.White;
                        btn5x5.BackColor = Color.White;
                        btn7x7.BackColor = Color.White;
                        break;
                    case 3:
                        MessageBox.Show("Chọn ký tự của bạn và chọn chế độ chơi");
                        kytu = null;
                        chedochoi = null;
                        btnx.BackColor = Color.White;
                        btno.BackColor = Color.White;
                        btn3x3.BackColor = Color.White;
                        btn5x5.BackColor = Color.White;
                        btn7x7.BackColor = Color.White;
                        break;
                }
            }

        }

        private void btnx_Click(object sender, EventArgs e)
        {
            if (kytu == null || kytu == "o")
            {
                kytu = "x";
                btnx.BackColor = Color.YellowGreen;
                btno.BackColor = Color.White;
            }
            else
            {
                kytu = null;
                btnx.BackColor = Color.White;
                btno.BackColor = Color.White;
            }
        }

        private void btno_Click(object sender, EventArgs e)
        {
            if (kytu == null || kytu == "x")
            {
                kytu = "o";
                btno.BackColor = Color.YellowGreen;
                btnx.BackColor = Color.White;
            }
            else
            {
                kytu = null;
                btnx.BackColor = Color.White;
                btno.BackColor = Color.White;
            }
        }

        private void btn3x3_Click(object sender, EventArgs e)
        {
            if (chedochoi == null || chedochoi == "5x5" || chedochoi == "7x7")
            {
                chedochoi = "3x3";
                btn3x3.BackColor = Color.YellowGreen;
                btn5x5.BackColor = Color.White;
                btn7x7.BackColor = Color.White;
            }
            else
            {
                chedochoi = null;
                btn3x3.BackColor = Color.White;
                btn5x5.BackColor = Color.White;
                btn7x7.BackColor = Color.White;
            }
        }

        private void btn5x5_Click(object sender, EventArgs e)
        {
            if (chedochoi == null || chedochoi == "3x3" || chedochoi == "7x7")
            {
                chedochoi = "5x5";
                btn5x5.BackColor = Color.YellowGreen;
                btn3x3.BackColor = Color.White;
                btn7x7.BackColor = Color.White;
            }
            else
            {
                chedochoi = null;
                btn3x3.BackColor = Color.White;
                btn5x5.BackColor = Color.White;
                btn7x7.BackColor = Color.White;
            }
        }

        private void btn7x7_Click(object sender, EventArgs e)
        {
            if (chedochoi == null || chedochoi == "3x3" || chedochoi == "5x5")
            {
                chedochoi = "7x7";
                btn7x7.BackColor = Color.YellowGreen;
                btn3x3.BackColor = Color.White;
                btn5x5.BackColor = Color.White;
            }
            else
            {
                chedochoi = null;
                btn3x3.BackColor = Color.White;
                btn5x5.BackColor = Color.White;
                btn7x7.BackColor = Color.White;
            }
        }
    }
}
