namespace smss.control
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbCodeView = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupData = new System.Windows.Forms.GroupBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.groupData2 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.groupUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupData.SuspendLayout();
            this.groupData2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStudent.Location = new System.Drawing.Point(3, 16);
            this.dataStudent.Margin = new System.Windows.Forms.Padding(2);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowTemplate.Height = 28;
            this.dataStudent.Size = new System.Drawing.Size(384, 120);
            this.dataStudent.TabIndex = 0;
            this.dataStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataStudent_CellClick);
            // 
            // groupUpdate
            // 
            this.groupUpdate.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupUpdate.Controls.Add(this.lbName);
            this.groupUpdate.Controls.Add(this.lbCodeView);
            this.groupUpdate.Controls.Add(this.btnEdit);
            this.groupUpdate.Controls.Add(this.btnDelete);
            this.groupUpdate.Controls.Add(this.groupBox1);
            this.groupUpdate.Location = new System.Drawing.Point(2, 2);
            this.groupUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.groupUpdate.Size = new System.Drawing.Size(247, 379);
            this.groupUpdate.TabIndex = 5;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Cập nhật sinh viên";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(47, 236);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 17);
            this.lbName.TabIndex = 13;
            this.lbName.Text = "Tên sinh viên";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCodeView
            // 
            this.lbCodeView.AutoSize = true;
            this.lbCodeView.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodeView.Location = new System.Drawing.Point(47, 219);
            this.lbCodeView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCodeView.Name = "lbCodeView";
            this.lbCodeView.Size = new System.Drawing.Size(95, 17);
            this.lbCodeView.TabIndex = 12;
            this.lbCodeView.Text = "Mã sinh viên";
            this.lbCodeView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(85, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 27);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(166, 337);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 27);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(48, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(2, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupData
            // 
            this.groupData.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupData.Controls.Add(this.txtClass);
            this.groupData.Controls.Add(this.txtGrade);
            this.groupData.Controls.Add(this.groupData2);
            this.groupData.Controls.Add(this.btnNew);
            this.groupData.Location = new System.Drawing.Point(314, 2);
            this.groupData.Margin = new System.Windows.Forms.Padding(2);
            this.groupData.Name = "groupData";
            this.groupData.Padding = new System.Windows.Forms.Padding(2);
            this.groupData.Size = new System.Drawing.Size(563, 379);
            this.groupData.TabIndex = 4;
            this.groupData.TabStop = false;
            // 
            // txtClass
            // 
            this.txtClass.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtClass.Enabled = false;
            this.txtClass.Location = new System.Drawing.Point(275, 12);
            this.txtClass.Margin = new System.Windows.Forms.Padding(2);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(133, 20);
            this.txtClass.TabIndex = 10;
            // 
            // txtGrade
            // 
            this.txtGrade.BackColor = System.Drawing.Color.NavajoWhite;
            this.txtGrade.Enabled = false;
            this.txtGrade.Location = new System.Drawing.Point(140, 12);
            this.txtGrade.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(133, 20);
            this.txtGrade.TabIndex = 6;
            // 
            // groupData2
            // 
            this.groupData2.Controls.Add(this.dataStudent);
            this.groupData2.Location = new System.Drawing.Point(5, 31);
            this.groupData2.Name = "groupData2";
            this.groupData2.Size = new System.Drawing.Size(390, 139);
            this.groupData2.TabIndex = 1;
            this.groupData2.TabStop = false;
            this.groupData2.Text = "Danh sách sinh viên";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNew.Location = new System.Drawing.Point(8, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 27);
            this.btnNew.TabIndex = 9;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupData);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(879, 488);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupData.ResumeLayout(false);
            this.groupData.PerformLayout();
            this.groupData2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox groupData2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbCodeView;
    }
}
