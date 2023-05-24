namespace ModuloVentas
{
    partial class ModuloVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModuloVenta));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pcLogo = new System.Windows.Forms.PictureBox();
            this.formVenta1 = new ModuloVentas.formVenta();
            this.formCompra1 = new ModuloVentas.formCompra();
            this.formInventario1 = new ModuloVentas.formInventario();
            this.login1 = new ModuloVentas.Login();
            this.menuPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.DarkCyan;
            this.menuPanel.Controls.Add(this.btnVenta);
            this.menuPanel.Controls.Add(this.btnCompra);
            this.menuPanel.Controls.Add(this.btnInventario);
            this.menuPanel.Controls.Add(this.label1);
            this.menuPanel.Controls.Add(this.panelLogo);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(259, 729);
            this.menuPanel.TabIndex = 0;
            // 
            // btnVenta
            // 
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVenta.ForeColor = System.Drawing.Color.White;
            this.btnVenta.Location = new System.Drawing.Point(0, 408);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(259, 44);
            this.btnVenta.TabIndex = 2;
            this.btnVenta.Text = "Venta";
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnCompra
            // 
            this.btnCompra.FlatAppearance.BorderSize = 0;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCompra.ForeColor = System.Drawing.Color.White;
            this.btnCompra.Location = new System.Drawing.Point(3, 316);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(253, 44);
            this.btnCompra.TabIndex = 1;
            this.btnCompra.Text = "Compra";
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(0, 234);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(259, 44);
            this.btnInventario.TabIndex = 0;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "____________________________________________";
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pcLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(259, 176);
            this.panelLogo.TabIndex = 0;
            // 
            // pcLogo
            // 
            this.pcLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.pcLogo.Image = global::ModuloVentas.Properties.Resources.VTR_BIG;
            this.pcLogo.Location = new System.Drawing.Point(3, 0);
            this.pcLogo.Name = "pcLogo";
            this.pcLogo.Size = new System.Drawing.Size(256, 173);
            this.pcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcLogo.TabIndex = 0;
            this.pcLogo.TabStop = false;
            // 
            // formVenta1
            // 
            this.formVenta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formVenta1.Location = new System.Drawing.Point(259, 0);
            this.formVenta1.Name = "formVenta1";
            this.formVenta1.Size = new System.Drawing.Size(1241, 729);
            this.formVenta1.TabIndex = 1;
            // 
            // formCompra1
            // 
            this.formCompra1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formCompra1.Location = new System.Drawing.Point(259, 0);
            this.formCompra1.Name = "formCompra1";
            this.formCompra1.Size = new System.Drawing.Size(1241, 729);
            this.formCompra1.TabIndex = 2;
            // 
            // formInventario1
            // 
            this.formInventario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formInventario1.Location = new System.Drawing.Point(259, 0);
            this.formInventario1.Name = "formInventario1";
            this.formInventario1.Size = new System.Drawing.Size(1241, 729);
            this.formInventario1.TabIndex = 3;
            // 
            // login1
            // 
            this.login1.BackColor = System.Drawing.Color.Chocolate;
            this.login1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login1.BackgroundImage")));
            this.login1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.login1.ForeColor = System.Drawing.Color.Black;
            this.login1.Location = new System.Drawing.Point(259, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1241, 729);
            this.login1.TabIndex = 4;
            this.login1.Load += new System.EventHandler(this.login1_Load);
            // 
            // ModuloVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1500, 729);
            this.Controls.Add(this.login1);
            this.Controls.Add(this.formInventario1);
            this.Controls.Add(this.formCompra1);
            this.Controls.Add(this.formVenta1);
            this.Controls.Add(this.menuPanel);
            this.Name = "ModuloVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modulo de Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel menuPanel;
        private Label label1;
        private Panel panelLogo;
        private PictureBox pcLogo;
        private Button btnCompra;
        private Button btnInventario;
        private Button btnVenta;
        private formVenta formVenta1;
        private formCompra formCompra1;
        private formInventario formInventario1;
        private Login login1;
    }
}