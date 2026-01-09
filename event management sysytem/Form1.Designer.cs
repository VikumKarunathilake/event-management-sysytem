namespace event_management_sysytem
{
    partial class frmPerformance
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
            this.txtPerformanceType = new System.Windows.Forms.TextBox();
            this.txtPerformanceName = new System.Windows.Forms.TextBox();
            this.txtSheduleID = new System.Windows.Forms.TextBox();
            this.txtPerformanceID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblScheduleID = new System.Windows.Forms.Label();
            this.lblPerformanceName = new System.Windows.Forms.Label();
            this.lblPerformanceType = new System.Windows.Forms.Label();
            this.lblPerformanceID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPerformanceType
            // 
            this.txtPerformanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerformanceType.Location = new System.Drawing.Point(240, 36);
            this.txtPerformanceType.Name = "txtPerformanceType";
            this.txtPerformanceType.Size = new System.Drawing.Size(100, 22);
            this.txtPerformanceType.TabIndex = 22;
            // 
            // txtPerformanceName
            // 
            this.txtPerformanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerformanceName.Location = new System.Drawing.Point(240, 83);
            this.txtPerformanceName.Name = "txtPerformanceName";
            this.txtPerformanceName.Size = new System.Drawing.Size(100, 22);
            this.txtPerformanceName.TabIndex = 21;
            // 
            // txtSheduleID
            // 
            this.txtSheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSheduleID.Location = new System.Drawing.Point(240, 131);
            this.txtSheduleID.Name = "txtSheduleID";
            this.txtSheduleID.Size = new System.Drawing.Size(100, 22);
            this.txtSheduleID.TabIndex = 20;
            // 
            // txtPerformanceID
            // 
            this.txtPerformanceID.Location = new System.Drawing.Point(175, -34);
            this.txtPerformanceID.Name = "txtPerformanceID";
            this.txtPerformanceID.Size = new System.Drawing.Size(100, 20);
            this.txtPerformanceID.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(174, 293);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(293, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(50, 209);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblScheduleID
            // 
            this.lblScheduleID.AutoSize = true;
            this.lblScheduleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScheduleID.Location = new System.Drawing.Point(47, 138);
            this.lblScheduleID.Name = "lblScheduleID";
            this.lblScheduleID.Size = new System.Drawing.Size(92, 16);
            this.lblScheduleID.TabIndex = 15;
            this.lblScheduleID.Text = "Schedule ID";
            // 
            // lblPerformanceName
            // 
            this.lblPerformanceName.AutoSize = true;
            this.lblPerformanceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformanceName.Location = new System.Drawing.Point(47, 86);
            this.lblPerformanceName.Name = "lblPerformanceName";
            this.lblPerformanceName.Size = new System.Drawing.Size(141, 16);
            this.lblPerformanceName.TabIndex = 14;
            this.lblPerformanceName.Text = "Performance Name";
            // 
            // lblPerformanceType
            // 
            this.lblPerformanceType.AutoSize = true;
            this.lblPerformanceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformanceType.Location = new System.Drawing.Point(47, 43);
            this.lblPerformanceType.Name = "lblPerformanceType";
            this.lblPerformanceType.Size = new System.Drawing.Size(136, 16);
            this.lblPerformanceType.TabIndex = 13;
            this.lblPerformanceType.Text = "Performance Type";
            // 
            // lblPerformanceID
            // 
            this.lblPerformanceID.AutoSize = true;
            this.lblPerformanceID.Location = new System.Drawing.Point(-18, -31);
            this.lblPerformanceID.Name = "lblPerformanceID";
            this.lblPerformanceID.Size = new System.Drawing.Size(81, 13);
            this.lblPerformanceID.TabIndex = 12;
            this.lblPerformanceID.Text = "Performance ID";
            // 
            // frmPerformance
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(459, 434);
            this.Controls.Add(this.txtPerformanceType);
            this.Controls.Add(this.txtPerformanceName);
            this.Controls.Add(this.txtSheduleID);
            this.Controls.Add(this.txtPerformanceID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblScheduleID);
            this.Controls.Add(this.lblPerformanceName);
            this.Controls.Add(this.lblPerformanceType);
            this.Controls.Add(this.lblPerformanceID);
            this.Name = "frmPerformance";
            this.Text = "Performance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPerformanceType;
        private System.Windows.Forms.TextBox txtPerformanceName;
        private System.Windows.Forms.TextBox txtSheduleID;
        private System.Windows.Forms.TextBox txtPerformanceID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label lblScheduleID;
        private System.Windows.Forms.Label lblPerformanceName;
        private System.Windows.Forms.Label lblPerformanceType;
        private System.Windows.Forms.Label lblPerformanceID;
    }
}

