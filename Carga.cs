using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Catan_Junior
{
    public partial class Carga : Form
    {
        public Carga()
        {
            InitializeComponent();
            this.TransparencyKey = Color.FromArgb(0xAA, 0x00, 0xFF);
            this.BackColor = Color.FromArgb(0xAA, 0x00, 0xFF);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarraC.Increment(1);
            if (BarraC.Value == BarraC.Maximum)
            {
                timer1.Stop();
            }
        }
    }
}
