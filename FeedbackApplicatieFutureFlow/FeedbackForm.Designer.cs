namespace FeedbackApplicatieFutureFlow
{
    partial class FeedbackForm
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
            this.TimeRegistrationLabel = new System.Windows.Forms.Label();
            this.FeedbackGoalDatagridview = new System.Windows.Forms.DataGridView();
            this.CreateFeedbackButton = new System.Windows.Forms.Button();
            this.DeleteFeedbackButton = new System.Windows.Forms.Button();
            this.CRUDFeedbackPanel = new System.Windows.Forms.Panel();
            this.FeedbackListLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGoalDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeRegistrationLabel
            // 
            this.TimeRegistrationLabel.AutoSize = true;
            this.TimeRegistrationLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimeRegistrationLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TimeRegistrationLabel.Location = new System.Drawing.Point(472, 31);
            this.TimeRegistrationLabel.Name = "TimeRegistrationLabel";
            this.TimeRegistrationLabel.Size = new System.Drawing.Size(105, 30);
            this.TimeRegistrationLabel.TabIndex = 1;
            this.TimeRegistrationLabel.Text = "Feedback";
            // 
            // FeedbackGoalDatagridview
            // 
            this.FeedbackGoalDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FeedbackGoalDatagridview.Location = new System.Drawing.Point(12, 64);
            this.FeedbackGoalDatagridview.Name = "FeedbackGoalDatagridview";
            this.FeedbackGoalDatagridview.RowTemplate.Height = 25;
            this.FeedbackGoalDatagridview.Size = new System.Drawing.Size(277, 395);
            this.FeedbackGoalDatagridview.TabIndex = 2;
            this.FeedbackGoalDatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeedbackGoalDatagridview_CellContentClick);
            // 
            // CreateFeedbackButton
            // 
            this.CreateFeedbackButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateFeedbackButton.Location = new System.Drawing.Point(379, 492);
            this.CreateFeedbackButton.Name = "CreateFeedbackButton";
            this.CreateFeedbackButton.Size = new System.Drawing.Size(155, 58);
            this.CreateFeedbackButton.TabIndex = 3;
            this.CreateFeedbackButton.Text = "Aanmaken of Updaten";
            this.CreateFeedbackButton.UseVisualStyleBackColor = true;
            this.CreateFeedbackButton.Click += new System.EventHandler(this.CreateTimeButton_Click);
            // 
            // DeleteFeedbackButton
            // 
            this.DeleteFeedbackButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteFeedbackButton.Location = new System.Drawing.Point(203, 492);
            this.DeleteFeedbackButton.Name = "DeleteFeedbackButton";
            this.DeleteFeedbackButton.Size = new System.Drawing.Size(155, 58);
            this.DeleteFeedbackButton.TabIndex = 5;
            this.DeleteFeedbackButton.Text = "Verwijderen";
            this.DeleteFeedbackButton.UseVisualStyleBackColor = true;
            // 
            // CRUDFeedbackPanel
            // 
            this.CRUDFeedbackPanel.Location = new System.Drawing.Point(326, 64);
            this.CRUDFeedbackPanel.Name = "CRUDFeedbackPanel";
            this.CRUDFeedbackPanel.Size = new System.Drawing.Size(428, 395);
            this.CRUDFeedbackPanel.TabIndex = 6;
            // 
            // FeedbackListLabel
            // 
            this.FeedbackListLabel.AutoSize = true;
            this.FeedbackListLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeedbackListLabel.ForeColor = System.Drawing.Color.Transparent;
            this.FeedbackListLabel.Location = new System.Drawing.Point(48, 31);
            this.FeedbackListLabel.Name = "FeedbackListLabel";
            this.FeedbackListLabel.Size = new System.Drawing.Size(192, 30);
            this.FeedbackListLabel.TabIndex = 7;
            this.FeedbackListLabel.Text = "Lijst met feedback";
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(766, 584);
            this.Controls.Add(this.FeedbackListLabel);
            this.Controls.Add(this.CRUDFeedbackPanel);
            this.Controls.Add(this.DeleteFeedbackButton);
            this.Controls.Add(this.CreateFeedbackButton);
            this.Controls.Add(this.FeedbackGoalDatagridview);
            this.Controls.Add(this.TimeRegistrationLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FeedbackForm";
            this.Text = "TimeRegistrationForm";
            ((System.ComponentModel.ISupportInitialize)(this.FeedbackGoalDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TimeRegistrationLabel;
        private DataGridView FeedbackGoalDatagridview;
        private Button CreateFeedbackButton;
        private Button DeleteFeedbackButton;
        private Panel CRUDFeedbackPanel;
        private Label FeedbackListLabel;
    }
}