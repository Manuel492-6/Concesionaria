namespace Concesionaria
{
    partial class Interfaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Interfaz));
            label1 = new Label();
            btnSalir = new BibliotecaDeClaseWindowsForms.button();
            btnEntrar = new BibliotecaDeClaseWindowsForms.button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Kristen ITC", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(754, 131);
            label1.TabIndex = 3;
            label1.Text = "Concecionaria";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.White;
            btnSalir.BackgroundColor = Color.White;
            btnSalir.BorderColor = Color.Black;
            btnSalir.BorderRadius = 35;
            btnSalir.BorderSize = 0;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.ForeColor = Color.Black;
            btnSalir.Location = new Point(407, 531);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(287, 116);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.TextColor = Color.Black;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.BackgroundColor = Color.White;
            btnEntrar.BorderColor = Color.Black;
            btnEntrar.BorderRadius = 35;
            btnEntrar.BorderSize = 0;
            btnEntrar.FlatAppearance.BorderSize = 0;
            btnEntrar.FlatStyle = FlatStyle.Flat;
            btnEntrar.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEntrar.ForeColor = Color.Black;
            btnEntrar.Location = new Point(407, 386);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(287, 118);
            btnEntrar.TabIndex = 6;
            btnEntrar.Text = "Entrar";
            btnEntrar.TextColor = Color.Black;
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // Interfaz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 689);
            Controls.Add(btnEntrar);
            Controls.Add(btnSalir);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Interfaz";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interfaz";
            FormClosing += Interfaz_FormClosing;
            Load += Interfaz_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private BibliotecaDeClaseWindowsForms.button btnSalir;
        private BibliotecaDeClaseWindowsForms.button btnEntrar;
    }
}
