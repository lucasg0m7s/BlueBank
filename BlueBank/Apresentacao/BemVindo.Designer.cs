namespace BlueBank.Apresentacao
{
    partial class BemVindo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BemVindo));
            this.lblSaldo = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExtrato = new FontAwesome.Sharp.IconButton();
            this.btnChaves = new FontAwesome.Sharp.IconButton();
            this.btnRealizarPix = new FontAwesome.Sharp.IconButton();
            this.btnSair = new FontAwesome.Sharp.IconButton();
            this.btnPix = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogo = new System.Windows.Forms.PictureBox();
            this.minimize = new FontAwesome.Sharp.IconPictureBox();
            this.maximize = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold);
            this.lblSaldo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSaldo.Location = new System.Drawing.Point(36, 267);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(0, 33);
            this.lblSaldo.TabIndex = 7;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitleBar.Controls.Add(this.minimize);
            this.panelTitleBar.Controls.Add(this.maximize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(740, 75);
            this.panelTitleBar.TabIndex = 9;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitleChildForm.Location = new System.Drawing.Point(46, 33);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(56, 21);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyWindow;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(9, 24);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 39);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(740, 9);
            this.panelShadow.TabIndex = 10;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(740, 487);
            this.panelDesktop.TabIndex = 11;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelMenu.Controls.Add(this.btnExtrato);
            this.panelMenu.Controls.Add(this.btnChaves);
            this.panelMenu.Controls.Add(this.btnRealizarPix);
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Controls.Add(this.btnPix);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 571);
            this.panelMenu.TabIndex = 8;
            // 
            // btnExtrato
            // 
            this.btnExtrato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExtrato.FlatAppearance.BorderSize = 0;
            this.btnExtrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtrato.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtrato.ForeColor = System.Drawing.Color.White;
            this.btnExtrato.IconChar = FontAwesome.Sharp.IconChar.MoneyBillTransfer;
            this.btnExtrato.IconColor = System.Drawing.Color.White;
            this.btnExtrato.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExtrato.IconSize = 38;
            this.btnExtrato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtrato.Location = new System.Drawing.Point(0, 380);
            this.btnExtrato.Name = "btnExtrato";
            this.btnExtrato.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btnExtrato.Size = new System.Drawing.Size(220, 60);
            this.btnExtrato.TabIndex = 6;
            this.btnExtrato.Text = "Extrato Pix";
            this.btnExtrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtrato.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExtrato.UseVisualStyleBackColor = true;
            this.btnExtrato.Click += new System.EventHandler(this.btnExtrato_Click);
            // 
            // btnChaves
            // 
            this.btnChaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChaves.FlatAppearance.BorderSize = 0;
            this.btnChaves.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChaves.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChaves.ForeColor = System.Drawing.Color.White;
            this.btnChaves.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChaves.IconColor = System.Drawing.Color.White;
            this.btnChaves.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChaves.IconSize = 38;
            this.btnChaves.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChaves.Location = new System.Drawing.Point(0, 320);
            this.btnChaves.Name = "btnChaves";
            this.btnChaves.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btnChaves.Size = new System.Drawing.Size(220, 60);
            this.btnChaves.TabIndex = 5;
            this.btnChaves.Text = "Chaves Pix";
            this.btnChaves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChaves.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChaves.UseVisualStyleBackColor = true;
            this.btnChaves.Click += new System.EventHandler(this.btnChaves_Click);
            // 
            // btnRealizarPix
            // 
            this.btnRealizarPix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRealizarPix.FlatAppearance.BorderSize = 0;
            this.btnRealizarPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarPix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPix.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPix.IconChar = FontAwesome.Sharp.IconChar.Pix;
            this.btnRealizarPix.IconColor = System.Drawing.Color.White;
            this.btnRealizarPix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRealizarPix.IconSize = 38;
            this.btnRealizarPix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarPix.Location = new System.Drawing.Point(0, 260);
            this.btnRealizarPix.Name = "btnRealizarPix";
            this.btnRealizarPix.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.btnRealizarPix.Size = new System.Drawing.Size(220, 60);
            this.btnRealizarPix.TabIndex = 4;
            this.btnRealizarPix.Text = "Pix";
            this.btnRealizarPix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRealizarPix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarPix.UseVisualStyleBackColor = true;
            this.btnRealizarPix.Click += new System.EventHandler(this.btnRealizarPix_Click);
            // 
            // btnSair
            // 
            this.btnSair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnSair.IconColor = System.Drawing.Color.White;
            this.btnSair.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSair.IconSize = 38;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(0, 511);
            this.btnSair.Name = "btnSair";
            this.btnSair.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSair.Size = new System.Drawing.Size(220, 60);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click_1);
            // 
            // btnPix
            // 
            this.btnPix.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPix.FlatAppearance.BorderSize = 0;
            this.btnPix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPix.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.ForeColor = System.Drawing.Color.White;
            this.btnPix.IconChar = FontAwesome.Sharp.IconChar.Pix;
            this.btnPix.IconColor = System.Drawing.Color.White;
            this.btnPix.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPix.IconSize = 38;
            this.btnPix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPix.Location = new System.Drawing.Point(0, 200);
            this.btnPix.Name = "btnPix";
            this.btnPix.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPix.Size = new System.Drawing.Size(220, 60);
            this.btnPix.TabIndex = 2;
            this.btnPix.Text = "Área Pix";
            this.btnPix.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPix.UseVisualStyleBackColor = true;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 38;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 140);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.Location = new System.Drawing.Point(22, 12);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(177, 117);
            this.btnLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogo.TabIndex = 1;
            this.btnLogo.TabStop = false;
            this.btnLogo.Click += new System.EventHandler(this.btnLogo_Click);
            // 
            // minimize
            // 
            this.minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize.BackColor = System.Drawing.Color.MidnightBlue;
            this.minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize.IconSize = 29;
            this.minimize.Location = new System.Drawing.Point(670, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(29, 35);
            this.minimize.TabIndex = 3;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // maximize
            // 
            this.maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize.BackColor = System.Drawing.Color.MidnightBlue;
            this.maximize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.maximize.IconSize = 29;
            this.maximize.Location = new System.Drawing.Point(705, 12);
            this.maximize.Name = "maximize";
            this.maximize.Size = new System.Drawing.Size(32, 35);
            this.maximize.TabIndex = 2;
            this.maximize.TabStop = false;
            this.maximize.Click += new System.EventHandler(this.maximize_Click);
            // 
            // BemVindo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(960, 571);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblSaldo);
            this.Name = "BemVindo";
            this.Text = "BemVindo";
            this.Resize += new System.EventHandler(this.BemVindo_Resize);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnLogo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSair;
        private FontAwesome.Sharp.IconButton btnPix;
        private FontAwesome.Sharp.IconButton btnChaves;
        private FontAwesome.Sharp.IconButton btnRealizarPix;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnExtrato;
        private FontAwesome.Sharp.IconPictureBox minimize;
        private FontAwesome.Sharp.IconPictureBox maximize;
    }
}