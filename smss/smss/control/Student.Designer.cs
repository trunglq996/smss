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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.dataStudent = new System.Windows.Forms.DataGridView();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.groupData = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.groupUpdate.SuspendLayout();
            this.groupData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStudent.Location = new System.Drawing.Point(2, 15);
            this.dataStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowTemplate.Height = 28;
            this.dataStudent.Size = new System.Drawing.Size(371, 151);
            this.dataStudent.TabIndex = 0;
            // 
            // groupUpdate
            // 
            this.groupUpdate.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupUpdate.Controls.Add(this.btnDelete);
            this.groupUpdate.Controls.Add(this.btnEdit);
            this.groupUpdate.Controls.Add(this.groupBox1);
            this.groupUpdate.Location = new System.Drawing.Point(2, 2);
            this.groupUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Padding = new System.Windows.Forms.Padding(2);
            this.groupUpdate.Size = new System.Drawing.Size(247, 379);
            this.groupUpdate.TabIndex = 5;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Thông tin sinh viên";
            // 
            // groupData
            // 
            this.groupData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupData.Controls.Add(this.dataStudent);
            this.groupData.Location = new System.Drawing.Point(314, 2);
            this.groupData.Margin = new System.Windows.Forms.Padding(2);
            this.groupData.Name = "groupData";
            this.groupData.Padding = new System.Windows.Forms.Padding(2);
            this.groupData.Size = new System.Drawing.Size(375, 168);
            this.groupData.TabIndex = 4;
            this.groupData.TabStop = false;
            this.groupData.Text = "Danh mục sinh viên";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(50, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 200);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEdit.Location = new System.Drawing.Point(110, 346);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 28);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Cập nhật";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(177, 346);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 28);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupData);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(845, 488);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.groupUpdate.ResumeLayout(false);
            this.groupData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
