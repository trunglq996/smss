namespace smss.control
{
    partial class Menu
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
            this.lbHello = new System.Windows.Forms.Label();
            this.btnGrade = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(2, 6);
            this.lbHello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(91, 24);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Xin chào:";
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGrade.Location = new System.Drawing.Point(1, 35);
            this.btnGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(91, 30);
            this.btnGrade.TabIndex = 1;
            this.btnGrade.Text = "Khóa học";
            this.btnGrade.UseVisualStyleBackColor = false;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClass.Location = new System.Drawing.Point(95, 35);
            this.btnClass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(91, 30);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = false;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnStudent.Location = new System.Drawing.Point(190, 35);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(91, 30);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "DS sinh viên";
            this.btnStudent.UseVisualStyleBackColor = false;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.lbHello);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(593, 65);
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnStudent;
    }
}
