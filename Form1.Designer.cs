namespace Updater
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(components);
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            pictureBox1 = new PictureBox();
            metroLabel2 = new MetroFramework.Controls.MetroLabel();
            statusLabel = new MetroFramework.Controls.MetroLabel();
            versionLabel = new MetroFramework.Controls.MetroLabel();
            metroLabel4 = new MetroFramework.Controls.MetroLabel();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            foundupdateLabel = new MetroFramework.Controls.MetroLabel();
            metroLabel8 = new MetroFramework.Controls.MetroLabel();
            developerLabel = new MetroFramework.Controls.MetroLabel();
            metroButton1 = new MetroFramework.Controls.MetroButton();
            metroLabel3 = new MetroFramework.Controls.MetroLabel();
            metroLabel5 = new MetroFramework.Controls.MetroLabel();
            downloadBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)metroStyleManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // metroStyleManager1
            // 
            metroStyleManager1.Owner = this;
            metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel1
            // 
            metroLabel1.AutoSize = true;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new Point(341, 47);
            metroLabel1.Margin = new Padding(4, 0, 4, 0);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new Size(139, 25);
            metroLabel1.TabIndex = 0;
            metroLabel1.Text = "HvH | Multi Tool";
            metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 6);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(276, 310);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            metroLabel2.AutoSize = true;
            metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel2.Location = new Point(341, 145);
            metroLabel2.Margin = new Padding(4, 0, 4, 0);
            metroLabel2.Name = "metroLabel2";
            metroLabel2.Size = new Size(64, 25);
            metroLabel2.TabIndex = 2;
            metroLabel2.Text = "Status:";
            metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            statusLabel.ForeColor = Color.GreenYellow;
            statusLabel.Location = new Point(410, 151);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(80, 19);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Undetected";
            // 
            // versionLabel
            // 
            versionLabel.AutoSize = true;
            versionLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            versionLabel.ForeColor = Color.Black;
            versionLabel.Location = new Point(421, 104);
            versionLabel.Margin = new Padding(4, 0, 4, 0);
            versionLabel.Name = "versionLabel";
            versionLabel.Size = new Size(16, 19);
            versionLabel.TabIndex = 5;
            versionLabel.Text = "v";
            // 
            // metroLabel4
            // 
            metroLabel4.AutoSize = true;
            metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel4.Location = new Point(341, 99);
            metroLabel4.Margin = new Padding(4, 0, 4, 0);
            metroLabel4.Name = "metroLabel4";
            metroLabel4.Size = new Size(74, 25);
            metroLabel4.TabIndex = 4;
            metroLabel4.Text = "Version:";
            metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel6.Location = new Point(341, 189);
            metroLabel6.Margin = new Padding(4, 0, 4, 0);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new Size(97, 25);
            metroLabel6.TabIndex = 6;
            metroLabel6.Text = "Developer:";
            metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // foundupdateLabel
            // 
            foundupdateLabel.AutoSize = true;
            foundupdateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            foundupdateLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            foundupdateLabel.ForeColor = Color.GreenYellow;
            foundupdateLabel.Location = new Point(446, 262);
            foundupdateLabel.Margin = new Padding(4, 0, 4, 0);
            foundupdateLabel.Name = "foundupdateLabel";
            foundupdateLabel.Size = new Size(156, 25);
            foundupdateLabel.TabIndex = 9;
            foundupdateLabel.Text = "No Update found.";
            foundupdateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            metroLabel8.AutoSize = true;
            metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel8.Location = new Point(341, 263);
            metroLabel8.Margin = new Padding(4, 0, 4, 0);
            metroLabel8.Name = "metroLabel8";
            metroLabel8.Size = new Size(90, 25);
            metroLabel8.TabIndex = 8;
            metroLabel8.Text = "Updates...";
            metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // developerLabel
            // 
            developerLabel.AutoSize = true;
            developerLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            developerLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            developerLabel.ForeColor = Color.GreenYellow;
            developerLabel.Location = new Point(447, 189);
            developerLabel.Margin = new Padding(4, 0, 4, 0);
            developerLabel.Name = "developerLabel";
            developerLabel.Size = new Size(65, 25);
            developerLabel.TabIndex = 7;
            developerLabel.Text = "bhop3";
            developerLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton1
            // 
            metroButton1.Location = new Point(602, 104);
            metroButton1.Margin = new Padding(4, 3, 4, 3);
            metroButton1.Name = "metroButton1";
            metroButton1.Size = new Size(113, 29);
            metroButton1.Style = MetroFramework.MetroColorStyle.Black;
            metroButton1.TabIndex = 10;
            metroButton1.Text = "Update";
            metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroButton1.UseSelectable = true;
            metroButton1.Click += metroButton1_Click;
            // 
            // metroLabel3
            // 
            metroLabel3.AutoSize = true;
            metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel3.ForeColor = Color.Black;
            metroLabel3.Location = new Point(410, 228);
            metroLabel3.Margin = new Padding(4, 0, 4, 0);
            metroLabel3.Name = "metroLabel3";
            metroLabel3.Size = new Size(127, 19);
            metroLabel3.TabIndex = 12;
            metroLabel3.Text = "https://xyzshop.org";
            // 
            // metroLabel5
            // 
            metroLabel5.AutoSize = true;
            metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel5.Location = new Point(341, 224);
            metroLabel5.Margin = new Padding(4, 0, 4, 0);
            metroLabel5.Name = "metroLabel5";
            metroLabel5.Size = new Size(64, 25);
            metroLabel5.TabIndex = 11;
            metroLabel5.Text = "Status:";
            metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // downloadBtn
            // 
            downloadBtn.Location = new Point(602, 170);
            downloadBtn.Margin = new Padding(4, 3, 4, 3);
            downloadBtn.Name = "downloadBtn";
            downloadBtn.Size = new Size(113, 29);
            downloadBtn.Style = MetroFramework.MetroColorStyle.Black;
            downloadBtn.TabIndex = 13;
            downloadBtn.Text = "Download";
            downloadBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            downloadBtn.UseSelectable = true;
            downloadBtn.Click += downloadBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 315);
            Controls.Add(downloadBtn);
            Controls.Add(metroLabel3);
            Controls.Add(metroLabel5);
            Controls.Add(metroButton1);
            Controls.Add(foundupdateLabel);
            Controls.Add(metroLabel8);
            Controls.Add(developerLabel);
            Controls.Add(metroLabel6);
            Controls.Add(versionLabel);
            Controls.Add(metroLabel4);
            Controls.Add(statusLabel);
            Controls.Add(metroLabel2);
            Controls.Add(pictureBox1);
            Controls.Add(metroLabel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Opacity = 0.7D;
            Padding = new Padding(23, 69, 23, 23);
            Resizable = false;
            Style = MetroFramework.MetroColorStyle.Black;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)metroStyleManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel statusLabel;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel versionLabel;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel foundupdateLabel;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel developerLabel;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton downloadBtn;
    }
}

