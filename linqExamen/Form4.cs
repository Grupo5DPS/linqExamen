using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace linqExamen
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        
        private void btnDiag_Click(object sender, EventArgs e)
        {
            Historia diag = new Historia();

            string b = diag.diagn();
            lbl1.Text = Convert.ToString(b);
        }
    }
}
