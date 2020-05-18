using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1._5
{
    public partial class frmConsultaMedica : Form
    {
        public frmConsultaMedica()
        {
            InitializeComponent();
        }

        int contCardio=0;
        int contOdonto = 0;
        int contPedia = 0;
        int contMedicos = 0;
        double sumaPrecios = 0;
        double promedioSueldo = 0;

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int pSexo;
            if (rdoMasc.Checked) pSexo = 1;
            else if (rdoFem.Checked) pSexo = 2;
            else if (rdoOtro.Checked) pSexo = 3;
            else pSexo = 0;

            Medico medico1 = new Medico(int.Parse(txtMatricula.Text), txtNombre.Text, pSexo, cmbEspecialidad.SelectedIndex + 1, double.Parse(txtPrecio.Text));

            if (medico1.Especialidad == 1) contCardio++;
            if (medico1.Especialidad == 2) contOdonto++;
            if (medico1.Especialidad == 3) contPedia++;

            contMedicos++;

            sumaPrecios += medico1.Precio;

            lblCantCardiologia.Text = contCardio.ToString();
            lblCantOdontologia.Text = contOdonto.ToString();
            lblCantPediatria.Text = contPedia.ToString();
            lblPrecioPromedio.Text = (Math.Round(medico1.CalcularPrecioGral(contMedicos, sumaPrecios), 2)).ToString();

            MessageBox.Show(medico1.MostrarInfo());


        }
    }
}
