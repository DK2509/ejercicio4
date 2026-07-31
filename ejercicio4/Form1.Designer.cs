namespace ejercicio4
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
            lstLista = new ListBox();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 62);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // lstLista
            // 
            lstLista.FormattingEnabled = true;
            lstLista.Location = new Point(12, 32);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(428, 244);
            lstLista.TabIndex = 1;
            lstLista.SelectedIndexChanged += lstLista_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 146);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 216);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 3;
            label3.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(521, 54);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(251, 23);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(521, 138);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(251, 23);
            txtTelefono.TabIndex = 5;
            txtTelefono.TextChanged += txtTelefono_TextChanged;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(521, 208);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(251, 23);
            txtCorreo.TabIndex = 6;
            txtCorreo.TextChanged += txtCorreo_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(135, 335);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(158, 56);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtCorreo);
            Controls.Add(txtTelefono);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstLista);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstLista;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private Button btnAgregar;
    }
}
