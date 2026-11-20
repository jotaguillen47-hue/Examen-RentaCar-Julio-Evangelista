namespace Examen_RentaCar_JulioEvangelista
{
    public partial class frmAlquiler : Form
    {
        decimal subtotal = 0; 

        public frmAlquiler() 
        {
            InitializeComponent();
            btnAgregar.Click += btnAgregar_Click;
            btnNuevoAlquiler.Click += btnNuevoAlquiler_Click;
        }
        // Agregar un alquiler a la lista
        private void btnAgregar_Click(object sender, EventArgs e) 
        {
            int dias = Convert.ToInt32(nudDias.Value);

            if (dias >= 1 && dias <= 30)
            {
                decimal tarifaDiaria = Convert.ToDecimal(txtTarifa.Text);
                string seguro = "Basico";

                // Seguro completo suma 300 a la tarifa diaria
                if (rbtCompleto.Checked)
                {
                    tarifaDiaria = tarifaDiaria + 300;
                    seguro = "Completo";
                }

                // GPS suma 100 por dia
                if (chkGps.Checked)
                {
                    tarifaDiaria = tarifaDiaria + 100;
                }
                // Calcula el total del alquiler
                decimal total = tarifaDiaria * dias;

                lstAlquileres.Items.Add(dias + "   " + txtVehiculo.Text + " \"" + (seguro) + "\"   " + tarifaDiaria + "   " + total);

                subtotal = subtotal + total;
                // Limpia después de agregar
                txtVehiculo.Clear();
                txtTarifa.Clear();
                nudDias.Value = 0;

                // Muestra los resultados al agregar
                btnCalcular_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Los días deben estar entre 1 y 30");
            }
        }
        // Calcular el total a pagar
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal descuento = 0;
            decimal domicilio = 0;

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
            // Muestra los resultados en los TextBox correspondientes
            txtSubtotal.Text = subtotal.ToString();
            txtDescuento.Text = descuento.ToString();
            txtDomicilio.Text = domicilio.ToString();
            txtItbis.Text = itbis.ToString();
            txtTotal.Text = totalPagar.ToString();
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
            subtotal = 0;
        }
        // Salir del programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdtBasico.Checked = true;
            rbtSucursal.Checked = true;

            // para que la lista se vea
            lstAlquileres.Visible = true;
            lstAlquileres.DrawMode = DrawMode.Normal;
            lstAlquileres.BackColor = Color.White;
            lstAlquileres.ForeColor = Color.Black;
            lstAlquileres.BringToFront();
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