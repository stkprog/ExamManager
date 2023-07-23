namespace ExamManager {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            dateTextbox = new TextBox();
            dateLabel = new Label();
            gradeTextbox = new TextBox();
            gradeLabel = new Label();
            subjectTextbox = new TextBox();
            subjectLabel = new Label();
            editLabel = new Label();
            finishEdit_Button = new Button();
            SuspendLayout();
            // 
            // dateTextbox
            // 
            dateTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTextbox.BackColor = Color.FromArgb(255, 234, 149);
            dateTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            dateTextbox.Location = new Point(12, 32);
            dateTextbox.Name = "dateTextbox";
            dateTextbox.Size = new Size(353, 25);
            dateTextbox.TabIndex = 1;
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.AliceBlue;
            dateLabel.Location = new Point(12, 9);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(53, 18);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Date:";
            // 
            // gradeTextbox
            // 
            gradeTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradeTextbox.BackColor = Color.FromArgb(255, 234, 149);
            gradeTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gradeTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            gradeTextbox.Location = new Point(12, 160);
            gradeTextbox.Name = "gradeTextbox";
            gradeTextbox.Size = new Size(353, 25);
            gradeTextbox.TabIndex = 5;
            // 
            // gradeLabel
            // 
            gradeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gradeLabel.AutoSize = true;
            gradeLabel.BackColor = Color.Transparent;
            gradeLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gradeLabel.ForeColor = Color.AliceBlue;
            gradeLabel.Location = new Point(12, 137);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(63, 18);
            gradeLabel.TabIndex = 4;
            gradeLabel.Text = "Grade:";
            // 
            // subjectTextbox
            // 
            subjectTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subjectTextbox.BackColor = Color.FromArgb(255, 234, 149);
            subjectTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            subjectTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            subjectTextbox.Location = new Point(12, 95);
            subjectTextbox.Name = "subjectTextbox";
            subjectTextbox.Size = new Size(353, 25);
            subjectTextbox.TabIndex = 3;
            // 
            // subjectLabel
            // 
            subjectLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = Color.Transparent;
            subjectLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            subjectLabel.ForeColor = Color.AliceBlue;
            subjectLabel.Location = new Point(12, 72);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(77, 18);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "Subject:";
            // 
            // editLabel
            // 
            editLabel.Anchor = AnchorStyles.Bottom;
            editLabel.AutoSize = true;
            editLabel.BackColor = Color.Transparent;
            editLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            editLabel.ForeColor = Color.AliceBlue;
            editLabel.Location = new Point(14, 213);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(0, 18);
            editLabel.TabIndex = 6;
            // 
            // finishEdit_Button
            // 
            finishEdit_Button.Anchor = AnchorStyles.Bottom;
            finishEdit_Button.BackColor = Color.Orange;
            finishEdit_Button.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            finishEdit_Button.ForeColor = Color.FromArgb(99, 118, 213);
            finishEdit_Button.Location = new Point(12, 236);
            finishEdit_Button.Name = "finishEdit_Button";
            finishEdit_Button.Size = new Size(353, 33);
            finishEdit_Button.TabIndex = 7;
            finishEdit_Button.Text = "Finish editing";
            finishEdit_Button.UseVisualStyleBackColor = false;
            finishEdit_Button.Click += finishEdit_Button_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 118, 213);
            ClientSize = new Size(377, 281);
            Controls.Add(editLabel);
            Controls.Add(finishEdit_Button);
            Controls.Add(dateTextbox);
            Controls.Add(dateLabel);
            Controls.Add(gradeTextbox);
            Controls.Add(gradeLabel);
            Controls.Add(subjectTextbox);
            Controls.Add(subjectLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editing an entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox dateTextbox;
        private Label dateLabel;
        private TextBox gradeTextbox;
        private Label gradeLabel;
        private TextBox subjectTextbox;
        private Label subjectLabel;
        private Label editLabel;
        private Button finishEdit_Button;
    }
}