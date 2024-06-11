namespace segundaDBFranco.FORM
{
    partial class Productos
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
            dgvProducto = new DataGridView();
            btnCargar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            txtPrecio = new TextBox();
            btnAgregar = new Button();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnAclualizar = new Button();
            txtPrecio2 = new TextBox();
            txtCantidad2 = new TextBox();
            txtNombre2 = new TextBox();
            txtId2 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducto
            // 
            dgvProducto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProducto.BorderStyle = BorderStyle.Fixed3D;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Location = new Point(38, 356);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.RowTemplate.Height = 25;
            dgvProducto.Size = new Size(661, 202);
            dgvProducto.TabIndex = 0;
            dgvProducto.CellContentClick += dgvProducto_CellContentClick;
            // 
            // btnCargar
            // 
            btnCargar.Location = new Point(594, 306);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(105, 44);
            btnCargar.TabIndex = 1;
            btnCargar.Text = "Cargar";
            btnCargar.UseVisualStyleBackColor = true;
            btnCargar.Click += btnCargar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 25);
            label1.Name = "label1";
            label1.Size = new Size(345, 37);
            label1.TabIndex = 2;
            label1.Text = "PRODUCTOS DE LA TIENDA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 133);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 175);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 4;
            label3.Text = "Cantidad: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 225);
            label4.Name = "label4";
            label4.Size = new Size(46, 15);
            label4.TabIndex = 5;
            label4.Text = "Precio: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(180, 101);
            label5.Name = "label5";
            label5.Size = new Size(24, 15);
            label5.TabIndex = 6;
            label5.Text = "ID: ";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(214, 98);
            txtId.Name = "txtId";
            txtId.Size = new Size(169, 23);
            txtId.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(214, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(169, 23);
            txtNombre.TabIndex = 8;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(214, 172);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(169, 23);
            txtCantidad.TabIndex = 9;
            txtCantidad.KeyPress += Productos_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(214, 217);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(169, 23);
            txtPrecio.TabIndex = 10;
            txtPrecio.KeyPress += Productos_KeyPress;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(440, 98);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(105, 44);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnAclualizar);
            panel1.Controls.Add(txtPrecio2);
            panel1.Controls.Add(txtCantidad2);
            panel1.Controls.Add(txtNombre2);
            panel1.Controls.Add(txtId2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(38, 81);
            panel1.Name = "panel1";
            panel1.Size = new Size(670, 513);
            panel1.TabIndex = 12;
            panel1.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(358, 255);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(105, 44);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAclualizar
            // 
            btnAclualizar.Location = new Point(231, 255);
            btnAclualizar.Name = "btnAclualizar";
            btnAclualizar.Size = new Size(105, 44);
            btnAclualizar.TabIndex = 20;
            btnAclualizar.Text = "Actualizar";
            btnAclualizar.UseVisualStyleBackColor = true;
            btnAclualizar.Click += btnAclualizar_Click;
            // 
            // txtPrecio2
            // 
            txtPrecio2.Location = new Point(273, 197);
            txtPrecio2.Name = "txtPrecio2";
            txtPrecio2.Size = new Size(169, 23);
            txtPrecio2.TabIndex = 19;
            // 
            // txtCantidad2
            // 
            txtCantidad2.Location = new Point(273, 152);
            txtCantidad2.Name = "txtCantidad2";
            txtCantidad2.Size = new Size(169, 23);
            txtCantidad2.TabIndex = 18;
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(273, 113);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(169, 23);
            txtNombre2.TabIndex = 17;
            // 
            // txtId2
            // 
            txtId2.Enabled = false;
            txtId2.Location = new Point(273, 78);
            txtId2.Name = "txtId2";
            txtId2.Size = new Size(169, 23);
            txtId2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(239, 81);
            label6.Name = "label6";
            label6.Size = new Size(24, 15);
            label6.TabIndex = 15;
            label6.Text = "ID: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 205);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 14;
            label7.Text = "Precio: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(202, 155);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 13;
            label8.Text = "Cantidad: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(206, 113);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 12;
            label9.Text = "Nombre: ";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(panel1);
            Controls.Add(btnAgregar);
            Controls.Add(txtPrecio);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Controls.Add(dgvProducto);
            Name = "Productos";
            Text = "ShowProducto";
            KeyPress += Productos_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducto;
        private Button btnCargar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private TextBox txtPrecio;
        private Button btnAgregar;
        private Panel panel1;
        private Button btnCancelar;
        private Button btnAclualizar;
        private TextBox txtPrecio2;
        private TextBox txtCantidad2;
        private TextBox txtNombre2;
        private TextBox txtId2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}