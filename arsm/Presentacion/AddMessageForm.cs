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
        private void AddMessageForm_Load(object sender, EventArgs e)
        {
            ShadowAddMF.SetShadowForm(this);
        }
        
        private void Ingresar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
