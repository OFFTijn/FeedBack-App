namespace FeedbackApplicatieFutureFlow
{
    partial class GoalOverviewForm
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
            components = new System.ComponentModel.Container();
            GoalOverviewLabel = new Label();
            GoalDatagridview = new DataGridView();
            goalBindingSource = new BindingSource(components);
            CreateGoalorTaskButton = new Button();
            UpdateGoalButton = new Button();
            DeleteGoalButton = new Button();
            TaskLabel = new Label();
            TaskDatagridview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)GoalDatagridview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TaskDatagridview).BeginInit();
            SuspendLayout();
            // 
            // GoalOverviewLabel
            // 
            GoalOverviewLabel.AutoSize = true;
            GoalOverviewLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            GoalOverviewLabel.ForeColor = Color.Transparent;
            GoalOverviewLabel.Location = new Point(198, 12);
            GoalOverviewLabel.Name = "GoalOverviewLabel";
            GoalOverviewLabel.Size = new Size(133, 46);
            GoalOverviewLabel.TabIndex = 0;
            GoalOverviewLabel.Text = "Doelen";
            // 
            // GoalDatagridview
            // 
            GoalDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GoalDatagridview.Location = new Point(14, 85);
            GoalDatagridview.Margin = new Padding(3, 4, 3, 4);
            GoalDatagridview.Name = "GoalDatagridview";
            GoalDatagridview.RowHeadersWidth = 51;
            GoalDatagridview.RowTemplate.Height = 25;
            GoalDatagridview.Size = new Size(525, 527);
            GoalDatagridview.TabIndex = 1;
            GoalDatagridview.CellContentClick += GoalDatagridview_CellContentClick_1;
            // 
            // goalBindingSource
            // 
            goalBindingSource.DataSource = typeof(Goal);
            // 
            // CreateGoalorTaskButton
            // 
            CreateGoalorTaskButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CreateGoalorTaskButton.Location = new Point(14, 656);
            CreateGoalorTaskButton.Margin = new Padding(3, 4, 3, 4);
            CreateGoalorTaskButton.Name = "CreateGoalorTaskButton";
            CreateGoalorTaskButton.Size = new Size(145, 77);
            CreateGoalorTaskButton.TabIndex = 2;
            CreateGoalorTaskButton.Text = "Aanmaken";
            CreateGoalorTaskButton.UseVisualStyleBackColor = true;
            CreateGoalorTaskButton.Click += CreateGoalorTaskButton_Click_1;
            // 
            // UpdateGoalButton
            // 
            UpdateGoalButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            UpdateGoalButton.Location = new Point(185, 656);
            UpdateGoalButton.Margin = new Padding(3, 4, 3, 4);
            UpdateGoalButton.Name = "UpdateGoalButton";
            UpdateGoalButton.Size = new Size(158, 77);
            UpdateGoalButton.TabIndex = 2;
            UpdateGoalButton.Text = "Bijwerken";
            UpdateGoalButton.UseVisualStyleBackColor = true;
            UpdateGoalButton.Click += UpdateGoalButton_Click;
            // 
            // DeleteGoalButton
            // 
            DeleteGoalButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DeleteGoalButton.Location = new Point(376, 656);
            DeleteGoalButton.Margin = new Padding(3, 4, 3, 4);
            DeleteGoalButton.Name = "DeleteGoalButton";
            DeleteGoalButton.Size = new Size(162, 77);
            DeleteGoalButton.TabIndex = 3;
            DeleteGoalButton.Text = "Verwijderen";
            DeleteGoalButton.UseVisualStyleBackColor = true;
            DeleteGoalButton.Click += DeleteGoalButton_Click;
            // 
            // TaskLabel
            // 
            TaskLabel.AutoSize = true;
            TaskLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TaskLabel.ForeColor = Color.Transparent;
            TaskLabel.Location = new Point(661, 33);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.RightToLeft = RightToLeft.No;
            TaskLabel.Size = new Size(113, 46);
            TaskLabel.TabIndex = 4;
            TaskLabel.Text = "Taken";
            // 
            // TaskDatagridview
            // 
            TaskDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TaskDatagridview.Location = new Point(563, 85);
            TaskDatagridview.Name = "TaskDatagridview";
            TaskDatagridview.RowHeadersWidth = 51;
            TaskDatagridview.RowTemplate.Height = 29;
            TaskDatagridview.Size = new Size(300, 648);
            TaskDatagridview.TabIndex = 5;
            // 
            // GoalOverviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(875, 779);
            Controls.Add(TaskDatagridview);
            Controls.Add(TaskLabel);
            Controls.Add(DeleteGoalButton);
            Controls.Add(UpdateGoalButton);
            Controls.Add(CreateGoalorTaskButton);
            Controls.Add(GoalDatagridview);
            Controls.Add(GoalOverviewLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GoalOverviewForm";
            Text = "GoalOverviewForm";
            ((System.ComponentModel.ISupportInitialize)GoalDatagridview).EndInit();
            ((System.ComponentModel.ISupportInitialize)goalBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)TaskDatagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label GoalOverviewLabel;
        private DataGridView GoalDatagridview;
        private Button CreateGoalorTaskButton;
        private Button UpdateGoalButton;
        private Button DeleteGoalButton;
        private Label TaskLabel;
        private BindingSource goalBindingSource;
        private DataGridView TaskDatagridview;
    }
}