namespace Win02
{
    partial class CadastroFuncionario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.lblErros = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.rbCLT = new System.Windows.Forms.RadioButton();
            this.rbPJ = new System.Windows.Forms.RadioButton();
            this.rbAutonomo = new System.Windows.Forms.RadioButton();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.gpbTipoContrato = new System.Windows.Forms.GroupBox();
            this.gpbSexo.SuspendLayout();
            this.gpbTipoContrato.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(21, 35);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(21, 99);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(21, 167);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário";
            // 
            // lblErros
            // 
            this.lblErros.AutoSize = true;
            this.lblErros.ForeColor = System.Drawing.Color.Red;
            this.lblErros.Location = new System.Drawing.Point(21, 246);
            this.lblErros.Name = "lblErros";
            this.lblErros.Size = new System.Drawing.Size(58, 13);
            this.lblErros.TabIndex = 5;
            this.lblErros.Text = "mensagem";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(220, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SalvarAction);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 51);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(435, 20);
            this.txtNome.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(24, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(435, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(24, 183);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(220, 20);
            this.txtSalario.TabIndex = 9;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.Location = new System.Drawing.Point(8, 19);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 10;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(99, 19);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 11;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // rbCLT
            // 
            this.rbCLT.AutoSize = true;
            this.rbCLT.Checked = true;
            this.rbCLT.Location = new System.Drawing.Point(8, 27);
            this.rbCLT.Name = "rbCLT";
            this.rbCLT.Size = new System.Drawing.Size(45, 17);
            this.rbCLT.TabIndex = 12;
            this.rbCLT.TabStop = true;
            this.rbCLT.Text = "CLT";
            this.rbCLT.UseVisualStyleBackColor = true;
            // 
            // rbPJ
            // 
            this.rbPJ.AutoSize = true;
            this.rbPJ.Location = new System.Drawing.Point(99, 27);
            this.rbPJ.Name = "rbPJ";
            this.rbPJ.Size = new System.Drawing.Size(37, 17);
            this.rbPJ.TabIndex = 13;
            this.rbPJ.TabStop = true;
            this.rbPJ.Text = "PJ";
            this.rbPJ.UseVisualStyleBackColor = true;
            // 
            // rbAutonomo
            // 
            this.rbAutonomo.AutoSize = true;
            this.rbAutonomo.Location = new System.Drawing.Point(190, 27);
            this.rbAutonomo.Name = "rbAutonomo";
            this.rbAutonomo.Size = new System.Drawing.Size(73, 17);
            this.rbAutonomo.TabIndex = 14;
            this.rbAutonomo.TabStop = true;
            this.rbAutonomo.Text = "Autonomo";
            this.rbAutonomo.UseVisualStyleBackColor = true;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbFeminino);
            this.gpbSexo.Controls.Add(this.rbMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(523, 35);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(198, 52);
            this.gpbSexo.TabIndex = 15;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // gpbTipoContrato
            // 
            this.gpbTipoContrato.Controls.Add(this.rbCLT);
            this.gpbTipoContrato.Controls.Add(this.rbPJ);
            this.gpbTipoContrato.Controls.Add(this.rbAutonomo);
            this.gpbTipoContrato.Location = new System.Drawing.Point(523, 99);
            this.gpbTipoContrato.Name = "gpbTipoContrato";
            this.gpbTipoContrato.Size = new System.Drawing.Size(283, 63);
            this.gpbTipoContrato.TabIndex = 16;
            this.gpbTipoContrato.TabStop = false;
            this.gpbTipoContrato.Text = "Tipo de Contrato";
            // 
            // CadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 309);
            this.Controls.Add(this.gpbTipoContrato);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblErros);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Name = "CadastroFuncionario";
            this.Text = "CadastroFuncionario";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbTipoContrato.ResumeLayout(false);
            this.gpbTipoContrato.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Label lblErros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.RadioButton rbCLT;
        private System.Windows.Forms.RadioButton rbPJ;
        private System.Windows.Forms.RadioButton rbAutonomo;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.GroupBox gpbTipoContrato;
    }
}