
namespace linqExamen
{
    partial class Form2
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
            this.btnNombreDoc = new System.Windows.Forms.Button();
            this.btnPersonales = new System.Windows.Forms.Button();
            this.btnFamiliares = new System.Windows.Forms.Button();
            this.btnQuirurjicos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgGridview = new System.Windows.Forms.DataGridView();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDiagnostico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNombreDoc
            // 
            this.btnNombreDoc.Location = new System.Drawing.Point(0, 0);
            this.btnNombreDoc.Name = "btnNombreDoc";
            this.btnNombreDoc.Size = new System.Drawing.Size(75, 23);
            this.btnNombreDoc.TabIndex = 13;
            // 
            // btnPersonales
            // 
            this.btnPersonales.Location = new System.Drawing.Point(337, 89);
            this.btnPersonales.Name = "btnPersonales";
            this.btnPersonales.Size = new System.Drawing.Size(75, 23);
            this.btnPersonales.TabIndex = 1;
            this.btnPersonales.Text = "Listar";
            this.btnPersonales.UseVisualStyleBackColor = true;
            this.btnPersonales.Click += new System.EventHandler(this.btnPersonales_Click);
            // 
            // btnFamiliares
            // 
            this.btnFamiliares.Location = new System.Drawing.Point(337, 133);
            this.btnFamiliares.Name = "btnFamiliares";
            this.btnFamiliares.Size = new System.Drawing.Size(75, 23);
            this.btnFamiliares.TabIndex = 2;
            this.btnFamiliares.Text = "Listar";
            this.btnFamiliares.UseVisualStyleBackColor = true;
            this.btnFamiliares.Click += new System.EventHandler(this.btnFamiliares_Click);
            // 
            // btnQuirurjicos
            // 
            this.btnQuirurjicos.Location = new System.Drawing.Point(337, 182);
            this.btnQuirurjicos.Name = "btnQuirurjicos";
            this.btnQuirurjicos.Size = new System.Drawing.Size(75, 23);
            this.btnQuirurjicos.TabIndex = 3;
            this.btnQuirurjicos.Text = "Listar";
            this.btnQuirurjicos.UseVisualStyleBackColor = true;
            this.btnQuirurjicos.Click += new System.EventHandler(this.btnQuirurjicos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Doctor, Paciente y Hospital";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // dgGridview
            // 
            this.dgGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridview.Location = new System.Drawing.Point(86, 274);
            this.dgGridview.Name = "dgGridview";
            this.dgGridview.Size = new System.Drawing.Size(646, 147);
            this.dgGridview.TabIndex = 8;
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(337, 41);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnDoctor.TabIndex = 14;
            this.btnDoctor.Text = "Listar ";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Paciente, Historia y Antecedentes Personales";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Paciente, Historia y Antecedentes Quirurjicos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Paciente, Historia y Antecedentes Familiares";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Paciente, Historia y Diagnostico";
            // 
            // btnDiagnostico
            // 
            this.btnDiagnostico.Location = new System.Drawing.Point(337, 229);
            this.btnDiagnostico.Name = "btnDiagnostico";
            this.btnDiagnostico.Size = new System.Drawing.Size(75, 23);
            this.btnDiagnostico.TabIndex = 20;
            this.btnDiagnostico.Text = "Listar";
            this.btnDiagnostico.UseVisualStyleBackColor = true;
            this.btnDiagnostico.Click += new System.EventHandler(this.btnDiagnostico_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDiagnostico);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.dgGridview);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuirurjicos);
            this.Controls.Add(this.btnFamiliares);
            this.Controls.Add(this.btnPersonales);
            this.Controls.Add(this.btnNombreDoc);
            this.Name = "Form2";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNombreDoc;
        private System.Windows.Forms.Button btnPersonales;
        private System.Windows.Forms.Button btnFamiliares;
        private System.Windows.Forms.Button btnQuirurjicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgGridview;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDiagnostico;
    }
}