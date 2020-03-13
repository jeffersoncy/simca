namespace appBanco
{
    partial class GestionarDespartamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionarDespartamento));
            this.tbcGestionarDepartamento = new System.Windows.Forms.TabControl();
            this.tpRegistrarDepartamento = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegVolver = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbCodigoDepartamento = new System.Windows.Forms.Label();
            this.txtCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.lbNombreDepartamento = new System.Windows.Forms.Label();
            this.dateAnioFundacionDepartamento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lbCodigoFacultad = new System.Windows.Forms.Label();
            this.txtCodigoFacultad = new System.Windows.Forms.TextBox();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.lbAnioFundacionDepartamento = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tpActualizarDepartamento = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tpVerDepartamento = new System.Windows.Forms.TabPage();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvVer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tbcGestionarDepartamento.SuspendLayout();
            this.tpRegistrarDepartamento.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tpActualizarDepartamento.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpVerDepartamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcGestionarDepartamento
            // 
            this.tbcGestionarDepartamento.Controls.Add(this.tpRegistrarDepartamento);
            this.tbcGestionarDepartamento.Controls.Add(this.tpActualizarDepartamento);
            this.tbcGestionarDepartamento.Controls.Add(this.tpVerDepartamento);
            this.tbcGestionarDepartamento.Location = new System.Drawing.Point(12, 34);
            this.tbcGestionarDepartamento.Name = "tbcGestionarDepartamento";
            this.tbcGestionarDepartamento.SelectedIndex = 0;
            this.tbcGestionarDepartamento.Size = new System.Drawing.Size(619, 386);
            this.tbcGestionarDepartamento.TabIndex = 0;
            // 
            // tpRegistrarDepartamento
            // 
            this.tpRegistrarDepartamento.Controls.Add(this.panel1);
            this.tpRegistrarDepartamento.Controls.Add(this.pictureBox1);
            this.tpRegistrarDepartamento.Location = new System.Drawing.Point(4, 22);
            this.tpRegistrarDepartamento.Name = "tpRegistrarDepartamento";
            this.tpRegistrarDepartamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpRegistrarDepartamento.Size = new System.Drawing.Size(611, 360);
            this.tpRegistrarDepartamento.TabIndex = 0;
            this.tpRegistrarDepartamento.Text = "Registrar";
            this.tpRegistrarDepartamento.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lbCodigoDepartamento);
            this.panel1.Controls.Add(this.txtCodigoDepartamento);
            this.panel1.Controls.Add(this.lbNombreDepartamento);
            this.panel1.Controls.Add(this.dateAnioFundacionDepartamento);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.lbCodigoFacultad);
            this.panel1.Controls.Add(this.txtCodigoFacultad);
            this.panel1.Controls.Add(this.txtNombreDepartamento);
            this.panel1.Controls.Add(this.lbAnioFundacionDepartamento);
            this.panel1.Location = new System.Drawing.Point(39, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 330);
            this.panel1.TabIndex = 16;
            // 
            // btnRegVolver
            // 
            this.btnRegVolver.Location = new System.Drawing.Point(509, 426);
            this.btnRegVolver.Name = "btnRegVolver";
            this.btnRegVolver.Size = new System.Drawing.Size(105, 27);
            this.btnRegVolver.TabIndex = 17;
            this.btnRegVolver.Text = "Volver";
            this.btnRegVolver.UseVisualStyleBackColor = true;
            this.btnRegVolver.Click += new System.EventHandler(this.btnRegVolver_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(362, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Ver codigos facultad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbCodigoDepartamento
            // 
            this.lbCodigoDepartamento.AutoSize = true;
            this.lbCodigoDepartamento.Location = new System.Drawing.Point(97, 70);
            this.lbCodigoDepartamento.Name = "lbCodigoDepartamento";
            this.lbCodigoDepartamento.Size = new System.Drawing.Size(108, 13);
            this.lbCodigoDepartamento.TabIndex = 0;
            this.lbCodigoDepartamento.Text = "Codigo departamento";
            // 
            // txtCodigoDepartamento
            // 
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(237, 70);
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDepartamento.TabIndex = 1;
            // 
            // lbNombreDepartamento
            // 
            this.lbNombreDepartamento.AutoSize = true;
            this.lbNombreDepartamento.Location = new System.Drawing.Point(95, 141);
            this.lbNombreDepartamento.Name = "lbNombreDepartamento";
            this.lbNombreDepartamento.Size = new System.Drawing.Size(110, 13);
            this.lbNombreDepartamento.TabIndex = 2;
            this.lbNombreDepartamento.Text = "nombre departamento";
            // 
            // dateAnioFundacionDepartamento
            // 
            this.dateAnioFundacionDepartamento.AllowDrop = true;
            this.dateAnioFundacionDepartamento.Location = new System.Drawing.Point(237, 210);
            this.dateAnioFundacionDepartamento.Name = "dateAnioFundacionDepartamento";
            this.dateAnioFundacionDepartamento.Size = new System.Drawing.Size(200, 20);
            this.dateAnioFundacionDepartamento.TabIndex = 13;
            this.dateAnioFundacionDepartamento.Value = new System.DateTime(2020, 3, 11, 0, 0, 0, 0);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(209, 285);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(85, 27);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // lbCodigoFacultad
            // 
            this.lbCodigoFacultad.AutoSize = true;
            this.lbCodigoFacultad.Location = new System.Drawing.Point(124, 107);
            this.lbCodigoFacultad.Name = "lbCodigoFacultad";
            this.lbCodigoFacultad.Size = new System.Drawing.Size(81, 13);
            this.lbCodigoFacultad.TabIndex = 4;
            this.lbCodigoFacultad.Text = "Codigo facultad";
            // 
            // txtCodigoFacultad
            // 
            this.txtCodigoFacultad.Location = new System.Drawing.Point(237, 104);
            this.txtCodigoFacultad.Name = "txtCodigoFacultad";
            this.txtCodigoFacultad.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoFacultad.TabIndex = 5;
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(237, 138);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDepartamento.TabIndex = 6;
            // 
            // lbAnioFundacionDepartamento
            // 
            this.lbAnioFundacionDepartamento.AutoSize = true;
            this.lbAnioFundacionDepartamento.Location = new System.Drawing.Point(62, 216);
            this.lbAnioFundacionDepartamento.Name = "lbAnioFundacionDepartamento";
            this.lbAnioFundacionDepartamento.Size = new System.Drawing.Size(143, 13);
            this.lbAnioFundacionDepartamento.TabIndex = 9;
            this.lbAnioFundacionDepartamento.Text = "año fundacion departamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(719, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // tpActualizarDepartamento
            // 
            this.tpActualizarDepartamento.Controls.Add(this.panel2);
            this.tpActualizarDepartamento.Location = new System.Drawing.Point(4, 22);
            this.tpActualizarDepartamento.Name = "tpActualizarDepartamento";
            this.tpActualizarDepartamento.Padding = new System.Windows.Forms.Padding(3);
            this.tpActualizarDepartamento.Size = new System.Drawing.Size(611, 387);
            this.tpActualizarDepartamento.TabIndex = 1;
            this.tpActualizarDepartamento.Text = "Actualizar";
            this.tpActualizarDepartamento.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Location = new System.Drawing.Point(33, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 330);
            this.panel2.TabIndex = 17;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 155);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.Value = new System.DateTime(2020, 3, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-16, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "año fundacion departamento";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(266, 49);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Buscar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Guardar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "ver codigos departamento";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo departamento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nombre departamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Codigo facultad";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(150, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(150, 123);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // tpVerDepartamento
            // 
            this.tpVerDepartamento.Controls.Add(this.btnVer);
            this.tpVerDepartamento.Controls.Add(this.dgvVer);
            this.tpVerDepartamento.Location = new System.Drawing.Point(4, 22);
            this.tpVerDepartamento.Name = "tpVerDepartamento";
            this.tpVerDepartamento.Size = new System.Drawing.Size(611, 387);
            this.tpVerDepartamento.TabIndex = 2;
            this.tpVerDepartamento.Text = "Ver Departamentos";
            this.tpVerDepartamento.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(442, 339);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 1;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // dgvVer
            // 
            this.dgvVer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVer.Location = new System.Drawing.Point(34, 14);
            this.dgvVer.Name = "dgvVer";
            this.dgvVer.Size = new System.Drawing.Size(474, 319);
            this.dgvVer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Departamentos SIMCA";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(480, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // GestionarDespartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 462);
            this.Controls.Add(this.btnRegVolver);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbcGestionarDepartamento);
            this.Name = "GestionarDespartamento";
            this.Text = "GestionarDespartamento";
            this.tbcGestionarDepartamento.ResumeLayout(false);
            this.tpRegistrarDepartamento.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tpActualizarDepartamento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpVerDepartamento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbcGestionarDepartamento;
        private System.Windows.Forms.TabPage tpRegistrarDepartamento;
        private System.Windows.Forms.TabPage tpActualizarDepartamento;
        private System.Windows.Forms.Label lbCodigoDepartamento;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lbAnioFundacionDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.TextBox txtCodigoFacultad;
        private System.Windows.Forms.Label lbCodigoFacultad;
        private System.Windows.Forms.Label lbNombreDepartamento;
        private System.Windows.Forms.TextBox txtCodigoDepartamento;
        private System.Windows.Forms.DateTimePicker dateAnioFundacionDepartamento;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tpVerDepartamento;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvVer;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnRegVolver;
    }
}