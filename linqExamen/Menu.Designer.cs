
namespace linqExamen
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPacientesCambio = new System.Windows.Forms.Button();
            this.btnDoctoresCambio = new System.Windows.Forms.Button();
            this.btnHospitalCambio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForm4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPacientesCambio
            // 
            this.btnPacientesCambio.Location = new System.Drawing.Point(143, 203);
            this.btnPacientesCambio.Name = "btnPacientesCambio";
            this.btnPacientesCambio.Size = new System.Drawing.Size(75, 23);
            this.btnPacientesCambio.TabIndex = 0;
            this.btnPacientesCambio.Text = "Pacientes";
            this.btnPacientesCambio.UseVisualStyleBackColor = true;
            this.btnPacientesCambio.Click += new System.EventHandler(this.btnPacientesCambio_Click);
            // 
            // btnDoctoresCambio
            // 
            this.btnDoctoresCambio.Location = new System.Drawing.Point(365, 203);
            this.btnDoctoresCambio.Name = "btnDoctoresCambio";
            this.btnDoctoresCambio.Size = new System.Drawing.Size(75, 23);
            this.btnDoctoresCambio.TabIndex = 1;
            this.btnDoctoresCambio.Text = "Doctores";
            this.btnDoctoresCambio.UseVisualStyleBackColor = true;
            this.btnDoctoresCambio.Click += new System.EventHandler(this.btnDoctoresCambio_Click);
            // 
            // btnHospitalCambio
            // 
            this.btnHospitalCambio.Location = new System.Drawing.Point(592, 203);
            this.btnHospitalCambio.Name = "btnHospitalCambio";
            this.btnHospitalCambio.Size = new System.Drawing.Size(75, 23);
            this.btnHospitalCambio.TabIndex = 2;
            this.btnHospitalCambio.Text = "Hospital";
            this.btnHospitalCambio.UseVisualStyleBackColor = true;
            this.btnHospitalCambio.Click += new System.EventHandler(this.btnHospitalCambio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDOS";
            // 
            // btnForm4
            // 
            this.btnForm4.Location = new System.Drawing.Point(388, 266);
            this.btnForm4.Name = "btnForm4";
            this.btnForm4.Size = new System.Drawing.Size(75, 23);
            this.btnForm4.TabIndex = 4;
            this.btnForm4.Text = "FORM4";
            this.btnForm4.UseVisualStyleBackColor = true;
            this.btnForm4.Click += new System.EventHandler(this.btnForm4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForm4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHospitalCambio);
            this.Controls.Add(this.btnDoctoresCambio);
            this.Controls.Add(this.btnPacientesCambio);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPacientesCambio;
        private System.Windows.Forms.Button btnDoctoresCambio;
        private System.Windows.Forms.Button btnHospitalCambio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForm4;
    }
}