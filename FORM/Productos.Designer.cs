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
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
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
            label2.Location = new Point(116, 135);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 661);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCargar);
            Controls.Add(dgvProducto);
            Name = "Productos";
            Text = "ShowProducto";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProducto;
        private Button btnCargar;
        private Label label1;
        private Label label2;
    }
}