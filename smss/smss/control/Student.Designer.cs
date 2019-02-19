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
            this.groupStudent = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).BeginInit();
            this.groupStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataStudent
            // 
            this.dataStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataStudent.Location = new System.Drawing.Point(3, 16);
            this.dataStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataStudent.Name = "dataStudent";
            this.dataStudent.RowTemplate.Height = 28;
            this.dataStudent.Size = new System.Drawing.Size(371, 241);
            this.dataStudent.TabIndex = 0;
            // 
            // groupStudent
            // 
            this.groupStudent.Controls.Add(this.dataStudent);
            this.groupStudent.Location = new System.Drawing.Point(405, 159);
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.Size = new System.Drawing.Size(377, 260);
            this.groupStudent.TabIndex = 1;
            this.groupStudent.TabStop = false;
            this.groupStudent.Text = "Danh sách sinh viên";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupStudent);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(845, 488);
            this.Load += new System.EventHandler(this.Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataStudent)).EndInit();
            this.groupStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataStudent;
        private System.Windows.Forms.GroupBox groupStudent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
