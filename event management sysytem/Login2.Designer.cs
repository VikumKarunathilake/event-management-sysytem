namespace event_management_sysytem
{
    partial class frmLogin2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnmembers = new System.Windows.Forms.Button();
            this.btnadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmembers
            // 
            this.btnmembers.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmembers.Location = new System.Drawing.Point(147, 191);
            this.btnmembers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnmembers.Name = "btnmembers";
            this.btnmembers.Size = new System.Drawing.Size(183, 66);
            this.btnmembers.TabIndex = 0;
            this.btnmembers.Text = "members";
            this.btnmembers.UseVisualStyleBackColor = true;
            this.btnmembers.Click += new System.EventHandler(this.btnmembers_Click);
            // 
            // btnadmin
            // 
            this.btnadmin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.Location = new System.Drawing.Point(147, 95);
            this.btnadmin.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(183, 66);
            this.btnadmin.TabIndex = 1;
            this.btnadmin.Text = "Admin";
            this.btnadmin.UseVisualStyleBackColor = true;
            this.btnadmin.Click += new System.EventHandler(this.btnadmin_Click);
            // 
            // frmLogin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(528, 413);
            this.Controls.Add(this.btnadmin);
            this.Controls.Add(this.btnmembers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmLogin2";
            this.Text = "Login2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmembers;
        private System.Windows.Forms.Button btnadmin;
    }
}