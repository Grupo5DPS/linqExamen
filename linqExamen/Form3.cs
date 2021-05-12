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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBHistoriasUsuarioDataSet.THospital' Puede moverla o quitarla según sea necesario.

        }
        historiasUsuarioDataContext historias = new historiasUsuarioDataContext();
        private void btnListarHN_Click(object sender, EventArgs e)
        {

            var consulta = historias.Hospital.OrderBy(A => A.nombreHospital);
            dataGridView1.DataSource = consulta;
        }

        private void btnListarH_Click(object sender, EventArgs e)
        {
            var consulta = historias.Hospital;
            dataGridView1.DataSource = consulta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var consulta = historias.Hospital.OrderByDescending(B => B.nombreHospital);
            dataGridView1.DataSource = consulta;
        }

        private void btn_Codasc_Click(object sender, EventArgs e)
        {
            var consulta = historias.Hospital.OrderBy(C => C.idHospital);
            dataGridView1.DataSource = consulta;
        }

        private void btnCoddesc_Click(object sender, EventArgs e)
        {
            var consulta = historias.Hospital.OrderByDescending(D => D.idHospital);
            dataGridView1.DataSource = consulta;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var consulta = historias.Hospital.Where(E => E.nombreHospital == txtNombreh.Text);
            dataGridView1.DataSource = consulta;
        }
    }
}
