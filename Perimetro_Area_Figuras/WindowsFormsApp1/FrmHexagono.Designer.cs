namespace WindowsFormsApp1
{
    partial class FrmHexagono
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtApotema = new System.Windows.Forms.TextBox();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblApotema = new System.Windows.Forms.Label();
            this.lblLado = new System.Windows.Forms.Label();
            this.txtPerimetro = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblTiPer = new System.Windows.Forms.Label();
            this.lblTiArea = new System.Windows.Forms.Label();
            this.lblHeptagono = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(306, 77);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(56, 19);
            this.btnCalcular.TabIndex = 39;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtApotema
            // 
            this.txtApotema.Location = new System.Drawing.Point(236, 250);
            this.txtApotema.Margin = new System.Windows.Forms.Padding(2);
            this.txtApotema.Name = "txtApotema";
            this.txtApotema.Size = new System.Drawing.Size(76, 20);
            this.txtApotema.TabIndex = 38;
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(159, 75);
            this.txtLado.Margin = new System.Windows.Forms.Padding(2);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(76, 20);
            this.txtLado.TabIndex = 37;
            // 
            // lblApotema
            // 
            this.lblApotema.AutoSize = true;
            this.lblApotema.Location = new System.Drawing.Point(180, 250);
            this.lblApotema.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApotema.Name = "lblApotema";
            this.lblApotema.Size = new System.Drawing.Size(52, 13);
            this.lblApotema.TabIndex = 36;
            this.lblApotema.Text = "Apotema:";
            // 
            // lblLado
            // 
            this.lblLado.AutoSize = true;
            this.lblLado.Location = new System.Drawing.Point(103, 77);
            this.lblLado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLado.Name = "lblLado";
            this.lblLado.Size = new System.Drawing.Size(34, 13);
            this.lblLado.TabIndex = 35;
            this.lblLado.Text = "Lado:";
            // 
            // txtPerimetro
            // 
            this.txtPerimetro.Location = new System.Drawing.Point(238, 212);
            this.txtPerimetro.Margin = new System.Windows.Forms.Padding(2);
            this.txtPerimetro.Name = "txtPerimetro";
            this.txtPerimetro.Size = new System.Drawing.Size(76, 20);
            this.txtPerimetro.TabIndex = 34;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(238, 176);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(76, 20);
            this.txtArea.TabIndex = 33;
            // 
            // lblTiPer
            // 
            this.lblTiPer.AutoSize = true;
            this.lblTiPer.Location = new System.Drawing.Point(176, 215);
            this.lblTiPer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiPer.Name = "lblTiPer";
            this.lblTiPer.Size = new System.Drawing.Size(56, 13);
            this.lblTiPer.TabIndex = 32;
            this.lblTiPer.Text = "Perímetro:";
            // 
            // lblTiArea
            // 
            this.lblTiArea.AutoSize = true;
            this.lblTiArea.Location = new System.Drawing.Point(176, 181);
            this.lblTiArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTiArea.Name = "lblTiArea";
            this.lblTiArea.Size = new System.Drawing.Size(32, 13);
            this.lblTiArea.TabIndex = 31;
            this.lblTiArea.Text = "Área:";
            // 
            // lblHeptagono
            // 
            this.lblHeptagono.AutoSize = true;
            this.lblHeptagono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeptagono.Location = new System.Drawing.Point(177, 9);
            this.lblHeptagono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeptagono.Name = "lblHeptagono";
            this.lblHeptagono.Size = new System.Drawing.Size(137, 31);
            this.lblHeptagono.TabIndex = 30;
            this.lblHeptagono.Text = "Hexágono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(212, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Resultado";
            // 
            // FrmHexagono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtApotema);
            this.Controls.Add(this.txtLado);
            this.Controls.Add(this.lblApotema);
            this.Controls.Add(this.lblLado);
            this.Controls.Add(this.txtPerimetro);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblTiPer);
            this.Controls.Add(this.lblTiArea);
            this.Controls.Add(this.lblHeptagono);
            this.Name = "FrmHexagono";
            this.Text = "Hexagono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtApotema;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblApotema;
        private System.Windows.Forms.Label lblLado;
        private System.Windows.Forms.TextBox txtPerimetro;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblTiPer;
        private System.Windows.Forms.Label lblTiArea;
        private System.Windows.Forms.Label lblHeptagono;
        private System.Windows.Forms.Label label2;
    }
}