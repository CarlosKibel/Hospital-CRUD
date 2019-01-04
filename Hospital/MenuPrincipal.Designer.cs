namespace Hospital
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFacturaLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearFacturaFarmaciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasFarmaciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFacturasToolStripMenuItem,
            this.verFacturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearFacturasToolStripMenuItem
            // 
            this.crearFacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearFacturaLaboratorioToolStripMenuItem,
            this.crearFacturaFarmaciaToolStripMenuItem});
            this.crearFacturasToolStripMenuItem.Name = "crearFacturasToolStripMenuItem";
            this.crearFacturasToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.crearFacturasToolStripMenuItem.Text = "Crear Facturas";
            // 
            // crearFacturaLaboratorioToolStripMenuItem
            // 
            this.crearFacturaLaboratorioToolStripMenuItem.Name = "crearFacturaLaboratorioToolStripMenuItem";
            this.crearFacturaLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.crearFacturaLaboratorioToolStripMenuItem.Text = "Crear Factura Laboratorio";
            this.crearFacturaLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.crearFacturaLaboratorioToolStripMenuItem_Click);
            // 
            // crearFacturaFarmaciaToolStripMenuItem
            // 
            this.crearFacturaFarmaciaToolStripMenuItem.Name = "crearFacturaFarmaciaToolStripMenuItem";
            this.crearFacturaFarmaciaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.crearFacturaFarmaciaToolStripMenuItem.Text = "Crear Factura Farmacia";
            this.crearFacturaFarmaciaToolStripMenuItem.Click += new System.EventHandler(this.crearFacturaFarmaciaToolStripMenuItem_Click);
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verFacturasLaboratorioToolStripMenuItem,
            this.verFacturasFarmaciaToolStripMenuItem});
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.verFacturasToolStripMenuItem.Text = "Ver Facturas";
            // 
            // verFacturasLaboratorioToolStripMenuItem
            // 
            this.verFacturasLaboratorioToolStripMenuItem.Name = "verFacturasLaboratorioToolStripMenuItem";
            this.verFacturasLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.verFacturasLaboratorioToolStripMenuItem.Text = "Ver Facturas Laboratorio";
            this.verFacturasLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.verFacturasLaboratorioToolStripMenuItem_Click);
            // 
            // verFacturasFarmaciaToolStripMenuItem
            // 
            this.verFacturasFarmaciaToolStripMenuItem.Name = "verFacturasFarmaciaToolStripMenuItem";
            this.verFacturasFarmaciaToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.verFacturasFarmaciaToolStripMenuItem.Text = "Ver Facturas Farmacia";
            this.verFacturasFarmaciaToolStripMenuItem.Click += new System.EventHandler(this.verFacturasFarmaciaToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(161, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOSPITAL MORILLO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFacturaLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearFacturaFarmaciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verFacturasFarmaciaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}