using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using WhatsAppApi;
using System.Net;
using System.Net.Http;
using System.IO;
using Presentacion;

namespace Presentacion
{
    public partial class Sweetie : Form
    {
        Random r = new Random();
        public Sweetie()
        {
            InitializeComponent();
        }
        private void Sweetie_Load(object sender, EventArgs e)
        {
            AnimateWindow1.SetAnimateWindow(this);
            this.ShadowSweetie.SetShadowForm(this);
        }
        //BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Dato.Valor + Dato.MessageYES , "Andrik Santos");
            AddMessageForm adms = new AddMessageForm();
            adms.Show();
            this.Hide();
        }
        private void NO_Click(object sender, EventArgs e)
        {
            Dato.ButtonNot();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Dato.ButtonYes();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //MOVE THE BUTTON NO WITH THE MOUSE
            int newX = r.Next(0, this.Size.Width - NO.Size.Width);
            int newY = r.Next(0, this.Size.Height - NO.Size.Height);
            NO.Location = new Point(newX, newY);
        }
    }
}
