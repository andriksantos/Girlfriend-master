using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; //libreria para redondear form
namespace Presentacion
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None; // redondear las esquinas del form
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // redondear las esquinas del form
        }
        // redondear las esquinas del form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
            );

        // Mover el form con el mouse
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        // Mover el form con el mouse
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Me encantas 💙", "Andrik Santos");
            Environment.Exit(0);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            // Aquí es donde ocurre toda la magia
            // Es muy simple
            int newX = r.Next(0, this.Size.Width - NO.Size.Width);
            int newY = r.Next(0, this.Size.Height - NO.Size.Height);
            NO.Location = new Point(newX, newY);
        }
    }
}
