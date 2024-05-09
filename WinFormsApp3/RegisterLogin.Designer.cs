namespace Windows_Forms_Prueba
{
    partial class RegisterLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterLogin));
            BoxRegCentro = new TextBox();
            BoxRegEmail = new TextBox();
            BoxRegPass = new TextBox();
            BoxRegUbicacion = new TextBox();
            BoxRegRECPass = new TextBox();
            ButtonRegCentro = new Button();
            LabelRegCuenta = new Label();
            ButtonRegInicio = new Button();
            pictureBox1 = new PictureBox();
            BoxRegUserAdmin = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BoxRegCentro
            // 
            BoxRegCentro.Font = new Font("Segoe UI", 12F);
            BoxRegCentro.Location = new Point(680, 423);
            BoxRegCentro.Margin = new Padding(3, 30, 3, 30);
            BoxRegCentro.Name = "BoxRegCentro";
            BoxRegCentro.PlaceholderText = "Nombre Centro Educativo";
            BoxRegCentro.Size = new Size(307, 34);
            BoxRegCentro.TabIndex = 0;
            // 
            // BoxRegEmail
            // 
            BoxRegEmail.Font = new Font("Segoe UI", 12F);
            BoxRegEmail.Location = new Point(680, 499);
            BoxRegEmail.Name = "BoxRegEmail";
            BoxRegEmail.PlaceholderText = "Correo Electronico";
            BoxRegEmail.Size = new Size(307, 34);
            BoxRegEmail.TabIndex = 3;
            // 
            // BoxRegPass
            // 
            BoxRegPass.Font = new Font("Segoe UI", 12F);
            BoxRegPass.Location = new Point(680, 571);
            BoxRegPass.Name = "BoxRegPass";
            BoxRegPass.PasswordChar = '*';
            BoxRegPass.PlaceholderText = "Contraseña";
            BoxRegPass.Size = new Size(307, 34);
            BoxRegPass.TabIndex = 4;
            // 
            // BoxRegUbicacion
            // 
            BoxRegUbicacion.Font = new Font("Segoe UI", 12F);
            BoxRegUbicacion.Location = new Point(1042, 499);
            BoxRegUbicacion.Name = "BoxRegUbicacion";
            BoxRegUbicacion.PlaceholderText = "Ubicación";
            BoxRegUbicacion.Size = new Size(307, 34);
            BoxRegUbicacion.TabIndex = 5;
            // 
            // BoxRegRECPass
            // 
            BoxRegRECPass.Font = new Font("Segoe UI", 12F);
            BoxRegRECPass.Location = new Point(1042, 571);
            BoxRegRECPass.Name = "BoxRegRECPass";
            BoxRegRECPass.PasswordChar = '*';
            BoxRegRECPass.PlaceholderText = "Confirmar Contraseña";
            BoxRegRECPass.Size = new Size(307, 34);
            BoxRegRECPass.TabIndex = 6;
            // 
            // ButtonRegCentro
            // 
            ButtonRegCentro.ForeColor = Color.Black;
            ButtonRegCentro.Location = new Point(866, 636);
            ButtonRegCentro.Name = "ButtonRegCentro";
            ButtonRegCentro.Size = new Size(303, 29);
            ButtonRegCentro.TabIndex = 7;
            ButtonRegCentro.Text = "Registrar Centro";
            ButtonRegCentro.UseVisualStyleBackColor = true;
            // 
            // LabelRegCuenta
            // 
            LabelRegCuenta.AutoSize = true;
            LabelRegCuenta.Font = new Font("Segoe UI", 10F);
            LabelRegCuenta.Location = new Point(866, 683);
            LabelRegCuenta.Name = "LabelRegCuenta";
            LabelRegCuenta.Size = new Size(311, 23);
            LabelRegCuenta.TabIndex = 8;
            LabelRegCuenta.Text = "¿Ya tu centro educativo está agregado?";
            // 
            // ButtonRegInicio
            // 
            ButtonRegInicio.ForeColor = Color.Black;
            ButtonRegInicio.Location = new Point(870, 720);
            ButtonRegInicio.Name = "ButtonRegInicio";
            ButtonRegInicio.Size = new Size(299, 29);
            ButtonRegInicio.TabIndex = 9;
            ButtonRegInicio.Text = "Iniciar Sesión";
            ButtonRegInicio.UseVisualStyleBackColor = true;
            ButtonRegInicio.Click += CambiarASesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(903, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 215);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BoxRegUserAdmin
            // 
            BoxRegUserAdmin.Font = new Font("Segoe UI", 12F);
            BoxRegUserAdmin.Location = new Point(1042, 423);
            BoxRegUserAdmin.Name = "BoxRegUserAdmin";
            BoxRegUserAdmin.PlaceholderText = "Usuario de Admin";
            BoxRegUserAdmin.Size = new Size(307, 34);
            BoxRegUserAdmin.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Javanese Text", 9F);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(680, 398);
            label1.Name = "label1";
            label1.Size = new Size(153, 34);
            label1.TabIndex = 12;
            label1.Text = "Nombre de su centro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Javanese Text", 9F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(680, 472);
            label2.Name = "label2";
            label2.Size = new Size(158, 34);
            label2.TabIndex = 13;
            label2.Text = "Correo de preferencia:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Javanese Text", 9F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(680, 548);
            label3.Name = "label3";
            label3.Size = new Size(136, 34);
            label3.TabIndex = 14;
            label3.Text = "Contraseña segura:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Javanese Text", 9F);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(1041, 548);
            label4.Name = "label4";
            label4.Size = new Size(136, 34);
            label4.TabIndex = 15;
            label4.Text = "Contraseña segura:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Javanese Text", 9F);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(1042, 472);
            label5.Name = "label5";
            label5.Size = new Size(151, 34);
            label5.TabIndex = 16;
            label5.Text = "Ubicación del centro:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Javanese Text", 9F);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(1042, 401);
            label6.Name = "label6";
            label6.Size = new Size(181, 34);
            label6.TabIndex = 17;
            label6.Text = "Usuario de administrador:";
            // 
            // RegisterLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(29, 31, 48);
            ClientSize = new Size(1902, 1033);
            Controls.Add(BoxRegUserAdmin);
            Controls.Add(pictureBox1);
            Controls.Add(ButtonRegInicio);
            Controls.Add(LabelRegCuenta);
            Controls.Add(ButtonRegCentro);
            Controls.Add(BoxRegRECPass);
            Controls.Add(BoxRegUbicacion);
            Controls.Add(BoxRegPass);
            Controls.Add(BoxRegEmail);
            Controls.Add(BoxRegCentro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            ForeColor = Color.White;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RegisterLogin";
            Text = "Register";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BoxRegCentro;
        private TextBox BoxRegEmail;
        private TextBox BoxRegPass;
        private TextBox BoxRegUbicacion;
        private TextBox BoxRegRECPass;
        private Button ButtonRegCentro;
        private Label LabelRegCuenta;
        private Button ButtonRegInicio;
        private PictureBox pictureBox1;
        private TextBox BoxRegUserAdmin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}