using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Nombre : Form
    {
        public Nombre()
        {
            InitializeComponent();
        }
        private void nombre_Load(object sender, EventArgs e)
        {
            sombre.SetShadowForm(this);
        }
        //METHODS
        public void IngresarSweetie()
        {
            if (IngresarName.Text == "")
            {
                MessageBox.Show("Sweetie enter your Name first..." , "Hi ❤, First!");
                IngresarName.Focus();
            }
            else
            {
                Sweetie sweetiee = new Sweetie();
                sweetiee.Show();
                Dato.Valor = IngresarName.Text;
                sweetiee.nombre2.Text = Dato.Valor;
                this.Hide();
            }
        }
        //BUTTONS
        private void Ingresar_Click(object sender, EventArgs e)
        {
            IngresarSweetie();
        }
    }
}
