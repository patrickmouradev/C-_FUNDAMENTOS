namespace WindowsFormsApp1
{
    partial class frmDatas
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtMeses = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.lblQtDias = new System.Windows.Forms.Label();
            this.lblQtdMeses = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe Uma Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Dias:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade de Meses:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(213, 60);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(227, 22);
            this.txtData.TabIndex = 3;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(213, 100);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(227, 22);
            this.txtDias.TabIndex = 4;
            // 
            // txtMeses
            // 
            this.txtMeses.Location = new System.Drawing.Point(213, 144);
            this.txtMeses.Name = "txtMeses";
            this.txtMeses.Size = new System.Drawing.Size(227, 22);
            this.txtMeses.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(213, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(365, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // lblQtDias
            // 
            this.lblQtDias.AutoSize = true;
            this.lblQtDias.ForeColor = System.Drawing.Color.Blue;
            this.lblQtDias.Location = new System.Drawing.Point(459, 105);
            this.lblQtDias.Name = "lblQtDias";
            this.lblQtDias.Size = new System.Drawing.Size(0, 17);
            this.lblQtDias.TabIndex = 8;
            // 
            // lblQtdMeses
            // 
            this.lblQtdMeses.AutoSize = true;
            this.lblQtdMeses.ForeColor = System.Drawing.Color.Blue;
            this.lblQtdMeses.Location = new System.Drawing.Point(459, 149);
            this.lblQtdMeses.Name = "lblQtdMeses";
            this.lblQtdMeses.Size = new System.Drawing.Size(0, 17);
            this.lblQtdMeses.TabIndex = 9;
            // 
            // frmDatas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblQtdMeses);
            this.Controls.Add(this.lblQtDias);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtMeses);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDatas";
            this.Text = "frmDatas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.TextBox txtMeses;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblQtDias;
        private System.Windows.Forms.Label lblQtdMeses;
    }
}