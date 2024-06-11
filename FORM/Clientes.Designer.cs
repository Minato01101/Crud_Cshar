namespace segundaDBFranco.FORM
{
    partial class Clientes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvClientes = new DataGridView();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTel = new TextBox();
            txtDireccion = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnActualizar = new Button();
            btnGuardar = new Button();
            label5 = new Label();
            txtId = new TextBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            txtIDactualizar = new TextBox();
            label6 = new Label();
            btnUPDATE = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtTel2 = new TextBox();
            txtDireccion2 = new TextBox();
            txtApellido2 = new TextBox();
            txtNombre2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Menu;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.Location = new Point(35, 354);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowTemplate.Height = 25;
            dgvClientes.Size = new Size(706, 215);
            dgvClientes.TabIndex = 0;
            dgvClientes.CellContentClick += dgvClientes_CellContentClick;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(165, 23);
            txtNombre.TabIndex = 1;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(104, 91);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(165, 23);
            txtApellido.TabIndex = 2;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(104, 184);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(165, 23);
            txtTel.TabIndex = 4;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(104, 139);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(165, 23);
            txtDireccion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 192);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 8;
            label3.Text = "Tel";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 142);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Direccion";
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(666, 325);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(317, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 9);
            label5.Name = "label5";
            label5.Size = new Size(23, 15);
            label5.TabIndex = 13;
            label5.Text = "Id: ";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 12);
            txtId.Name = "txtId";
            txtId.Size = new Size(165, 23);
            txtId.TabIndex = 14;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(txtIDactualizar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnUPDATE);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtTel2);
            groupBox1.Controls.Add(txtDireccion2);
            groupBox1.Controls.Add(txtApellido2);
            groupBox1.Controls.Add(txtNombre2);
            groupBox1.Location = new Point(31, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(732, 583);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            groupBox1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(377, 313);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtIDactualizar
            // 
            txtIDactualizar.Enabled = false;
            txtIDactualizar.Location = new Point(287, 82);
            txtIDactualizar.Name = "txtIDactualizar";
            txtIDactualizar.Size = new Size(165, 23);
            txtIDactualizar.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(244, 79);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 24;
            label6.Text = "Id: ";
            // 
            // btnUPDATE
            // 
            btnUPDATE.Location = new Point(246, 313);
            btnUPDATE.Name = "btnUPDATE";
            btnUPDATE.Size = new Size(75, 23);
            btnUPDATE.TabIndex = 23;
            btnUPDATE.Text = "Actualizar";
            btnUPDATE.UseVisualStyleBackColor = true;
            btnUPDATE.Click += btnUPDATE_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(246, 262);
            label7.Name = "label7";
            label7.Size = new Size(21, 15);
            label7.TabIndex = 22;
            label7.Text = "Tel";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(210, 212);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 21;
            label8.Text = "Direccion";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(216, 164);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 20;
            label9.Text = "Apellido";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(216, 114);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 19;
            label10.Text = "Nombre";
            // 
            // txtTel2
            // 
            txtTel2.Location = new Point(287, 254);
            txtTel2.Name = "txtTel2";
            txtTel2.Size = new Size(165, 23);
            txtTel2.TabIndex = 18;
            // 
            // txtDireccion2
            // 
            txtDireccion2.Location = new Point(287, 209);
            txtDireccion2.Name = "txtDireccion2";
            txtDireccion2.Size = new Size(165, 23);
            txtDireccion2.TabIndex = 17;
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(287, 161);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(165, 23);
            txtApellido2.TabIndex = 16;
            // 
            // txtNombre2
            // 
            txtNombre2.Location = new Point(287, 114);
            txtNombre2.Name = "txtNombre2";
            txtNombre2.Size = new Size(165, 23);
            txtNombre2.TabIndex = 15;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(groupBox1);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(btnActualizar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTel);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(dgvClientes);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            Shown += Clientes_Shown;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTel;
        private TextBox txtDireccion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnActualizar;
        private Button btnGuardar;
        private Label label5;
        private TextBox txtId;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox txtIDactualizar;
        private Label label6;
        private Button btnUPDATE;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtTel2;
        private TextBox txtDireccion2;
        private TextBox txtApellido2;
        private TextBox txtNombre2;
    }
}