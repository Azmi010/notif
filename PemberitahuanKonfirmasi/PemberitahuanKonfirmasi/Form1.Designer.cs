﻿namespace PemberitahuanKonfirmasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panelLabels = new Panel();
            label8 = new Label();
            panelout = new Panel();
            PanelNotif = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label14 = new Label();
            pictureBox5 = new PictureBox();
            label12 = new Label();
            label13 = new Label();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel1.SuspendLayout();
            panelLabels.SuspendLayout();
            PanelNotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(panelLabels);
            panel1.Controls.Add(panelout);
            panel1.Controls.Add(PanelNotif);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 681);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panelLabels
            // 
            panelLabels.AutoScroll = true;
            panelLabels.Controls.Add(label8);
            panelLabels.Location = new Point(274, 114);
            panelLabels.Name = "panelLabels";
            panelLabels.Size = new Size(325, 387);
            panelLabels.TabIndex = 6;
            panelLabels.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(106, 22);
            label8.TabIndex = 2;
            label8.Text = "Nama Hotel";
            // 
            // panelout
            // 
            panelout.BackColor = Color.White;
            panelout.Location = new Point(1052, 100);
            panelout.Name = "panelout";
            panelout.Size = new Size(209, 217);
            panelout.TabIndex = 3;
            panelout.Visible = false;
            panelout.Paint += panelout_Paint;
            // 
            // PanelNotif
            // 
            PanelNotif.BackColor = Color.Transparent;
            PanelNotif.BorderRadius = 10;
            PanelNotif.Controls.Add(label14);
            PanelNotif.Controls.Add(pictureBox5);
            PanelNotif.Controls.Add(label12);
            PanelNotif.Controls.Add(label13);
            PanelNotif.Controls.Add(guna2Button2);
            PanelNotif.Controls.Add(guna2Button1);
            PanelNotif.Controls.Add(pictureBox4);
            PanelNotif.Controls.Add(label6);
            PanelNotif.CustomizableEdges = customizableEdges5;
            PanelNotif.Location = new Point(867, 100);
            PanelNotif.Name = "PanelNotif";
            PanelNotif.ShadowDecoration.CustomizableEdges = customizableEdges6;
            PanelNotif.Size = new Size(344, 563);
            PanelNotif.TabIndex = 2;
            PanelNotif.Visible = false;
            PanelNotif.Paint += PanelNotif_Paint;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(79, 306);
            label14.Name = "label14";
            label14.Size = new Size(158, 22);
            label14.TabIndex = 12;
            label14.Text = "Kode Pembayaran";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(14, 257);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(44, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(79, 284);
            label12.Name = "label12";
            label12.Size = new Size(165, 22);
            label12.TabIndex = 10;
            label12.Text = "Kode Pembayaran :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.FromArgb(8, 102, 255);
            label13.Location = new Point(67, 257);
            label13.Name = "label13";
            label13.Size = new Size(199, 22);
            label13.TabIndex = 9;
            label13.Text = "User telah membeli ini";
            label13.Click += label13_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BorderColor = Color.FromArgb(221, 221, 221);
            guna2Button2.BorderRadius = 2;
            guna2Button2.BorderThickness = 1;
            guna2Button2.CustomizableEdges = customizableEdges1;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(221, 221, 221);
            guna2Button2.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button2.ForeColor = Color.FromArgb(8, 102, 255);
            guna2Button2.Location = new Point(209, 214);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button2.Size = new Size(96, 20);
            guna2Button2.TabIndex = 8;
            guna2Button2.Text = "Batal";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderColor = Color.FromArgb(8, 102, 255);
            guna2Button1.BorderRadius = 2;
            guna2Button1.BorderThickness = 1;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(8, 102, 255);
            guna2Button1.Font = new Font("Montserrat SemiBold", 9.749999F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(35, 214);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(153, 20);
            guna2Button1.TabIndex = 7;
            guna2Button1.Text = "Konfirmasi";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(14, 73);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(44, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Montserrat SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 14);
            label6.Name = "label6";
            label6.Size = new Size(133, 33);
            label6.TabIndex = 0;
            label6.Text = "Notifikasi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1264, 100);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(925, 37);
            label5.Name = "label5";
            label5.Size = new Size(89, 26);
            label5.TabIndex = 11;
            label5.Text = "Lainnya";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(732, 37);
            label4.Name = "label4";
            label4.Size = new Size(146, 26);
            label4.TabIndex = 10;
            label4.Text = "Status Kamar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(527, 37);
            label3.Name = "label3";
            label3.Size = new Size(157, 26);
            label3.TabIndex = 9;
            label3.Text = "Database User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(413, 37);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 8;
            label2.Text = "Staff";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1119, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            pictureBox3.DoubleClick += pictureBox3_DoubleClick;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1193, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat SemiBold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(294, 37);
            label1.Name = "label1";
            label1.Size = new Size(71, 26);
            label1.TabIndex = 2;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(180, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(642, 114);
            label7.Name = "label7";
            label7.Size = new Size(152, 22);
            label7.TabIndex = 1;
            label7.Text = "User membeli ini";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(642, 149);
            label9.Name = "label9";
            label9.Size = new Size(127, 22);
            label9.TabIndex = 3;
            label9.Text = "Berapa malam";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(669, 184);
            label10.Name = "label10";
            label10.Size = new Size(100, 22);
            label10.TabIndex = 4;
            label10.Text = "Total Harga";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(690, 240);
            label11.Name = "label11";
            label11.Size = new Size(104, 22);
            label11.TabIndex = 5;
            label11.Text = "Rp. 100.000";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 681);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            TextChanged += Form1_TextChanged;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelLabels.ResumeLayout(false);
            panelLabels.PerformLayout();
            PanelNotif.ResumeLayout(false);
            PanelNotif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelNotif;
        private Label label6;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private PictureBox pictureBox4;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox5;
        private Label label12;
        private Label label13;
        private Label label14;
        private Panel panelout;
        private Panel panelLabels;
    }
}