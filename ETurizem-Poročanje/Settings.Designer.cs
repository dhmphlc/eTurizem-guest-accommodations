namespace ETurizem_Poročanje
{
    partial class Settings
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
            this.usernameLbl = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shraniBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.databaseLbl = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.hostLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trustServerCertCheckBox = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(14, 137);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(89, 13);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Uporabniško ime:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(17, 154);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(142, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(14, 177);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(37, 13);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Geslo:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(17, 194);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(142, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Podatki za dostop do baze";
            // 
            // shraniBtn
            // 
            this.shraniBtn.Location = new System.Drawing.Point(17, 243);
            this.shraniBtn.Name = "shraniBtn";
            this.shraniBtn.Size = new System.Drawing.Size(75, 23);
            this.shraniBtn.TabIndex = 6;
            this.shraniBtn.Text = "Shrani";
            this.shraniBtn.UseVisualStyleBackColor = true;
            this.shraniBtn.Click += new System.EventHandler(this.shraniBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(372, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(17, 114);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(142, 20);
            this.txtDatabaseName.TabIndex = 2;
            // 
            // databaseLbl
            // 
            this.databaseLbl.AutoSize = true;
            this.databaseLbl.Location = new System.Drawing.Point(14, 97);
            this.databaseLbl.Name = "databaseLbl";
            this.databaseLbl.Size = new System.Drawing.Size(113, 13);
            this.databaseLbl.TabIndex = 7;
            this.databaseLbl.Text = "Ime podatkovne baze:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(17, 74);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(142, 20);
            this.txtHost.TabIndex = 1;
            this.txtHost.Tag = "";
            // 
            // hostLbl
            // 
            this.hostLbl.AutoSize = true;
            this.hostLbl.Location = new System.Drawing.Point(14, 45);
            this.hostLbl.Name = "hostLbl";
            this.hostLbl.Size = new System.Drawing.Size(32, 13);
            this.hostLbl.TabIndex = 9;
            this.hostLbl.Text = "Host:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "localhost, 192.168.0.156";
            // 
            // trustServerCertCheckBox
            // 
            this.trustServerCertCheckBox.AutoSize = true;
            this.trustServerCertCheckBox.Location = new System.Drawing.Point(17, 220);
            this.trustServerCertCheckBox.Name = "trustServerCertCheckBox";
            this.trustServerCertCheckBox.Size = new System.Drawing.Size(131, 17);
            this.trustServerCertCheckBox.TabIndex = 5;
            this.trustServerCertCheckBox.Text = "Trust server certificate";
            this.trustServerCertCheckBox.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 361);
            this.Controls.Add(this.trustServerCertCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.hostLbl);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.databaseLbl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.shraniBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.usernameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button shraniBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label databaseLbl;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label hostLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox trustServerCertCheckBox;
    }
}