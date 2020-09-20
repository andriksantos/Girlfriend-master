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
    public partial class AddMessageForm : Form
    {
        public AddMessageForm()
        {
            InitializeComponent();
        }
        public string _mensaje;
        private void AddMessageForm_Load(object sender, EventArgs e)
        {
            guna2AnimateWindow1.SetAnimateWindow(this);
            ShadowAddMF.SetShadowForm(this);
            nombre3.Text = Dato.Valor;
            CerrarApp.Visible = false;
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (addmesage.Text == "")
            {
                MessageBox.Show(Dato.MessageEnterMessage, "Hi ❤, First!");
            }
            else
            {
                Dato.ADDmesage =  addmesage.Text;
                Dato.ButtonYes();
                Sendmsg.Text = "Message sent 💌";
                CerrarApp.Visible = true;
            }
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
