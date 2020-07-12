namespace Presentacion
{
    partial class Sweetie
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sweetie));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SI = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SI
            // 
            this.SI.BackColor = System.Drawing.Color.Maroon;
            this.SI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SI.FlatAppearance.BorderSize = 0;
            this.SI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SI.Font = new System.Drawing.Font("Open Sans Extrabold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SI.ForeColor = System.Drawing.Color.White;
            this.SI.Location = new System.Drawing.Point(285, 296);
            this.SI.Name = "SI";
            this.SI.Size = new System.Drawing.Size(75, 30);
            this.SI.TabIndex = 1;
            this.SI.Text = "YES";
            this.SI.UseVisualStyleBackColor = false;
            this.SI.Click += new System.EventHandler(this.button1_Click);
            // 
            // NO
            // 
            this.NO.BackColor = System.Drawing.Color.Transparent;
            this.NO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NO.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.NO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NO.Font = new System.Drawing.Font("Open Sans Extrabold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NO.ForeColor = System.Drawing.Color.Maroon;
            this.NO.Location = new System.Drawing.Point(384, 296);
            this.NO.Name = "NO";
            this.NO.Size = new System.Drawing.Size(75, 30);
            this.NO.TabIndex = 2;
            this.NO.TabStop = false;
            this.NO.Text = "NO";
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            this.NO.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // Sweetie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sweetie";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sweetie";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button NO;
    }
}

