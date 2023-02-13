namespace loteria
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
            this.txtPrimera = new System.Windows.Forms.TextBox();
            this.txtSegunda = new System.Windows.Forms.TextBox();
            this.txtTercera = new System.Windows.Forms.TextBox();
            this.btnJuega = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtJugarnumero = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPrimera
            // 
            this.txtPrimera.Location = new System.Drawing.Point(80, 102);
            this.txtPrimera.Multiline = true;
            this.txtPrimera.Name = "txtPrimera";
            this.txtPrimera.ReadOnly = true;
            this.txtPrimera.Size = new System.Drawing.Size(69, 46);
            this.txtPrimera.TabIndex = 0;
            // 
            // txtSegunda
            // 
            this.txtSegunda.Location = new System.Drawing.Point(181, 102);
            this.txtSegunda.Multiline = true;
            this.txtSegunda.Name = "txtSegunda";
            this.txtSegunda.ReadOnly = true;
            this.txtSegunda.Size = new System.Drawing.Size(69, 46);
            this.txtSegunda.TabIndex = 1;
            // 
            // txtTercera
            // 
            this.txtTercera.Location = new System.Drawing.Point(295, 102);
            this.txtTercera.Multiline = true;
            this.txtTercera.Name = "txtTercera";
            this.txtTercera.ReadOnly = true;
            this.txtTercera.Size = new System.Drawing.Size(69, 46);
            this.txtTercera.TabIndex = 2;
            // 
            // btnJuega
            // 
            this.btnJuega.Location = new System.Drawing.Point(197, 182);
            this.btnJuega.Name = "btnJuega";
            this.btnJuega.Size = new System.Drawing.Size(84, 43);
            this.btnJuega.TabIndex = 3;
            this.btnJuega.Text = "Juega";
            this.btnJuega.UseVisualStyleBackColor = true;
            this.btnJuega.Click += new System.EventHandler(this.btnJuega_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Primera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Segunda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "tercera";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(231, 254);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "0";
            // 
            // txtJugarnumero
            // 
            this.txtJugarnumero.Location = new System.Drawing.Point(212, 12);
            this.txtJugarnumero.Multiline = true;
            this.txtJugarnumero.Name = "txtJugarnumero";
            this.txtJugarnumero.Size = new System.Drawing.Size(69, 46);
            this.txtJugarnumero.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 284);
            this.Controls.Add(this.txtJugarnumero);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnJuega);
            this.Controls.Add(this.txtTercera);
            this.Controls.Add(this.txtSegunda);
            this.Controls.Add(this.txtPrimera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimera;
        private System.Windows.Forms.TextBox txtSegunda;
        private System.Windows.Forms.TextBox txtTercera;
        private System.Windows.Forms.Button btnJuega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtJugarnumero;
    }
}

