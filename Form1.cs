namespace Examen_RentaCar_JulioEvangelista
{
    public partial class frmAlquiler : Form
    {
        

        public frmAlquiler()
        {
            InitializeComponent();
            btnAgregar.Click += btnAgregar_Click;
            btnNuevoAlquiler.Click += btnNuevoAlquiler_Click;
        }
        // Agregar un alquiler a la lista
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seguro = "Basico";

            if (rbtCompleto.Checked)
            {
                seguro = "Completo";
            }

            lstAlquileres.Items.Add(nudDias.Value + " " + txtVehiculo.Text + " (" + seguro + ") " + txtTarifa.Text + " " + txtTotal.Text);
        }
        // Calcular el total a pagar
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dias = Convert.ToInt32(nudDias.Value);
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);
            decimal descuento = 0;
            decimal domicilio = 0;

            if (rbtCompleto.Checked)
            {
                tarifa = tarifa + 300;
            }

            if (chkGps.Checked)
            {
                tarifa = tarifa + 100;
            }

            decimal subtotal = tarifa * dias;

            if (chkCorporativo.Checked)
            {
                descuento = subtotal * 0.15m;
            }

            if (rbtDomicilio.Checked)
            {
                domicilio = 500;
            }

            decimal baseImponible = subtotal - descuento + domicilio;
            decimal itbis = baseImponible * 0.18m;
            decimal totalPagar = baseImponible + itbis;

            txtSubtotal.Text = subtotal.ToString("N2");
            txtDescuento.Text = descuento.ToString("N2");
            txtDomicilio.Text = domicilio.ToString("N2");
            txtItbis.Text = itbis.ToString("N2");
            txtTotal.Text = totalPagar.ToString("N2");
        }
        // Salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btnNuevoAlquiler_Click(object sender, EventArgs e)
        {
            txtCliente.Clear();
            txtVehiculo.Clear();
            txtTarifa.Clear();
            nudDias.Value = 0;
            chkCorporativo.Checked = false;
            chkGps.Checked = false;
            lstAlquileres.Items.Clear();
            txtSubtotal.Clear();
            txtDescuento.Clear();
            txtDomicilio.Clear();
            txtItbis.Clear();
            txtTotal.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdtBasico.Checked = true;
            rbtSucursal.Checked = true;

        }
          


        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void nudDias_ValueChanged(object sender, EventArgs e) { }
      
        private void checkBox1_CheckedChanged(object sender, EventArgs e) { }
        private void lblSubtotal_Click(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void lstAlquileres_SelectedIndexChanged(object sender, EventArgs e) { }
        private void groupBox2_Enter(object sender, EventArgs e) { }
        private void rdtBasico_CheckedChanged(object sender, EventArgs e) { }
        private void txtSubtotal_TextChanged(object sender, EventArgs e) { }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
