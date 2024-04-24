namespace AdmissionCommittee
{
    partial class ApplicantListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicantListForm));
            statusStrip = new StatusStrip();
            ApplicantsCountLabel = new ToolStripStatusLabel();
            applicantsCount = new ToolStripStatusLabel();
            toolStrip = new ToolStrip();
            addButton = new ToolStripButton();
            editButton = new ToolStripButton();
            deleteButton = new ToolStripButton();
            dataGridView = new DataGridView();
            statusStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { ApplicantsCountLabel, applicantsCount });
            statusStrip.Location = new Point(0, 428);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(800, 22);
            statusStrip.TabIndex = 0;
            statusStrip.Text = "statusStrip1";
            // 
            // ApplicantsCountLabel
            // 
            ApplicantsCountLabel.Name = "ApplicantsCountLabel";
            ApplicantsCountLabel.Size = new Size(256, 17);
            ApplicantsCountLabel.Text = "Кол-во абитуриентов с суммой баллов >150:";
            // 
            // applicantsCount
            // 
            applicantsCount.Name = "applicantsCount";
            applicantsCount.Size = new Size(13, 17);
            applicantsCount.Text = "0";
            // 
            // toolStrip
            // 
            toolStrip.Items.AddRange(new ToolStripItem[] { addButton, editButton, deleteButton });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 25);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // addButton
            // 
            addButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            addButton.Image = (Image)resources.GetObject("addButton.Image");
            addButton.ImageTransparentColor = Color.Magenta;
            addButton.Name = "addButton";
            addButton.Size = new Size(63, 22);
            addButton.Text = "Добавить";
            addButton.Click += AddButton_Click;
            // 
            // editButton
            // 
            editButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            editButton.Image = (Image)resources.GetObject("editButton.Image");
            editButton.ImageTransparentColor = Color.Magenta;
            editButton.Name = "editButton";
            editButton.Size = new Size(65, 22);
            editButton.Text = "Изменить";
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.DisplayStyle = ToolStripItemDisplayStyle.Text;
            deleteButton.Image = (Image)resources.GetObject("deleteButton.Image");
            deleteButton.ImageTransparentColor = Color.Magenta;
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(55, 22);
            deleteButton.Text = "Удалить";
            deleteButton.Click += deleteButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 25);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(800, 403);
            dataGridView.TabIndex = 2;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // ApplicantListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView);
            Controls.Add(toolStrip);
            Controls.Add(statusStrip);
            Name = "ApplicantListForm";
            Text = "Абитуриенты";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip;
        private ToolStrip toolStrip;
        private ToolStripButton deleteButton;
        private ToolStripButton addButton;
        private ToolStripButton editButton;
        private ToolStripStatusLabel ApplicantsCountLabel;
        private ToolStripStatusLabel applicantsCount;
        private DataGridView dataGridView;
    }
}
