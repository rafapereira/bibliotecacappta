namespace WindowsFormsApp3
{
    partial class FormMenuAlugueis
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviarEmail = new System.Windows.Forms.Button();
            this.txtAlugadoPor = new System.Windows.Forms.TextBox();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.txtDataLocacao = new System.Windows.Forms.TextBox();
            this.comboEmDia = new System.Windows.Forms.ComboBox();
            this.comboVencidos = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(13, 96);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 18);
            label3.TabIndex = 4;
            label3.Text = "Vencidos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(13, 122);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(90, 18);
            label4.TabIndex = 9;
            label4.Text = "Alugado por:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(13, 174);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(123, 18);
            label5.TabIndex = 10;
            label5.Text = "Data de Locação:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(13, 148);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 18);
            label6.TabIndex = 11;
            label6.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ALUGUÉIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Em dia:";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.Location = new System.Drawing.Point(127, 250);
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Size = new System.Drawing.Size(179, 23);
            this.btnEnviarEmail.TabIndex = 5;
            this.btnEnviarEmail.Text = "Enviar e-mail de cobrança";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.btnEnviarEmail_Click);
            // 
            // txtAlugadoPor
            // 
            this.txtAlugadoPor.Location = new System.Drawing.Point(163, 120);
            this.txtAlugadoPor.Name = "txtAlugadoPor";
            this.txtAlugadoPor.Size = new System.Drawing.Size(242, 20);
            this.txtAlugadoPor.TabIndex = 6;
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(163, 146);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(242, 20);
            this.txtEmailCliente.TabIndex = 7;
            // 
            // txtDataLocacao
            // 
            this.txtDataLocacao.Location = new System.Drawing.Point(163, 172);
            this.txtDataLocacao.Name = "txtDataLocacao";
            this.txtDataLocacao.Size = new System.Drawing.Size(242, 20);
            this.txtDataLocacao.TabIndex = 8;
            // 
            // comboEmDia
            // 
            this.comboEmDia.FormattingEnabled = true;
            this.comboEmDia.Location = new System.Drawing.Point(163, 66);
            this.comboEmDia.Name = "comboEmDia";
            this.comboEmDia.Size = new System.Drawing.Size(242, 21);
            this.comboEmDia.TabIndex = 14;
            this.comboEmDia.SelectedIndexChanged += new System.EventHandler(this.comboEmDia_SelectedIndexChanged);
            // 
            // comboVencidos
            // 
            this.comboVencidos.FormattingEnabled = true;
            this.comboVencidos.Location = new System.Drawing.Point(163, 93);
            this.comboVencidos.Name = "comboVencidos";
            this.comboVencidos.Size = new System.Drawing.Size(242, 21);
            this.comboVencidos.TabIndex = 15;
            this.comboVencidos.SelectedIndexChanged += new System.EventHandler(this.comboVencidos_SelectedIndexChanged);
            // 
            // FormMenuAlugueis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 298);
            this.Controls.Add(this.comboVencidos);
            this.Controls.Add(this.comboEmDia);
            this.Controls.Add(label6);
            this.Controls.Add(label5);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtDataLocacao);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.txtAlugadoPor);
            this.Controls.Add(this.btnEnviarEmail);
            this.Controls.Add(label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMenuAlugueis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviarEmail;
        private System.Windows.Forms.TextBox txtAlugadoPor;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.TextBox txtDataLocacao;
        private System.Windows.Forms.ComboBox comboEmDia;
        private System.Windows.Forms.ComboBox comboVencidos;
    }
}