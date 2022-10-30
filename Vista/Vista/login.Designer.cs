namespace Vista
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            this.Correolabel = new System.Windows.Forms.Label();
            this.Contrasenalabel = new System.Windows.Forms.Label();
            this.CorreotextBox = new System.Windows.Forms.TextBox();
            this.ContrasenatextBox = new System.Windows.Forms.TextBox();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.IniciopictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IniciopictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Correolabel
            // 
            this.Correolabel.AutoSize = true;
            this.Correolabel.Location = new System.Drawing.Point(73, 49);
            this.Correolabel.Name = "Correolabel";
            this.Correolabel.Size = new System.Drawing.Size(49, 15);
            this.Correolabel.TabIndex = 0;
            this.Correolabel.Text = "Correo: ";
            // 
            // Contrasenalabel
            // 
            this.Contrasenalabel.AutoSize = true;
            this.Contrasenalabel.Location = new System.Drawing.Point(44, 80);
            this.Contrasenalabel.Name = "Contrasenalabel";
            this.Contrasenalabel.Size = new System.Drawing.Size(78, 15);
            this.Contrasenalabel.TabIndex = 1;
            this.Contrasenalabel.Text = "Constraseña: ";
            // 
            // CorreotextBox
            // 
            this.CorreotextBox.Location = new System.Drawing.Point(141, 41);
            this.CorreotextBox.Name = "CorreotextBox";
            this.CorreotextBox.Size = new System.Drawing.Size(185, 23);
            this.CorreotextBox.TabIndex = 2;
            // 
            // ContrasenatextBox
            // 
            this.ContrasenatextBox.Location = new System.Drawing.Point(141, 72);
            this.ContrasenatextBox.Name = "ContrasenatextBox";
            this.ContrasenatextBox.PasswordChar = '*';
            this.ContrasenatextBox.Size = new System.Drawing.Size(185, 23);
            this.ContrasenatextBox.TabIndex = 3;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.Image = global::Vista.Properties.Resources.cheque;
            this.Aceptarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Aceptarbutton.Location = new System.Drawing.Point(141, 123);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(83, 44);
            this.Aceptarbutton.TabIndex = 4;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Aceptarbutton.UseVisualStyleBackColor = true;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::Vista.Properties.Resources.cerrar;
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancelarbutton.Location = new System.Drawing.Point(241, 123);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(85, 44);
            this.Cancelarbutton.TabIndex = 5;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // IniciopictureBox
            // 
            this.IniciopictureBox.Image = global::Vista.Properties.Resources.iniciar_sesion;
            this.IniciopictureBox.Location = new System.Drawing.Point(412, 30);
            this.IniciopictureBox.Name = "IniciopictureBox";
            this.IniciopictureBox.Size = new System.Drawing.Size(130, 137);
            this.IniciopictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IniciopictureBox.TabIndex = 6;
            this.IniciopictureBox.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // login
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(606, 234);
            this.Controls.Add(this.IniciopictureBox);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.ContrasenatextBox);
            this.Controls.Add(this.CorreotextBox);
            this.Controls.Add(this.Contrasenalabel);
            this.Controls.Add(this.Correolabel);
            this.Name = "login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.IniciopictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Correolabel;
        private Label Contrasenalabel;
        private TextBox CorreotextBox;
        private TextBox ContrasenatextBox;
        private Button Aceptarbutton;
        private Button Cancelarbutton;
        private PictureBox IniciopictureBox;
        private ErrorProvider errorProvider1;
    }
}