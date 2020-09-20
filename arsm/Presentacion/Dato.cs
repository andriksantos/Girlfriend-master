using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using WhatsAppApi;
using System.Net;
using System.Net.Http;
using System.IO;
using Presentacion;
using System.Windows.Forms;
namespace Presentacion
{
    public class Dato
    {
        //METHODS OF MESSAGES
        static public string Valor;
        static public string MessageYES = ", I looked at what you gave him, YES! \n I 💙 sweetie...";
        static public string MessageNO = ", I looked at what you gave him, NO! \n 💔 💔 💔 💔 💔";
        static public string MessageError = "You need conection to internet for used this application...";
        static public string MessageEnterName = "Sweetie enter your Name first...";
        static public string MessageEnterMessage = "Sweetie enter your message first...";
        static public string ADDmesage;
        static public string nextMSG = "wrote the following message";

        //METHOD OF CLICK ON BUTTON YES
        static public void ButtonYes(){
        //Code for msg to whatsapp
        string yourId = "ZxM359P9/Em2QSCtSMZtdWFuZHJpY2tzYW50b3MxX2F0X2dtYWlsX2RvdF9jb20=";
        string yourMobile = "+50496679577";
        string yourMessage = Dato.Valor + Dato.nextMSG +  Dato.ADDmesage ;

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
                MessageBox.Show(Dato.MessageError, "Sweetie ❤");
                Console.WriteLine(se.Message);
            }
            Console.ReadLine();
            Environment.Exit(0);
        }
        static public void ButtonNot()
        {
            MessageBox.Show(Dato.Valor + Dato.MessageNO, "Andrik Santos");
        }
    }
}
