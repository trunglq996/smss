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
            ((System.ComponentModel.ISupportInitialize)(this.dataGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrade
            // 
            this.dataGrade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrade.Location = new System.Drawing.Point(0, 0);
            this.dataGrade.Margin = new System.Windows.Forms.Padding(0);
            this.dataGrade.Name = "dataGrade";
            this.dataGrade.ReadOnly = true;
            this.dataGrade.RowTemplate.Height = 28;
            this.dataGrade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrade.Size = new System.Drawing.Size(916, 394);
            this.dataGrade.TabIndex = 0;
            this.dataGrade.SelectionChanged += new System.EventHandler(this.dataGrade_SelectionChanged);
            // 
            // Grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGrade);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Grade";
            this.Size = new System.Drawing.Size(916, 394);
            this.Load += new System.EventHandler(this.ViewData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrade;
    }
}
