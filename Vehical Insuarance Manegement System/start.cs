using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vehical_Insuarance_Manegement_System
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
           label1.Parent = pictureBox1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();
          Start2 form = new Start2();
            form.ShowDialog();
            Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
