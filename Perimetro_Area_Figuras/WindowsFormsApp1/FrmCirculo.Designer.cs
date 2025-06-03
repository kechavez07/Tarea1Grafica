namespace WindowsFormsApp1
{
    partial class FrmCirculo
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
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblTiPer = new System.Windows.Forms.Label();
            this.lblTiArea = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblCirculo = new System.Windows.Forms.Label();
            this.lblTiRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(265, 241);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(76, 20);
            this.txtPerimetro.TabIndex = 14;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(265, 205);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(76, 20);
            this.txtArea.TabIndex = 13;
            // 
            // lblTiPer
            // 
            this.lblTiPer.AutoSize = true;
            this.lblTiPer.Location = new System.Drawing.Point(202, 244);
            this.lblTiPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiPer.Name = "lblTiPer";
            this.lblTiPer.Size = new System.Drawing.Size(56, 13);
            this.lblTiPer.TabIndex = 12;
            this.lblTiPer.Text = "Perímetro:";
            // 
            // lblTiArea
            // 
            this.lblTiArea.AutoSize = true;
            this.lblTiArea.Location = new System.Drawing.Point(202, 210);
            this.lblTiArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiArea.Name = "lblTiArea";
            this.lblTiArea.Size = new System.Drawing.Size(32, 13);
            this.lblTiArea.TabIndex = 11;
            this.lblTiArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(353, 101);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 16;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblCirculo
            // 
            this.lblCirculo.AutoSize = true;
            this.lblCirculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCirculo.Location = new System.Drawing.Point(257, 19);
            this.lblCirculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCirculo.Name = "lblCirculo";
            this.lblCirculo.Size = new System.Drawing.Size(99, 31);
            this.lblCirculo.TabIndex = 15;
            this.lblCirculo.Text = "Circulo";
            // 
            // lblTiRadio
            // 
            this.lblTiRadio.AutoSize = true;
            this.lblTiRadio.Location = new System.Drawing.Point(112, 100);
            this.lblTiRadio.Name = "lblTiRadio";
            this.lblTiRadio.Size = new System.Drawing.Size(38, 13);
            this.lblTiRadio.TabIndex = 17;
            this.lblTiRadio.Text = "Radio:";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(157, 100);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Resultado";
            // 
            // FrmCirculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblTiRadio);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblCirculo);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblTiPer);
            this.Controls.Add(this.lblTiArea);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCirculo";
            this.Text = "Circulo";
            this.Load += new System.EventHandler(this.FrmCirculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblTiPer;
        private System.Windows.Forms.Label lblTiArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblCirculo;
        private System.Windows.Forms.Label lblTiRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label2;
    }
}