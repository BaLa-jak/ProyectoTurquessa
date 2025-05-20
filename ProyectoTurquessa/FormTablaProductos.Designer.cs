namespace ProyectoTurquessa
{
    partial class FormTablaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTablaProductos));
            this.ProductosGridView = new System.Windows.Forms.DataGridView();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductosGridView
            // 
            this.ProductosGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductosGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ProductosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductosGridView.Location = new System.Drawing.Point(16, 232);
            this.ProductosGridView.Name = "ProductosGridView";
            this.ProductosGridView.RowHeadersWidth = 82;
            this.ProductosGridView.Size = new System.Drawing.Size(807, 352);
            this.ProductosGridView.TabIndex = 1;
            this.ProductosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductosGridView_CellContentClick);
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
            this.btnVolverInicio.Location = new System.Drawing.Point(644, 132);
            this.btnVolverInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(149, 32);
            this.btnVolverInicio.TabIndex = 62;
            this.btnVolverInicio.Text = "Volver al inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = false;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnAgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(474, 175);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(149, 32);
            this.btnAgregarProducto.TabIndex = 61;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.label1.Location = new System.Drawing.Point(46, 114);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 63;
            this.label1.Text = "Productos existentes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-345, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1549, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
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
            this.btnEditar.Location = new System.Drawing.Point(644, 175);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 32);
            this.btnEditar.TabIndex = 64;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnBorrarProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBorrarProducto.FlatAppearance.BorderSize = 0;
            this.btnBorrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarProducto.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBorrarProducto.Location = new System.Drawing.Point(300, 175);
            this.btnBorrarProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(149, 32);
            this.btnBorrarProducto.TabIndex = 65;
            this.btnBorrarProducto.Text = "Borrar Producto";
            this.btnBorrarProducto.UseVisualStyleBackColor = false;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.btnMostrarTabla.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMostrarTabla.FlatAppearance.BorderSize = 0;
            this.btnMostrarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTabla.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTabla.ForeColor = System.Drawing.Color.White;
            this.btnMostrarTabla.Location = new System.Drawing.Point(52, 175);
            this.btnMostrarTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(149, 32);
            this.btnMostrarTabla.TabIndex = 66;
            this.btnMostrarTabla.Text = "Mostrar";
            this.btnMostrarTabla.UseVisualStyleBackColor = false;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // FormTablaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(845, 552);
            this.Controls.Add(this.btnMostrarTabla);
            this.Controls.Add(this.btnBorrarProducto);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolverInicio);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.ProductosGridView);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormTablaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTablaProductos";
            this.Load += new System.EventHandler(this.FormTablaProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductosGridView;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnMostrarTabla;
    }
}