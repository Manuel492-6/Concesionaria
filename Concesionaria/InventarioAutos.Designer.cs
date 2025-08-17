namespace Concesionaria
{
    partial class InventarioAutos
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            tabInventario = new TabControl();
            TabAgregarInformacion = new TabPage();
            btnRegresar = new BibliotecaDeClaseWindowsForms.button();
            btnAgregarAuto = new BibliotecaDeClaseWindowsForms.button();
            btnCargarImagen = new BibliotecaDeClaseWindowsForms.button();
            picFoto = new PictureBox();
            cboColorAuto = new ComboBox();
            label5 = new Label();
            txtPrecioAuto = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            cboModelo = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            txtNombreAuto = new TextBox();
            tabListaAutos = new TabPage();
            dgtListaAutos = new DataGridView();
            tabVisualizacion = new TabPage();
            picFotoVisualizacion = new PictureBox();
            richDescripcion = new RichTextBox();
            lblColor = new Label();
            label13 = new Label();
            lblPrecio = new Label();
            label11 = new Label();
            label9 = new Label();
            lblModelo = new Label();
            label7 = new Label();
            lblNombre = new Label();
            label6 = new Label();
            tabInventario.SuspendLayout();
            TabAgregarInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            tabListaAutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgtListaAutos).BeginInit();
            tabVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoVisualizacion).BeginInit();
            SuspendLayout();
            // 
            // tabInventario
            // 
            tabInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabInventario.Controls.Add(TabAgregarInformacion);
            tabInventario.Controls.Add(tabListaAutos);
            tabInventario.Controls.Add(tabVisualizacion);
            tabInventario.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tabInventario.Location = new Point(12, 22);
            tabInventario.Name = "tabInventario";
            tabInventario.SelectedIndex = 0;
            tabInventario.Size = new Size(1747, 868);
            tabInventario.TabIndex = 0;
            // 
            // TabAgregarInformacion
            // 
            TabAgregarInformacion.BackColor = SystemColors.Control;
            TabAgregarInformacion.Controls.Add(btnRegresar);
            TabAgregarInformacion.Controls.Add(btnAgregarAuto);
            TabAgregarInformacion.Controls.Add(btnCargarImagen);
            TabAgregarInformacion.Controls.Add(picFoto);
            TabAgregarInformacion.Controls.Add(cboColorAuto);
            TabAgregarInformacion.Controls.Add(label5);
            TabAgregarInformacion.Controls.Add(txtPrecioAuto);
            TabAgregarInformacion.Controls.Add(label4);
            TabAgregarInformacion.Controls.Add(txtDescripcion);
            TabAgregarInformacion.Controls.Add(label3);
            TabAgregarInformacion.Controls.Add(cboModelo);
            TabAgregarInformacion.Controls.Add(label2);
            TabAgregarInformacion.Controls.Add(label1);
            TabAgregarInformacion.Controls.Add(txtNombreAuto);
            TabAgregarInformacion.Location = new Point(4, 33);
            TabAgregarInformacion.Name = "TabAgregarInformacion";
            TabAgregarInformacion.Padding = new Padding(3);
            TabAgregarInformacion.Size = new Size(1739, 831);
            TabAgregarInformacion.TabIndex = 0;
            TabAgregarInformacion.Text = "Agregar";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.White;
            btnRegresar.BackgroundColor = Color.White;
            btnRegresar.BorderColor = Color.Black;
            btnRegresar.BorderRadius = 35;
            btnRegresar.BorderSize = 0;
            btnRegresar.FlatAppearance.BorderSize = 0;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegresar.ForeColor = Color.Black;
            btnRegresar.Location = new Point(1024, 608);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(273, 148);
            btnRegresar.TabIndex = 16;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextColor = Color.Black;
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click_1;
            // 
            // btnAgregarAuto
            // 
            btnAgregarAuto.BackColor = Color.White;
            btnAgregarAuto.BackgroundColor = Color.White;
            btnAgregarAuto.BorderColor = Color.Black;
            btnAgregarAuto.BorderRadius = 35;
            btnAgregarAuto.BorderSize = 0;
            btnAgregarAuto.FlatAppearance.BorderSize = 0;
            btnAgregarAuto.FlatStyle = FlatStyle.Flat;
            btnAgregarAuto.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarAuto.ForeColor = Color.Black;
            btnAgregarAuto.Location = new Point(1024, 424);
            btnAgregarAuto.Name = "btnAgregarAuto";
            btnAgregarAuto.Size = new Size(273, 148);
            btnAgregarAuto.TabIndex = 15;
            btnAgregarAuto.Text = "Agregar Auto";
            btnAgregarAuto.TextColor = Color.Black;
            btnAgregarAuto.UseVisualStyleBackColor = false;
            btnAgregarAuto.Click += btnAgregarAuto_Click_1;
            // 
            // btnCargarImagen
            // 
            btnCargarImagen.BackColor = Color.White;
            btnCargarImagen.BackgroundColor = Color.White;
            btnCargarImagen.BorderColor = Color.Black;
            btnCargarImagen.BorderRadius = 35;
            btnCargarImagen.BorderSize = 0;
            btnCargarImagen.FlatAppearance.BorderSize = 0;
            btnCargarImagen.FlatStyle = FlatStyle.Flat;
            btnCargarImagen.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCargarImagen.ForeColor = Color.Black;
            btnCargarImagen.Location = new Point(1424, 142);
            btnCargarImagen.Name = "btnCargarImagen";
            btnCargarImagen.Size = new Size(273, 148);
            btnCargarImagen.TabIndex = 14;
            btnCargarImagen.Text = "Cargar Imagen";
            btnCargarImagen.TextColor = Color.Black;
            btnCargarImagen.UseVisualStyleBackColor = false;
            btnCargarImagen.Click += btnCargarImagen_Click_1;
            // 
            // picFoto
            // 
            picFoto.BorderStyle = BorderStyle.FixedSingle;
            picFoto.Location = new Point(918, 52);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(418, 347);
            picFoto.TabIndex = 13;
            picFoto.TabStop = false;
            // 
            // cboColorAuto
            // 
            cboColorAuto.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboColorAuto.FormattingEnabled = true;
            cboColorAuto.Items.AddRange(new object[] { "Gris Metalico", "Grafito", "Blanco", "Negro", "Rojo", "Plata", "Blanco Perlado" });
            cboColorAuto.Location = new Point(255, 731);
            cboColorAuto.Name = "cboColorAuto";
            cboColorAuto.Size = new Size(459, 48);
            cboColorAuto.TabIndex = 9;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(42, 731);
            label5.Name = "label5";
            label5.Size = new Size(97, 40);
            label5.TabIndex = 8;
            label5.Text = "Color";
            // 
            // txtPrecioAuto
            // 
            txtPrecioAuto.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrecioAuto.Location = new Point(255, 642);
            txtPrecioAuto.Name = "txtPrecioAuto";
            txtPrecioAuto.Size = new Size(581, 48);
            txtPrecioAuto.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(42, 642);
            label4.Name = "label4";
            label4.Size = new Size(113, 40);
            label4.TabIndex = 6;
            label4.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(255, 299);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(581, 321);
            txtDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 298);
            label3.Name = "label3";
            label3.Size = new Size(196, 40);
            label3.TabIndex = 4;
            label3.Text = "Descripcion";
            // 
            // cboModelo
            // 
            cboModelo.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboModelo.FormattingEnabled = true;
            cboModelo.Items.AddRange(new object[] { "Sedanes & Hatchbacks", "Suvs & Minivans", "Pickups & Comercials", "Toyota Gazoo Razing", "Hibridos Electricos (HEV)" });
            cboModelo.Location = new Point(255, 189);
            cboModelo.Name = "cboModelo";
            cboModelo.Size = new Size(581, 48);
            cboModelo.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(42, 189);
            label2.Name = "label2";
            label2.Size = new Size(126, 40);
            label2.TabIndex = 2;
            label2.Text = "Modelo";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(42, 71);
            label1.Name = "label1";
            label1.Size = new Size(138, 40);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombreAuto
            // 
            txtNombreAuto.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreAuto.Location = new Point(255, 71);
            txtNombreAuto.Name = "txtNombreAuto";
            txtNombreAuto.Size = new Size(593, 48);
            txtNombreAuto.TabIndex = 0;
            // 
            // tabListaAutos
            // 
            tabListaAutos.Controls.Add(dgtListaAutos);
            tabListaAutos.Location = new Point(4, 33);
            tabListaAutos.Name = "tabListaAutos";
            tabListaAutos.Padding = new Padding(3);
            tabListaAutos.Size = new Size(1739, 831);
            tabListaAutos.TabIndex = 1;
            tabListaAutos.Text = "Lista Autos";
            tabListaAutos.UseVisualStyleBackColor = true;
            // 
            // dgtListaAutos
            // 
            dgtListaAutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgtListaAutos.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Arial", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgtListaAutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgtListaAutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgtListaAutos.DefaultCellStyle = dataGridViewCellStyle2;
            dgtListaAutos.Location = new Point(6, 27);
            dgtListaAutos.Name = "dgtListaAutos";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgtListaAutos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgtListaAutos.RowTemplate.Height = 45;
            dgtListaAutos.Size = new Size(1708, 796);
            dgtListaAutos.TabIndex = 0;
            dgtListaAutos.Click += dgtListaAutos_Click;
            // 
            // tabVisualizacion
            // 
            tabVisualizacion.Controls.Add(picFotoVisualizacion);
            tabVisualizacion.Controls.Add(richDescripcion);
            tabVisualizacion.Controls.Add(lblColor);
            tabVisualizacion.Controls.Add(label13);
            tabVisualizacion.Controls.Add(lblPrecio);
            tabVisualizacion.Controls.Add(label11);
            tabVisualizacion.Controls.Add(label9);
            tabVisualizacion.Controls.Add(lblModelo);
            tabVisualizacion.Controls.Add(label7);
            tabVisualizacion.Controls.Add(lblNombre);
            tabVisualizacion.Controls.Add(label6);
            tabVisualizacion.Location = new Point(4, 33);
            tabVisualizacion.Name = "tabVisualizacion";
            tabVisualizacion.Padding = new Padding(3);
            tabVisualizacion.Size = new Size(1739, 831);
            tabVisualizacion.TabIndex = 2;
            tabVisualizacion.Text = "Visualizacion";
            tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // picFotoVisualizacion
            // 
            picFotoVisualizacion.Location = new Point(1082, 29);
            picFotoVisualizacion.Name = "picFotoVisualizacion";
            picFotoVisualizacion.Size = new Size(611, 446);
            picFotoVisualizacion.TabIndex = 11;
            picFotoVisualizacion.TabStop = false;
            // 
            // richDescripcion
            // 
            richDescripcion.BackColor = Color.White;
            richDescripcion.BorderStyle = BorderStyle.FixedSingle;
            richDescripcion.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            richDescripcion.Location = new Point(309, 250);
            richDescripcion.Name = "richDescripcion";
            richDescripcion.ReadOnly = true;
            richDescripcion.Size = new Size(522, 327);
            richDescripcion.TabIndex = 10;
            richDescripcion.Text = "";
            richDescripcion.Visible = false;
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblColor.Location = new Point(324, 748);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(124, 40);
            lblColor.TabIndex = 9;
            lblColor.Text = "label14";
            lblColor.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(72, 748);
            label13.Name = "label13";
            label13.Size = new Size(97, 40);
            label13.TabIndex = 8;
            label13.Text = "Color";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(324, 607);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(124, 40);
            lblPrecio.TabIndex = 7;
            lblPrecio.Text = "label12";
            lblPrecio.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(72, 607);
            label11.Name = "label11";
            label11.Size = new Size(113, 40);
            label11.TabIndex = 6;
            label11.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(72, 312);
            label9.Name = "label9";
            label9.Size = new Size(196, 40);
            label9.TabIndex = 4;
            label9.Text = "Descripcion";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblModelo.Location = new Point(324, 178);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(159, 40);
            lblModelo.TabIndex = 3;
            lblModelo.Text = "lblModelo";
            lblModelo.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(72, 178);
            label7.Name = "label7";
            label7.Size = new Size(126, 40);
            label7.TabIndex = 2;
            label7.Text = "Modelo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombre.Location = new Point(324, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(105, 40);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "label7";
            lblNombre.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(72, 44);
            label6.Name = "label6";
            label6.Size = new Size(138, 40);
            label6.TabIndex = 0;
            label6.Text = "Nombre";
            // 
            // InventarioAutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1771, 929);
            Controls.Add(tabInventario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InventarioAutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InventarioAutos";
            WindowState = FormWindowState.Maximized;
            Load += InventarioAutos_Load;
            tabInventario.ResumeLayout(false);
            TabAgregarInformacion.ResumeLayout(false);
            TabAgregarInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            tabListaAutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgtListaAutos).EndInit();
            tabVisualizacion.ResumeLayout(false);
            tabVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFotoVisualizacion).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabInventario;
        private TabPage TabAgregarInformacion;
        private TabPage tabListaAutos;
        private ComboBox cboModelo;
        private Label label2;
        private Label label1;
        private TextBox txtNombreAuto;
        private TextBox txtPrecioAuto;
        private Label label4;
        private TextBox txtDescripcion;
        private Label label3;
        private ComboBox cboColorAuto;
        private Label label5;
        private PictureBox picFoto;
        private DataGridView dgtListaAutos;
        private TabPage tabVisualizacion;
        private Label lblNombre;
        private Label label6;
        private Label lblColor;
        private Label label13;
        private Label lblPrecio;
        private Label label11;
        private Label label9;
        private Label lblModelo;
        private Label label7;
        private BibliotecaDeClaseWindowsForms.button btnCargarImagen;
        private BibliotecaDeClaseWindowsForms.button btnRegresar;
        private BibliotecaDeClaseWindowsForms.button btnAgregarAuto;
        private RichTextBox richDescripcion;
        private PictureBox picFotoVisualizacion;
    }
}