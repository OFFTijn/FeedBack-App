namespace FeedbackApplicatieFutureFlow
{
    partial class CreateFeedbackForm
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
            this.EnterGoalIDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FeedbackRichtextbox = new System.Windows.Forms.RichTextBox();
            this.FeedbackSortLabel = new System.Windows.Forms.Label();
            this.FeedbacksortTextbox = new System.Windows.Forms.TextBox();
            this.DocentFeedbackLabel = new System.Windows.Forms.Label();
            this.TeacherFeedbackTextbox = new System.Windows.Forms.TextBox();
            this.CreateFeedbackButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.FeedbackGoalComboBox = new System.Windows.Forms.ComboBox();
            this.AddFeedbackMessageLabel = new System.Windows.Forms.Label();
            this.FeedbackcomboBox = new System.Windows.Forms.ComboBox();
            this.SelectFeedbackLabel = new System.Windows.Forms.Label();
            this.ChangeFeedbackMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterGoalIDLabel
            // 
            this.EnterGoalIDLabel.AutoSize = true;
            this.EnterGoalIDLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterGoalIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EnterGoalIDLabel.Location = new System.Drawing.Point(37, 26);
            this.EnterGoalIDLabel.Name = "EnterGoalIDLabel";
            this.EnterGoalIDLabel.Size = new System.Drawing.Size(135, 20);
            this.EnterGoalIDLabel.TabIndex = 17;
            this.EnterGoalIDLabel.Text = "Selecteer een doel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(135, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Voer de feedback in";
            // 
            // FeedbackRichtextbox
            // 
            this.FeedbackRichtextbox.Location = new System.Drawing.Point(102, 103);
            this.FeedbackRichtextbox.Name = "FeedbackRichtextbox";
            this.FeedbackRichtextbox.Size = new System.Drawing.Size(215, 64);
            this.FeedbackRichtextbox.TabIndex = 20;
            this.FeedbackRichtextbox.Text = "";
            // 
            // FeedbackSortLabel
            // 
            this.FeedbackSortLabel.AutoSize = true;
            this.FeedbackSortLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FeedbackSortLabel.ForeColor = System.Drawing.Color.White;
            this.FeedbackSortLabel.Location = new System.Drawing.Point(115, 181);
            this.FeedbackSortLabel.Name = "FeedbackSortLabel";
            this.FeedbackSortLabel.Size = new System.Drawing.Size(193, 20);
            this.FeedbackSortLabel.TabIndex = 21;
            this.FeedbackSortLabel.Text = "Voer het soort feedback in";
            // 
            // FeedbacksortTextbox
            // 
            this.FeedbacksortTextbox.Location = new System.Drawing.Point(102, 204);
            this.FeedbacksortTextbox.Name = "FeedbacksortTextbox";
            this.FeedbacksortTextbox.Size = new System.Drawing.Size(215, 23);
            this.FeedbacksortTextbox.TabIndex = 22;
            // 
            // DocentFeedbackLabel
            // 
            this.DocentFeedbackLabel.AutoSize = true;
            this.DocentFeedbackLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DocentFeedbackLabel.ForeColor = System.Drawing.Color.White;
            this.DocentFeedbackLabel.Location = new System.Drawing.Point(135, 239);
            this.DocentFeedbackLabel.Name = "DocentFeedbackLabel";
            this.DocentFeedbackLabel.Size = new System.Drawing.Size(158, 20);
            this.DocentFeedbackLabel.TabIndex = 23;
            this.DocentFeedbackLabel.Text = "Wie gaf de feedback?";
            // 
            // TeacherFeedbackTextbox
            // 
            this.TeacherFeedbackTextbox.Location = new System.Drawing.Point(102, 262);
            this.TeacherFeedbackTextbox.Name = "TeacherFeedbackTextbox";
            this.TeacherFeedbackTextbox.Size = new System.Drawing.Size(215, 23);
            this.TeacherFeedbackTextbox.TabIndex = 24;
            // 
            // CreateFeedbackButton
            // 
            this.CreateFeedbackButton.BackColor = System.Drawing.Color.Red;
            this.CreateFeedbackButton.FlatAppearance.BorderSize = 0;
            this.CreateFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateFeedbackButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateFeedbackButton.ForeColor = System.Drawing.Color.Transparent;
            this.CreateFeedbackButton.Location = new System.Drawing.Point(78, 337);
            this.CreateFeedbackButton.Name = "CreateFeedbackButton";
            this.CreateFeedbackButton.Size = new System.Drawing.Size(118, 46);
            this.CreateFeedbackButton.TabIndex = 25;
            this.CreateFeedbackButton.Text = "Aanmaken";
            this.CreateFeedbackButton.UseVisualStyleBackColor = false;
            this.CreateFeedbackButton.Click += new System.EventHandler(this.CreateFeedbackButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.Red;
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateButton.ForeColor = System.Drawing.Color.Transparent;
            this.UpdateButton.Location = new System.Drawing.Point(219, 337);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(118, 46);
            this.UpdateButton.TabIndex = 26;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // FeedbackGoalComboBox
            // 
            this.FeedbackGoalComboBox.FormattingEnabled = true;
            this.FeedbackGoalComboBox.Location = new System.Drawing.Point(12, 48);
            this.FeedbackGoalComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FeedbackGoalComboBox.Name = "FeedbackGoalComboBox";
            this.FeedbackGoalComboBox.Size = new System.Drawing.Size(197, 23);
            this.FeedbackGoalComboBox.TabIndex = 27;
            this.FeedbackGoalComboBox.SelectedIndexChanged += new System.EventHandler(this.FeedbackGoalComboBox_SelectedIndexChanged);
            // 
            // AddFeedbackMessageLabel
            // 
            this.AddFeedbackMessageLabel.AutoSize = true;
            this.AddFeedbackMessageLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddFeedbackMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddFeedbackMessageLabel.Location = new System.Drawing.Point(86, 298);
            this.AddFeedbackMessageLabel.Name = "AddFeedbackMessageLabel";
            this.AddFeedbackMessageLabel.Size = new System.Drawing.Size(236, 20);
            this.AddFeedbackMessageLabel.TabIndex = 28;
            this.AddFeedbackMessageLabel.Text = "Feedback succesvol toegevoegd!";
            this.AddFeedbackMessageLabel.Visible = false;
            // 
            // FeedbackcomboBox
            // 
            this.FeedbackcomboBox.FormattingEnabled = true;
            this.FeedbackcomboBox.Location = new System.Drawing.Point(238, 48);
            this.FeedbackcomboBox.Name = "FeedbackcomboBox";
            this.FeedbackcomboBox.Size = new System.Drawing.Size(178, 23);
            this.FeedbackcomboBox.TabIndex = 29;
            // 
            // SelectFeedbackLabel
            // 
            this.SelectFeedbackLabel.AutoSize = true;
            this.SelectFeedbackLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectFeedbackLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SelectFeedbackLabel.Location = new System.Drawing.Point(243, 26);
            this.SelectFeedbackLabel.Name = "SelectFeedbackLabel";
            this.SelectFeedbackLabel.Size = new System.Drawing.Size(160, 20);
            this.SelectFeedbackLabel.TabIndex = 30;
            this.SelectFeedbackLabel.Text = "Selecteer de feedback";
            // 
            // ChangeFeedbackMessageLabel
            // 
            this.ChangeFeedbackMessageLabel.AutoSize = true;
            this.ChangeFeedbackMessageLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChangeFeedbackMessageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ChangeFeedbackMessageLabel.Location = new System.Drawing.Point(97, 298);
            this.ChangeFeedbackMessageLabel.Name = "ChangeFeedbackMessageLabel";
            this.ChangeFeedbackMessageLabel.Size = new System.Drawing.Size(225, 20);
            this.ChangeFeedbackMessageLabel.TabIndex = 31;
            this.ChangeFeedbackMessageLabel.Text = "Feedback succesvol aangepast!";
            this.ChangeFeedbackMessageLabel.Visible = false;
            // 
            // CreateFeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(428, 395);
            this.Controls.Add(this.ChangeFeedbackMessageLabel);
            this.Controls.Add(this.SelectFeedbackLabel);
            this.Controls.Add(this.FeedbackcomboBox);
            this.Controls.Add(this.AddFeedbackMessageLabel);
            this.Controls.Add(this.FeedbackGoalComboBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.CreateFeedbackButton);
            this.Controls.Add(this.TeacherFeedbackTextbox);
            this.Controls.Add(this.DocentFeedbackLabel);
            this.Controls.Add(this.FeedbacksortTextbox);
            this.Controls.Add(this.FeedbackSortLabel);
            this.Controls.Add(this.FeedbackRichtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EnterGoalIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateFeedbackForm";
            this.Text = "CreateFeedbackForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label EnterGoalIDLabel;
        private Label label1;
        private RichTextBox FeedbackRichtextbox;
        private Label FeedbackSortLabel;
        private TextBox FeedbacksortTextbox;
        private Label DocentFeedbackLabel;
        private TextBox TeacherFeedbackTextbox;
        private Button CreateFeedbackButton;
        private Button UpdateButton;
        private ComboBox FeedbackGoalComboBox;
        private Label AddFeedbackMessageLabel;
        private ComboBox FeedbackcomboBox;
        private Label SelectFeedbackLabel;
        private Label ChangeFeedbackMessageLabel;
    }
}