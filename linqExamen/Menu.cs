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
    public partial class Menu : Form
    {
      
        public Menu()
        {
            InitializeComponent();
        }
        historiasUsuarioDataContext historias = new historiasUsuarioDataContext();
        gvPaciente f1 = new gvPaciente();
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        private void btnPacientesCambio_Click(object sender, EventArgs e)
        {
            f1.Show();
        }

        private void btnDoctoresCambio_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void btnHospitalCambio_Click(object sender, EventArgs e)
        {
            f3.Show();
        }

        private void btnForm4_Click(object sender, EventArgs e)
        {
            f4.Show();
        }
    }
}
