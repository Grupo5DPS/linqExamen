
namespace linqExamen
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.btnListarHN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();

            this.tHospitalBindingSource = new System.Windows.Forms.BindingSource(this.components);

            this.btnListarH = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Codasc = new System.Windows.Forms.Button();
            this.btnCoddesc = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombreh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)(this.tHospitalBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListarHN
            // 
            this.btnListarHN.Location = new System.Drawing.Point(378, 77);
            this.btnListarHN.Name = "btnListarHN";
            this.btnListarHN.Size = new System.Drawing.Size(187, 29);
            this.btnListarHN.TabIndex = 0;
            this.btnListarHN.Text = "Listar por nombre Descendente";
            this.btnListarHN.UseVisualStyleBackColor = true;
            this.btnListarHN.Click += new System.EventHandler(this.btnListarHN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Hospitales Registrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.Size = new System.Drawing.Size(336, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // dBHistoriasUsuarioDataSet
            // 

            // 
            // tHospitalBindingSource
            // 
            this.tHospitalBindingSource.DataMember = "THospital";

            // 
            // tHospitalTableAdapter
            // 

            // 
            // btnListarH
            // 
            this.btnListarH.Location = new System.Drawing.Point(378, 48);
            this.btnListarH.Name = "btnListarH";
            this.btnListarH.Size = new System.Drawing.Size(75, 23);
            this.btnListarH.TabIndex = 3;
            this.btnListarH.Text = "Listar";
            this.btnListarH.UseVisualStyleBackColor = true;
            this.btnListarH.Click += new System.EventHandler(this.btnListarH_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Listar por nombre Ascendente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Codasc
            // 
            this.btn_Codasc.Location = new System.Drawing.Point(378, 148);
            this.btn_Codasc.Name = "btn_Codasc";
            this.btn_Codasc.Size = new System.Drawing.Size(187, 30);
            this.btn_Codasc.TabIndex = 5;
            this.btn_Codasc.Text = "Listar por Codigo Ascendente ";
            this.btn_Codasc.UseVisualStyleBackColor = true;
            this.btn_Codasc.Click += new System.EventHandler(this.btn_Codasc_Click);
            // 
            // btnCoddesc
            // 
            this.btnCoddesc.Location = new System.Drawing.Point(378, 185);
            this.btnCoddesc.Name = "btnCoddesc";
            this.btnCoddesc.Size = new System.Drawing.Size(187, 28);
            this.btnCoddesc.TabIndex = 6;
            this.btnCoddesc.Text = "Listar por Codigo Descendente";
            this.btnCoddesc.UseVisualStyleBackColor = true;
            this.btnCoddesc.Click += new System.EventHandler(this.btnCoddesc_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(378, 258);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombreh
            // 
            this.txtNombreh.Location = new System.Drawing.Point(378, 232);
            this.txtNombreh.Name = "txtNombreh";
            this.txtNombreh.Size = new System.Drawing.Size(100, 20);
            this.txtNombreh.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNombreh);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCoddesc);
            this.Controls.Add(this.btn_Codasc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListarH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnListarHN);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();

            ((System.ComponentModel.ISupportInitialize)(this.tHospitalBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListarHN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.BindingSource tHospitalBindingSource;

        private System.Windows.Forms.Button btnListarH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Codasc;
        private System.Windows.Forms.Button btnCoddesc;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombreh;
    }
}