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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtYearOut = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtYearIn = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.groupButton = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrade)).BeginInit();
            this.groupData.SuspendLayout();
            this.groupUpdate.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOut)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYearIn)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupButton.SuspendLayout();
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
            this.dataGrade.Size = new System.Drawing.Size(556, 233);
            this.dataGrade.TabIndex = 0;
            this.dataGrade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrade_CellClick);
            // 
            // groupData
            // 
            this.groupData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupData.Controls.Add(this.dataGrade);
            this.groupData.Location = new System.Drawing.Point(346, 3);
            this.groupData.Name = "groupData";
            this.groupData.Size = new System.Drawing.Size(562, 258);
            this.groupData.TabIndex = 1;
            this.groupData.TabStop = false;
            this.groupData.Text = "Danh mục khóa học";
            // 
            // groupUpdate
            // 
            this.groupUpdate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupUpdate.Controls.Add(this.btnHuy);
            this.groupUpdate.Controls.Add(this.btnSave);
            this.groupUpdate.Controls.Add(this.groupBox5);
            this.groupUpdate.Controls.Add(this.groupBox4);
            this.groupUpdate.Controls.Add(this.groupBox3);
            this.groupUpdate.Controls.Add(this.groupBox2);
            this.groupUpdate.Controls.Add(this.groupBox1);
            this.groupUpdate.Location = new System.Drawing.Point(3, 3);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(338, 497);
            this.groupUpdate.TabIndex = 2;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Cập nhật khóa học";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHuy.Location = new System.Drawing.Point(242, 442);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 31);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Location = new System.Drawing.Point(147, 442);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox5.Controls.Add(this.txtNote);
            this.groupBox5.Location = new System.Drawing.Point(44, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(286, 118);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Ghi chú";
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(6, 25);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(276, 89);
            this.txtNote.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox4.Controls.Add(this.txtYearOut);
            this.groupBox4.Location = new System.Drawing.Point(44, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 63);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Năm ra:";
            // 
            // txtYearOut
            // 
            this.txtYearOut.Location = new System.Drawing.Point(6, 25);
            this.txtYearOut.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtYearOut.Name = "txtYearOut";
            this.txtYearOut.Size = new System.Drawing.Size(274, 26);
            this.txtYearOut.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox3.Controls.Add(this.txtYearIn);
            this.groupBox3.Location = new System.Drawing.Point(44, 178);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Năm vào:";
            // 
            // txtYearIn
            // 
            this.txtYearIn.Location = new System.Drawing.Point(6, 25);
            this.txtYearIn.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtYearIn.Name = "txtYearIn";
            this.txtYearIn.Size = new System.Drawing.Size(274, 26);
            this.txtYearIn.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Location = new System.Drawing.Point(44, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 63);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(276, 26);
            this.txtName.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.txtMa);
            this.groupBox1.Location = new System.Drawing.Point(44, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 63);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(6, 25);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(276, 26);
            this.txtMa.TabIndex = 0;
            // 
            // groupButton
            // 
            this.groupButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupButton.Controls.Add(this.btnEdit);
            this.groupButton.Controls.Add(this.btnNew);
            this.groupButton.Controls.Add(this.btnDelete);
            this.groupButton.Location = new System.Drawing.Point(3, 506);
            this.groupButton.Name = "groupButton";
            this.groupButton.Size = new System.Drawing.Size(338, 100);
            this.groupButton.TabIndex = 3;
            this.groupButton.TabStop = false;
            this.groupButton.Text = "Thêm/Sửa/Xóa";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEdit.Location = new System.Drawing.Point(152, 25);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 42);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNew.Location = new System.Drawing.Point(50, 25);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 42);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Thêm";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnDelete.Location = new System.Drawing.Point(254, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 42);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupButton);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupData);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Grade";
            this.Size = new System.Drawing.Size(1004, 618);
            this.Load += new System.EventHandler(this.ViewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrade)).EndInit();
            this.groupData.ResumeLayout(false);
            this.groupUpdate.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtYearOut)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtYearIn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupButton.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupButton;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown txtYearOut;
        private System.Windows.Forms.NumericUpDown txtYearIn;
        private System.Windows.Forms.Button btnHuy;
    }
}
