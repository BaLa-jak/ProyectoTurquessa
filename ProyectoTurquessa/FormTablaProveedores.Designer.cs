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
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarProveedor = new System.Windows.Forms.Button();
            this.btnMostrarProveedor = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(38, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(615, 67);
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
            this.btnVolverInicio.Location = new System.Drawing.Point(1288, 206);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(266, 62);
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
            this.btnRegistrarProveedor.Location = new System.Drawing.Point(960, 290);
            this.btnRegistrarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            this.btnRegistrarProveedor.Size = new System.Drawing.Size(298, 62);
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
            this.ProveedoresGridView.Location = new System.Drawing.Point(34, 384);
            this.ProveedoresGridView.Margin = new System.Windows.Forms.Padding(6);
            this.ProveedoresGridView.Name = "ProveedoresGridView";
            this.ProveedoresGridView.RowHeadersWidth = 82;
            this.ProveedoresGridView.Size = new System.Drawing.Size(1520, 658);
            this.ProveedoresGridView.TabIndex = 65;
            this.ProveedoresGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-740, -13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(3098, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(1288, 290);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(266, 62);
            this.btnEditar.TabIndex = 70;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrarProveedor
            // 
            this.btnBorrarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnBorrarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBorrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarProveedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBorrarProveedor.Location = new System.Drawing.Point(625, 290);
            this.btnBorrarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrarProveedor.Name = "btnBorrarProveedor";
            this.btnBorrarProveedor.Size = new System.Drawing.Size(298, 62);
            this.btnBorrarProveedor.TabIndex = 71;
            this.btnBorrarProveedor.Text = "Borrar Proveedor";
            this.btnBorrarProveedor.UseVisualStyleBackColor = false;
            this.btnBorrarProveedor.Click += new System.EventHandler(this.btnBorrarProveedor_Click);
            // 
            // btnMostrarProveedor
            // 
            this.btnMostrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnMostrarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMostrarProveedor.FlatAppearance.BorderSize = 0;
            this.btnMostrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarProveedor.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnMostrarProveedor.Location = new System.Drawing.Point(34, 290);
            this.btnMostrarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnMostrarProveedor.Name = "btnMostrarProveedor";
            this.btnMostrarProveedor.Size = new System.Drawing.Size(266, 62);
            this.btnMostrarProveedor.TabIndex = 72;
            this.btnMostrarProveedor.Text = "Mostrar";
            this.btnMostrarProveedor.UseVisualStyleBackColor = false;
            this.btnMostrarProveedor.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormTablaProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1602, 1067);
            this.Controls.Add(this.btnMostrarProveedor);
            this.Controls.Add(this.btnBorrarProveedor);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnRegistrarProveedor);
            this.Controls.Add(this.ProveedoresGridView);
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarProveedor;
        private System.Windows.Forms.Button btnMostrarProveedor;
    }
}