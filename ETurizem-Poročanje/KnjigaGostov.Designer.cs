namespace ETurizem_Poročanje
{
    partial class KnjigaGostov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KnjigaGostov));
            this.guest_bookDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canceled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guest_bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eturizemDataSet = new ETurizem_Poročanje.eturizemDataSet();
            this.formLabel = new System.Windows.Forms.Label();
            this.guest_bookTableAdapter = new ETurizem_Poročanje.eturizemDataSetTableAdapters.guest_bookTableAdapter();
            this.tableAdapterManager = new ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.cancelGuestBtn = new System.Windows.Forms.Button();
            this.btnExportGuests = new System.Windows.Forms.Button();
            this.addGuestButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guest_bookDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guest_bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guest_bookDataGridView
            // 
            this.guest_bookDataGridView.AllowUserToAddRows = false;
            this.guest_bookDataGridView.AllowUserToDeleteRows = false;
            this.guest_bookDataGridView.AllowUserToResizeRows = false;
            this.guest_bookDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guest_bookDataGridView.AutoGenerateColumns = false;
            this.guest_bookDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guest_bookDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.canceled,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.guest_bookDataGridView.DataSource = this.guest_bookBindingSource;
            this.guest_bookDataGridView.Location = new System.Drawing.Point(0, 40);
            this.guest_bookDataGridView.Name = "guest_bookDataGridView";
            this.guest_bookDataGridView.RowTemplate.Height = 30;
            this.guest_bookDataGridView.Size = new System.Drawing.Size(884, 500);
            this.guest_bookDataGridView.TabIndex = 1;
            this.guest_bookDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guest_bookDataGridView_CellContentDoubleClick);
            this.guest_bookDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.guest_bookDataGridView_CellFormatting);
            this.guest_bookDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.guest_bookDataGridView_RowPrePaint);
            this.guest_bookDataGridView.SelectionChanged += new System.EventHandler(this.guest_bookDataGridView_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 30F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // canceled
            // 
            this.canceled.DataPropertyName = "canceled";
            this.canceled.HeaderText = "canceled";
            this.canceled.Name = "canceled";
            this.canceled.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.FillWeight = 70F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Ime";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 49;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn3.FillWeight = 70F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Priimek";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "country";
            this.dataGridViewTextBoxColumn4.FillWeight = 70F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Država";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date_of_birth";
            this.dataGridViewTextBoxColumn5.FillWeight = 70F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Datum rojstva";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn6.FillWeight = 40F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Spol";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 53;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "document_type";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tip dokumenta";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "document_number";
            this.dataGridViewTextBoxColumn8.HeaderText = "Številka dokumenta";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "date_arrival";
            this.dataGridViewTextBoxColumn9.HeaderText = "Datum prihoda";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "time_arrival";
            this.dataGridViewTextBoxColumn10.FillWeight = 50F;
            this.dataGridViewTextBoxColumn10.HeaderText = "Ura prihoda";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date_departure";
            this.dataGridViewTextBoxColumn11.HeaderText = "Datum odhoda";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "time_departure";
            this.dataGridViewTextBoxColumn12.FillWeight = 50F;
            this.dataGridViewTextBoxColumn12.HeaderText = "Ura odhoda";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 81;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn13.DataPropertyName = "ttax_type";
            this.dataGridViewTextBoxColumn13.HeaderText = "Tip turistične takse";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 111;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "accommodation_unit";
            this.dataGridViewTextBoxColumn14.HeaderText = "Enota";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "ajpes_sending_state";
            this.dataGridViewTextBoxColumn15.HeaderText = "ajpes_sending_state";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Visible = false;
            // 
            // guest_bookBindingSource
            // 
            this.guest_bookBindingSource.DataMember = "guest_book";
            this.guest_bookBindingSource.DataSource = this.eturizemDataSet;
            // 
            // eturizemDataSet
            // 
            this.eturizemDataSet.DataSetName = "eturizemDataSet";
            this.eturizemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(3, 8);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(135, 24);
            this.formLabel.TabIndex = 8;
            this.formLabel.Text = "Knjiga gostov";
            // 
            // guest_bookTableAdapter
            // 
            this.guest_bookTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accommodation_facilitiesTableAdapter = null;
            this.tableAdapterManager.accommodation_unitsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.guest_bookTableAdapter = this.guest_bookTableAdapter;
            this.tableAdapterManager.UpdateOrder = ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = global::ETurizem_Poročanje.Properties.Resources.refresh_page_option;
            this.refreshBtn.Location = new System.Drawing.Point(754, 8);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(25, 25);
            this.refreshBtn.TabIndex = 10;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // cancelGuestBtn
            // 
            this.cancelGuestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelGuestBtn.Image = global::ETurizem_Poročanje.Properties.Resources.close;
            this.cancelGuestBtn.Location = new System.Drawing.Point(816, 7);
            this.cancelGuestBtn.Name = "cancelGuestBtn";
            this.cancelGuestBtn.Size = new System.Drawing.Size(25, 25);
            this.cancelGuestBtn.TabIndex = 9;
            this.cancelGuestBtn.UseVisualStyleBackColor = true;
            this.cancelGuestBtn.Click += new System.EventHandler(this.cancelGuestBtn_Click);
            // 
            // btnExportGuests
            // 
            this.btnExportGuests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportGuests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportGuests.Image = ((System.Drawing.Image)(resources.GetObject("btnExportGuests.Image")));
            this.btnExportGuests.Location = new System.Drawing.Point(785, 8);
            this.btnExportGuests.Name = "btnExportGuests";
            this.btnExportGuests.Size = new System.Drawing.Size(25, 25);
            this.btnExportGuests.TabIndex = 5;
            this.btnExportGuests.Tag = "";
            this.btnExportGuests.UseVisualStyleBackColor = true;
            this.btnExportGuests.Click += new System.EventHandler(this.btnExportGuests_Click);
            // 
            // addGuestButton
            // 
            this.addGuestButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addGuestButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGuestButton.Image = ((System.Drawing.Image)(resources.GetObject("addGuestButton.Image")));
            this.addGuestButton.Location = new System.Drawing.Point(847, 7);
            this.addGuestButton.Name = "addGuestButton";
            this.addGuestButton.Size = new System.Drawing.Size(25, 25);
            this.addGuestButton.TabIndex = 4;
            this.addGuestButton.UseVisualStyleBackColor = true;
            this.addGuestButton.Click += new System.EventHandler(this.addGuestButton_Click);
            // 
            // KnjigaGostov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.cancelGuestBtn);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.btnExportGuests);
            this.Controls.Add(this.addGuestButton);
            this.Controls.Add(this.guest_bookDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KnjigaGostov";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Knjiga gostov";
            this.Load += new System.EventHandler(this.KnjigaGostov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guest_bookDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guest_bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eturizemDataSet eturizemDataSet;
        private System.Windows.Forms.BindingSource guest_bookBindingSource;
        private eturizemDataSetTableAdapters.guest_bookTableAdapter guest_bookTableAdapter;
        private eturizemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView guest_bookDataGridView;
        private System.Windows.Forms.Button addGuestButton;
        private System.Windows.Forms.Button btnExportGuests;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Button cancelGuestBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn canceled;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.Button refreshBtn;
    }
}