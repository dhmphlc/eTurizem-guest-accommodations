namespace ETurizem_Poročanje
{
    partial class NastavitveneEnote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NastavitveneEnote));
            this.eturizemDataSet = new ETurizem_Poročanje.eturizemDataSet();
            this.accommodation_unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accommodation_unitsTableAdapter = new ETurizem_Poročanje.eturizemDataSetTableAdapters.accommodation_unitsTableAdapter();
            this.tableAdapterManager = new ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager();
            this.accommodation_unitsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formLabel = new System.Windows.Forms.Label();
            this.deleteUnitBtn = new System.Windows.Forms.Button();
            this.addUnitButton = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_unitsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_unitsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // eturizemDataSet
            // 
            this.eturizemDataSet.DataSetName = "eturizemDataSet";
            this.eturizemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accommodation_unitsBindingSource
            // 
            this.accommodation_unitsBindingSource.DataMember = "accommodation_units";
            this.accommodation_unitsBindingSource.DataSource = this.eturizemDataSet;
            // 
            // accommodation_unitsTableAdapter
            // 
            this.accommodation_unitsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accommodation_facilitiesTableAdapter = null;
            this.tableAdapterManager.accommodation_unitsTableAdapter = this.accommodation_unitsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.guest_bookTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accommodation_unitsDataGridView
            // 
            this.accommodation_unitsDataGridView.AllowUserToAddRows = false;
            this.accommodation_unitsDataGridView.AllowUserToDeleteRows = false;
            this.accommodation_unitsDataGridView.AllowUserToResizeRows = false;
            this.accommodation_unitsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accommodation_unitsDataGridView.AutoGenerateColumns = false;
            this.accommodation_unitsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accommodation_unitsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.accommodation_unitsDataGridView.DataSource = this.accommodation_unitsBindingSource;
            this.accommodation_unitsDataGridView.Location = new System.Drawing.Point(0, 40);
            this.accommodation_unitsDataGridView.Name = "accommodation_unitsDataGridView";
            this.accommodation_unitsDataGridView.RowTemplate.Height = 30;
            this.accommodation_unitsDataGridView.Size = new System.Drawing.Size(884, 500);
            this.accommodation_unitsDataGridView.TabIndex = 3;
            this.accommodation_unitsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accommodation_unitsDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "accommodation_facility";
            this.dataGridViewTextBoxColumn2.HeaderText = "accommodation_facility";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "capacity";
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Število ležišč";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price_per_night";
            this.dataGridViewTextBoxColumn5.FillWeight = 30F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Cena nočitve (€)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(3, 8);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(189, 24);
            this.formLabel.TabIndex = 7;
            this.formLabel.Text = "Nastanitvene enote";
            // 
            // deleteUnitBtn
            // 
            this.deleteUnitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteUnitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUnitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUnitBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteUnitBtn.Image")));
            this.deleteUnitBtn.Location = new System.Drawing.Point(816, 7);
            this.deleteUnitBtn.Name = "deleteUnitBtn";
            this.deleteUnitBtn.Size = new System.Drawing.Size(25, 25);
            this.deleteUnitBtn.TabIndex = 4;
            this.deleteUnitBtn.UseVisualStyleBackColor = true;
            this.deleteUnitBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // addUnitButton
            // 
            this.addUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUnitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUnitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUnitButton.Image = ((System.Drawing.Image)(resources.GetObject("addUnitButton.Image")));
            this.addUnitButton.Location = new System.Drawing.Point(847, 7);
            this.addUnitButton.Name = "addUnitButton";
            this.addUnitButton.Size = new System.Drawing.Size(25, 25);
            this.addUnitButton.TabIndex = 3;
            this.addUnitButton.UseVisualStyleBackColor = true;
            this.addUnitButton.Click += new System.EventHandler(this.addUnitButton_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshBtn.Image = global::ETurizem_Poročanje.Properties.Resources.refresh_page_option;
            this.refreshBtn.Location = new System.Drawing.Point(785, 7);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(25, 25);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // NastavitveneEnote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.deleteUnitBtn);
            this.Controls.Add(this.addUnitButton);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.accommodation_unitsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NastavitveneEnote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Nastavitvene enote";
            this.Load += new System.EventHandler(this.NastavitveneEnote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_unitsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_unitsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eturizemDataSet eturizemDataSet;
        private System.Windows.Forms.BindingSource accommodation_unitsBindingSource;
        private eturizemDataSetTableAdapters.accommodation_unitsTableAdapter accommodation_unitsTableAdapter;
        private eturizemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button addUnitButton;
        private System.Windows.Forms.DataGridView accommodation_unitsDataGridView;
        private System.Windows.Forms.Button deleteUnitBtn;
        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button refreshBtn;
    }
}