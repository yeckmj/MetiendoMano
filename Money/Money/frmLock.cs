using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Money
{
    public partial class frm ck : Form
    {
        private Fade fade = new Fade();
        public frmLock()
        {
            InitializeComponent();
        }

        private void frmLock_DoubleClick(object sender, EventArgs e)
        {
            fade.FadeOut(this);
        }





    }
}