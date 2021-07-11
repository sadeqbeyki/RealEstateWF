
namespace RealEstate
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgRealEstate = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squareMetersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sellerMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estateTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.realState_DBDataSet = new RealEstate.RealState_DBDataSet();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.editLable = new System.Windows.Forms.ToolStripLabel();
            this.deleteLable = new System.Windows.Forms.ToolStripLabel();
            this.tsUpdate = new System.Windows.Forms.ToolStripButton();
            this.estateTableTableAdapter = new RealEstate.RealState_DBDataSetTableAdapters.EstateTableTableAdapter();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRealEstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realState_DBDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgRealEstate);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(700, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فهرست املاک";
            // 
            // dgRealEstate
            // 
            this.dgRealEstate.AllowUserToAddRows = false;
            this.dgRealEstate.AllowUserToDeleteRows = false;
            this.dgRealEstate.AutoGenerateColumns = false;
            this.dgRealEstate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRealEstate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRealEstate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.squareMetersDataGridViewTextBoxColumn,
            this.optionsDataGridViewTextBoxColumn,
            this.sellerNameDataGridViewTextBoxColumn,
            this.sellerMobileDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgRealEstate.DataSource = this.estateTableBindingSource;
            this.dgRealEstate.Location = new System.Drawing.Point(6, 20);
            this.dgRealEstate.Name = "dgRealEstate";
            this.dgRealEstate.ReadOnly = true;
            this.dgRealEstate.Size = new System.Drawing.Size(688, 196);
            this.dgRealEstate.TabIndex = 0;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "ردیف";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "نوع ملک";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // squareMetersDataGridViewTextBoxColumn
            // 
            this.squareMetersDataGridViewTextBoxColumn.DataPropertyName = "SquareMeters";
            this.squareMetersDataGridViewTextBoxColumn.HeaderText = "متراژ";
            this.squareMetersDataGridViewTextBoxColumn.Name = "squareMetersDataGridViewTextBoxColumn";
            this.squareMetersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // optionsDataGridViewTextBoxColumn
            // 
            this.optionsDataGridViewTextBoxColumn.DataPropertyName = "Options";
            this.optionsDataGridViewTextBoxColumn.HeaderText = "گزینه ها";
            this.optionsDataGridViewTextBoxColumn.Name = "optionsDataGridViewTextBoxColumn";
            this.optionsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerNameDataGridViewTextBoxColumn
            // 
            this.sellerNameDataGridViewTextBoxColumn.DataPropertyName = "SellerName";
            this.sellerNameDataGridViewTextBoxColumn.HeaderText = "نام فروشنده";
            this.sellerNameDataGridViewTextBoxColumn.Name = "sellerNameDataGridViewTextBoxColumn";
            this.sellerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sellerMobileDataGridViewTextBoxColumn
            // 
            this.sellerMobileDataGridViewTextBoxColumn.DataPropertyName = "SellerMobile";
            this.sellerMobileDataGridViewTextBoxColumn.HeaderText = "موبایل فروشنده";
            this.sellerMobileDataGridViewTextBoxColumn.Name = "sellerMobileDataGridViewTextBoxColumn";
            this.sellerMobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "قیمت";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estateTableBindingSource
            // 
            this.estateTableBindingSource.DataMember = "EstateTable";
            this.estateTableBindingSource.DataSource = this.realState_DBDataSet;
            // 
            // realState_DBDataSet
            // 
            this.realState_DBDataSet.DataSetName = "RealState_DBDataSet";
            this.realState_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.editLable,
            this.deleteLable,
            this.tsUpdate});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(724, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsAdd
            // 
            this.tsAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsAdd.Image")));
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(44, 22);
            this.tsAdd.Text = "افزودن";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // editLable
            // 
            this.editLable.Name = "editLable";
            this.editLable.Size = new System.Drawing.Size(43, 22);
            this.editLable.Text = "ویرایش";
            this.editLable.Click += new System.EventHandler(this.editLable_Click);
            // 
            // deleteLable
            // 
            this.deleteLable.Name = "deleteLable";
            this.deleteLable.Size = new System.Drawing.Size(32, 22);
            this.deleteLable.Text = "حذف";
            this.deleteLable.Click += new System.EventHandler(this.deleteLable_Click);
            // 
            // tsUpdate
            // 
            this.tsUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsUpdate.Image = ((System.Drawing.Image)(resources.GetObject("tsUpdate.Image")));
            this.tsUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUpdate.Name = "tsUpdate";
            this.tsUpdate.Size = new System.Drawing.Size(60, 22);
            this.tsUpdate.Text = "بروزرسانی";
            this.tsUpdate.Click += new System.EventHandler(this.tsUpdate_Click);
            // 
            // estateTableTableAdapter
            // 
            this.estateTableTableAdapter.ClearBeforeFill = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(35, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(328, 21);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearchX_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(700, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(424, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ابتدا نوع ملک و سپس نام مالک را وارد نمایید";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 388);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHome";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مشاورین املاک";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRealEstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estateTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realState_DBDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsUpdate;
        private System.Windows.Forms.DataGridView dgRealEstate;
        private RealState_DBDataSet realState_DBDataSet;
        private System.Windows.Forms.BindingSource estateTableBindingSource;
        private RealState_DBDataSetTableAdapters.EstateTableTableAdapter estateTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn squareMetersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripLabel editLable;
        private System.Windows.Forms.ToolStripLabel deleteLable;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

