namespace Implementacion2ColaEstaticaPrioridad
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCola0 = new System.Windows.Forms.Label();
            this.lblCola1 = new System.Windows.Forms.Label();
            this.tbcCitas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAbrirCodigo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGuardarCita = new System.Windows.Forms.Button();
            this.pbCodigo = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtMostrar = new System.Windows.Forms.Label();
            this.pbCodigo2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkPrioridad = new System.Windows.Forms.CheckBox();
            this.tbcCitas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Citas urgentes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fila";
            // 
            // lblCola0
            // 
            this.lblCola0.AutoSize = true;
            this.lblCola0.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCola0.Location = new System.Drawing.Point(158, 23);
            this.lblCola0.Name = "lblCola0";
            this.lblCola0.Size = new System.Drawing.Size(51, 18);
            this.lblCola0.TabIndex = 4;
            this.lblCola0.Text = "Cola 0";
            // 
            // lblCola1
            // 
            this.lblCola1.AutoSize = true;
            this.lblCola1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCola1.Location = new System.Drawing.Point(158, 48);
            this.lblCola1.Name = "lblCola1";
            this.lblCola1.Size = new System.Drawing.Size(51, 18);
            this.lblCola1.TabIndex = 5;
            this.lblCola1.Text = "Cola 1";
            // 
            // tbcCitas
            // 
            this.tbcCitas.Controls.Add(this.tabPage1);
            this.tbcCitas.Controls.Add(this.tabPage2);
            this.tbcCitas.Location = new System.Drawing.Point(12, 12);
            this.tbcCitas.Name = "tbcCitas";
            this.tbcCitas.SelectedIndex = 0;
            this.tbcCitas.Size = new System.Drawing.Size(524, 361);
            this.tbcCitas.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pbCodigo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agendar cita";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAbrirCodigo);
            this.groupBox2.Location = new System.Drawing.Point(18, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agendar cita ";
            // 
            // btnAbrirCodigo
            // 
            this.btnAbrirCodigo.Location = new System.Drawing.Point(131, 49);
            this.btnAbrirCodigo.Name = "btnAbrirCodigo";
            this.btnAbrirCodigo.Size = new System.Drawing.Size(75, 39);
            this.btnAbrirCodigo.TabIndex = 8;
            this.btnAbrirCodigo.Text = "Agregar cita (código)";
            this.btnAbrirCodigo.UseVisualStyleBackColor = true;
            this.btnAbrirCodigo.Click += new System.EventHandler(this.btnAbrirCodigo_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkPrioridad);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnGuardarCita);
            this.groupBox1.Location = new System.Drawing.Point(18, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 127);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendar nueva cita";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(88, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 24);
            this.txtNombre.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nombre: ";
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.Location = new System.Drawing.Point(131, 78);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCita.TabIndex = 0;
            this.btnGuardarCita.Text = "Agendar cita";
            this.btnGuardarCita.UseVisualStyleBackColor = true;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // pbCodigo
            // 
            this.pbCodigo.Location = new System.Drawing.Point(384, 174);
            this.pbCodigo.Name = "pbCodigo";
            this.pbCodigo.Size = new System.Drawing.Size(100, 50);
            this.pbCodigo.TabIndex = 7;
            this.pbCodigo.TabStop = false;
            this.pbCodigo.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtMostrar);
            this.tabPage2.Controls.Add(this.pbCodigo2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lblCola0);
            this.tabPage2.Controls.Add(this.lblCola1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Citas agendadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtMostrar
            // 
            this.txtMostrar.AutoSize = true;
            this.txtMostrar.Location = new System.Drawing.Point(45, 129);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(0, 13);
            this.txtMostrar.TabIndex = 9;
            // 
            // pbCodigo2
            // 
            this.pbCodigo2.Location = new System.Drawing.Point(351, 165);
            this.pbCodigo2.Name = "pbCodigo2";
            this.pbCodigo2.Size = new System.Drawing.Size(100, 50);
            this.pbCodigo2.TabIndex = 8;
            this.pbCodigo2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Se debe poner la tabla de sql server para que se vea\r\n";
            // 
            // checkPrioridad
            // 
            this.checkPrioridad.AutoSize = true;
            this.checkPrioridad.Location = new System.Drawing.Point(14, 59);
            this.checkPrioridad.Name = "checkPrioridad";
            this.checkPrioridad.Size = new System.Drawing.Size(67, 17);
            this.checkPrioridad.TabIndex = 6;
            this.checkPrioridad.Text = "Prioridad";
            this.checkPrioridad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 382);
            this.Controls.Add(this.tbcCitas);
            this.Name = "Form1";
            this.Text = "Registro de citas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcCitas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCodigo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCola0;
        private System.Windows.Forms.Label lblCola1;
        private System.Windows.Forms.TabControl tbcCitas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGuardarCita;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pbCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbCodigo2;
        private System.Windows.Forms.Label txtMostrar;
        private System.Windows.Forms.Button btnAbrirCodigo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkPrioridad;
    }
}

