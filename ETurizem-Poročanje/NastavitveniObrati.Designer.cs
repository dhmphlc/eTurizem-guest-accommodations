namespace ETurizem_Poročanje
{
    partial class NastavitveniObrati
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NastavitveniObrati));
            this.eturizemDataSet = new ETurizem_Poročanje.eturizemDataSet();
            this.accommodation_facilitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accommodation_facilitiesTableAdapter = new ETurizem_Poročanje.eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter();
            this.tableAdapterManager = new ETurizem_Poročanje.eturizemDataSetTableAdapters.TableAdapterManager();
            this.accommodation_facilitiesDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_facilitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_facilitiesDataGridView)).BeginInit();
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
            // accommodation_facilitiesDataGridView
            // 
            this.accommodation_facilitiesDataGridView.AllowUserToAddRows = false;
            this.accommodation_facilitiesDataGridView.AllowUserToDeleteRows = false;
            this.accommodation_facilitiesDataGridView.AllowUserToResizeRows = false;
            this.accommodation_facilitiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accommodation_facilitiesDataGridView.AutoGenerateColumns = false;
            this.accommodation_facilitiesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.accommodation_facilitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accommodation_facilitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.accommodation_facilitiesDataGridView.DataSource = this.accommodation_facilitiesBindingSource;
            this.accommodation_facilitiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.accommodation_facilitiesDataGridView.Location = new System.Drawing.Point(0, 40);
            this.accommodation_facilitiesDataGridView.Name = "accommodation_facilitiesDataGridView";
            this.accommodation_facilitiesDataGridView.RowTemplate.Height = 30;
            this.accommodation_facilitiesDataGridView.Size = new System.Drawing.Size(884, 500);
            this.accommodation_facilitiesDataGridView.TabIndex = 1;
            this.accommodation_facilitiesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.accommodation_facilitiesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 20F;
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.dataGridViewTextBoxColumn2.FillWeight = 60F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "address";
            this.dataGridViewTextBoxColumn3.FillWeight = 50F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Naslov";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ttax_price";
            this.dataGridViewTextBoxColumn4.FillWeight = 20F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Cena takse (€)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ajpes_id";
            this.dataGridViewTextBoxColumn5.FillWeight = 30F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Reg. št. AJPES";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(3, 8);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(181, 24);
            this.formLabel.TabIndex = 5;
            this.formLabel.Text = "Nastanitveni obrati";
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
            this.deleteUnitBtn.TabIndex = 3;
            this.deleteUnitBtn.UseVisualStyleBackColor = true;
            this.deleteUnitBtn.Click += new System.EventHandler(this.deleteUnitBtn_Click);
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
            this.addUnitButton.TabIndex = 2;
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
            this.refreshBtn.TabIndex = 12;
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // NastavitveniObrati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.formLabel);
            this.Controls.Add(this.deleteUnitBtn);
            this.Controls.Add(this.addUnitButton);
            this.Controls.Add(this.accommodation_facilitiesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NastavitveniObrati";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Nastanitveni obrati";
            this.Load += new System.EventHandler(this.NastavitveniObrati_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eturizemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_facilitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodation_facilitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private eturizemDataSet eturizemDataSet;
        private System.Windows.Forms.BindingSource accommodation_facilitiesBindingSource;
        private eturizemDataSetTableAdapters.accommodation_facilitiesTableAdapter accommodation_facilitiesTableAdapter;
        private eturizemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView accommodation_facilitiesDataGridView;
        private System.Windows.Forms.Button addUnitButton;
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