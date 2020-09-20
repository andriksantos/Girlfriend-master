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
            this.ShadowSweetie.SetShadowForm(this);
        }
        //METHODS
        string MessageYes = "addmesage.Text";
        string MessageNo = "Logro darle en el boton que dice NO...";
       void ButtonYes()
        {
            //Code for msg to whatsapp
            string yourId = "ZxM359P9/Em2QSCtSMZtdWFuZHJpY2tzYW50b3MxX2F0X2dtYWlsX2RvdF9jb20=";
            string yourMobile = "+50496679577";
            string yourMessage = nombre2.Text + MessageYes;

            try
            {
                string url = "https://NiceApi.net/API";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.Headers.Add("X-APIId", yourId);
                request.Headers.Add("X-APIMobile", yourMobile);
                using (StreamWriter streamOut = new StreamWriter(request.GetRequestStream()))
                {
                    streamOut.Write(yourMessage);
                }
                using (StreamReader streamIn = new StreamReader(request.GetResponse().GetResponseStream()))
                {
                    Console.WriteLine(streamIn.ReadToEnd());
                }
            }
            catch (SystemException se)
            {
                MessageBox.Show("Se necesita conexxion a internet");
                Console.WriteLine(se.Message);
            }
            Console.ReadLine();
            Environment.Exit(0);
        }

        void ButtonNot()
        {

        }

        //BUTTONS
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nombre2.Text + ", I looked at what you gave him, YES! I 💙 sweetie...", "Andrik Santos");
            AddMessageForm adms = new AddMessageForm();
            adms.Show();
        }
        private void NO_Click(object sender, EventArgs e)
        {
            ButtonNot();
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
