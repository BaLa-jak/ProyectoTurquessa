namespace ProyectoTurquessa
{
    partial class FormMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuPrincipal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSoporte = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.btnAgregarProveedores = new System.Windows.Forms.Button();
            this.btnVerProductos = new System.Windows.Forms.Button();
            this.btnVerProveedores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSoporte);
            this.groupBox1.Controls.Add(this.btnAgregarProductos);
            this.groupBox1.Controls.Add(this.btnAgregarProveedores);
            this.groupBox1.Controls.Add(this.btnVerProductos);
            this.groupBox1.Controls.Add(this.btnVerProveedores);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(-1, -9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(950, 563);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnSoporte
            // 
            this.btnSoporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSoporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(189)))), ((int)(((byte)(212)))));
            this.btnSoporte.FlatAppearance.BorderSize = 0;
            this.btnSoporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoporte.Location = new System.Drawing.Point(418, 446);
            this.btnSoporte.Margin = new System.Windows.Forms.Padding(2);
            this.btnSoporte.Name = "btnSoporte";
            this.btnSoporte.Size = new System.Drawing.Size(122, 25);
            this.btnSoporte.TabIndex = 5;
            this.btnSoporte.Text = "Contactar Soporte";
            this.btnSoporte.UseVisualStyleBackColor = false;
            this.btnSoporte.Click += new System.EventHandler(this.btnSoporte_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProductos.BackgroundImage")));
            this.btnAgregarProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProductos.FlatAppearance.BorderSize = 0;
            this.btnAgregarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProductos.Location = new System.Drawing.Point(538, 226);
            this.btnAgregarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(134, 129);
            this.btnAgregarProductos.TabIndex = 3;
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // btnAgregarProveedores
            // 
            this.btnAgregarProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregarProveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarProveedores.BackgroundImage")));
            this.btnAgregarProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarProveedores.FlatAppearance.BorderSize = 0;
            this.btnAgregarProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedores.Location = new System.Drawing.Point(280, 226);
            this.btnAgregarProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarProveedores.Name = "btnAgregarProveedores";
            this.btnAgregarProveedores.Size = new System.Drawing.Size(134, 129);
            this.btnAgregarProveedores.TabIndex = 1;
            this.btnAgregarProveedores.UseVisualStyleBackColor = true;
            this.btnAgregarProveedores.Click += new System.EventHandler(this.btnAgregarProveedores_Click);
            // 
            // btnVerProductos
            // 
            this.btnVerProductos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(189)))), ((int)(((byte)(212)))));
            this.btnVerProductos.FlatAppearance.BorderSize = 0;
            this.btnVerProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProductos.Location = new System.Drawing.Point(544, 391);
            this.btnVerProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerProductos.Name = "btnVerProductos";
            this.btnVerProductos.Size = new System.Drawing.Size(128, 27);
            this.btnVerProductos.TabIndex = 4;
            this.btnVerProductos.Text = "Ver Productos";
            this.btnVerProductos.UseVisualStyleBackColor = false;
            this.btnVerProductos.Click += new System.EventHandler(this.btnVerProductos_Click);
            // 
            // btnVerProveedores
            // 
            this.btnVerProveedores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(189)))), ((int)(((byte)(212)))));
            this.btnVerProveedores.FlatAppearance.BorderSize = 0;
            this.btnVerProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProveedores.Location = new System.Drawing.Point(280, 391);
            this.btnVerProveedores.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerProveedores.Name = "btnVerProveedores";
            this.btnVerProveedores.Size = new System.Drawing.Size(134, 24);
            this.btnVerProveedores.TabIndex = 2;
            this.btnVerProveedores.Text = "Ver Proveedores";
            this.btnVerProveedores.UseVisualStyleBackColor = false;
            this.btnVerProveedores.Click += new System.EventHandler(this.btnVerProveedores_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(959, 567);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(950, 551);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1950, 1600);
            this.Name = "FormMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuPrincipal";
            this.Load += new System.EventHandler(this.FormMenuPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnAgregarProveedores;
        private System.Windows.Forms.Button btnVerProductos;
        private System.Windows.Forms.Button btnVerProveedores;
        private System.Windows.Forms.Button btnSoporte;
    }
}