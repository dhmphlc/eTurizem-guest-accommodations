namespace ETurizem_Poročanje
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.eturizemDataSet = new ETurizem_Poročanje.eturizemDataSet();
            this.accommodation_facilitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accommodation_facilitiesTableAdapter = new ETurizem_Poročanje.eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter();
            this.tableAdapterManager = new ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager();
            this.openFacilitiesBtn = new System.Windows.Forms.Button();
            this.appLabel = new System.Windows.Forms.Label();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openUnitsBtn = new System.Windows.Forms.Button();
            this.openGuestBookBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_facilitiesBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eturizemDataSet
            // 
            this.eturizemDataSet.DataSetName = "eturizemDataSet";
            this.eturizemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accommodation_facilitiesBindingSource
            // 
            this.accommodation_facilitiesBindingSource.DataMember = "accommodation_facilities";
            this.accommodation_facilitiesBindingSource.DataSource = this.eturizemDataSet;
            // 
            // accommodation_facilitiesTableAdapter
            // 
            this.accommodation_facilitiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accommodation_facilitiesTableAdapter = this.accommodation_facilitiesTableAdapter;
            this.tableAdapterManager.accommodation_unitsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.guest_bookTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // openFacilitiesBtn
            // 
            this.openFacilitiesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openFacilitiesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openFacilitiesBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openFacilitiesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openFacilitiesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openFacilitiesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openFacilitiesBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.openFacilitiesBtn.Location = new System.Drawing.Point(18, 18);
            this.openFacilitiesBtn.Name = "openFacilitiesBtn";
            this.openFacilitiesBtn.Size = new System.Drawing.Size(212, 40);
            this.openFacilitiesBtn.TabIndex = 0;
            this.openFacilitiesBtn.Text = "Nastanitveni obrati";
            this.openFacilitiesBtn.UseVisualStyleBackColor = false;
            this.openFacilitiesBtn.Click += new System.EventHandler(this.openFacilitiesBtn_Click);
            // 
            // appLabel
            // 
            this.appLabel.AutoSize = true;
            this.appLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appLabel.Font = new System.Drawing.Font("Young Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.appLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.appLabel.Location = new System.Drawing.Point(34, 6);
            this.appLabel.Name = "appLabel";
            this.appLabel.Size = new System.Drawing.Size(184, 54);
            this.appLabel.TabIndex = 0;
            this.appLabel.Text = "eTurizem";
            this.appLabel.Click += new System.EventHandler(this.appLabel_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.settingsBtn.Image = global::ETurizem_Poročanje.Properties.Resources.gear;
            this.settingsBtn.Location = new System.Drawing.Point(1611, 20);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(40, 40);
            this.settingsBtn.TabIndex = 1;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.panel2.Controls.Add(this.settingsBtn);
            this.panel2.Controls.Add(this.appLabel);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1681, 75);
            this.panel2.TabIndex = 5;
            // 
            // openUnitsBtn
            // 
            this.openUnitsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openUnitsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openUnitsBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openUnitsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openUnitsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openUnitsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openUnitsBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.openUnitsBtn.Location = new System.Drawing.Point(18, 64);
            this.openUnitsBtn.Name = "openUnitsBtn";
            this.openUnitsBtn.Size = new System.Drawing.Size(212, 40);
            this.openUnitsBtn.TabIndex = 1;
            this.openUnitsBtn.Text = "Nastanitvene enote";
            this.openUnitsBtn.UseVisualStyleBackColor = false;
            this.openUnitsBtn.Click += new System.EventHandler(this.openUnitsBtn_Click);
            // 
            // openGuestBookBtn
            // 
            this.openGuestBookBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openGuestBookBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openGuestBookBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.openGuestBookBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.openGuestBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openGuestBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGuestBookBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.openGuestBookBtn.Location = new System.Drawing.Point(18, 110);
            this.openGuestBookBtn.Name = "openGuestBookBtn";
            this.openGuestBookBtn.Size = new System.Drawing.Size(212, 40);
            this.openGuestBookBtn.TabIndex = 2;
            this.openGuestBookBtn.Text = "Knjiga gostov";
            this.openGuestBookBtn.UseVisualStyleBackColor = false;
            this.openGuestBookBtn.Click += new System.EventHandler(this.openGuestBookBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(131)))), ((int)(((byte)(195)))));
            this.panel1.Controls.Add(this.openGuestBookBtn);
            this.panel1.Controls.Add(this.openUnitsBtn);
            this.panel1.Controls.Add(this.openFacilitiesBtn);
            this.panel1.Location = new System.Drawing.Point(2, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(248, 729);
            this.panel1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1683, 804);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(250, 75, 0, 0);
            this.Text = "e-Turizem poročanje";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_facilitiesBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private eturizemDataSet eturizemDataSet;
        private System.Windows.Forms.BindingSource accommodation_facilitiesBindingSource;
        private eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter accommodation_facilitiesTableAdapter;
        private eturizemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button openFacilitiesBtn;
        private System.Windows.Forms.Label appLabel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button openUnitsBtn;
        private System.Windows.Forms.Button openGuestBookBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

