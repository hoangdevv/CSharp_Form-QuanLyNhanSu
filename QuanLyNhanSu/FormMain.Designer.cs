namespace QuanLyNhanSu
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIManagerAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemManager = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIManagerStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMIManagerDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemStatistical = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSuport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFix = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dateTimeBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbbSex = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.employeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSystem,
            this.ToolStripMenuItemManager,
            this.ToolStripMenuItemStatistical,
            this.ToolStripMenuItemSuport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemSystem
            // 
            this.ToolStripMenuItemSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIManagerAccount,
            this.toolStripSeparator1,
            this.MenuItemLogout});
            this.ToolStripMenuItemSystem.Name = "ToolStripMenuItemSystem";
            this.ToolStripMenuItemSystem.Size = new System.Drawing.Size(69, 20);
            this.ToolStripMenuItemSystem.Text = "Hệ thống";
            // 
            // tSMIManagerAccount
            // 
            this.tSMIManagerAccount.Name = "tSMIManagerAccount";
            this.tSMIManagerAccount.Size = new System.Drawing.Size(167, 22);
            this.tSMIManagerAccount.Text = "Quản lý tài khoản";
            this.tSMIManagerAccount.Click += new System.EventHandler(this.tSMIManagerAccount_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(167, 22);
            this.MenuItemLogout.Text = "Đăng xuất";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // ToolStripMenuItemManager
            // 
            this.ToolStripMenuItemManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMIManagerStaff,
            this.tSMIManagerDepartment});
            this.ToolStripMenuItemManager.Name = "ToolStripMenuItemManager";
            this.ToolStripMenuItemManager.Size = new System.Drawing.Size(60, 20);
            this.ToolStripMenuItemManager.Text = "Quản lý";
            // 
            // tSMIManagerStaff
            // 
            this.tSMIManagerStaff.Name = "tSMIManagerStaff";
            this.tSMIManagerStaff.Size = new System.Drawing.Size(132, 22);
            this.tSMIManagerStaff.Text = "Nhân viên";
            // 
            // tSMIManagerDepartment
            // 
            this.tSMIManagerDepartment.Name = "tSMIManagerDepartment";
            this.tSMIManagerDepartment.Size = new System.Drawing.Size(132, 22);
            this.tSMIManagerDepartment.Text = "Phòng ban";
            this.tSMIManagerDepartment.Click += new System.EventHandler(this.tSMIManagerDepartment_Click);
            // 
            // ToolStripMenuItemStatistical
            // 
            this.ToolStripMenuItemStatistical.Name = "ToolStripMenuItemStatistical";
            this.ToolStripMenuItemStatistical.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItemStatistical.Text = "Thống kê";
            // 
            // ToolStripMenuItemSuport
            // 
            this.ToolStripMenuItemSuport.Name = "ToolStripMenuItemSuport";
            this.ToolStripMenuItemSuport.Size = new System.Drawing.Size(62, 20);
            this.ToolStripMenuItemSuport.Text = "Trợ giúp";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonView,
            this.toolStripButtonAdd,
            this.toolStripButtonFix,
            this.toolStripButtonDelete,
            this.toolStripButtonSave,
            this.toolStripButtonCancel,
            this.toolStripSeparator2,
            this.toolStripButtonUpdate,
            this.toolStripSeparator3,
            this.toolStripButtonPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(831, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonView
            // 
            this.toolStripButtonView.Image = global::QuanLyNhanSu.Properties.Resources.view;
            this.toolStripButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonView.Name = "toolStripButtonView";
            this.toolStripButtonView.Size = new System.Drawing.Size(51, 22);
            this.toolStripButtonView.Text = "Xem";
            this.toolStripButtonView.Click += new System.EventHandler(this.toolStripButtonView_Click);
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.Image = global::QuanLyNhanSu.Properties.Resources.addperson;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonAdd.Text = "Thêm";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonFix
            // 
            this.toolStripButtonFix.Image = global::QuanLyNhanSu.Properties.Resources.edit;
            this.toolStripButtonFix.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFix.Name = "toolStripButtonFix";
            this.toolStripButtonFix.Size = new System.Drawing.Size(46, 22);
            this.toolStripButtonFix.Text = "Sửa";
            this.toolStripButtonFix.Click += new System.EventHandler(this.toolStripButtonFix_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.Image = global::QuanLyNhanSu.Properties.Resources.delete;
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonDelete.Text = "Xóa";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.Image = global::QuanLyNhanSu.Properties.Resources.save_file;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(47, 22);
            this.toolStripButtonSave.Text = "Lưu";
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.Image = global::QuanLyNhanSu.Properties.Resources.cancel;
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonCancel.Text = "Hủy";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.Image = global::QuanLyNhanSu.Properties.Resources.update;
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(75, 22);
            this.toolStripButtonUpdate.Text = "Cập nhật";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.Image = global::QuanLyNhanSu.Properties.Resources.print;
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(37, 22);
            this.toolStripButtonPrint.Text = "In";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.dateTimeBirthDay);
            this.groupBox1.Controls.Add(this.cbbSex);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 129);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(699, 82);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 27);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(489, 86);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(164, 20);
            this.txtID.TabIndex = 7;
            // 
            // dateTimeBirthDay
            // 
            this.dateTimeBirthDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBirthDay.Location = new System.Drawing.Point(102, 79);
            this.dateTimeBirthDay.Name = "dateTimeBirthDay";
            this.dateTimeBirthDay.Size = new System.Drawing.Size(222, 20);
            this.dateTimeBirthDay.TabIndex = 6;
            // 
            // cbbSex
            // 
            this.cbbSex.FormattingEnabled = true;
            this.cbbSex.Location = new System.Drawing.Point(489, 23);
            this.cbbSex.Name = "cbbSex";
            this.cbbSex.Size = new System.Drawing.Size(121, 21);
            this.cbbSex.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 24);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(390, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngảy sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(305, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeID,
            this.employeeName,
            this.sex,
            this.birthDay,
            this.position,
            this.department,
            this.status});
            this.dataGridViewMain.Location = new System.Drawing.Point(12, 243);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.Size = new System.Drawing.Size(807, 261);
            this.dataGridViewMain.TabIndex = 4;
            this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
            // 
            // employeeID
            // 
            this.employeeID.DataPropertyName = "EmployeeID";
            this.employeeID.HeaderText = "Mã nhân viên";
            this.employeeID.Name = "employeeID";
            // 
            // employeeName
            // 
            this.employeeName.DataPropertyName = "EmployeeName";
            this.employeeName.HeaderText = "Họ Tên";
            this.employeeName.Name = "employeeName";
            this.employeeName.Width = 150;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "Sex";
            this.sex.HeaderText = "Giới tính";
            this.sex.Name = "sex";
            // 
            // birthDay
            // 
            this.birthDay.DataPropertyName = "BirthDay";
            this.birthDay.HeaderText = "Ngày sinh";
            this.birthDay.Name = "birthDay";
            // 
            // position
            // 
            this.position.DataPropertyName = "Position";
            this.position.HeaderText = "Chức vụ";
            this.position.Name = "position";
            // 
            // department
            // 
            this.department.DataPropertyName = "Department";
            this.department.HeaderText = "Phòng ban";
            this.department.Name = "department";
            this.department.Width = 120;
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Trạng thái";
            this.status.Name = "status";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(831, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(157, 17);
            this.toolStripStatusLabel1.Text = "Admin : Blogger Huy Hoàng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 529);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dateTimeBirthDay;
        private System.Windows.Forms.ComboBox cbbSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSystem;
        private System.Windows.Forms.ToolStripMenuItem tSMIManagerAccount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemManager;
        private System.Windows.Forms.ToolStripMenuItem tSMIManagerStaff;
        private System.Windows.Forms.ToolStripMenuItem tSMIManagerDepartment;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemStatistical;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSuport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonFix;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonView;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}