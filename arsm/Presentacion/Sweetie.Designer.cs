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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sweetie));
            this.SI = new System.Windows.Forms.Button();
            this.NO = new System.Windows.Forms.Button();
            this.nombre2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.etiquetas = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.RedondearSweetie = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MoverSweetie = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.ShadowSweetie = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.etiquetas.SetToolTip(this.SI, "if you accept i will be the happiest and i will make you happy");
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
            this.etiquetas.SetToolTip(this.NO, "like no, give it yes");
            this.NO.UseVisualStyleBackColor = false;
            this.NO.Click += new System.EventHandler(this.NO_Click);
            this.NO.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            // 
            // nombre2
            // 
            this.nombre2.BackColor = System.Drawing.Color.Transparent;
            this.nombre2.CheckedState.Parent = this.nombre2;
            this.nombre2.CustomImages.Parent = this.nombre2;
            this.nombre2.Enabled = false;
            this.nombre2.FillColor = System.Drawing.Color.Transparent;
            this.nombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nombre2.ForeColor = System.Drawing.Color.White;
            this.nombre2.HoverState.Parent = this.nombre2;
            this.nombre2.IndicateFocus = true;
            this.nombre2.Location = new System.Drawing.Point(269, 188);
            this.nombre2.Name = "nombre2";
            this.nombre2.ShadowDecoration.Parent = this.nombre2;
            this.nombre2.Size = new System.Drawing.Size(210, 38);
            this.nombre2.TabIndex = 4;
            this.nombre2.Text = "nombre";
            this.nombre2.UseTransparentBackground = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Enabled = false;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(205, 232);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(330, 38);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "¿would you accept being my girlfriend?";
            this.guna2Button1.UseTransparentBackground = true;
            // 
            // etiquetas
            // 
            this.etiquetas.AllowLinksHandling = true;
            this.etiquetas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.etiquetas.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // RedondearSweetie
            // 
            this.RedondearSweetie.TargetControl = this;
            // 
            // MoverSweetie
            // 
            this.MoverSweetie.TargetControl = this.pictureBox1;
            // 
            // AnimateWindow1
            // 
            this.AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.AnimateWindow1.Interval = 1000;
            // 
            // Sweetie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 500);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.NO);
            this.Controls.Add(this.SI);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sweetie";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sweetie";
            this.Load += new System.EventHandler(this.Sweetie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SI;
        private System.Windows.Forms.Button NO;
        public Guna.UI2.WinForms.Guna2Button nombre2;
        public Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip etiquetas;
        private Guna.UI2.WinForms.Guna2Elipse RedondearSweetie;
        private Guna.UI2.WinForms.Guna2DragControl MoverSweetie;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowSweetie;
        public Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow1;
    }
}

