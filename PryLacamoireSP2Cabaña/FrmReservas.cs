using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLacamoireSP2Cabaña
{
    public partial class frmMain : Form
    {
        // Establece los valores de cada uno Item
        private const float TIPOA = 20;
        public const float TIPOB = 34;
        const float COCINA = 1;
        const float HELADERA = 1.5f;
        const float TELEVISOR = 2;
        const float PORPERSONA = 1;
        public frmMain()
        {
            InitializeComponent();
        }

        private void chkCocina_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Carga las opciones del lstTipo
            lstTipo.Items.Clear();
            lstTipo.Items.Add("Tipo A");
            lstTipo.Items.Add("Tipo B");
            //El programa empieza con Tipo A seleccionada
            lstTipo.SelectedIndex = 0;
            // El programa empieza con la cantidad de días en 1
            txtDias.Text = "1";
           
           
            // El programa empieza con rb efectivo seleccionado
            rbEfectivo.Checked = true;
          
            // Carga los Items del lstTarjetas
            lstTarjetas.Items.Clear();
            lstTarjetas.Items.Add("Card Red");
            lstTarjetas.Items.Add("Card Green");
            lstTarjetas.Items.Add("Card Blue");
            // deshabiliar el botón "Aceptar"
            cmdAceptar.Enabled = false;

        }

        private void lstTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cambia la cantidad de personas que permite seleccionar
            int I = 0;
            // limpiar los items de personas
            lstPersonas.Items.Clear();
            // Tipo A cargar los items del 1 al 4
            if (lstTipo.SelectedIndex == 0) 
            {
                for (I = 1; I <= 4; I++)
                {
                    lstPersonas.Items.Add(I);
                }
            }
            else
            { // si es tipo de cabaña B  cargar los items del 1 al 8
                for (I = 1; I <= 8; I++)
                {
                    lstPersonas.Items.Add(I);
                }
            }
            // establecer como preseleccionado el item 0 del combo
            lstPersonas.SelectedIndex = 0;

        }

        private void mrcTipoCabaña_Enter(object sender, EventArgs e)
        {

        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            // Si se selecciona opcion efectivo inhabilitar lstTarjeta y no dejar seleccionada ninguna tarjeta
            lstTarjetas.Enabled = false;
            lstTarjetas.SelectedIndex = -1;
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            // Si se selecciona la opcion tarjeta habilitar lst tarjeta 
            lstTarjetas.Enabled = true;
            lstTarjetas.SelectedIndex = 0;
            
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            
            // Activa y desactiva el cmdAceptar
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

            // Activa y desactiva el cmdAceptar
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }


        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            // Activa y desactiva el cmdAceptar
            if (txtDias.Text != "" && txtDias.Text != "0" &&
            txtNombre.Text != "" && txtTelefono.Text != "")
            {
                cmdAceptar.Enabled = true;
            }
            else
            {
                cmdAceptar.Enabled = false;
            }
        }

        private void cmdAceptar_Click(object sender, EventArgs e)
        {
            float PrecioBase;
            float Opcionales;
            float Recargo;
            int Dias;
            float Total;

            // obtener la cantidad de dìas ingresados
            Dias = int.Parse(txtDias.Text);
            // controlar el tipo de cabaña para determinar el precio base
            if (lstTipo.SelectedIndex == 0)
            {
                PrecioBase = TIPOA;
            }
            else
            {
                PrecioBase = TIPOB;
            }


            // sumar al precio base el importe extra por persona (US$ 1)
            PrecioBase = PrecioBase + (PORPERSONA * int.Parse(lstPersonas.Text));
            // controlar los adicionales por las opciones
            Opcionales = 0;
            if (chkCocina.Checked == true)
            {
                Opcionales = Opcionales + COCINA;
            }
            if (chkHeladera.Checked == true)
            {
                Opcionales = Opcionales + HELADERA;
            }
            if (chkTelevisor.Checked == true)
            {
                Opcionales = Opcionales + TELEVISOR;
            }
            // determinar el total por la cantidad de dìas
            Total = (PrecioBase + Opcionales) * Dias;



            // Controlar recargo por tarjeta
            if (rbTarjeta.Checked == true)
            {
                if (lstTarjetas.SelectedIndex == 0)
                {
                    Recargo = Total * 10 / 100;
                }
                else
                {
                    Recargo = Total * 20 / 100;
                }
            //Cargar recargo por tarjeta
                Total = Total + Recargo;
            }
            // mostrar el resultado
            MessageBox.Show("Total =$" + Total.ToString(), "Importe de la reserva",
            MessageBoxButtons.OK, MessageBoxIcon.Information);






        }

        private void txtDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permite escribir Letras en txtDias
            if ((e.KeyChar >= 32 && e.KeyChar <=47 ) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show ("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDias.Clear();
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permite escribir numeros en txtNombre
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 123 && e.KeyChar <= 255) || (e.KeyChar >= 91 && e.KeyChar <= 96))
            {
                MessageBox.Show("Solo Letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDias.Clear();
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            //No permite escribir letras en txtTelefono
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDias.Clear();
                e.Handled = true;
                return;
            }
        }
    }
}
