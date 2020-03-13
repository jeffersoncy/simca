namespace appBanco
{
    partial class GestionFacultad
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tacGestionFac = new System.Windows.Forms.TabControl();
            this.tbPRegistrarFac = new System.Windows.Forms.TabPage();
            this.pnlRegistrarFac = new System.Windows.Forms.Panel();
            this.btnSalirFac = new System.Windows.Forms.Button();
            this.btnRegFacultad = new System.Windows.Forms.Button();
            this.txtNomDecFacultad = new System.Windows.Forms.TextBox();
            this.txtNombreFacultad = new System.Windows.Forms.TextBox();
            this.txtCodFacultad = new System.Windows.Forms.TextBox();
            this.lbNomDecFac = new System.Windows.Forms.Label();
            this.lbNomFacultad = new System.Windows.Forms.Label();
            this.lbCodFacultad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tacGestionFac.SuspendLayout();
            this.tbPRegistrarFac.SuspendLayout();
            this.pnlRegistrarFac.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tacGestionFac);
            this.panel1.Location = new System.Drawing.Point(4, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 371);
            this.panel1.TabIndex = 0;
            // 
            // tacGestionFac
            // 
            this.tacGestionFac.Controls.Add(this.tbPRegistrarFac);
            this.tacGestionFac.Controls.Add(this.tabPage2);
            this.tacGestionFac.Controls.Add(this.tabPage3);
            this.tacGestionFac.Location = new System.Drawing.Point(8, 3);
            this.tacGestionFac.Name = "tacGestionFac";
            this.tacGestionFac.SelectedIndex = 0;
            this.tacGestionFac.Size = new System.Drawing.Size(884, 435);
            this.tacGestionFac.TabIndex = 0;
            // 
            // tbPRegistrarFac
            // 
            this.tbPRegistrarFac.Controls.Add(this.pnlRegistrarFac);
            this.tbPRegistrarFac.Location = new System.Drawing.Point(4, 22);
            this.tbPRegistrarFac.Name = "tbPRegistrarFac";
            this.tbPRegistrarFac.Padding = new System.Windows.Forms.Padding(3);
            this.tbPRegistrarFac.Size = new System.Drawing.Size(876, 409);
            this.tbPRegistrarFac.TabIndex = 0;
            this.tbPRegistrarFac.Text = "Registrar Facultad";
            this.tbPRegistrarFac.UseVisualStyleBackColor = true;
            // 
            // pnlRegistrarFac
            // 
            this.pnlRegistrarFac.Controls.Add(this.btnRegFacultad);
            this.pnlRegistrarFac.Controls.Add(this.txtNomDecFacultad);
            this.pnlRegistrarFac.Controls.Add(this.txtNombreFacultad);
            this.pnlRegistrarFac.Controls.Add(this.txtCodFacultad);
            this.pnlRegistrarFac.Controls.Add(this.lbNomDecFac);
            this.pnlRegistrarFac.Controls.Add(this.lbNomFacultad);
            this.pnlRegistrarFac.Controls.Add(this.lbCodFacultad);
            this.pnlRegistrarFac.Controls.Add(this.label2);
            this.pnlRegistrarFac.Location = new System.Drawing.Point(47, 6);
            this.pnlRegistrarFac.Name = "pnlRegistrarFac";
            this.pnlRegistrarFac.Size = new System.Drawing.Size(754, 337);
            this.pnlRegistrarFac.TabIndex = 0;
            // 
            // btnSalirFac
            // 
            this.btnSalirFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirFac.Location = new System.Drawing.Point(731, 449);
            this.btnSalirFac.Name = "btnSalirFac";
            this.btnSalirFac.Size = new System.Drawing.Size(86, 32);
            this.btnSalirFac.TabIndex = 8;
            this.btnSalirFac.Text = "Volver";
            this.btnSalirFac.UseVisualStyleBackColor = true;
            this.btnSalirFac.Click += new System.EventHandler(this.btnSalirFac_Click);
            // 
            // btnRegFacultad
            // 
            this.btnRegFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegFacultad.Location = new System.Drawing.Point(279, 251);
            this.btnRegFacultad.Name = "btnRegFacultad";
            this.btnRegFacultad.Size = new System.Drawing.Size(103, 42);
            this.btnRegFacultad.TabIndex = 7;
            this.btnRegFacultad.Text = "Registrar";
            this.btnRegFacultad.UseVisualStyleBackColor = true;
            this.btnRegFacultad.Click += new System.EventHandler(this.btnRegFacultad_Click);
            // 
            // txtNomDecFacultad
            // 
            this.txtNomDecFacultad.Location = new System.Drawing.Point(279, 170);
            this.txtNomDecFacultad.Name = "txtNomDecFacultad";
            this.txtNomDecFacultad.Size = new System.Drawing.Size(184, 20);
            this.txtNomDecFacultad.TabIndex = 6;
            // 
            // txtNombreFacultad
            // 
            this.txtNombreFacultad.Location = new System.Drawing.Point(279, 134);
            this.txtNombreFacultad.Name = "txtNombreFacultad";
            this.txtNombreFacultad.Size = new System.Drawing.Size(184, 20);
            this.txtNombreFacultad.TabIndex = 5;
            // 
            // txtCodFacultad
            // 
            this.txtCodFacultad.Location = new System.Drawing.Point(279, 98);
            this.txtCodFacultad.Name = "txtCodFacultad";
            this.txtCodFacultad.Size = new System.Drawing.Size(184, 20);
            this.txtCodFacultad.TabIndex = 4;
            // 
            // lbNomDecFac
            // 
            this.lbNomDecFac.AutoSize = true;
            this.lbNomDecFac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomDecFac.Location = new System.Drawing.Point(50, 175);
            this.lbNomDecFac.Name = "lbNomDecFac";
            this.lbNomDecFac.Size = new System.Drawing.Size(201, 15);
            this.lbNomDecFac.TabIndex = 3;
            this.lbNomDecFac.Text = "Nombre del Decano de la Facultad:";
            // 
            // lbNomFacultad
            // 
            this.lbNomFacultad.AutoSize = true;
            this.lbNomFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomFacultad.Location = new System.Drawing.Point(50, 139);
            this.lbNomFacultad.Name = "lbNomFacultad";
            this.lbNomFacultad.Size = new System.Drawing.Size(135, 15);
            this.lbNomFacultad.TabIndex = 2;
            this.lbNomFacultad.Text = "Nombre de la Facultad:";
            // 
            // lbCodFacultad
            // 
            this.lbCodFacultad.AutoSize = true;
            this.lbCodFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodFacultad.Location = new System.Drawing.Point(50, 103);
            this.lbCodFacultad.Name = "lbCodFacultad";
            this.lbCodFacultad.Size = new System.Drawing.Size(129, 15);
            this.lbCodFacultad.TabIndex = 1;
            this.lbCodFacultad.Text = "Código de la Facultad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Registrar Facultad";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(876, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar Facultad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(876, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Facultad";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de Facultad SIMCA DBA";
            // 
            // GestionFacultad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 481);
            this.Controls.Add(this.btnSalirFac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "GestionFacultad";
            this.Text = "GestionFacultad";
            this.panel1.ResumeLayout(false);
            this.tacGestionFac.ResumeLayout(false);
            this.tbPRegistrarFac.ResumeLayout(false);
            this.pnlRegistrarFac.ResumeLayout(false);
            this.pnlRegistrarFac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tacGestionFac;
        private System.Windows.Forms.TabPage tbPRegistrarFac;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlRegistrarFac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbNomDecFac;
        private System.Windows.Forms.Label lbNomFacultad;
        private System.Windows.Forms.Label lbCodFacultad;
        private System.Windows.Forms.TextBox txtNomDecFacultad;
        private System.Windows.Forms.TextBox txtNombreFacultad;
        private System.Windows.Forms.TextBox txtCodFacultad;
        private System.Windows.Forms.Button btnSalirFac;
        private System.Windows.Forms.Button btnRegFacultad;
    }
}