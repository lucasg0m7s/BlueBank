namespace BlueBank.Apresentacao
{
    partial class AreaPix
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AreaPix));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPix = new System.Windows.Forms.Button();
            this.btnChaves = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Área pix";
            // 
            // btnPix
            // 
            this.btnPix.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnPix.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPix.Location = new System.Drawing.Point(64, 106);
            this.btnPix.Name = "btnPix";
            this.btnPix.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnPix.Size = new System.Drawing.Size(169, 32);
            this.btnPix.TabIndex = 5;
            this.btnPix.Text = "Pix";
            this.btnPix.UseVisualStyleBackColor = false;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // btnChaves
            // 
            this.btnChaves.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnChaves.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChaves.Location = new System.Drawing.Point(64, 153);
            this.btnChaves.Name = "btnChaves";
            this.btnChaves.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnChaves.Size = new System.Drawing.Size(169, 32);
            this.btnChaves.TabIndex = 6;
            this.btnChaves.Text = "Minhas Chaves";
            this.btnChaves.UseVisualStyleBackColor = false;
            this.btnChaves.Click += new System.EventHandler(this.btnChaves_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AreaPix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(500, 259);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChaves);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AreaPix";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pix";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPix;
        private System.Windows.Forms.Button btnChaves;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}