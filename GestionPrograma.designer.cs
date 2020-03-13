namespace appBanco
{
    partial class GestionPrograma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionPrograma));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbcGestionPrograma = new System.Windows.Forms.TabControl();
            this.tbpRegProgram = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbActProgram = new System.Windows.Forms.TabPage();
            this.tbpDropProgram = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodPrograma = new System.Windows.Forms.TextBox();
            this.txtCreditosProgram = new System.Windows.Forms.TextBox();
            this.txtNomPrograma = new System.Windows.Forms.TextBox();
            this.txtCodFacPrograma = new System.Windows.Forms.TextBox();
            this.btnRegPrograma = new System.Windows.Forms.Button();
            this.btnVolverProgram = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.tbcGestionPrograma.SuspendLayout();
            this.tbpRegProgram.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbcGestionPrograma);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 475);
            this.panel1.TabIndex = 0;
            // 
            // tbcGestionPrograma
            // 
            this.tbcGestionPrograma.Controls.Add(this.tbpRegProgram);
            this.tbcGestionPrograma.Controls.Add(this.tbActProgram);
            this.tbcGestionPrograma.Controls.Add(this.tbpDropProgram);
            this.tbcGestionPrograma.Location = new System.Drawing.Point(14, 66);
            this.tbcGestionPrograma.Name = "tbcGestionPrograma";
            this.tbcGestionPrograma.SelectedIndex = 0;
            this.tbcGestionPrograma.Size = new System.Drawing.Size(846, 406);
            this.tbcGestionPrograma.TabIndex = 0;
            // 
            // tbpRegProgram
            // 
            this.tbpRegProgram.Controls.Add(this.panel2);
            this.tbpRegProgram.Location = new System.Drawing.Point(4, 22);
            this.tbpRegProgram.Name = "tbpRegProgram";
            this.tbpRegProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegProgram.Size = new System.Drawing.Size(838, 380);
            this.tbpRegProgram.TabIndex = 0;
            this.tbpRegProgram.Text = "Registrar Programa";
            this.tbpRegProgram.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión Programa de SIMCA DBA";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.btnVolverProgram);
            this.panel2.Controls.Add(this.btnRegPrograma);
            this.panel2.Controls.Add(this.txtCodFacPrograma);
            this.panel2.Controls.Add(this.txtNomPrograma);
            this.panel2.Controls.Add(this.txtCreditosProgram);
            this.panel2.Controls.Add(this.txtCodPrograma);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(61, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 346);
            this.panel2.TabIndex = 0;
            // 
            // tbActProgram
            // 
            this.tbActProgram.Location = new System.Drawing.Point(4, 22);
            this.tbActProgram.Name = "tbActProgram";
            this.tbActProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tbActProgram.Size = new System.Drawing.Size(838, 380);
            this.tbActProgram.TabIndex = 1;
            this.tbActProgram.Text = "Actualizar Programa";
            this.tbActProgram.UseVisualStyleBackColor = true;
            // 
            // tbpDropProgram
            // 
            this.tbpDropProgram.Location = new System.Drawing.Point(4, 22);
            this.tbpDropProgram.Name = "tbpDropProgram";
            this.tbpDropProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDropProgram.Size = new System.Drawing.Size(838, 380);
            this.tbpDropProgram.TabIndex = 2;
            this.tbpDropProgram.Text = "Eliminar Programa";
            this.tbpDropProgram.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Código del programa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total de Créditos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre del programa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Código de la facultad:";
            // 
            // txtCodPrograma
            // 
            this.txtCodPrograma.Location = new System.Drawing.Point(252, 48);
            this.txtCodPrograma.Name = "txtCodPrograma";
            this.txtCodPrograma.Size = new System.Drawing.Size(131, 20);
            this.txtCodPrograma.TabIndex = 4;
            // 
            // txtCreditosProgram
            // 
            this.txtCreditosProgram.Location = new System.Drawing.Point(252, 186);
            this.txtCreditosProgram.Name = "txtCreditosProgram";
            this.txtCreditosProgram.Size = new System.Drawing.Size(131, 20);
            this.txtCreditosProgram.TabIndex = 5;
            // 
            // txtNomPrograma
            // 
            this.txtNomPrograma.Location = new System.Drawing.Point(252, 137);
            this.txtNomPrograma.Name = "txtNomPrograma";
            this.txtNomPrograma.Size = new System.Drawing.Size(131, 20);
            this.txtNomPrograma.TabIndex = 6;
            // 
            // txtCodFacPrograma
            // 
            this.txtCodFacPrograma.Location = new System.Drawing.Point(252, 91);
            this.txtCodFacPrograma.Name = "txtCodFacPrograma";
            this.txtCodFacPrograma.Size = new System.Drawing.Size(131, 20);
            this.txtCodFacPrograma.TabIndex = 7;
            // 
            // btnRegPrograma
            // 
            this.btnRegPrograma.Location = new System.Drawing.Point(388, 275);
            this.btnRegPrograma.Name = "btnRegPrograma";
            this.btnRegPrograma.Size = new System.Drawing.Size(120, 38);
            this.btnRegPrograma.TabIndex = 8;
            this.btnRegPrograma.Text = "Registrar";
            this.btnRegPrograma.UseVisualStyleBackColor = true;
            this.btnRegPrograma.Click += new System.EventHandler(this.btnRegPrograma_Click);
            // 
            // btnVolverProgram
            // 
            this.btnVolverProgram.Location = new System.Drawing.Point(580, 275);
            this.btnVolverProgram.Name = "btnVolverProgram";
            this.btnVolverProgram.Size = new System.Drawing.Size(104, 38);
            this.btnVolverProgram.TabIndex = 9;
            this.btnVolverProgram.Text = "Volver";
            this.btnVolverProgram.UseVisualStyleBackColor = true;
            this.btnVolverProgram.Click += new System.EventHandler(this.btnVolverProgram_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(673, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(34, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(434, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(278, 189);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // GestionPrograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 491);
            this.Controls.Add(this.panel1);
            this.Name = "GestionPrograma";
            this.Text = "GestionPrograma";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcGestionPrograma.ResumeLayout(false);
            this.tbpRegProgram.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbcGestionPrograma;
        private System.Windows.Forms.TabPage tbpRegProgram;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVolverProgram;
        private System.Windows.Forms.Button btnRegPrograma;
        private System.Windows.Forms.TextBox txtCodFacPrograma;
        private System.Windows.Forms.TextBox txtNomPrograma;
        private System.Windows.Forms.TextBox txtCreditosProgram;
        private System.Windows.Forms.TextBox txtCodPrograma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tbActProgram;
        private System.Windows.Forms.TabPage tbpDropProgram;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}