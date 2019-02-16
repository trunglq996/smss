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
            this.lbHello.Location = new System.Drawing.Point(3, 9);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(134, 32);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "Xin chào:";
            // 
            // btnGrade
            // 
            this.btnGrade.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnGrade.Location = new System.Drawing.Point(1, 54);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(136, 46);
            this.btnGrade.TabIndex = 1;
            this.btnGrade.Text = "Khóa học";
            this.btnGrade.UseVisualStyleBackColor = false;
            // 
            // btnClass
            // 
            this.btnClass.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnClass.Location = new System.Drawing.Point(143, 54);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(136, 46);
            this.btnClass.TabIndex = 2;
            this.btnClass.Text = "Lớp học";
            this.btnClass.UseVisualStyleBackColor = false;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnStudent.Location = new System.Drawing.Point(285, 54);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(136, 46);
            this.btnStudent.TabIndex = 3;
            this.btnStudent.Text = "DS sinh viên";
            this.btnStudent.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.lbHello);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(890, 100);
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
