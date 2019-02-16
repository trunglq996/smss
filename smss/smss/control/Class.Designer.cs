namespace smss.control
{
    partial class Class
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
            this.dataClass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataClass)).BeginInit();
            this.SuspendLayout();
            // 
            // dataClass
            // 
            this.dataClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataClass.Location = new System.Drawing.Point(0, 0);
            this.dataClass.Name = "dataClass";
            this.dataClass.RowTemplate.Height = 28;
            this.dataClass.Size = new System.Drawing.Size(811, 387);
            this.dataClass.TabIndex = 0;
            // 
            // Class
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataClass);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Class";
            this.Size = new System.Drawing.Size(811, 387);
            this.Load += new System.EventHandler(this.Class_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataClass;
    }
}
