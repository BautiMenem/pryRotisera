namespace pryRotisera
{
    partial class frmVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.mrcTotal = new System.Windows.Forms.GroupBox();
            this.lbltotalTot = new System.Windows.Forms.Label();
            this.lblDescuentoTot = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lstDescuento = new System.Windows.Forms.ComboBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.mrcPago = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.mrcArticulo = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lblTipoUn = new System.Windows.Forms.ComboBox();
            this.lblEleccion = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.mrcDetalles = new System.Windows.Forms.GroupBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.mrcTotal.SuspendLayout();
            this.mrcPago.SuspendLayout();
            this.mrcArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.mrcDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(422, 480);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Generar Ticket";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mrcTotal
            // 
            this.mrcTotal.Controls.Add(this.lbltotalTot);
            this.mrcTotal.Controls.Add(this.lblDescuentoTot);
            this.mrcTotal.Controls.Add(this.lblSubTotal);
            this.mrcTotal.Controls.Add(this.lblTotal);
            this.mrcTotal.Controls.Add(this.lstDescuento);
            this.mrcTotal.Controls.Add(this.lblDescuento);
            this.mrcTotal.Controls.Add(this.lblSub);
            this.mrcTotal.Location = new System.Drawing.Point(316, 372);
            this.mrcTotal.Name = "mrcTotal";
            this.mrcTotal.Size = new System.Drawing.Size(283, 102);
            this.mrcTotal.TabIndex = 19;
            this.mrcTotal.TabStop = false;
            // 
            // lbltotalTot
            // 
            this.lbltotalTot.AutoSize = true;
            this.lbltotalTot.Location = new System.Drawing.Point(206, 72);
            this.lbltotalTot.Name = "lbltotalTot";
            this.lbltotalTot.Size = new System.Drawing.Size(37, 13);
            this.lbltotalTot.TabIndex = 6;
            this.lbltotalTot.Text = "$$$$$";
            // 
            // lblDescuentoTot
            // 
            this.lblDescuentoTot.AutoSize = true;
            this.lblDescuentoTot.Location = new System.Drawing.Point(206, 45);
            this.lblDescuentoTot.Name = "lblDescuentoTot";
            this.lblDescuentoTot.Size = new System.Drawing.Size(37, 13);
            this.lblDescuentoTot.TabIndex = 5;
            this.lblDescuentoTot.Text = "$$$$$";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(206, 20);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(37, 13);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "$$$$$";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 72);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            // 
            // lstDescuento
            // 
            this.lstDescuento.FormattingEnabled = true;
            this.lstDescuento.Items.AddRange(new object[] {
            "Sin descuento",
            "Con descuento"});
            this.lstDescuento.Location = new System.Drawing.Point(90, 41);
            this.lstDescuento.Name = "lstDescuento";
            this.lstDescuento.Size = new System.Drawing.Size(77, 21);
            this.lstDescuento.TabIndex = 2;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(22, 44);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Descuento";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(22, 22);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(46, 13);
            this.lblSub.TabIndex = 0;
            this.lblSub.Text = "Subtotal";
            // 
            // mrcPago
            // 
            this.mrcPago.Controls.Add(this.radioButton3);
            this.mrcPago.Controls.Add(this.radioButton2);
            this.mrcPago.Controls.Add(this.radioButton1);
            this.mrcPago.Location = new System.Drawing.Point(38, 372);
            this.mrcPago.Name = "mrcPago";
            this.mrcPago.Size = new System.Drawing.Size(252, 102);
            this.mrcPago.TabIndex = 17;
            this.mrcPago.TabStop = false;
            this.mrcPago.Text = "Formas de pago";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Transferencia";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 45);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tarjeta";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Efectivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.White;
            this.btnMenos.ForeColor = System.Drawing.Color.Red;
            this.btnMenos.Location = new System.Drawing.Point(559, 340);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(30, 23);
            this.btnMenos.TabIndex = 16;
            this.btnMenos.Text = "➖";
            this.btnMenos.UseVisualStyleBackColor = false;
            // 
            // btnMas
            // 
            this.btnMas.BackColor = System.Drawing.Color.White;
            this.btnMas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnMas.Location = new System.Drawing.Point(522, 322);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(30, 23);
            this.btnMas.TabIndex = 15;
            this.btnMas.Text = "➕";
            this.btnMas.UseVisualStyleBackColor = false;
            // 
            // mrcArticulo
            // 
            this.mrcArticulo.Controls.Add(this.numericUpDown1);
            this.mrcArticulo.Controls.Add(this.lblTipoUn);
            this.mrcArticulo.Controls.Add(this.lblEleccion);
            this.mrcArticulo.Controls.Add(this.txtNombre);
            this.mrcArticulo.Controls.Add(this.btnAgregar);
            this.mrcArticulo.Location = new System.Drawing.Point(38, 36);
            this.mrcArticulo.Name = "mrcArticulo";
            this.mrcArticulo.Size = new System.Drawing.Size(561, 100);
            this.mrcArticulo.TabIndex = 13;
            this.mrcArticulo.TabStop = false;
            this.mrcArticulo.Text = "Ingrese un artículo";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(179, 64);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(117, 20);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTipoUn
            // 
            this.lblTipoUn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblTipoUn.FormattingEnabled = true;
            this.lblTipoUn.Items.AddRange(new object[] {
            "Unidades",
            "Gramos"});
            this.lblTipoUn.Location = new System.Drawing.Point(28, 64);
            this.lblTipoUn.Name = "lblTipoUn";
            this.lblTipoUn.Size = new System.Drawing.Size(124, 21);
            this.lblTipoUn.TabIndex = 2;
            // 
            // lblEleccion
            // 
            this.lblEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblEleccion.FormattingEnabled = true;
            this.lblEleccion.Items.AddRange(new object[] {
            "Nombre + Código",
            "Nombre",
            "Código"});
            this.lblEleccion.Location = new System.Drawing.Point(28, 31);
            this.lblEleccion.Name = "lblEleccion";
            this.lblEleccion.Size = new System.Drawing.Size(124, 21);
            this.lblEleccion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(179, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(117, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(374, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(177, 33);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // mrcDetalles
            // 
            this.mrcDetalles.Controls.Add(this.dgvDetalle);
            this.mrcDetalles.Controls.Add(this.btnEliminar);
            this.mrcDetalles.Location = new System.Drawing.Point(38, 143);
            this.mrcDetalles.Name = "mrcDetalles";
            this.mrcDetalles.Size = new System.Drawing.Size(561, 213);
            this.mrcDetalles.TabIndex = 18;
            this.mrcDetalles.TabStop = false;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Codigo,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDetalle.Location = new System.Drawing.Point(17, 23);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.Size = new System.Drawing.Size(534, 150);
            this.dgvDetalle.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 35F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Detalle";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 30F;
            this.Column1.HeaderText = "Cant.";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 30F;
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 30F;
            this.Column3.HeaderText = "Subtotal";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(413, 179);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar❌";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mrcTotal);
            this.Controls.Add(this.mrcPago);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.mrcArticulo);
            this.Controls.Add(this.mrcDetalles);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            this.mrcTotal.ResumeLayout(false);
            this.mrcTotal.PerformLayout();
            this.mrcPago.ResumeLayout(false);
            this.mrcPago.PerformLayout();
            this.mrcArticulo.ResumeLayout(false);
            this.mrcArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.mrcDetalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox mrcTotal;
        private System.Windows.Forms.Label lbltotalTot;
        private System.Windows.Forms.Label lblDescuentoTot;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox lstDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.GroupBox mrcPago;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.GroupBox mrcArticulo;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox lblTipoUn;
        private System.Windows.Forms.ComboBox lblEleccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox mrcDetalles;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnEliminar;
    }
}