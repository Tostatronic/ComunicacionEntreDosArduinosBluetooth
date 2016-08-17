namespace ControladorRGBApp
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
            this.lblControlador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pctBColorRGB = new System.Windows.Forms.PictureBox();
            this.scbR = new System.Windows.Forms.HScrollBar();
            this.lblRS = new System.Windows.Forms.Label();
            this.scbG = new System.Windows.Forms.HScrollBar();
            this.scbB = new System.Windows.Forms.HScrollBar();
            this.lblGS = new System.Windows.Forms.Label();
            this.lblBS = new System.Windows.Forms.Label();
            this.nudR = new System.Windows.Forms.NumericUpDown();
            this.nudG = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.btnAsingColor = new System.Windows.Forms.Button();
            this.cd1 = new System.Windows.Forms.ColorDialog();
            this.btnColores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBColorRGB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            this.SuspendLayout();
            // 
            // lblControlador
            // 
            this.lblControlador.AutoSize = true;
            this.lblControlador.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlador.Location = new System.Drawing.Point(85, 9);
            this.lblControlador.Name = "lblControlador";
            this.lblControlador.Size = new System.Drawing.Size(108, 26);
            this.lblControlador.TabIndex = 0;
            this.lblControlador.Text = "Controlador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(235, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "G";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(256, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "B";
            // 
            // pctBColorRGB
            // 
            this.pctBColorRGB.Location = new System.Drawing.Point(162, 58);
            this.pctBColorRGB.Name = "pctBColorRGB";
            this.pctBColorRGB.Size = new System.Drawing.Size(61, 50);
            this.pctBColorRGB.TabIndex = 4;
            this.pctBColorRGB.TabStop = false;
            // 
            // scbR
            // 
            this.scbR.Location = new System.Drawing.Point(50, 142);
            this.scbR.Maximum = 255;
            this.scbR.Name = "scbR";
            this.scbR.Size = new System.Drawing.Size(290, 17);
            this.scbR.TabIndex = 5;
            this.scbR.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // lblRS
            // 
            this.lblRS.AutoSize = true;
            this.lblRS.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRS.ForeColor = System.Drawing.Color.Red;
            this.lblRS.Location = new System.Drawing.Point(12, 133);
            this.lblRS.Name = "lblRS";
            this.lblRS.Size = new System.Drawing.Size(29, 26);
            this.lblRS.TabIndex = 6;
            this.lblRS.Text = "R";
            // 
            // scbG
            // 
            this.scbG.Location = new System.Drawing.Point(50, 179);
            this.scbG.Maximum = 255;
            this.scbG.Name = "scbG";
            this.scbG.Size = new System.Drawing.Size(290, 17);
            this.scbG.TabIndex = 7;
            this.scbG.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbG_Scroll);
            // 
            // scbB
            // 
            this.scbB.Location = new System.Drawing.Point(50, 216);
            this.scbB.Maximum = 255;
            this.scbB.Name = "scbB";
            this.scbB.Size = new System.Drawing.Size(290, 17);
            this.scbB.TabIndex = 8;
            this.scbB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scbB_Scroll);
            // 
            // lblGS
            // 
            this.lblGS.AutoSize = true;
            this.lblGS.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblGS.Location = new System.Drawing.Point(12, 170);
            this.lblGS.Name = "lblGS";
            this.lblGS.Size = new System.Drawing.Size(29, 26);
            this.lblGS.TabIndex = 9;
            this.lblGS.Text = "G";
            // 
            // lblBS
            // 
            this.lblBS.AutoSize = true;
            this.lblBS.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblBS.Location = new System.Drawing.Point(11, 207);
            this.lblBS.Name = "lblBS";
            this.lblBS.Size = new System.Drawing.Size(30, 26);
            this.lblBS.TabIndex = 10;
            this.lblBS.Text = "B";
            // 
            // nudR
            // 
            this.nudR.Location = new System.Drawing.Point(362, 139);
            this.nudR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudR.Name = "nudR";
            this.nudR.Size = new System.Drawing.Size(55, 20);
            this.nudR.TabIndex = 11;
            this.nudR.ValueChanged += new System.EventHandler(this.nudR_ValueChanged);
            // 
            // nudG
            // 
            this.nudG.Location = new System.Drawing.Point(362, 178);
            this.nudG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudG.Name = "nudG";
            this.nudG.Size = new System.Drawing.Size(55, 20);
            this.nudG.TabIndex = 12;
            this.nudG.ValueChanged += new System.EventHandler(this.nudG_ValueChanged);
            // 
            // nudB
            // 
            this.nudB.Location = new System.Drawing.Point(362, 213);
            this.nudB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(55, 20);
            this.nudB.TabIndex = 13;
            this.nudB.ValueChanged += new System.EventHandler(this.nudB_ValueChanged);
            // 
            // btnAsingColor
            // 
            this.btnAsingColor.Location = new System.Drawing.Point(294, 58);
            this.btnAsingColor.Name = "btnAsingColor";
            this.btnAsingColor.Size = new System.Drawing.Size(99, 50);
            this.btnAsingColor.TabIndex = 14;
            this.btnAsingColor.Text = "Asignar color";
            this.btnAsingColor.UseVisualStyleBackColor = true;
            this.btnAsingColor.Click += new System.EventHandler(this.btnAsingColor_Click);
            // 
            // btnColores
            // 
            this.btnColores.Location = new System.Drawing.Point(17, 58);
            this.btnColores.Name = "btnColores";
            this.btnColores.Size = new System.Drawing.Size(75, 23);
            this.btnColores.TabIndex = 15;
            this.btnColores.Text = "Colores";
            this.btnColores.UseVisualStyleBackColor = true;
            this.btnColores.Click += new System.EventHandler(this.btnColores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.btnColores);
            this.Controls.Add(this.btnAsingColor);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudG);
            this.Controls.Add(this.nudR);
            this.Controls.Add(this.lblBS);
            this.Controls.Add(this.lblGS);
            this.Controls.Add(this.scbB);
            this.Controls.Add(this.scbG);
            this.Controls.Add(this.lblRS);
            this.Controls.Add(this.scbR);
            this.Controls.Add(this.pctBColorRGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblControlador);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctBColorRGB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblControlador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pctBColorRGB;
        private System.Windows.Forms.HScrollBar scbR;
        private System.Windows.Forms.Label lblRS;
        private System.Windows.Forms.HScrollBar scbG;
        private System.Windows.Forms.HScrollBar scbB;
        private System.Windows.Forms.Label lblGS;
        private System.Windows.Forms.Label lblBS;
        private System.Windows.Forms.NumericUpDown nudR;
        private System.Windows.Forms.NumericUpDown nudG;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Button btnAsingColor;
        private System.Windows.Forms.ColorDialog cd1;
        private System.Windows.Forms.Button btnColores;
    }
}

