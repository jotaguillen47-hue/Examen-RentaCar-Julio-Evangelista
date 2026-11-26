namespace Examen_RentaCar_JulioEvangelista
{
    partial class frmAlquiler
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblSalida = new Label();
            lbl = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCliente = new TextBox();
            chkCorporativo = new CheckBox();
            txtVehiculo = new TextBox();
            txtTarifa = new TextBox();
            btnAgregar = new Button();
            btnCalcular = new Button();
            btnNuevoAlquiler = new Button();
            btnSalir = new Button();
            lstAlquileres = new ListBox();
            nudDias = new NumericUpDown();
            groupBox1 = new GroupBox();
            rbtCompleto = new RadioButton();
            rdtBasico = new RadioButton();
            groupBox2 = new GroupBox();
            rbtDomicilio = new RadioButton();
            rbtSucursal = new RadioButton();
            chkGps = new CheckBox();
            lblSubtotal = new Label();
            lblDescuento = new Label();
            lblDomicilio = new Label();
            lblItbis = new Label();
            lblTotal = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtSubtotal = new TextBox();
            txtDescuento = new TextBox();
            txtDomicilio = new TextBox();
            txtItbis = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudDias).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(62, 63);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Cliente:";
            lblNombre.Click += label1_Click;
            // 
            // lblSalida
            // 
            lblSalida.AutoSize = true;
            lblSalida.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalida.Location = new Point(62, 167);
            lblSalida.Name = "lblSalida";
            lblSalida.Size = new Size(54, 20);
            lblSalida.TabIndex = 1;
            lblSalida.Text = "Salida:";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl.Location = new Point(62, 227);
            lbl.Name = "lbl";
            lbl.Size = new Size(72, 20);
            lbl.TabIndex = 2;
            lbl.Text = "Vehiculo:";
            lbl.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 292);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 3;
            label4.Text = "Tarifa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(62, 362);
            label5.Name = "label5";
            label5.Size = new Size(42, 20);
            label5.TabIndex = 4;
            label5.Text = "Dias:";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(181, 63);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(200, 27);
            txtCliente.TabIndex = 5;
            // 
            // chkCorporativo
            // 
            chkCorporativo.AutoSize = true;
            chkCorporativo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkCorporativo.Location = new Point(62, 105);
            chkCorporativo.Name = "chkCorporativo";
            chkCorporativo.Size = new Size(164, 24);
            chkCorporativo.TabIndex = 6;
            chkCorporativo.Text = "Cliente Corporativo";
            chkCorporativo.UseVisualStyleBackColor = true;
            // 
            // txtVehiculo
            // 
            txtVehiculo.Location = new Point(181, 227);
            txtVehiculo.Name = "txtVehiculo";
            txtVehiculo.Size = new Size(200, 27);
            txtVehiculo.TabIndex = 7;
            txtVehiculo.TextChanged += textBox1_TextChanged;
            // 
            // txtTarifa
            // 
            txtTarifa.Location = new Point(181, 292);
            txtTarifa.Name = "txtTarifa";
            txtTarifa.Size = new Size(200, 27);
            txtTarifa.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.DarkGray;
            btnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(516, 40);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(295, 50);
            btnAgregar.TabIndex = 9;
            btnAgregar.Text = "Agregar al alquiler";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.DarkGray;
            btnCalcular.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(62, 628);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(127, 49);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular total";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnNuevoAlquiler
            // 
            btnNuevoAlquiler.BackColor = Color.DarkGray;
            btnNuevoAlquiler.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevoAlquiler.Location = new Point(206, 628);
            btnNuevoAlquiler.Name = "btnNuevoAlquiler";
            btnNuevoAlquiler.Size = new Size(140, 49);
            btnNuevoAlquiler.TabIndex = 11;
            btnNuevoAlquiler.Text = "Nuevo alquiler";
            btnNuevoAlquiler.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkGray;
            btnSalir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(368, 628);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(130, 49);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // lstAlquileres
            // 
            lstAlquileres.BorderStyle = BorderStyle.FixedSingle;
            lstAlquileres.ForeColor = Color.Transparent;
            lstAlquileres.FormattingEnabled = true;
            lstAlquileres.Location = new Point(519, 128);
            lstAlquileres.Name = "lstAlquileres";
            lstAlquileres.Size = new Size(295, 182);
            lstAlquileres.TabIndex = 13;
            lstAlquileres.SelectedIndexChanged += lstAlquileres_SelectedIndexChanged;
            // 
            // nudDias
            // 
            nudDias.Location = new Point(181, 360);
            nudDias.Name = "nudDias";
            nudDias.Size = new Size(150, 27);
            nudDias.TabIndex = 14;
            nudDias.ValueChanged += nudDias_ValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Silver;
            groupBox1.Controls.Add(rbtCompleto);
            groupBox1.Controls.Add(rdtBasico);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(62, 439);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(177, 125);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seguro";
            // 
            // rbtCompleto
            // 
            rbtCompleto.AutoSize = true;
            rbtCompleto.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtCompleto.Location = new Point(10, 76);
            rbtCompleto.Name = "rbtCompleto";
            rbtCompleto.Size = new Size(106, 27);
            rbtCompleto.TabIndex = 19;
            rbtCompleto.TabStop = true;
            rbtCompleto.Text = "Completo";
            rbtCompleto.UseVisualStyleBackColor = true;
            // 
            // rdtBasico
            // 
            rdtBasico.AutoSize = true;
            rdtBasico.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdtBasico.Location = new Point(10, 43);
            rdtBasico.Name = "rdtBasico";
            rdtBasico.Size = new Size(79, 27);
            rdtBasico.TabIndex = 18;
            rdtBasico.TabStop = true;
            rdtBasico.Text = "Basico";
            rdtBasico.UseVisualStyleBackColor = true;
            rdtBasico.CheckedChanged += rdtBasico_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Silver;
            groupBox2.Controls.Add(rbtDomicilio);
            groupBox2.Controls.Add(rbtSucursal);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(280, 439);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 125);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Entrega";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // rbtDomicilio
            // 
            rbtDomicilio.AutoSize = true;
            rbtDomicilio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtDomicilio.Location = new Point(19, 82);
            rbtDomicilio.Name = "rbtDomicilio";
            rbtDomicilio.Size = new Size(102, 27);
            rbtDomicilio.TabIndex = 20;
            rbtDomicilio.TabStop = true;
            rbtDomicilio.Text = "Domicilio";
            rbtDomicilio.UseVisualStyleBackColor = true;
            // 
            // rbtSucursal
            // 
            rbtSucursal.AutoSize = true;
            rbtSucursal.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbtSucursal.Location = new Point(19, 49);
            rbtSucursal.Name = "rbtSucursal";
            rbtSucursal.Size = new Size(116, 27);
            rbtSucursal.TabIndex = 19;
            rbtSucursal.TabStop = true;
            rbtSucursal.Text = "En sucursal";
            rbtSucursal.UseVisualStyleBackColor = true;
            // 
            // chkGps
            // 
            chkGps.AutoSize = true;
            chkGps.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkGps.Location = new Point(62, 585);
            chkGps.Name = "chkGps";
            chkGps.Size = new Size(189, 24);
            chkGps.TabIndex = 17;
            chkGps.Text = "GPS ( +RD$100 por dia)";
            chkGps.UseVisualStyleBackColor = true;
            chkGps.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(521, 377);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(66, 20);
            lblSubtotal.TabIndex = 18;
            lblSubtotal.Text = "Subtotal";
            lblSubtotal.Click += lblSubtotal_Click;
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescuento.Location = new Point(521, 410);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(81, 20);
            lblDescuento.TabIndex = 19;
            lblDescuento.Text = "Descuento";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDomicilio.Location = new Point(521, 443);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(74, 20);
            lblDomicilio.TabIndex = 20;
            lblDomicilio.Text = "Domicilio";
            // 
            // lblItbis
            // 
            lblItbis.AutoSize = true;
            lblItbis.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItbis.Location = new Point(519, 476);
            lblItbis.Name = "lblItbis";
            lblItbis.Size = new Size(87, 20);
            lblItbis.TabIndex = 21;
            lblItbis.Text = "ITBIS (18 %)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(516, 544);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(115, 20);
            lblTotal.TabIndex = 23;
            lblTotal.Text = "TOTAL A PAGAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(521, 105);
            label2.Name = "label2";
            label2.Size = new Size(294, 22);
            label2.TabIndex = 24;
            label2.Text = "Dias         Vehiculo            Tarifa          Total";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 25;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtSubtotal
            // 
            txtSubtotal.Location = new Point(623, 374);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new Size(156, 27);
            txtSubtotal.TabIndex = 26;
            txtSubtotal.TextChanged += txtSubtotal_TextChanged;
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(623, 407);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(156, 27);
            txtDescuento.TabIndex = 27;
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(623, 440);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(156, 27);
            txtDomicilio.TabIndex = 28;
            // 
            // txtItbis
            // 
            txtItbis.Location = new Point(623, 473);
            txtItbis.Name = "txtItbis";
            txtItbis.Size = new Size(156, 27);
            txtItbis.TabIndex = 29;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(637, 537);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(156, 27);
            txtTotal.TabIndex = 30;
            // 
            // label1
            // 
            label1.BackColor = Color.Gainsboro;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 509);
            label1.Name = "label1";
            label1.Size = new Size(309, 25);
            label1.TabIndex = 31;
            label1.Text = "-----------------------------------------------";
            // 
            // frmAlquiler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(911, 718);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtItbis);
            Controls.Add(txtDomicilio);
            Controls.Add(txtDescuento);
            Controls.Add(txtSubtotal);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(lblTotal);
            Controls.Add(lblItbis);
            Controls.Add(lblDomicilio);
            Controls.Add(lblDescuento);
            Controls.Add(lblSubtotal);
            Controls.Add(chkGps);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(nudDias);
            Controls.Add(lstAlquileres);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevoAlquiler);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(txtTarifa);
            Controls.Add(txtVehiculo);
            Controls.Add(chkCorporativo);
            Controls.Add(txtCliente);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl);
            Controls.Add(lblSalida);
            Controls.Add(lblNombre);
            Name = "frmAlquiler";
            Text = "RentaCar Express - Alquileres";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudDias).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblSalida;
        private Label lbl;
        private Label label4;
        private Label label5;
        private TextBox txtCliente;
        private CheckBox chkCorporativo;
        private TextBox txtVehiculo;
        private TextBox txtTarifa;
        private Button btnAgregar;
        private Button btnCalcular;
        private Button btnNuevoAlquiler;
        private Button btnSalir;
        private ListBox lstAlquileres;
        private NumericUpDown nudDias;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private CheckBox chkGps;
        private RadioButton rdtBasico;
        private RadioButton rbtCompleto;
        private RadioButton rbtDomicilio;
        private RadioButton rbtSucursal;
        private Label lblSubtotal;
        private Label lblDescuento;
        private Label lblDomicilio;
        private Label lblItbis;
        private Label lblTotal;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox txtSubtotal;
        private TextBox txtDescuento;
        private TextBox txtDomicilio;
        private TextBox txtItbis;
        private TextBox txtTotal;
        private Label label1;
    }
}
