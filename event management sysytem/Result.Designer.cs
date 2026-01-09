namespace event_management_sysytem
{
    partial class frmResult
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
            this.txtComptitionID = new System.Windows.Forms.TextBox();
            this.txtParticipantID = new System.Windows.Forms.TextBox();
            this.txtPlace = new System.Windows.Forms.TextBox();
            this.lblPlace = new System.Windows.Forms.Label();
            this.lblParticipantID = new System.Windows.Forms.Label();
            this.lblCompetitionID = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComptitionID
            // 
            this.txtComptitionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComptitionID.Location = new System.Drawing.Point(294, 35);
            this.txtComptitionID.Name = "txtComptitionID";
            this.txtComptitionID.Size = new System.Drawing.Size(100, 22);
            this.txtComptitionID.TabIndex = 17;
            // 
            // txtParticipantID
            // 
            this.txtParticipantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipantID.Location = new System.Drawing.Point(294, 76);
            this.txtParticipantID.Name = "txtParticipantID";
            this.txtParticipantID.Size = new System.Drawing.Size(100, 22);
            this.txtParticipantID.TabIndex = 16;
            // 
            // txtPlace
            // 
            this.txtPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlace.Location = new System.Drawing.Point(294, 119);
            this.txtPlace.Name = "txtPlace";
            this.txtPlace.Size = new System.Drawing.Size(100, 22);
            this.txtPlace.TabIndex = 15;
            // 
            // lblPlace
            // 
            this.lblPlace.AutoSize = true;
            this.lblPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlace.Location = new System.Drawing.Point(50, 122);
            this.lblPlace.Name = "lblPlace";
            this.lblPlace.Size = new System.Drawing.Size(48, 16);
            this.lblPlace.TabIndex = 14;
            this.lblPlace.Text = "Place";
            // 
            // lblParticipantID
            // 
            this.lblParticipantID.AutoSize = true;
            this.lblParticipantID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParticipantID.Location = new System.Drawing.Point(50, 79);
            this.lblParticipantID.Name = "lblParticipantID";
            this.lblParticipantID.Size = new System.Drawing.Size(101, 16);
            this.lblParticipantID.TabIndex = 13;
            this.lblParticipantID.Text = "Participant ID";
            // 
            // lblCompetitionID
            // 
            this.lblCompetitionID.AutoSize = true;
            this.lblCompetitionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitionID.Location = new System.Drawing.Point(50, 38);
            this.lblCompetitionID.Name = "lblCompetitionID";
            this.lblCompetitionID.Size = new System.Drawing.Size(109, 16);
            this.lblCompetitionID.TabIndex = 12;
            this.lblCompetitionID.Text = "Competition ID";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(177, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(294, 222);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(53, 222);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 376);
            this.Controls.Add(this.txtComptitionID);
            this.Controls.Add(this.txtParticipantID);
            this.Controls.Add(this.txtPlace);
            this.Controls.Add(this.lblPlace);
            this.Controls.Add(this.lblParticipantID);
            this.Controls.Add(this.lblCompetitionID);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Name = "frmResult";
            this.Text = "    ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComptitionID;
        private System.Windows.Forms.TextBox txtParticipantID;
        private System.Windows.Forms.TextBox txtPlace;
        private System.Windows.Forms.Label lblPlace;
        private System.Windows.Forms.Label lblParticipantID;
        private System.Windows.Forms.Label lblCompetitionID;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnInsert;
    }
}