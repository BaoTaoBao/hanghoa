namespace TangTanBao_HangHoa
{
    partial class Fromhanghoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fromhanghoa));
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButtonThem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLuu = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewMH = new System.Windows.Forms.DataGridView();
            this.maHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCongTyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hinhAnhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLBHDataSet = new TangTanBao_HangHoa.QLBHDataSet();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mATHANGTableAdapter = new TangTanBao_HangHoa.QLBHDataSetTableAdapters.MATHANGTableAdapter();
            this.qLBHDataSet1 = new TangTanBao_HangHoa.QLBHDataSet1();
            this.mATHANGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mATHANGTableAdapter1 = new TangTanBao_HangHoa.QLBHDataSet1TableAdapters.MATHANGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txttongtien
            // 
            this.txttongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttongtien.Location = new System.Drawing.Point(724, 448);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(164, 26);
            this.txttongtien.TabIndex = 34;
            this.txttongtien.TextChanged += new System.EventHandler(this.txttongtien_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(635, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tổng Tiền:";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.Color.Pink;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonThem,
            this.toolStripButtonXoa,
            this.toolStripButtonLuu});
            this.bindingNavigator1.Location = new System.Drawing.Point(405, 126);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(159, 43);
            this.bindingNavigator1.TabIndex = 32;
            this.bindingNavigator1.Text = "Lưu Hóa Đơn";
            // 
            // toolStripButtonThem
            // 
            this.toolStripButtonThem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonThem.Image")));
            this.toolStripButtonThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonThem.Name = "toolStripButtonThem";
            this.toolStripButtonThem.Size = new System.Drawing.Size(57, 40);
            this.toolStripButtonThem.Text = "Thêm ";
            this.toolStripButtonThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonXoa
            // 
            this.toolStripButtonXoa.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonXoa.Image")));
            this.toolStripButtonXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonXoa.Name = "toolStripButtonXoa";
            this.toolStripButtonXoa.Size = new System.Drawing.Size(46, 40);
            this.toolStripButtonXoa.Text = "Xóa ";
            this.toolStripButtonXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButtonLuu
            // 
            this.toolStripButtonLuu.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLuu.Image")));
            this.toolStripButtonLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLuu.Name = "toolStripButtonLuu";
            this.toolStripButtonLuu.Size = new System.Drawing.Size(44, 40);
            this.toolStripButtonLuu.Text = "Lưu ";
            this.toolStripButtonLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridViewMH
            // 
            this.dataGridViewMH.AutoGenerateColumns = false;
            this.dataGridViewMH.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridViewMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHangDataGridViewTextBoxColumn,
            this.tenHangDataGridViewTextBoxColumn,
            this.maCongTyDataGridViewTextBoxColumn,
            this.maLoaiHangDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.donViTinhDataGridViewTextBoxColumn,
            this.giaHangDataGridViewTextBoxColumn,
            this.hinhAnhDataGridViewTextBoxColumn});
            this.dataGridViewMH.DataSource = this.mATHANGBindingSource1;
            this.dataGridViewMH.Location = new System.Drawing.Point(34, 208);
            this.dataGridViewMH.Name = "dataGridViewMH";
            this.dataGridViewMH.Size = new System.Drawing.Size(852, 225);
            this.dataGridViewMH.TabIndex = 31;
            // 
            // maHangDataGridViewTextBoxColumn
            // 
            this.maHangDataGridViewTextBoxColumn.DataPropertyName = "MaHang";
            this.maHangDataGridViewTextBoxColumn.HeaderText = "MaHang";
            this.maHangDataGridViewTextBoxColumn.Name = "maHangDataGridViewTextBoxColumn";
            // 
            // tenHangDataGridViewTextBoxColumn
            // 
            this.tenHangDataGridViewTextBoxColumn.DataPropertyName = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.HeaderText = "TenHang";
            this.tenHangDataGridViewTextBoxColumn.Name = "tenHangDataGridViewTextBoxColumn";
            // 
            // maCongTyDataGridViewTextBoxColumn
            // 
            this.maCongTyDataGridViewTextBoxColumn.DataPropertyName = "MaCongTy";
            this.maCongTyDataGridViewTextBoxColumn.HeaderText = "MaCongTy";
            this.maCongTyDataGridViewTextBoxColumn.Name = "maCongTyDataGridViewTextBoxColumn";
            // 
            // maLoaiHangDataGridViewTextBoxColumn
            // 
            this.maLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.HeaderText = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.Name = "maLoaiHangDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // donViTinhDataGridViewTextBoxColumn
            // 
            this.donViTinhDataGridViewTextBoxColumn.DataPropertyName = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.HeaderText = "DonViTinh";
            this.donViTinhDataGridViewTextBoxColumn.Name = "donViTinhDataGridViewTextBoxColumn";
            // 
            // giaHangDataGridViewTextBoxColumn
            // 
            this.giaHangDataGridViewTextBoxColumn.DataPropertyName = "GiaHang";
            this.giaHangDataGridViewTextBoxColumn.HeaderText = "GiaHang";
            this.giaHangDataGridViewTextBoxColumn.Name = "giaHangDataGridViewTextBoxColumn";
            // 
            // hinhAnhDataGridViewTextBoxColumn
            // 
            this.hinhAnhDataGridViewTextBoxColumn.DataPropertyName = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.HeaderText = "HinhAnh";
            this.hinhAnhDataGridViewTextBoxColumn.Name = "hinhAnhDataGridViewTextBoxColumn";
            // 
            // mATHANGBindingSource
            // 
            this.mATHANGBindingSource.DataMember = "MATHANG";
            this.mATHANGBindingSource.DataSource = this.qLBHDataSet;
            // 
            // qLBHDataSet
            // 
            this.qLBHDataSet.DataSetName = "QLBHDataSet";
            this.qLBHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiHang.Location = new System.Drawing.Point(572, 60);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(131, 26);
            this.txtLoaiHang.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(480, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Loại Hàng:";
            // 
            // txtMaLH
            // 
            this.txtMaLH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLH.Location = new System.Drawing.Point(321, 60);
            this.txtMaLH.Name = "txtMaLH";
            this.txtMaLH.Size = new System.Drawing.Size(133, 26);
            this.txtMaLH.TabIndex = 28;
            this.txtMaLH.TextChanged += new System.EventHandler(this.txtMaLH_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Mã LH:";
            // 
            // mATHANGTableAdapter
            // 
            this.mATHANGTableAdapter.ClearBeforeFill = true;
            // 
            // qLBHDataSet1
            // 
            this.qLBHDataSet1.DataSetName = "QLBHDataSet1";
            this.qLBHDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mATHANGBindingSource1
            // 
            this.mATHANGBindingSource1.DataMember = "MATHANG";
            this.mATHANGBindingSource1.DataSource = this.qLBHDataSet1;
            // 
            // mATHANGTableAdapter1
            // 
            this.mATHANGTableAdapter1.ClearBeforeFill = true;
            // 
            // Fromhanghoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(922, 534);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridViewMH);
            this.Controls.Add(this.txtLoaiHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLH);
            this.Controls.Add(this.label1);
            this.Name = "Fromhanghoa";
            this.Text = "Fromhanghoa";
            this.Load += new System.EventHandler(this.Fromhanghoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLBHDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mATHANGBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonThem;
        private System.Windows.Forms.ToolStripButton toolStripButtonXoa;
        private System.Windows.Forms.ToolStripButton toolStripButtonLuu;
        private System.Windows.Forms.DataGridView dataGridViewMH;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLH;
        private System.Windows.Forms.Label label1;
        private QLBHDataSet qLBHDataSet;
        private System.Windows.Forms.BindingSource mATHANGBindingSource;
        private QLBHDataSetTableAdapters.MATHANGTableAdapter mATHANGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCongTyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hinhAnhDataGridViewTextBoxColumn;
        private QLBHDataSet1 qLBHDataSet1;
        private System.Windows.Forms.BindingSource mATHANGBindingSource1;
        private QLBHDataSet1TableAdapters.MATHANGTableAdapter mATHANGTableAdapter1;
    }
}