using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GasMetering
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Met met = new Met();

            met.Month = txtMonth.Text;
            met.GasPoint = int.Parse(txtGasPoint.Text);
            met.GasMet = int.Parse(txtMetering.Text);

            MessageBox.Show(met.ToString());
        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            txtMonth.Text = "";
        }

        private void txtGasPoint_TextChanged(object sender, EventArgs e)
        {
            txtGasPoint.Text = "";
        }

        private void txtMetering_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
