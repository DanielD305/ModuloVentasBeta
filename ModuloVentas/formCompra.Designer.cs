namespace ModuloVentas
{
    partial class formCompra
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnComprar = new System.Windows.Forms.Button();
            this.CantidadCompra = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCompra = new System.Windows.Forms.ComboBox();
            this.dgvInventarioCompras = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.cbProveedor);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnComprar);
            this.groupBox2.Controls.Add(this.CantidadCompra);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbCompra);
            this.groupBox2.Location = new System.Drawing.Point(33, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1078, 172);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // cbProveedor
            // 
            this.cbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(396, 80);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(151, 28);
            this.cbProveedor.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(396, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Proveedor";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(792, 61);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(115, 48);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // CantidadCompra
            // 
            this.CantidadCompra.Location = new System.Drawing.Point(219, 81);
            this.CantidadCompra.Name = "CantidadCompra";
            this.CantidadCompra.Size = new System.Drawing.Size(128, 27);
            this.CantidadCompra.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(219, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 31);
            this.label8.TabIndex = 3;
            this.label8.Text = "Cantidad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(29, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 31);
            this.label9.TabIndex = 1;
            this.label9.Text = "Articulo";
            // 
            // cbCompra
            // 
            this.cbCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCompra.FormattingEnabled = true;
            this.cbCompra.Location = new System.Drawing.Point(29, 81);
            this.cbCompra.Name = "cbCompra";
            this.cbCompra.Size = new System.Drawing.Size(151, 28);
            this.cbCompra.TabIndex = 0;
            // 
            // dgvInventarioCompras
            // 
            this.dgvInventarioCompras.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvInventarioCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventarioCompras.Location = new System.Drawing.Point(33, 282);
            this.dgvInventarioCompras.Name = "dgvInventarioCompras";
            this.dgvInventarioCompras.RowHeadersWidth = 51;
            this.dgvInventarioCompras.RowTemplate.Height = 29;
            this.dgvInventarioCompras.Size = new System.Drawing.Size(1078, 360);
            this.dgvInventarioCompras.TabIndex = 11;
            // 
            // formCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInventarioCompras);
            this.Controls.Add(this.groupBox2);
            this.Name = "formCompra";
            this.Size = new System.Drawing.Size(1134, 702);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventarioCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private Button btnComprar;
        private NumericUpDown CantidadCompra;
        private Label label8;
        private Label label9;
        private ComboBox cbCompra;
        private DataGridView dgvInventarioCompras;
        private ComboBox cbProveedor;
        private Label label1;
    }
}
