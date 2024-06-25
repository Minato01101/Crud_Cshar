namespace segundaDBFranco.FORM
{
    partial class Home
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
            btnProductos = new Button();
            btn = new Button();
            btnUsuarios = new Button();
            dgvProductos = new DataGridView();
            btnActualizar = new Button();
            dgvCarrito = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            label1 = new Label();
            txtCantidad = new TextBox();
            lblTotal = new Label();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(140, 12);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(91, 26);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btn
            // 
            btn.Location = new Point(26, 12);
            btn.Name = "btn";
            btn.Size = new Size(91, 26);
            btn.TabIndex = 1;
            btn.Text = "Clientes";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(251, 12);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(91, 26);
            btnUsuarios.TabIndex = 2;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(49, 113);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(632, 205);
            dgvProductos.TabIndex = 3;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(590, 81);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(91, 26);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.AllowUserToAddRows = false;
            dgvCarrito.AllowUserToDeleteRows = false;
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cantidad, Precio, SubTotal });
            dgvCarrito.Location = new Point(49, 435);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.ReadOnly = true;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(632, 150);
            dgvCarrito.TabIndex = 5;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(346, 81);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(91, 26);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(163, 84);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 7;
            label1.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(224, 81);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 8;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(525, 603);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total: $";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(687, 435);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 26);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(btnEliminar);
            Controls.Add(lblTotal);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dgvCarrito);
            Controls.Add(btnActualizar);
            Controls.Add(dgvProductos);
            Controls.Add(btnUsuarios);
            Controls.Add(btn);
            Controls.Add(btnProductos);
            Name = "Home";
            Text = " Home";
            Load += Home_Load;
            Shown += Home_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductos;
        private Button btn;
        private Button btnUsuarios;
        private DataGridView dgvProductos;
        private Button btnActualizar;
        private DataGridView dgvCarrito;
        private Button btnAgregar;
        private Label label1;
        private TextBox txtCantidad;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private Label lblTotal;
        private Button btnEliminar;
    }
}