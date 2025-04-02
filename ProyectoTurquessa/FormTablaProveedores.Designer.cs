namespace ProyectoTurquessa
{
    partial class FormTablaProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablaProveedores));
            this.label1 = new System.Windows.Forms.Label();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnRegistrarProveedor = new System.Windows.Forms.Button();
            this.ProveedoresGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(322, 33);
            this.label1.TabIndex = 68;
            this.label1.Text = "Nuestros proveedores";
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolverInicio.BackColor = System.Drawing.Color.White;
            this.btnVolverInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnVolverInicio.FlatAppearance.BorderSize = 0;
            this.btnVolverInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolverInicio.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolverInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnVolverInicio.Location = new System.Drawing.Point(314, 151);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(149, 32);
            this.btnVolverInicio.TabIndex = 67;
            this.btnVolverInicio.Text = "Volver al inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // btnRegistrarProveedor
            // 
            this.btnRegistrarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnRegistrarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistrarProveedor.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProveedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProveedor.Location = new System.Drawing.Point(480, 151);
            this.btnRegistrarProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            this.btnRegistrarProveedor.Size = new System.Drawing.Size(149, 32);
            this.btnRegistrarProveedor.TabIndex = 66;
            this.btnRegistrarProveedor.Text = "Registrar proveedor";
            this.btnRegistrarProveedor.UseVisualStyleBackColor = false;
            this.btnRegistrarProveedor.Click += new System.EventHandler(this.btnRegistrarProveedor_Click);
            // 
            // ProveedoresGridView
            // 
            this.ProveedoresGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProveedoresGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProveedoresGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProveedoresGridView.Location = new System.Drawing.Point(17, 188);
            this.ProveedoresGridView.Name = "ProveedoresGridView";
            this.ProveedoresGridView.RowHeadersWidth = 82;
            this.ProveedoresGridView.Size = new System.Drawing.Size(760, 342);
            this.ProveedoresGridView.TabIndex = 65;
            this.ProveedoresGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-370, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1549, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(644, 151);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 32);
            this.button1.TabIndex = 70;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormTablaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 555);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnRegistrarProveedor);
            this.Controls.Add(this.ProveedoresGridView);
            this.Name = "FormTablaProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTablaProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.ProveedoresGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnRegistrarProveedor;
        private System.Windows.Forms.DataGridView ProveedoresGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}