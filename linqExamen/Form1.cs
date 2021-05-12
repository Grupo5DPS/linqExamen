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
    public partial class gvPaciente : Form
    {
        public gvPaciente()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        historiasUsuarioDataContext historias = new historiasUsuarioDataContext();
        Form2 f2 = new Form2();
        private void btnCodigo_Click(object sender, EventArgs e)
        {
            //Consultar por Codigo PROYECCION
            var consulta = from P in historias.Paciente
                           where P.idPaciente.Contains(txtCodigo.Text)
                           select new
                           {
                               P.idPaciente,
                               P.nombre,
                               P.apellidoPaterno,
                               P.apellidoMaterno,
                           };
            dgGridview.DataSource = consulta;

        }

        private void btnDni_Click(object sender, EventArgs e)
        {
            var consulta = from P in historias.Paciente
                           where P.dni.Contains(txtDni.Text)
                           select new
                           {
                               P.nombre,
                               P.dni,
                           };
            dgGridview.DataSource = consulta;
        }

        private void btnOcupacion_Click(object sender, EventArgs e)
        {
            var consulta = from P in historias.Paciente
                           where P.ocupacion.Contains(txtOcupacion.Text)
                           select new
                           {
                               P.nombre,
                               P.apellidoPaterno,
                               P.apellidoMaterno,
                               P.ocupacion,
                           };
            dgGridview.DataSource = consulta;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtAnio.Text);
            var consulta = from P in historias.Paciente
                           where Convert.ToInt32(P.fechaIngreso.Year) == x
                           select P;
            dgGridview.DataSource = consulta;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            f2.Show();
       
        }
    }
}
