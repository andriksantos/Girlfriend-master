namespace Presentacion
{
    partial class addmessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addmessage));
            this.redondearAddmessage = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.addmesage = new Guna.UI2.WinForms.Guna2TextBox();
            this.Ingresar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // redondearAddmessage
            // 
            this.redondearAddmessage.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(402, 271);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // addmesage
            // 
            this.addmesage.Animated = true;
            this.addmesage.BackColor = System.Drawing.Color.Transparent;
            this.addmesage.BorderColor = System.Drawing.Color.Transparent;
            this.addmesage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addmesage.DefaultText = "";
            this.addmesage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addmesage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addmesage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addmesage.DisabledState.Parent = this.addmesage;
            this.addmesage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addmesage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addmesage.FocusedState.Parent = this.addmesage;
            this.addmesage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.addmesage.HoverState.Parent = this.addmesage;
            this.addmesage.Location = new System.Drawing.Point(12, 12);
            this.addmesage.Modified = true;
            this.addmesage.Multiline = true;
            this.addmesage.Name = "addmesage";
            this.addmesage.PasswordChar = '\0';
            this.addmesage.PlaceholderText = "¿Algo que decir?";
            this.addmesage.SelectedText = "";
            this.addmesage.ShadowDecoration.Parent = this.addmesage;
            this.addmesage.Size = new System.Drawing.Size(378, 156);
            this.addmesage.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.addmesage.TabIndex = 1;
            this.addmesage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Ingresar.Location = new System.Drawing.Point(138, 174);
            this.Ingresar.Name = "Ingresar";
            this.Ingresar.ShadowDecoration.Parent = this.Ingresar;
            this.Ingresar.Size = new System.Drawing.Size(134, 30);
            this.Ingresar.TabIndex = 3;
            this.Ingresar.Text = "Send Message";
            this.Ingresar.UseTransparentBackground = true;
            // 
            // addmessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(402, 271);
            this.Controls.Add(this.Ingresar);
            this.Controls.Add(this.addmesage);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addmessage";
            this.Text = "addmessage";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse redondearAddmessage;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox addmesage;
        private Guna.UI2.WinForms.Guna2Button Ingresar;
    }
}