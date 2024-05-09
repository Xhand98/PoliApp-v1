namespace WinFormsApp3
{
    partial class GradeMaster
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradeMaster));
            sidePanel = new Panel();
            logOut = new Label();
            pictureBox2 = new PictureBox();
            subMenuPro = new Panel();
            panel6 = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            btnManerjarCurso = new Button();
            panel3 = new Panel();
            btnAsg = new Button();
            panel2 = new Panel();
            btnEst = new Button();
            panel1 = new Panel();
            btnPro = new Button();
            homePage = new PictureBox();
            mainCont = new Panel();
            fastAcc = new Label();
            presentTxt = new Label();
            appTitle = new Label();
            contextMenuStrip3 = new ContextMenuStrip(components);
            profesoresToolStripMenuItem = new ToolStripMenuItem();
            sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            subMenuPro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)homePage).BeginInit();
            mainCont.SuspendLayout();
            contextMenuStrip3.SuspendLayout();
            SuspendLayout();
            // 
            // sidePanel
            // 
            sidePanel.BackColor = Color.FromArgb(26, 32, 40);
            sidePanel.Controls.Add(logOut);
            sidePanel.Controls.Add(pictureBox2);
            sidePanel.Controls.Add(subMenuPro);
            sidePanel.Controls.Add(panel3);
            sidePanel.Controls.Add(btnAsg);
            sidePanel.Controls.Add(panel2);
            sidePanel.Controls.Add(btnEst);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(btnPro);
            sidePanel.Controls.Add(homePage);
            sidePanel.Dock = DockStyle.Left;
            sidePanel.Location = new Point(0, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Size = new Size(200, 679);
            sidePanel.TabIndex = 1;
            // 
            // logOut
            // 
            logOut.AutoSize = true;
            logOut.Cursor = Cursors.Hand;
            logOut.ForeColor = SystemColors.ButtonHighlight;
            logOut.Location = new Point(10, 492);
            logOut.Name = "logOut";
            logOut.Size = new Size(13, 20);
            logOut.TabIndex = 7;
            logOut.Text = " ";
            logOut.Click += logOut_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(150, 631);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // subMenuPro
            // 
            subMenuPro.Controls.Add(panel6);
            subMenuPro.Controls.Add(button2);
            subMenuPro.Controls.Add(panel5);
            subMenuPro.Controls.Add(btnManerjarCurso);
            subMenuPro.Location = new Point(50, 265);
            subMenuPro.Name = "subMenuPro";
            subMenuPro.Size = new Size(149, 89);
            subMenuPro.TabIndex = 0;
            subMenuPro.Visible = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(0, 80, 200);
            panel6.Location = new Point(0, 45);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 35);
            panel6.TabIndex = 8;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(26, 32, 40);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 45);
            button2.Name = "button2";
            button2.Size = new Size(145, 35);
            button2.TabIndex = 9;
            button2.Text = "Asignar notas";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 80, 200);
            panel5.Location = new Point(0, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 33);
            panel5.TabIndex = 6;
            // 
            // btnManerjarCurso
            // 
            btnManerjarCurso.BackColor = Color.FromArgb(26, 32, 40);
            btnManerjarCurso.FlatAppearance.BorderSize = 0;
            btnManerjarCurso.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnManerjarCurso.FlatStyle = FlatStyle.Flat;
            btnManerjarCurso.ForeColor = SystemColors.Control;
            btnManerjarCurso.Location = new Point(3, 6);
            btnManerjarCurso.Name = "btnManerjarCurso";
            btnManerjarCurso.Size = new Size(145, 33);
            btnManerjarCurso.TabIndex = 7;
            btnManerjarCurso.Text = "Manejar cursos";
            btnManerjarCurso.UseVisualStyleBackColor = false;
            btnManerjarCurso.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 80, 200);
            panel3.Location = new Point(0, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(10, 47);
            panel3.TabIndex = 2;
            // 
            // btnAsg
            // 
            btnAsg.BackColor = Color.FromArgb(26, 32, 40);
            btnAsg.FlatAppearance.BorderSize = 0;
            btnAsg.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnAsg.FlatStyle = FlatStyle.Flat;
            btnAsg.ForeColor = SystemColors.Control;
            btnAsg.Location = new Point(4, 164);
            btnAsg.Name = "btnAsg";
            btnAsg.Size = new Size(195, 47);
            btnAsg.TabIndex = 5;
            btnAsg.Text = "Asignaturas";
            btnAsg.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 80, 200);
            panel2.Location = new Point(1, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(10, 47);
            panel2.TabIndex = 1;
            // 
            // btnEst
            // 
            btnEst.BackColor = Color.FromArgb(26, 32, 40);
            btnEst.Cursor = Cursors.Hand;
            btnEst.FlatAppearance.BorderSize = 0;
            btnEst.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnEst.FlatStyle = FlatStyle.Flat;
            btnEst.ForeColor = SystemColors.Control;
            btnEst.Location = new Point(4, 111);
            btnEst.Name = "btnEst";
            btnEst.Size = new Size(195, 47);
            btnEst.TabIndex = 4;
            btnEst.Text = "Estudiantes";
            btnEst.UseVisualStyleBackColor = false;
            btnEst.Click += btnEst_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 80, 200);
            panel1.Location = new Point(0, 217);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 47);
            panel1.TabIndex = 0;
            // 
            // btnPro
            // 
            btnPro.BackColor = Color.FromArgb(26, 32, 40);
            btnPro.FlatAppearance.BorderSize = 0;
            btnPro.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 80, 200);
            btnPro.FlatStyle = FlatStyle.Flat;
            btnPro.ForeColor = SystemColors.Control;
            btnPro.Location = new Point(1, 217);
            btnPro.Name = "btnPro";
            btnPro.Size = new Size(196, 47);
            btnPro.TabIndex = 1;
            btnPro.Text = "Docente";
            btnPro.UseVisualStyleBackColor = false;
            btnPro.Click += btnPro_Click;
            // 
            // homePage
            // 
            homePage.Image = (Image)resources.GetObject("homePage.Image");
            homePage.Location = new Point(19, 6);
            homePage.Name = "homePage";
            homePage.Size = new Size(164, 108);
            homePage.SizeMode = PictureBoxSizeMode.Zoom;
            homePage.TabIndex = 0;
            homePage.TabStop = false;
            homePage.Click += homePage_Click;
            // 
            // mainCont
            // 
            mainCont.AllowDrop = true;
            mainCont.BackColor = Color.FromArgb(49, 66, 82);
            mainCont.Controls.Add(fastAcc);
            mainCont.Controls.Add(presentTxt);
            mainCont.Controls.Add(appTitle);
            mainCont.Dock = DockStyle.Fill;
            mainCont.Font = new Font("Javanese Text", 32F, FontStyle.Bold);
            mainCont.Location = new Point(200, 0);
            mainCont.Name = "mainCont";
            mainCont.Size = new Size(1185, 679);
            mainCont.TabIndex = 2;
            mainCont.Paint += mainCont_Paint_1;
            // 
            // fastAcc
            // 
            fastAcc.AutoSize = true;
            fastAcc.BackColor = Color.Transparent;
            fastAcc.Font = new Font("Javanese Text", 10F);
            fastAcc.ForeColor = SystemColors.ButtonHighlight;
            fastAcc.Location = new Point(373, 143);
            fastAcc.Name = "fastAcc";
            fastAcc.Size = new Size(119, 38);
            fastAcc.TabIndex = 2;
            fastAcc.Text = "Acceso rapido";
            // 
            // presentTxt
            // 
            presentTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            presentTxt.AutoSize = true;
            presentTxt.BackColor = Color.Transparent;
            presentTxt.Font = new Font("Javanese Text", 16F);
            presentTxt.ForeColor = SystemColors.ControlLightLight;
            presentTxt.Location = new Point(195, 96);
            presentTxt.Name = "presentTxt";
            presentTxt.Size = new Size(504, 62);
            presentTxt.TabIndex = 1;
            presentTxt.Text = "Su gestor de calificaciones de preferencia";
            presentTxt.TextAlign = ContentAlignment.BottomCenter;
            presentTxt.Click += label1_Click;
            // 
            // appTitle
            // 
            appTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            appTitle.AutoSize = true;
            appTitle.Font = new Font("Javanese Text", 32F, FontStyle.Bold);
            appTitle.ForeColor = Color.LightYellow;
            appTitle.Location = new Point(81, 9);
            appTitle.Name = "appTitle";
            appTitle.Size = new Size(729, 123);
            appTitle.TabIndex = 0;
            appTitle.Text = "Bienvenido/a a GradeMaster";
            appTitle.TextAlign = ContentAlignment.MiddleCenter;
            appTitle.Click += appTitle_Click;
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(20, 20);
            contextMenuStrip3.Items.AddRange(new ToolStripItem[] { profesoresToolStripMenuItem });
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip3.Size = new Size(148, 28);
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.BackColor = Color.FromArgb(49, 66, 82);
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new Size(147, 24);
            profesoresToolStripMenuItem.Text = "Profesores";
            // 
            // GradeMaster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 679);
            Controls.Add(mainCont);
            Controls.Add(sidePanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GradeMaster";
            Text = "GradeMaster";
            Load += Form1_Load;
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            subMenuPro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)homePage).EndInit();
            mainCont.ResumeLayout(false);
            mainCont.PerformLayout();
            contextMenuStrip3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel sidePanel;
        private Panel mainCont;
        private PictureBox homePage;
        private Button btnPro;
        private Panel panel1;
        private Panel panel3;
        private Button btnAsg;
        private Panel panel2;
        private Button btnEst;
        private Panel subMenuPro;
        private Panel panel6;
        private Button button2;
        private Panel panel5;
        private Button btnManerjarCurso;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem profesoresToolStripMenuItem;
        private PictureBox pictureBox2;
        private Label presentTxt;
        private Label fastAcc;
        private Label appTitle;
        private Label logOut;
    }
}
