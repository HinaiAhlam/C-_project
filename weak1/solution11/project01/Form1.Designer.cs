namespace project01
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtID = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            cmbGender = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnSearch = new Button();
            txtSearchID = new TextBox();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(640, 65);
            txtID.Name = "txtID";
            txtID.Size = new Size(112, 23);
            txtID.TabIndex = 0;
            txtID.TextAlign = HorizontalAlignment.Center;
            // تم حذف السطر المسبب للخطأ من هنا
            // 
            // txtName
            // 
            txtName.Location = new Point(640, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(112, 23);
            txtName.TabIndex = 1;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(640, 203);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(112, 23);
            txtAge.TabIndex = 2;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "ذكر", "أنثى" });
            cmbGender.Location = new Point(640, 269);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(662, 357);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "اضافة";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(431, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "حذف";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(431, 166);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "بحث";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearchID
            // 
            txtSearchID.Location = new Point(393, 269);
            txtSearchID.Name = "txtSearchID";
            txtSearchID.Size = new Size(173, 23);
            txtSearchID.TabIndex = 7;
            txtSearchID.TextAlign = HorizontalAlignment.Center;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(375, 407);
            dgvStudents.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(txtSearchID);
            Controls.Add(btnSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbGender);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "نظام إدارة الطلاب";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAge;
        private ComboBox cmbGender;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox txtSearchID;
        private DataGridView dgvStudents;
    }
}