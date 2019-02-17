namespace smss.control
{
    partial class Grade
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
            this.dataGrade = new System.Windows.Forms.DataGridView();
            this.groupData = new System.Windows.Forms.GroupBox();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtYearIn = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtYearOut = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrade)).BeginInit();
            this.groupData.SuspendLayout();
            this.groupUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrade
            // 
            this.dataGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrade.Location = new System.Drawing.Point(3, 22);
            this.dataGrade.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrade.Name = "dataGrade";
            this.dataGrade.ReadOnly = true;
            this.dataGrade.RowTemplate.Height = 28;
            this.dataGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrade.Size = new System.Drawing.Size(557, 234);
            this.dataGrade.TabIndex = 0;
            this.dataGrade.SelectionChanged += new System.EventHandler(this.dataGrade_SelectionChanged);
            // 
            // groupData
            // 
            this.groupData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupData.Controls.Add(this.dataGrade);
            this.groupData.Location = new System.Drawing.Point(346, 3);
            this.groupData.Name = "groupData";
            this.groupData.Size = new System.Drawing.Size(563, 259);
            this.groupData.TabIndex = 1;
            this.groupData.TabStop = false;
            this.groupData.Text = "Danh mục khóa học";
            // 
            // groupUpdate
            // 
            this.groupUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupUpdate.Controls.Add(this.groupBox5);
            this.groupUpdate.Controls.Add(this.groupBox4);
            this.groupUpdate.Controls.Add(this.groupBox3);
            this.groupUpdate.Controls.Add(this.groupBox2);
            this.groupUpdate.Controls.Add(this.groupBox1);
            this.groupUpdate.Location = new System.Drawing.Point(3, 3);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(337, 520);
            this.groupUpdate.TabIndex = 2;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Cập nhật khóa học";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(6, 25);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(275, 26);
            this.txtMa.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(44, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(44, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 26);
            this.txtName.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.txtYearIn);
            this.groupBox3.Location = new System.Drawing.Point(44, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(287, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Năm vào:";
            // 
            // txtYearIn
            // 
            this.txtYearIn.Location = new System.Drawing.Point(6, 25);
            this.txtYearIn.Name = "txtYearIn";
            this.txtYearIn.Size = new System.Drawing.Size(275, 26);
            this.txtYearIn.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Controls.Add(this.txtYearOut);
            this.groupBox4.Location = new System.Drawing.Point(44, 247);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 63);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Năm ra:";
            // 
            // txtYearOut
            // 
            this.txtYearOut.Location = new System.Drawing.Point(6, 25);
            this.txtYearOut.Name = "txtYearOut";
            this.txtYearOut.Size = new System.Drawing.Size(275, 26);
            this.txtYearOut.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Controls.Add(this.txtNote);
            this.groupBox5.Location = new System.Drawing.Point(44, 316);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 119);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 25);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(275, 88);
            this.txtNote.TabIndex = 0;
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupData);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Grade";
            this.Size = new System.Drawing.Size(1003, 619);
            this.Load += new System.EventHandler(this.ViewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrade)).EndInit();
            this.groupData.ResumeLayout(false);
            this.groupUpdate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrade;
        private System.Windows.Forms.GroupBox groupData;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtYearOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtYearIn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
    }
}
