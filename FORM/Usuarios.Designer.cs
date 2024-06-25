namespace segundaDBFranco.FORM
{
    partial class Usuarios
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
            dgvUsuarios = new DataGridView();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnActualizar = new Button();
            panel1 = new Panel();
            btnCancelar = new Button();
            btnActualizar2 = new Button();
            txtClave2 = new TextBox();
            txtUsuario2 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtID2 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(67, 417);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.Size = new Size(648, 232);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(389, 158);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 36);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 158);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 214);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(256, 158);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 4;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(256, 214);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(100, 23);
            txtClave.TabIndex = 5;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(621, 375);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 36);
            btnActualizar.TabIndex = 6;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtID2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(btnActualizar2);
            panel1.Controls.Add(txtClave2);
            panel1.Controls.Add(txtUsuario2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(67, 100);
            panel1.Name = "panel1";
            panel1.Size = new Size(648, 311);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(338, 195);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar2
            // 
            btnActualizar2.Location = new Point(176, 195);
            btnActualizar2.Name = "btnActualizar2";
            btnActualizar2.Size = new Size(78, 23);
            btnActualizar2.TabIndex = 4;
            btnActualizar2.Text = "Actualizar";
            btnActualizar2.UseVisualStyleBackColor = true;
            btnActualizar2.Click += btnActualizar2_Click;
            // 
            // txtClave2
            // 
            txtClave2.Location = new Point(279, 124);
            txtClave2.Name = "txtClave2";
            txtClave2.Size = new Size(121, 23);
            txtClave2.TabIndex = 3;
            // 
            // txtUsuario2
            // 
            txtUsuario2.Location = new Point(279, 78);
            txtUsuario2.Name = "txtUsuario2";
            txtUsuario2.Size = new Size(121, 23);
            txtUsuario2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(179, 124);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 1;
            label4.Text = "Constraseña:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 81);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 0;
            label3.Text = "Usuario:";
            // 
            // txtID2
            // 
            txtID2.Enabled = false;
            txtID2.Location = new Point(279, 47);
            txtID2.Name = "txtID2";
            txtID2.Size = new Size(121, 23);
            txtID2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 50);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 6;
            label5.Text = "IdUsurio:";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(panel1);
            Controls.Add(btnActualizar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dgvUsuarios);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnActualizar;
        private Panel panel1;
        private Label label3;
        private TextBox txtClave2;
        private TextBox txtUsuario2;
        private Label label4;
        private Button btnCancelar;
        private Button btnActualizar2;
        private TextBox txtID2;
        private Label label5;
    }
}