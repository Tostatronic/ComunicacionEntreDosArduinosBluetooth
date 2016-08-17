namespace ControladorRGBApp
{
    partial class Configuration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.lblName = new System.Windows.Forms.Label();
            this.cmbSeleccion = new System.Windows.Forms.ComboBox();
            this.pcbOk = new System.Windows.Forms.PictureBox();
            this.pcbCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(13, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(93, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Seleccione puerto";
            // 
            // cmbSeleccion
            // 
            this.cmbSeleccion.FormattingEnabled = true;
            this.cmbSeleccion.Items.AddRange(new object[] {
            "[Seleccione Opcion]"});
            this.cmbSeleccion.Location = new System.Drawing.Point(112, 36);
            this.cmbSeleccion.Name = "cmbSeleccion";
            this.cmbSeleccion.Size = new System.Drawing.Size(251, 21);
            this.cmbSeleccion.TabIndex = 1;
            // 
            // pcbOk
            // 
            this.pcbOk.BackColor = System.Drawing.Color.White;
            this.pcbOk.Image = ((System.Drawing.Image)(resources.GetObject("pcbOk.Image")));
            this.pcbOk.Location = new System.Drawing.Point(314, 97);
            this.pcbOk.Name = "pcbOk";
            this.pcbOk.Size = new System.Drawing.Size(49, 50);
            this.pcbOk.TabIndex = 2;
            this.pcbOk.TabStop = false;
            this.pcbOk.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcbOk_MouseClick);
            // 
            // pcbCancel
            // 
            this.pcbCancel.BackColor = System.Drawing.Color.White;
            this.pcbCancel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pcbCancel.Image = ((System.Drawing.Image)(resources.GetObject("pcbCancel.Image")));
            this.pcbCancel.Location = new System.Drawing.Point(259, 97);
            this.pcbCancel.Name = "pcbCancel";
            this.pcbCancel.Size = new System.Drawing.Size(49, 50);
            this.pcbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbCancel.TabIndex = 3;
            this.pcbCancel.TabStop = false;
            this.pcbCancel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pcbCancel_MouseClick);
            // 
            // Configuration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 159);
            this.Controls.Add(this.pcbCancel);
            this.Controls.Add(this.pcbOk);
            this.Controls.Add(this.cmbSeleccion);
            this.Controls.Add(this.lblName);
            this.Name = "Configuration";
            this.Text = "Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.pcbOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbSeleccion;
        private System.Windows.Forms.PictureBox pcbOk;
        private System.Windows.Forms.PictureBox pcbCancel;
    }
}