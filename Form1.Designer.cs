namespace segundaDBFranco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            label3 = new Label();
            btnVer = new Button();
            btnSiguinete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 136);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 179);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(144, 136);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(122, 23);
            txtUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(144, 179);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(122, 23);
            txtClave.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(154, 33);
            label3.Name = "label3";
            label3.Size = new Size(73, 28);
            label3.TabIndex = 3;
            label3.Text = "Loggin";
            // 
            // btnVer
            // 
            btnVer.Location = new Point(287, 182);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(29, 23);
            btnVer.TabIndex = 4;
            btnVer.Text = "button1";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnSiguinete
            // 
            btnSiguinete.Location = new Point(144, 268);
            btnSiguinete.Name = "btnSiguinete";
            btnSiguinete.Size = new Size(93, 28);
            btnSiguinete.TabIndex = 5;
            btnSiguinete.Text = "Siguiente";
            btnSiguinete.UseVisualStyleBackColor = true;
            btnSiguinete.Click += btnSiguinete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 450);
            Controls.Add(btnSiguinete);
            Controls.Add(btnVer);
            Controls.Add(label3);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Label label3;
        private Button btnVer;
        private Button btnSiguinete;
    }
}
