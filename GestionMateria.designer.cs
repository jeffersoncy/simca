namespace appBanco
{
    partial class GestionMateria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPRegistrarMateria = new System.Windows.Forms.TabPage();
            this.pnlRegsitrarMateria = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rbNoTieneCorrequisito = new System.Windows.Forms.RadioButton();
            this.rbTieneCorrequisito = new System.Windows.Forms.RadioButton();
            this.btnSalirRegMat = new System.Windows.Forms.Button();
            this.btnRegMateria = new System.Windows.Forms.Button();
            this.lblCreditosMat = new System.Windows.Forms.Label();
            this.lblNombreMat = new System.Windows.Forms.Label();
            this.lblCuposMat = new System.Windows.Forms.Label();
            this.lblSemestreMat = new System.Windows.Forms.Label();
            this.lblCorrequisitoMat = new System.Windows.Forms.Label();
            this.lbCodMateria = new System.Windows.Forms.Label();
            this.txtNombreMat = new System.Windows.Forms.TextBox();
            this.txtCuposMat = new System.Windows.Forms.TextBox();
            this.txtCreditosMat = new System.Windows.Forms.TextBox();
            this.txtSemestreMat = new System.Windows.Forms.TextBox();
            this.txtCorrequisitoMat = new System.Windows.Forms.TextBox();
            this.txtCodMateria = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbPRegistrarMateria.SuspendLayout();
            this.pnlRegsitrarMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(3, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 397);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPRegistrarMateria);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(9, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 391);
            this.tabControl1.TabIndex = 0;
            // 
            // tbPRegistrarMateria
            // 
            this.tbPRegistrarMateria.Controls.Add(this.pnlRegsitrarMateria);
            this.tbPRegistrarMateria.Location = new System.Drawing.Point(4, 22);
            this.tbPRegistrarMateria.Name = "tbPRegistrarMateria";
            this.tbPRegistrarMateria.Padding = new System.Windows.Forms.Padding(3);
            this.tbPRegistrarMateria.Size = new System.Drawing.Size(840, 365);
            this.tbPRegistrarMateria.TabIndex = 0;
            this.tbPRegistrarMateria.Text = "Registrar Materia";
            this.tbPRegistrarMateria.UseVisualStyleBackColor = true;
            // 
            // pnlRegsitrarMateria
            // 
            this.pnlRegsitrarMateria.Controls.Add(this.label2);
            this.pnlRegsitrarMateria.Controls.Add(this.rbNoTieneCorrequisito);
            this.pnlRegsitrarMateria.Controls.Add(this.rbTieneCorrequisito);
            this.pnlRegsitrarMateria.Controls.Add(this.btnSalirRegMat);
            this.pnlRegsitrarMateria.Controls.Add(this.btnRegMateria);
            this.pnlRegsitrarMateria.Controls.Add(this.lblCreditosMat);
            this.pnlRegsitrarMateria.Controls.Add(this.lblNombreMat);
            this.pnlRegsitrarMateria.Controls.Add(this.lblCuposMat);
            this.pnlRegsitrarMateria.Controls.Add(this.lblSemestreMat);
            this.pnlRegsitrarMateria.Controls.Add(this.lblCorrequisitoMat);
            this.pnlRegsitrarMateria.Controls.Add(this.lbCodMateria);
            this.pnlRegsitrarMateria.Controls.Add(this.txtNombreMat);
            this.pnlRegsitrarMateria.Controls.Add(this.txtCuposMat);
            this.pnlRegsitrarMateria.Controls.Add(this.txtCreditosMat);
            this.pnlRegsitrarMateria.Controls.Add(this.txtSemestreMat);
            this.pnlRegsitrarMateria.Controls.Add(this.txtCorrequisitoMat);
            this.pnlRegsitrarMateria.Controls.Add(this.txtCodMateria);
            this.pnlRegsitrarMateria.Location = new System.Drawing.Point(28, 19);
            this.pnlRegsitrarMateria.Name = "pnlRegsitrarMateria";
            this.pnlRegsitrarMateria.Size = new System.Drawing.Size(790, 328);
            this.pnlRegsitrarMateria.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Digite el código de la materia correquisito:";
            // 
            // rbNoTieneCorrequisito
            // 
            this.rbNoTieneCorrequisito.AutoSize = true;
            this.rbNoTieneCorrequisito.Location = new System.Drawing.Point(386, 68);
            this.rbNoTieneCorrequisito.Name = "rbNoTieneCorrequisito";
            this.rbNoTieneCorrequisito.Size = new System.Drawing.Size(42, 17);
            this.rbNoTieneCorrequisito.TabIndex = 15;
            this.rbNoTieneCorrequisito.TabStop = true;
            this.rbNoTieneCorrequisito.Text = "No ";
            this.rbNoTieneCorrequisito.UseVisualStyleBackColor = true;
            // 
            // rbTieneCorrequisito
            // 
            this.rbTieneCorrequisito.AutoSize = true;
            this.rbTieneCorrequisito.Location = new System.Drawing.Point(318, 67);
            this.rbTieneCorrequisito.Name = "rbTieneCorrequisito";
            this.rbTieneCorrequisito.Size = new System.Drawing.Size(34, 17);
            this.rbTieneCorrequisito.TabIndex = 14;
            this.rbTieneCorrequisito.TabStop = true;
            this.rbTieneCorrequisito.Text = "Si";
            this.rbTieneCorrequisito.UseVisualStyleBackColor = true;
            // 
            // btnSalirRegMat
            // 
            this.btnSalirRegMat.Location = new System.Drawing.Point(660, 264);
            this.btnSalirRegMat.Name = "btnSalirRegMat";
            this.btnSalirRegMat.Size = new System.Drawing.Size(101, 49);
            this.btnSalirRegMat.TabIndex = 13;
            this.btnSalirRegMat.Text = "Salir";
            this.btnSalirRegMat.UseVisualStyleBackColor = true;
            this.btnSalirRegMat.Click += new System.EventHandler(this.btnSalirRegMat_Click);
            // 
            // btnRegMateria
            // 
            this.btnRegMateria.Location = new System.Drawing.Point(490, 264);
            this.btnRegMateria.Name = "btnRegMateria";
            this.btnRegMateria.Size = new System.Drawing.Size(127, 49);
            this.btnRegMateria.TabIndex = 12;
            this.btnRegMateria.Text = "Registrar Materia";
            this.btnRegMateria.UseVisualStyleBackColor = true;
            this.btnRegMateria.Click += new System.EventHandler(this.btnRegMateria_Click);
            // 
            // lblCreditosMat
            // 
            this.lblCreditosMat.AutoSize = true;
            this.lblCreditosMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditosMat.Location = new System.Drawing.Point(65, 165);
            this.lblCreditosMat.Name = "lblCreditosMat";
            this.lblCreditosMat.Size = new System.Drawing.Size(130, 15);
            this.lblCreditosMat.TabIndex = 11;
            this.lblCreditosMat.Text = "Creditos de la materia:";
            // 
            // lblNombreMat
            // 
            this.lblNombreMat.AutoSize = true;
            this.lblNombreMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMat.Location = new System.Drawing.Point(65, 200);
            this.lblNombreMat.Name = "lblNombreMat";
            this.lblNombreMat.Size = new System.Drawing.Size(130, 15);
            this.lblNombreMat.TabIndex = 10;
            this.lblNombreMat.Text = "Nombre de la materia:";
            // 
            // lblCuposMat
            // 
            this.lblCuposMat.AutoSize = true;
            this.lblCuposMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuposMat.Location = new System.Drawing.Point(65, 239);
            this.lblCuposMat.Name = "lblCuposMat";
            this.lblCuposMat.Size = new System.Drawing.Size(183, 15);
            this.lblCuposMat.TabIndex = 9;
            this.lblCuposMat.Text = "Número de cupos en la materia:";
            // 
            // lblSemestreMat
            // 
            this.lblSemestreMat.AutoSize = true;
            this.lblSemestreMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemestreMat.Location = new System.Drawing.Point(65, 125);
            this.lblSemestreMat.Name = "lblSemestreMat";
            this.lblSemestreMat.Size = new System.Drawing.Size(168, 15);
            this.lblSemestreMat.TabIndex = 8;
            this.lblSemestreMat.Text = "Semestre para ver la materia:";
            // 
            // lblCorrequisitoMat
            // 
            this.lblCorrequisitoMat.AutoSize = true;
            this.lblCorrequisitoMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrequisitoMat.Location = new System.Drawing.Point(65, 70);
            this.lblCorrequisitoMat.Name = "lblCorrequisitoMat";
            this.lblCorrequisitoMat.Size = new System.Drawing.Size(170, 15);
            this.lblCorrequisitoMat.TabIndex = 7;
            this.lblCorrequisitoMat.Text = "La materia tiene correquisito?";
            // 
            // lbCodMateria
            // 
            this.lbCodMateria.AutoSize = true;
            this.lbCodMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodMateria.Location = new System.Drawing.Point(65, 41);
            this.lbCodMateria.Name = "lbCodMateria";
            this.lbCodMateria.Size = new System.Drawing.Size(179, 15);
            this.lbCodMateria.TabIndex = 6;
            this.lbCodMateria.Text = "Ingrese el código de la materia:";
            // 
            // txtNombreMat
            // 
            this.txtNombreMat.Location = new System.Drawing.Point(318, 199);
            this.txtNombreMat.Name = "txtNombreMat";
            this.txtNombreMat.Size = new System.Drawing.Size(146, 20);
            this.txtNombreMat.TabIndex = 5;
            // 
            // txtCuposMat
            // 
            this.txtCuposMat.Location = new System.Drawing.Point(318, 238);
            this.txtCuposMat.Name = "txtCuposMat";
            this.txtCuposMat.Size = new System.Drawing.Size(146, 20);
            this.txtCuposMat.TabIndex = 4;
            // 
            // txtCreditosMat
            // 
            this.txtCreditosMat.Location = new System.Drawing.Point(318, 164);
            this.txtCreditosMat.Name = "txtCreditosMat";
            this.txtCreditosMat.Size = new System.Drawing.Size(146, 20);
            this.txtCreditosMat.TabIndex = 3;
            // 
            // txtSemestreMat
            // 
            this.txtSemestreMat.Location = new System.Drawing.Point(318, 124);
            this.txtSemestreMat.Name = "txtSemestreMat";
            this.txtSemestreMat.Size = new System.Drawing.Size(146, 20);
            this.txtSemestreMat.TabIndex = 2;
            // 
            // txtCorrequisitoMat
            // 
            this.txtCorrequisitoMat.Location = new System.Drawing.Point(318, 93);
            this.txtCorrequisitoMat.Name = "txtCorrequisitoMat";
            this.txtCorrequisitoMat.Size = new System.Drawing.Size(146, 20);
            this.txtCorrequisitoMat.TabIndex = 1;
            // 
            // txtCodMateria
            // 
            this.txtCodMateria.Location = new System.Drawing.Point(318, 36);
            this.txtCodMateria.Name = "txtCodMateria";
            this.txtCodMateria.Size = new System.Drawing.Size(146, 20);
            this.txtCodMateria.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(840, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar Materia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(840, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Materia";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de materias SIMCA BDA";
            // 
            // GestionMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "GestionMateria";
            this.Text = "GestionMateria";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbPRegistrarMateria.ResumeLayout(false);
            this.pnlRegsitrarMateria.ResumeLayout(false);
            this.pnlRegsitrarMateria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPRegistrarMateria;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnlRegsitrarMateria;
        private System.Windows.Forms.TextBox txtNombreMat;
        private System.Windows.Forms.TextBox txtCuposMat;
        private System.Windows.Forms.TextBox txtCreditosMat;
        private System.Windows.Forms.TextBox txtSemestreMat;
        private System.Windows.Forms.TextBox txtCorrequisitoMat;
        private System.Windows.Forms.TextBox txtCodMateria;
        private System.Windows.Forms.Label lblCreditosMat;
        private System.Windows.Forms.Label lblNombreMat;
        private System.Windows.Forms.Label lblCuposMat;
        private System.Windows.Forms.Label lblSemestreMat;
        private System.Windows.Forms.Label lblCorrequisitoMat;
        private System.Windows.Forms.Label lbCodMateria;
        private System.Windows.Forms.Button btnSalirRegMat;
        private System.Windows.Forms.Button btnRegMateria;
        private System.Windows.Forms.RadioButton rbNoTieneCorrequisito;
        private System.Windows.Forms.RadioButton rbTieneCorrequisito;
        private System.Windows.Forms.Label label2;
    }
}