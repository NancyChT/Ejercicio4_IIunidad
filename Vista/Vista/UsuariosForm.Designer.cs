namespace Vista
{
    partial class UsuariosForm
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
            this.Codigolabel = new System.Windows.Forms.Label();
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.Clavelabel = new System.Windows.Forms.Label();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.Correolabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Rollabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EstaActivolabel = new System.Windows.Forms.Label();
            this.EstaActivocheckBox = new System.Windows.Forms.CheckBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.UsuariosdataGridView = new System.Windows.Forms.DataGridView();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Modificarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Codigolabel
            // 
            this.Codigolabel.AutoSize = true;
            this.Codigolabel.Location = new System.Drawing.Point(71, 53);
            this.Codigolabel.Name = "Codigolabel";
            this.Codigolabel.Size = new System.Drawing.Size(58, 17);
            this.Codigolabel.TabIndex = 0;
            this.Codigolabel.Text = "Codigo: ";
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(144, 45);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(175, 25);
            this.CodigotextBox.TabIndex = 1;
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(65, 94);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(64, 17);
            this.Nombrelabel.TabIndex = 2;
            this.Nombrelabel.Text = "Nombre: ";
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(144, 86);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(175, 25);
            this.NombretextBox.TabIndex = 3;
            // 
            // Clavelabel
            // 
            this.Clavelabel.AutoSize = true;
            this.Clavelabel.Location = new System.Drawing.Point(83, 136);
            this.Clavelabel.Name = "Clavelabel";
            this.Clavelabel.Size = new System.Drawing.Size(46, 17);
            this.Clavelabel.TabIndex = 4;
            this.Clavelabel.Text = "Clave: ";
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(144, 128);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(175, 25);
            this.ClavetextBox.TabIndex = 5;
            // 
            // Correolabel
            // 
            this.Correolabel.AutoSize = true;
            this.Correolabel.Location = new System.Drawing.Point(73, 174);
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(56, 17);
            this.Correolabel.TabIndex = 6;
            this.Correolabel.Text = "Correo: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 25);
            this.textBox1.TabIndex = 7;
            // 
            // Rollabel
            // 
            this.Rollabel.AutoSize = true;
            this.Rollabel.Location = new System.Drawing.Point(95, 211);
            this.Rollabel.Name = "Rollabel";
            this.Rollabel.Size = new System.Drawing.Size(34, 17);
            this.Rollabel.TabIndex = 8;
            this.Rollabel.Text = "Rol: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.comboBox1.Location = new System.Drawing.Point(144, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(175, 25);
            this.comboBox1.TabIndex = 9;
            // 
            // EstaActivolabel
            // 
            this.EstaActivolabel.AutoSize = true;
            this.EstaActivolabel.Location = new System.Drawing.Point(51, 249);
            this.EstaActivolabel.Name = "EstaActivolabel";
            this.EstaActivolabel.Size = new System.Drawing.Size(78, 17);
            this.EstaActivolabel.TabIndex = 10;
            this.EstaActivolabel.Text = "Esta Activo: ";
            // 
            // EstaActivocheckBox
            // 
            this.EstaActivocheckBox.AutoSize = true;
            this.EstaActivocheckBox.Location = new System.Drawing.Point(144, 252);
            this.EstaActivocheckBox.Name = "EstaActivocheckBox";
            this.EstaActivocheckBox.Size = new System.Drawing.Size(15, 14);
            this.EstaActivocheckBox.TabIndex = 11;
            this.EstaActivocheckBox.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(417, 53);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 29);
            this.Nuevobutton.TabIndex = 12;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // UsuariosdataGridView
            // 
            this.UsuariosdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsuariosdataGridView.Location = new System.Drawing.Point(338, 94);
            this.UsuariosdataGridView.Name = "UsuariosdataGridView";
            this.UsuariosdataGridView.RowTemplate.Height = 25;
            this.UsuariosdataGridView.Size = new System.Drawing.Size(509, 150);
            this.UsuariosdataGridView.TabIndex = 13;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(509, 53);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 29);
            this.Guardarbutton.TabIndex = 14;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseCompatibleTextRendering = true;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            // 
            // Modificarbutton
            // 
            this.Modificarbutton.Location = new System.Drawing.Point(602, 53);
            this.Modificarbutton.Name = "Modificarbutton";
            this.Modificarbutton.Size = new System.Drawing.Size(75, 29);
            this.Modificarbutton.TabIndex = 15;
            this.Modificarbutton.Text = "Modificar";
            this.Modificarbutton.UseVisualStyleBackColor = true;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Location = new System.Drawing.Point(692, 53);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(75, 29);
            this.Cancelarbutton.TabIndex = 16;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            // 
            // UsuariosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 400);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Modificarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.UsuariosdataGridView);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.EstaActivocheckBox);
            this.Controls.Add(this.EstaActivolabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Rollabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Correolabel);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.Clavelabel);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.Nombrelabel);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.Codigolabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "UsuariosForm";
            this.Text = "UsuariosForm";
            this.Load += new System.EventHandler(this.UsuariosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Codigolabel;
        private TextBox CodigotextBox;
        private Label Nombrelabel;
        private TextBox NombretextBox;
        private Label Clavelabel;
        private TextBox ClavetextBox;
        private Label Correolabel;
        private TextBox textBox1;
        private Label Rollabel;
        private ComboBox comboBox1;
        private Label EstaActivolabel;
        private CheckBox EstaActivocheckBox;
        private Button Nuevobutton;
        private DataGridView UsuariosdataGridView;
        private Button Guardarbutton;
        private Button Modificarbutton;
        private Button Cancelarbutton;
    }
}