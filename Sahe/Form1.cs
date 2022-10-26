using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahe
{
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z , result;
            x = Convert.ToInt32(txtX.Text);
            y = Convert.ToInt32(txtY.Text);
            result = x * y ;
            txtresult.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtX.Clear();
            txtY.Clear();
          
            txtresult.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
