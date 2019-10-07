using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODEL_CODE
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void btnConfrim_Click(object sender, EventArgs e)
        {
            var myForm = new frm1();
            myForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int mapX = Int32.Parse(txtX.Text); //get map x
            int mapY = Int32.Parse(txtY.Text); //get map y

            if (txtX.Text == "") //default values if nothing is entered
            {
                mapX = 20;
            }

            if (txtY.Text == "")
            {
                mapY = 20;
            }
        }
    }
}
