namespace FeedbackApplicatieFutureFlow
{
    partial class StudentOverviewForm
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
            this.StudentOverviewLabel = new System.Windows.Forms.Label();
            this.StudentOverviewDatagridview = new System.Windows.Forms.DataGridView();
            this.CreateRemarkButton = new System.Windows.Forms.Button();
            this.StudentcodeLabel = new System.Windows.Forms.Label();
            this.StudentcodeTextbox = new System.Windows.Forms.TextBox();
            this.UpdateRemarkButton = new System.Windows.Forms.Button();
            this.DeleteRemarkButton = new System.Windows.Forms.Button();
            this.RemarkListbox = new System.Windows.Forms.ListBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentOverviewDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentOverviewLabel
            // 
            this.StudentOverviewLabel.AutoSize = true;
            this.StudentOverviewLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentOverviewLabel.ForeColor = System.Drawing.Color.Transparent;
            this.StudentOverviewLabel.Location = new System.Drawing.Point(243, 9);
            this.StudentOverviewLabel.Name = "StudentOverviewLabel";
            this.StudentOverviewLabel.Size = new System.Drawing.Size(244, 37);
            this.StudentOverviewLabel.TabIndex = 1;
            this.StudentOverviewLabel.Text = "Student overzicht";
            // 
            // StudentOverviewDatagridview
            // 
            this.StudentOverviewDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentOverviewDatagridview.Location = new System.Drawing.Point(12, 153);
            this.StudentOverviewDatagridview.Name = "StudentOverviewDatagridview";
            this.StudentOverviewDatagridview.RowTemplate.Height = 25;
            this.StudentOverviewDatagridview.Size = new System.Drawing.Size(459, 334);
            this.StudentOverviewDatagridview.TabIndex = 2;
            // 
            // CreateRemarkButton
            // 
            this.CreateRemarkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateRemarkButton.Location = new System.Drawing.Point(12, 504);
            this.CreateRemarkButton.Name = "CreateRemarkButton";
            this.CreateRemarkButton.Size = new System.Drawing.Size(119, 58);
            this.CreateRemarkButton.TabIndex = 3;
            this.CreateRemarkButton.Text = "Opmerking toevoegen";
            this.CreateRemarkButton.UseVisualStyleBackColor = true;
            // 
            // StudentcodeLabel
            // 
            this.StudentcodeLabel.AutoSize = true;
            this.StudentcodeLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StudentcodeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StudentcodeLabel.Location = new System.Drawing.Point(81, 66);
            this.StudentcodeLabel.Name = "StudentcodeLabel";
            this.StudentcodeLabel.Size = new System.Drawing.Size(126, 25);
            this.StudentcodeLabel.TabIndex = 4;
            this.StudentcodeLabel.Text = "Studentcode";
            // 
            // StudentcodeTextbox
            // 
            this.StudentcodeTextbox.Location = new System.Drawing.Point(38, 105);
            this.StudentcodeTextbox.Name = "StudentcodeTextbox";
            this.StudentcodeTextbox.Size = new System.Drawing.Size(228, 23);
            this.StudentcodeTextbox.TabIndex = 5;
            // 
            // UpdateRemarkButton
            // 
            this.UpdateRemarkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateRemarkButton.Location = new System.Drawing.Point(179, 504);
            this.UpdateRemarkButton.Name = "UpdateRemarkButton";
            this.UpdateRemarkButton.Size = new System.Drawing.Size(119, 58);
            this.UpdateRemarkButton.TabIndex = 6;
            this.UpdateRemarkButton.Text = "Opmerking bijwerken";
            this.UpdateRemarkButton.UseVisualStyleBackColor = true;
            // 
            // DeleteRemarkButton
            // 
            this.DeleteRemarkButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteRemarkButton.Location = new System.Drawing.Point(352, 504);
            this.DeleteRemarkButton.Name = "DeleteRemarkButton";
            this.DeleteRemarkButton.Size = new System.Drawing.Size(119, 58);
            this.DeleteRemarkButton.TabIndex = 7;
            this.DeleteRemarkButton.Text = "Opmerking verwijderen";
            this.DeleteRemarkButton.UseVisualStyleBackColor = true;
            // 
            // RemarkListbox
            // 
            this.RemarkListbox.FormattingEnabled = true;
            this.RemarkListbox.ItemHeight = 15;
            this.RemarkListbox.Location = new System.Drawing.Point(499, 153);
            this.RemarkListbox.Name = "RemarkListbox";
            this.RemarkListbox.Size = new System.Drawing.Size(235, 409);
            this.RemarkListbox.TabIndex = 8;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RemarkLabel.ForeColor = System.Drawing.Color.Transparent;
            this.RemarkLabel.Location = new System.Drawing.Point(499, 125);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(224, 25);
            this.RemarkLabel.TabIndex = 9;
            this.RemarkLabel.Text = "Opmerkingen over doel";
            // 
            // StudentOverviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(766, 584);
            this.Controls.Add(this.RemarkLabel);
            this.Controls.Add(this.RemarkListbox);
            this.Controls.Add(this.DeleteRemarkButton);
            this.Controls.Add(this.UpdateRemarkButton);
            this.Controls.Add(this.StudentcodeTextbox);
            this.Controls.Add(this.StudentcodeLabel);
            this.Controls.Add(this.CreateRemarkButton);
            this.Controls.Add(this.StudentOverviewDatagridview);
            this.Controls.Add(this.StudentOverviewLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentOverviewForm";
            this.Text = "StudentOverviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.StudentOverviewDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label StudentOverviewLabel;
        private DataGridView StudentOverviewDatagridview;
        private Button CreateRemarkButton;
        private Label StudentcodeLabel;
        private TextBox StudentcodeTextbox;
        private Button UpdateRemarkButton;
        private Button DeleteRemarkButton;
        private ListBox RemarkListbox;
        private Label RemarkLabel;
    }
}