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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
        historiasUsuarioDataContext historias = new historiasUsuarioDataContext();

        private void btnDoctor_Click(object sender, EventArgs e)
        {



            var consulta = from P in historias.Paciente
                           join H in historias.Historia on P.idPaciente equals H.idPaciente
                           join D in historias.Doctor on H.idDoctor equals D.idDoctor
                           select new
                           {
                               P.idPaciente,
                               P.nombre,
                               P.apellidoPaterno,
                               H.fechaRegistro,
                               D.idDoctor,
                               D.apellidoMaterno
                               
                           };
            dgGridview.DataSource = consulta;
        }

        private void btnPersonales_Click(object sender, EventArgs e)
        {

            var consulta = from P in historias.Paciente
                           join H in historias.Historia on P.idPaciente equals H.idPaciente
                           join A in historias.AntecedentesPersonales on H.idAntecedenteP equals A.idAntecedenteP
                           select new
                           {
                               P.idPaciente,
                               P.nombre,
                               P.apellidoPaterno,
                               H.motivoConsulta,
                               A.relacionesSexuales,
                               A.usasProteccion,
                               A.vacunaViruela,
                               A.vacunaHepatitis,
                               A.otrasVacunas
                           };

            dgGridview.DataSource = consulta;
        }

        private void btnFamiliares_Click(object sender, EventArgs e)
        {
            var consulta = from P in historias.Paciente
                           join H in historias.Historia on P.idPaciente equals H.idPaciente
                           join A in historias.AntecedentesFamiliares on H.idAntecedenteF equals A.idAntecedenteF
                           select new
                           {
                               P.idPaciente,
                               P.nombre,
                               P.apellidoPaterno,
                               H.motivoConsulta,
                               A.diabetes,
                               A.covid,
                               A.otrasEnfermedades
                           };

            dgGridview.DataSource = consulta;
        }

        private void btnQuirurjicos_Click(object sender, EventArgs e)
        {
            var consulta = from P in historias.Paciente
                           join H in historias.Historia on P.idPaciente equals H.idPaciente
                           join A in historias.AntecedentesQuirurjicos on H.idAntecedenteQ equals A.idAntecedenteQ
                           select new
                           {
                               P.idPaciente,
                               P.nombre,
                               P.apellidoPaterno,
                               H.motivoConsulta,
                               A.tuvoIntervencion,
                               A.alergias,
                               A.sufreDiabetes,
                               A.sufreHipertension,
                               A.otrasEnfermedades,
                               A.medicamentos
                           };

            dgGridview.DataSource = consulta;
        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            var consulta = from P in historias.Paciente
                           join H in historias.Historia on P.idPaciente equals H.idPaciente
                           join D in historias.Diagnosticos on H.codDiagnostico equals D.codDiagnostico
                           select new
                           {
                               P.idPaciente,
                               P.nombre,
                               P.apellidoPaterno,
                               H.fechaRegistro,
                               D.codDiagnostico,
                               D.descripcion
                               
                           };

            dgGridview.DataSource = consulta;

        }
    }
}
