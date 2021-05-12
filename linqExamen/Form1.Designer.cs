
namespace linqExamen
{
    partial class gvPaciente
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCodigo = new System.Windows.Forms.Button();
            this.dgGridview = new System.Windows.Forms.DataGridView();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.btnDni = new System.Windows.Forms.Button();
            this.btnOcupacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCodigo
            // 
            this.btnCodigo.Location = new System.Drawing.Point(372, 61);
            this.btnCodigo.Name = "btnCodigo";
            this.btnCodigo.Size = new System.Drawing.Size(116, 23);
            this.btnCodigo.TabIndex = 3;
            this.btnCodigo.Text = "Buscar Codigo";
            this.btnCodigo.UseVisualStyleBackColor = true;
            this.btnCodigo.Click += new System.EventHandler(this.btnCodigo_Click);
            // 
            // dgGridview
            // 
            this.dgGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridview.Location = new System.Drawing.Point(124, 220);
            this.dgGridview.Name = "dgGridview";
            this.dgGridview.Size = new System.Drawing.Size(364, 169);
            this.dgGridview.TabIndex = 4;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(228, 61);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(116, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(228, 97);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(116, 20);
            this.txtDni.TabIndex = 6;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Location = new System.Drawing.Point(228, 137);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(116, 20);
            this.txtOcupacion.TabIndex = 7;
            // 
            // btnDni
            // 
            this.btnDni.Location = new System.Drawing.Point(372, 97);
            this.btnDni.Name = "btnDni";
            this.btnDni.Size = new System.Drawing.Size(116, 23);
            this.btnDni.TabIndex = 8;
            this.btnDni.Text = "Buscar DNI";
            this.btnDni.UseVisualStyleBackColor = true;
            this.btnDni.Click += new System.EventHandler(this.btnDni_Click);
            // 
            // btnOcupacion
            // 
            this.btnOcupacion.Location = new System.Drawing.Point(372, 137);
            this.btnOcupacion.Name = "btnOcupacion";
            this.btnOcupacion.Size = new System.Drawing.Size(116, 23);
            this.btnOcupacion.TabIndex = 9;
            this.btnOcupacion.Text = "Buscar Ocupación";
            this.btnOcupacion.UseVisualStyleBackColor = true;
            this.btnOcupacion.Click += new System.EventHandler(this.btnOcupacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 8.25F);
            this.label2.Location = new System.Drawing.Point(121, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 8.25F);
            this.label3.Location = new System.Drawing.Point(111, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ingrese Ocupación";
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(372, 175);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(116, 24);
            this.btnIngreso.TabIndex = 13;
            this.btnIngreso.Text = "Buscar por año";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(228, 175);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(116, 20);
            this.txtAnio.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 8.25F);
            this.label4.Location = new System.Drawing.Point(121, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ingrese año ";
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVolver.Location = new System.Drawing.Point(616, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(116, 24);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Formulario 2";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(636, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "BIENVENIDO, AQUÍ PUEDE CONSULTAR LA INFORMACIÓN DEL PACIENTE";
            // 
            // gvPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOcupacion);
            this.Controls.Add(this.btnDni);
            this.Controls.Add(this.txtOcupacion);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.dgGridview);
            this.Controls.Add(this.btnCodigo);
            this.Name = "gvPaciente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCodigo;
        private System.Windows.Forms.DataGridView dgGridview;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtOcupacion;
        private System.Windows.Forms.Button btnDni;
        private System.Windows.Forms.Button btnOcupacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label5;
    }
}

