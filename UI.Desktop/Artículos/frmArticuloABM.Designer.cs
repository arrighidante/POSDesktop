namespace UI.Desktop.Artículos
{
    partial class frmArticuloABM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticuloABM));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbDatosArticulo = new System.Windows.Forms.GroupBox();
            this.cbxProveedor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblDescri = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblNoHayProveedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbDatosArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gbDatosArticulo
            // 
            this.gbDatosArticulo.Controls.Add(this.lblNoHayProveedores);
            this.gbDatosArticulo.Controls.Add(this.cbxProveedor);
            this.gbDatosArticulo.Controls.Add(this.label3);
            this.gbDatosArticulo.Controls.Add(this.btnGuardar);
            this.gbDatosArticulo.Controls.Add(this.btnModificarStock);
            this.gbDatosArticulo.Controls.Add(this.btnCancelar);
            this.gbDatosArticulo.Controls.Add(this.label2);
            this.gbDatosArticulo.Controls.Add(this.label1);
            this.gbDatosArticulo.Controls.Add(this.lblStock);
            this.gbDatosArticulo.Controls.Add(this.lblDescri);
            this.gbDatosArticulo.Controls.Add(this.lblCodigo);
            this.gbDatosArticulo.Controls.Add(this.txtPrecio);
            this.gbDatosArticulo.Controls.Add(this.txtStockMin);
            this.gbDatosArticulo.Controls.Add(this.txtStock);
            this.gbDatosArticulo.Controls.Add(this.txtCodigo);
            this.gbDatosArticulo.Controls.Add(this.txtDescripcion);
            this.gbDatosArticulo.Controls.Add(this.pictureBox1);
            this.gbDatosArticulo.Location = new System.Drawing.Point(12, 12);
            this.gbDatosArticulo.Name = "gbDatosArticulo";
            this.gbDatosArticulo.Size = new System.Drawing.Size(448, 285);
            this.gbDatosArticulo.TabIndex = 1;
            this.gbDatosArticulo.TabStop = false;
            this.gbDatosArticulo.Text = "groupBox1";
            // 
            // cbxProveedor
            // 
            this.cbxProveedor.FormattingEnabled = true;
            this.cbxProveedor.Location = new System.Drawing.Point(238, 51);
            this.cbxProveedor.Name = "cbxProveedor";
            this.cbxProveedor.Size = new System.Drawing.Size(121, 21);
            this.cbxProveedor.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Proveedor";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(98, 232);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 37);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarStock.Image")));
            this.btnModificarStock.Location = new System.Drawing.Point(301, 156);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(31, 28);
            this.btnModificarStock.TabIndex = 43;
            this.btnModificarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarStock.UseVisualStyleBackColor = true;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(228, 232);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Precio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stock Mínimo";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(197, 164);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(35, 13);
            this.lblStock.TabIndex = 39;
            this.lblStock.Text = "Stock";
            // 
            // lblDescri
            // 
            this.lblDescri.AutoSize = true;
            this.lblDescri.Location = new System.Drawing.Point(169, 81);
            this.lblDescri.Name = "lblDescri";
            this.lblDescri.Size = new System.Drawing.Size(63, 13);
            this.lblDescri.TabIndex = 38;
            this.lblDescri.Text = "Descripción";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(192, 29);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 37;
            this.lblCodigo.Text = "Código";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(238, 135);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(57, 20);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            this.txtPrecio.Leave += new System.EventHandler(this.txtPrecio_Leave);
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(238, 187);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(57, 20);
            this.txtStockMin.TabIndex = 4;
            this.txtStockMin.Text = "1";
            this.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMin_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(238, 161);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(57, 20);
            this.txtStock.TabIndex = 3;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(238, 26);
            this.txtCodigo.MaxLength = 22;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(238, 78);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 51);
            this.txtDescripcion.TabIndex = 1;
            // 
            // lblNoHayProveedores
            // 
            this.lblNoHayProveedores.AutoSize = true;
            this.lblNoHayProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoHayProveedores.Location = new System.Drawing.Point(238, 55);
            this.lblNoHayProveedores.Name = "lblNoHayProveedores";
            this.lblNoHayProveedores.Size = new System.Drawing.Size(181, 13);
            this.lblNoHayProveedores.TabIndex = 47;
            this.lblNoHayProveedores.Text = "No hay proveedores cargados.";
            this.lblNoHayProveedores.Visible = false;
            // 
            // frmArticuloABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 309);
            this.Controls.Add(this.gbDatosArticulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticuloABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmArticuloABM";
            this.Load += new System.EventHandler(this.frmArticuloABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbDatosArticulo.ResumeLayout(false);
            this.gbDatosArticulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbDatosArticulo;
        public System.Windows.Forms.TextBox txtPrecio;
        public System.Windows.Forms.TextBox txtStockMin;
        public System.Windows.Forms.TextBox txtStock;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnCancelar;
        protected System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProveedor;
        private System.Windows.Forms.Label lblNoHayProveedores;
    }
}