namespace FeedbackApplicatieFutureFlow
{
    partial class ReflectionForm
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
            this.ReflectionLabel = new System.Windows.Forms.Label();
            this.ReflectionDatagridview = new System.Windows.Forms.DataGridView();
            this.CreateReflectionButton = new System.Windows.Forms.Button();
            this.UpdateReflectionButton = new System.Windows.Forms.Button();
            this.DeleteReflectionButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReflectionDatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // ReflectionLabel
            // 
            this.ReflectionLabel.AutoSize = true;
            this.ReflectionLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReflectionLabel.ForeColor = System.Drawing.Color.Transparent;
            this.ReflectionLabel.Location = new System.Drawing.Point(312, 9);
            this.ReflectionLabel.Name = "ReflectionLabel";
            this.ReflectionLabel.Size = new System.Drawing.Size(129, 37);
            this.ReflectionLabel.TabIndex = 2;
            this.ReflectionLabel.Text = "Reflectie";
            // 
            // ReflectionDatagridview
            // 
            this.ReflectionDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReflectionDatagridview.Location = new System.Drawing.Point(12, 64);
            this.ReflectionDatagridview.Name = "ReflectionDatagridview";
            this.ReflectionDatagridview.RowTemplate.Height = 25;
            this.ReflectionDatagridview.Size = new System.Drawing.Size(742, 395);
            this.ReflectionDatagridview.TabIndex = 3;
            // 
            // CreateReflectionButton
            // 
            this.CreateReflectionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateReflectionButton.Location = new System.Drawing.Point(54, 492);
            this.CreateReflectionButton.Name = "CreateReflectionButton";
            this.CreateReflectionButton.Size = new System.Drawing.Size(155, 58);
            this.CreateReflectionButton.TabIndex = 4;
            this.CreateReflectionButton.Text = "Aanmaken";
            this.CreateReflectionButton.UseVisualStyleBackColor = true;
            // 
            // UpdateReflectionButton
            // 
            this.UpdateReflectionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdateReflectionButton.Location = new System.Drawing.Point(301, 492);
            this.UpdateReflectionButton.Name = "UpdateReflectionButton";
            this.UpdateReflectionButton.Size = new System.Drawing.Size(155, 58);
            this.UpdateReflectionButton.TabIndex = 5;
            this.UpdateReflectionButton.Text = "Bijwerken";
            this.UpdateReflectionButton.UseVisualStyleBackColor = true;
            // 
            // DeleteReflectionButton
            // 
            this.DeleteReflectionButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteReflectionButton.Location = new System.Drawing.Point(551, 492);
            this.DeleteReflectionButton.Name = "DeleteReflectionButton";
            this.DeleteReflectionButton.Size = new System.Drawing.Size(155, 58);
            this.DeleteReflectionButton.TabIndex = 6;
            this.DeleteReflectionButton.Text = "Verwijderen";
            this.DeleteReflectionButton.UseVisualStyleBackColor = true;
            // 
            // ReflectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(766, 584);
            this.Controls.Add(this.DeleteReflectionButton);
            this.Controls.Add(this.UpdateReflectionButton);
            this.Controls.Add(this.CreateReflectionButton);
            this.Controls.Add(this.ReflectionDatagridview);
            this.Controls.Add(this.ReflectionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReflectionForm";
            this.Text = "ReflectionForm";
            ((System.ComponentModel.ISupportInitialize)(this.ReflectionDatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ReflectionLabel;
        private DataGridView ReflectionDatagridview;
        private Button CreateReflectionButton;
        private Button UpdateReflectionButton;
        private Button DeleteReflectionButton;
    }
}