namespace AdmissionCommittee
{
    partial class EditForm
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            mathScoreNumericUpDown = new NumericUpDown();
            label9 = new Label();
            russianScoreNumericUpDown = new NumericUpDown();
            label8 = new Label();
            ITScoreNumericUpDown = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            genderComboBox = new ComboBox();
            formOfEducationComboBox = new ComboBox();
            birthDateTimePicker = new DateTimePicker();
            patronymicTextBox = new TextBox();
            surnameTextBox = new TextBox();
            nameTextBox = new TextBox();
            cancelButton = new Button();
            saveButton = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mathScoreNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)russianScoreNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ITScoreNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(genderComboBox);
            groupBox1.Controls.Add(formOfEducationComboBox);
            groupBox1.Controls.Add(birthDateTimePicker);
            groupBox1.Controls.Add(patronymicTextBox);
            groupBox1.Controls.Add(surnameTextBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 337);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Абитуриент";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mathScoreNumericUpDown);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(russianScoreNumericUpDown);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(ITScoreNumericUpDown);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(44, 196);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(253, 124);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Баллы ЕГЭ";
            // 
            // mathScoreNumericUpDown
            // 
            mathScoreNumericUpDown.Location = new Point(96, 60);
            mathScoreNumericUpDown.Name = "mathScoreNumericUpDown";
            mathScoreNumericUpDown.Size = new Size(147, 23);
            mathScoreNumericUpDown.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 91);
            label9.Name = "label9";
            label9.Size = new Size(85, 15);
            label9.TabIndex = 17;
            label9.Text = "Информатика";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // russianScoreNumericUpDown
            // 
            russianScoreNumericUpDown.Location = new Point(96, 31);
            russianScoreNumericUpDown.Name = "russianScoreNumericUpDown";
            russianScoreNumericUpDown.Size = new Size(148, 23);
            russianScoreNumericUpDown.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 62);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 16;
            label8.Text = "Математика";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ITScoreNumericUpDown
            // 
            ITScoreNumericUpDown.Location = new Point(96, 89);
            ITScoreNumericUpDown.Name = "ITScoreNumericUpDown";
            ITScoreNumericUpDown.Size = new Size(147, 23);
            ITScoreNumericUpDown.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 33);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 15;
            label7.Text = "Русский язык";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(104, 170);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 14;
            label6.Text = "Пол";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 141);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 13;
            label5.Text = "Форма обучения";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 115);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 12;
            label4.Text = "Дата рождения";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 83);
            label3.Name = "label3";
            label3.Size = new Size(121, 15);
            label3.TabIndex = 11;
            label3.Text = "Отчество (если есть)";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 54);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 10;
            label2.Text = "Фамилия";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 25);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 9;
            label1.Text = "Имя";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(140, 167);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(148, 23);
            genderComboBox.TabIndex = 5;
            // 
            // formOfEducationComboBox
            // 
            formOfEducationComboBox.FormattingEnabled = true;
            formOfEducationComboBox.Location = new Point(140, 138);
            formOfEducationComboBox.Name = "formOfEducationComboBox";
            formOfEducationComboBox.Size = new Size(148, 23);
            formOfEducationComboBox.TabIndex = 4;
            // 
            // birthDateTimePicker
            // 
            birthDateTimePicker.Location = new Point(140, 109);
            birthDateTimePicker.Name = "birthDateTimePicker";
            birthDateTimePicker.Size = new Size(148, 23);
            birthDateTimePicker.TabIndex = 3;
            // 
            // patronymicTextBox
            // 
            patronymicTextBox.Location = new Point(140, 80);
            patronymicTextBox.Name = "patronymicTextBox";
            patronymicTextBox.Size = new Size(148, 23);
            patronymicTextBox.TabIndex = 2;
            // 
            // surnameTextBox
            // 
            surnameTextBox.Location = new Point(140, 51);
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(148, 23);
            surnameTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(140, 22);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(148, 23);
            nameTextBox.TabIndex = 0;
            // 
            // cancelButton
            // 
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point(250, 355);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(169, 355);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 2;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 387);
            Controls.Add(saveButton);
            Controls.Add(cancelButton);
            Controls.Add(groupBox1);
            Name = "EditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Редактирование";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mathScoreNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)russianScoreNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ITScoreNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown ITScoreNumericUpDown;
        private NumericUpDown mathScoreNumericUpDown;
        private NumericUpDown russianScoreNumericUpDown;
        private ComboBox genderComboBox;
        private ComboBox formOfEducationComboBox;
        private DateTimePicker birthDateTimePicker;
        private TextBox patronymicTextBox;
        private TextBox surnameTextBox;
        private TextBox nameTextBox;
        private GroupBox groupBox2;
        private Button cancelButton;
        private Button saveButton;
        private ErrorProvider errorProvider;
    }
}
