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
    public partial class frmloi : Form
    {
        public frmloi()
        {
            InitializeComponent();
        }

        private int maloi;

        public int Maloi
        {
            get { return maloi; }
            set { maloi = value; }
        }

        private void frmloi_Activated(object sender, EventArgs e)
        {
            switch (maloi)
            {
                case 1:
                    {
                        lbloi.Text = "Vui lòng chọn ký tự của bạn";
                        break;
                    }
                case 2:
                    {
                        lbloi.Text = "Vui lòng chọn chế độ chơi";
                        break;
                    }
                case 3:
                    {
                        lbloi.Text = "Vui lòng chọn ký tự của bạn và chọn chế độ chơi";
                        break;
                    }
            }
        }
    }
}
