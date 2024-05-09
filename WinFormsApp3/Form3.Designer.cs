namespace WinFormsApp3
{
    partial class Form3
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
            fastAcc = new Label();
            presentTxt = new Label();
            appTitle = new Label();
            SuspendLayout();
            // 
            // fastAcc
            // 
            fastAcc.AutoSize = true;
            fastAcc.BackColor = Color.Transparent;
            fastAcc.Font = new Font("Javanese Text", 10F);
            fastAcc.ForeColor = SystemColors.ButtonHighlight;
            fastAcc.Location = new Point(326, 174);
            fastAcc.Name = "fastAcc";
            fastAcc.Size = new Size(119, 38);
            fastAcc.TabIndex = 5;
            fastAcc.Text = "Acceso rapido";
            // 
            // presentTxt
            // 
            presentTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            presentTxt.AutoSize = true;
            presentTxt.BackColor = Color.Transparent;
            presentTxt.Font = new Font("Javanese Text", 16F);
            presentTxt.ForeColor = SystemColors.ControlLightLight;
            presentTxt.Location = new Point(148, 127);
            presentTxt.Name = "presentTxt";
            presentTxt.Size = new Size(504, 62);
            presentTxt.TabIndex = 4;
            presentTxt.Text = "Su gestor de calificaciones de preferencia";
            presentTxt.TextAlign = ContentAlignment.BottomCenter;
            // 
            // appTitle
            // 
            appTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Javanese Text", 32F, FontStyle.Bold);
            appTitle.ForeColor = Color.LightYellow;
            appTitle.Location = new Point(34, 40);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(729, 123);
            appTitle.TabIndex = 3;
            appTitle.Text = "Bienvenido/a a GradeMaster";
            appTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 66, 82);
            ClientSize = new Size(800, 450);
            Controls.Add(fastAcc);
            Controls.Add(presentTxt);
            Controls.Add(appTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label fastAcc;
        private Label presentTxt;
        private Label appTitle;
    }
}