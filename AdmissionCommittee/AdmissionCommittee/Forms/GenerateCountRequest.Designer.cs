namespace AdmissionCommittee.Forms
{
    partial class GenerateCountRequest
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
            label1 = new Label();
            generateCount = new NumericUpDown();
            OKButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)generateCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 0;
            label1.Text = "Сколько сгенерировать?";
            // 
            // generateCount
            // 
            generateCount.Location = new Point(12, 36);
            generateCount.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            generateCount.Name = "generateCount";
            generateCount.Size = new Size(165, 23);
            generateCount.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.Location = new Point(12, 77);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 23);
            OKButton.TabIndex = 2;
            OKButton.Text = "ОК";
            OKButton.UseVisualStyleBackColor = true;
            OKButton.Click += OKButton_Click;
            // 
            // CancelButton
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(102, 77);
            button1.Name = "CancelButton";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            // 
            // GenerateCountRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(189, 119);
            Controls.Add(button1);
            Controls.Add(OKButton);
            Controls.Add(generateCount);
            Controls.Add(label1);
            Name = "GenerateCountRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Генерация";
            ((System.ComponentModel.ISupportInitialize)generateCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button OKButton;
        private Button button1;
        internal NumericUpDown generateCount;
    }
}
