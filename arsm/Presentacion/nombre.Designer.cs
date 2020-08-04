namespace Presentacion
{
    partial class nombre
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nombre));
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.IngresarName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Ingresar = new Guna.UI2.WinForms.Guna2Button();
            this.mover = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.sombre = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.etiqueas = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // IngresarName
            // 
            this.IngresarName.Animated = true;
            this.IngresarName.BackColor = System.Drawing.Color.IndianRed;
            this.IngresarName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IngresarName.BorderRadius = 6;
            this.IngresarName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IngresarName.DefaultText = "";
            this.IngresarName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IngresarName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IngresarName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngresarName.DisabledState.Parent = this.IngresarName;
            this.IngresarName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IngresarName.FillColor = System.Drawing.Color.RosyBrown;
            this.IngresarName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IngresarName.FocusedState.Parent = this.IngresarName;
            this.IngresarName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.IngresarName.ForeColor = System.Drawing.Color.White;
            this.IngresarName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IngresarName.HoverState.Parent = this.IngresarName;
            this.IngresarName.Location = new System.Drawing.Point(104, 96);
            this.IngresarName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IngresarName.MaxLength = 30;
            this.IngresarName.Name = "IngresarName";
            this.IngresarName.PasswordChar = '\0';
            this.IngresarName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.IngresarName.PlaceholderText = "Enter your Name";
            this.IngresarName.SelectedText = "";
            this.IngresarName.ShadowDecoration.Parent = this.IngresarName;
            this.IngresarName.Size = new System.Drawing.Size(144, 33);
            this.IngresarName.TabIndex = 0;
            // 
            // Ingresar
            // 
            this.Ingresar.Animated = true;
            this.Ingresar.BackColor = System.Drawing.Color.Transparent;
            this.Ingresar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Ingresar.BorderRadius = 6;
            this.Ingresar.BorderThickness = 1;
            this.Ingresar.CheckedState.Parent = this.Ingresar;
            this.Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ingresar.CustomImages.Parent = this.Ingresar;
            this.Ingresar.FillColor = System.Drawing.Color.White;
            this.Ingresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ingresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Ingresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Ingresar.HoverState.ForeColor = System.Drawing.Color.White;
            this.Ingresar.HoverState.Parent = this.Ingresar;
            this.Ingresar.Location = new System.Drawing.Point(137, 136);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.ShadowDecoration.Parent = this.Ingresar;
            this.Ingresar.Size = new System.Drawing.Size(76, 30);
            this.Ingresar.TabIndex = 2;
            this.Ingresar.Text = "Sing in";
            this.etiqueas.SetToolTip(this.Ingresar, "Enter to app");
            this.Ingresar.UseTransparentBackground = true;
            this.Ingresar.Click += new System.EventHandler(this.Ingresar_Click);
            // 
            // mover
            // 
            this.mover.TargetControl = this.guna2PictureBox1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(350, 250);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // etiqueas
            // 
            this.etiqueas.AllowLinksHandling = true;
            this.etiqueas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.etiqueas.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // nombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 250);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.IngresarName);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "nombre";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nombre";
            this.Load += new System.EventHandler(this.nombre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Ingresar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl mover;
        private Guna.UI2.WinForms.Guna2ShadowForm sombre;
        public Guna.UI2.WinForms.Guna2TextBox IngresarName;
        private Guna.UI2.WinForms.Guna2HtmlToolTip etiqueas;
    }
}