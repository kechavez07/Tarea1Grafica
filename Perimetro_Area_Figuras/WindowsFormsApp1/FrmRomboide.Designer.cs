namespace WindowsFormsApp1
{
    partial class FrmRomboide
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
            this.lblRomboide = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.lblLado = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(268, 247);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(76, 20);
            this.txtPerimetro.TabIndex = 14;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(268, 211);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(76, 20);
            this.txtArea.TabIndex = 13;
            // 
            // lblTiPer
            // 
            this.lblTiPer.AutoSize = true;
            this.lblTiPer.Location = new System.Drawing.Point(206, 250);
            this.lblTiPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiPer.Name = "lblTiPer";
            this.lblTiPer.Size = new System.Drawing.Size(56, 13);
            this.lblTiPer.TabIndex = 12;
            this.lblTiPer.Text = "Perímetro:";
            // 
            // lblTiArea
            // 
            this.lblTiArea.AutoSize = true;
            this.lblTiArea.Location = new System.Drawing.Point(206, 216);
            this.lblTiArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiArea.Name = "lblTiArea";
            this.lblTiArea.Size = new System.Drawing.Size(32, 13);
            this.lblTiArea.TabIndex = 11;
            this.lblTiArea.Text = "Área:";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(380, 104);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblRomboide
            // 
            this.lblRomboide.AutoSize = true;
            this.lblRomboide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRomboide.Location = new System.Drawing.Point(236, 9);
            this.lblRomboide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRomboide.Name = "lblRomboide";
            this.lblRomboide.Size = new System.Drawing.Size(137, 31);
            this.lblRomboide.TabIndex = 17;
            this.lblRomboide.Text = "Romboide";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(213, 68);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 24;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(140, 68);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(34, 13);
            this.lblBase.TabIndex = 23;
            this.lblBase.Text = "Base:";
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(213, 139);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 20);
            this.txtLado.TabIndex = 29;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(213, 103);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 28;
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(140, 139);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(34, 13);
            this.lblLado.TabIndex = 27;
            this.lblLado.Text = "Lado:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(140, 103);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 26;
            this.lblAltura.Text = "Altura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Resultado";
            // 
            // FrmRomboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.lblRomboide);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblTiPer);
            this.Controls.Add(this.lblTiArea);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRomboide";
            this.Text = "Romboide";
            this.Load += new System.EventHandler(this.FrmRomboide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblTiPer;
        private System.Windows.Forms.Label lblTiArea;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblRomboide;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label2;
    }
}