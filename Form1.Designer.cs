namespace ExamManager {
    partial class myWindow {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            addNewEntry_Button = new Button();
            examListView = new ListView();
            columnCheckboxes = new ColumnHeader();
            Date = new ColumnHeader();
            Subject = new ColumnHeader();
            Grade = new ColumnHeader();
            dateTextbox = new TextBox();
            dateLabel = new Label();
            gradeTextbox = new TextBox();
            gradeLabel = new Label();
            subjectTextbox = new TextBox();
            subjectLabel = new Label();
            calculateGrade_Button = new Button();
            calculateResultTextbox = new TextBox();
            calculateResultLabel = new Label();
            removeEntry_Button = new Button();
            subjectCalculateLabel = new Label();
            removeLabel = new Label();
            addEntryLabel = new Label();
            editLabel = new Label();
            editSelectedEntry_Button = new Button();
            SuspendLayout();
            // 
            // addNewEntry_Button
            // 
            addNewEntry_Button.BackColor = Color.Orange;
            addNewEntry_Button.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addNewEntry_Button.ForeColor = Color.FromArgb(99, 118, 213);
            addNewEntry_Button.Location = new Point(12, 346);
            addNewEntry_Button.Name = "addNewEntry_Button";
            addNewEntry_Button.Size = new Size(218, 33);
            addNewEntry_Button.TabIndex = 7;
            addNewEntry_Button.Text = "Add a new entry";
            addNewEntry_Button.UseVisualStyleBackColor = false;
            addNewEntry_Button.Click += addNewEntry_Button_Click;
            // 
            // examListView
            // 
            examListView.Activation = ItemActivation.OneClick;
            examListView.Alignment = ListViewAlignment.SnapToGrid;
            examListView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            examListView.BackColor = Color.FromArgb(255, 206, 77);
            examListView.BorderStyle = BorderStyle.FixedSingle;
            examListView.CheckBoxes = true;
            examListView.Columns.AddRange(new ColumnHeader[] { columnCheckboxes, Date, Subject, Grade });
            examListView.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            examListView.ForeColor = Color.FromArgb(99, 118, 213);
            examListView.GridLines = true;
            examListView.Location = new Point(12, 396);
            examListView.Name = "examListView";
            examListView.ShowGroups = false;
            examListView.Size = new Size(574, 309);
            examListView.TabIndex = 16;
            examListView.UseCompatibleStateImageBehavior = false;
            examListView.View = View.Details;
            examListView.ColumnClick += examListView_ColumnClick;
            examListView.ItemSelectionChanged += examListView_ItemSelectionChanged;
            // 
            // columnCheckboxes
            // 
            columnCheckboxes.Text = "";
            columnCheckboxes.Width = 25;
            // 
            // Date
            // 
            Date.Text = "Date";
            Date.Width = 200;
            // 
            // Subject
            // 
            Subject.Text = "Subject";
            Subject.Width = 215;
            // 
            // Grade
            // 
            Grade.Text = "Grade";
            Grade.Width = 125;
            // 
            // dateTextbox
            // 
            dateTextbox.BackColor = Color.FromArgb(255, 234, 149);
            dateTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            dateTextbox.Location = new Point(15, 41);
            dateTextbox.Name = "dateTextbox";
            dateTextbox.Size = new Size(215, 25);
            dateTextbox.TabIndex = 1;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = Color.AliceBlue;
            dateLabel.Location = new Point(15, 18);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(53, 18);
            dateLabel.TabIndex = 0;
            dateLabel.Text = "Date:";
            // 
            // gradeTextbox
            // 
            gradeTextbox.BackColor = Color.FromArgb(255, 234, 149);
            gradeTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gradeTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            gradeTextbox.Location = new Point(15, 169);
            gradeTextbox.Name = "gradeTextbox";
            gradeTextbox.Size = new Size(215, 25);
            gradeTextbox.TabIndex = 5;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.BackColor = Color.Transparent;
            gradeLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gradeLabel.ForeColor = Color.AliceBlue;
            gradeLabel.Location = new Point(15, 146);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(63, 18);
            gradeLabel.TabIndex = 4;
            gradeLabel.Text = "Grade:";
            // 
            // subjectTextbox
            // 
            subjectTextbox.BackColor = Color.FromArgb(255, 234, 149);
            subjectTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            subjectTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            subjectTextbox.Location = new Point(15, 104);
            subjectTextbox.Name = "subjectTextbox";
            subjectTextbox.Size = new Size(215, 25);
            subjectTextbox.TabIndex = 3;
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.BackColor = Color.Transparent;
            subjectLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            subjectLabel.ForeColor = Color.AliceBlue;
            subjectLabel.Location = new Point(15, 81);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new Size(77, 18);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "Subject:";
            // 
            // calculateGrade_Button
            // 
            calculateGrade_Button.BackColor = Color.Orange;
            calculateGrade_Button.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            calculateGrade_Button.ForeColor = Color.FromArgb(99, 118, 213);
            calculateGrade_Button.Location = new Point(313, 346);
            calculateGrade_Button.Name = "calculateGrade_Button";
            calculateGrade_Button.Size = new Size(273, 33);
            calculateGrade_Button.TabIndex = 15;
            calculateGrade_Button.Text = "Calculate Subject Grade";
            calculateGrade_Button.UseVisualStyleBackColor = false;
            calculateGrade_Button.Click += calculateGrade_Button_Click;
            // 
            // calculateResultTextbox
            // 
            calculateResultTextbox.BackColor = Color.FromArgb(255, 234, 149);
            calculateResultTextbox.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            calculateResultTextbox.ForeColor = Color.FromArgb(99, 118, 213);
            calculateResultTextbox.Location = new Point(314, 294);
            calculateResultTextbox.Name = "calculateResultTextbox";
            calculateResultTextbox.Size = new Size(271, 25);
            calculateResultTextbox.TabIndex = 13;
            // 
            // calculateResultLabel
            // 
            calculateResultLabel.AutoSize = true;
            calculateResultLabel.BackColor = Color.Transparent;
            calculateResultLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            calculateResultLabel.ForeColor = Color.AliceBlue;
            calculateResultLabel.Location = new Point(315, 324);
            calculateResultLabel.Name = "calculateResultLabel";
            calculateResultLabel.Size = new Size(0, 18);
            calculateResultLabel.TabIndex = 14;
            // 
            // removeEntry_Button
            // 
            removeEntry_Button.BackColor = Color.Orange;
            removeEntry_Button.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeEntry_Button.ForeColor = Color.FromArgb(99, 118, 213);
            removeEntry_Button.Location = new Point(312, 37);
            removeEntry_Button.Name = "removeEntry_Button";
            removeEntry_Button.Size = new Size(273, 33);
            removeEntry_Button.TabIndex = 8;
            removeEntry_Button.Text = "Remove selected entries";
            removeEntry_Button.UseVisualStyleBackColor = false;
            removeEntry_Button.Click += removeEntry_Button_Click;
            // 
            // subjectCalculateLabel
            // 
            subjectCalculateLabel.AutoSize = true;
            subjectCalculateLabel.BackColor = Color.Transparent;
            subjectCalculateLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            subjectCalculateLabel.ForeColor = Color.AliceBlue;
            subjectCalculateLabel.Location = new Point(314, 271);
            subjectCalculateLabel.Name = "subjectCalculateLabel";
            subjectCalculateLabel.Size = new Size(183, 18);
            subjectCalculateLabel.TabIndex = 12;
            subjectCalculateLabel.Text = "Subject to calculate:";
            // 
            // removeLabel
            // 
            removeLabel.AutoSize = true;
            removeLabel.BackColor = Color.Transparent;
            removeLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            removeLabel.ForeColor = Color.AliceBlue;
            removeLabel.Location = new Point(314, 75);
            removeLabel.Name = "removeLabel";
            removeLabel.Size = new Size(0, 18);
            removeLabel.TabIndex = 9;
            // 
            // addEntryLabel
            // 
            addEntryLabel.AutoSize = true;
            addEntryLabel.BackColor = Color.Transparent;
            addEntryLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            addEntryLabel.ForeColor = Color.AliceBlue;
            addEntryLabel.Location = new Point(15, 323);
            addEntryLabel.Name = "addEntryLabel";
            addEntryLabel.Size = new Size(0, 18);
            addEntryLabel.TabIndex = 6;
            // 
            // editLabel
            // 
            editLabel.AutoSize = true;
            editLabel.BackColor = Color.Transparent;
            editLabel.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            editLabel.ForeColor = Color.AliceBlue;
            editLabel.Location = new Point(314, 203);
            editLabel.Name = "editLabel";
            editLabel.Size = new Size(0, 18);
            editLabel.TabIndex = 11;
            // 
            // editSelectedEntry_Button
            // 
            editSelectedEntry_Button.BackColor = Color.Orange;
            editSelectedEntry_Button.Font = new Font("MS PGothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            editSelectedEntry_Button.ForeColor = Color.FromArgb(99, 118, 213);
            editSelectedEntry_Button.Location = new Point(312, 165);
            editSelectedEntry_Button.Name = "editSelectedEntry_Button";
            editSelectedEntry_Button.Size = new Size(273, 33);
            editSelectedEntry_Button.TabIndex = 10;
            editSelectedEntry_Button.Text = "Edit selected Entry";
            editSelectedEntry_Button.UseVisualStyleBackColor = false;
            editSelectedEntry_Button.Click += editSelectedEntry_Button_Click;
            // 
            // myWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(99, 118, 213);
            ClientSize = new Size(598, 717);
            Controls.Add(editLabel);
            Controls.Add(editSelectedEntry_Button);
            Controls.Add(addEntryLabel);
            Controls.Add(removeLabel);
            Controls.Add(removeEntry_Button);
            Controls.Add(calculateResultLabel);
            Controls.Add(calculateResultTextbox);
            Controls.Add(calculateGrade_Button);
            Controls.Add(subjectCalculateLabel);
            Controls.Add(dateTextbox);
            Controls.Add(dateLabel);
            Controls.Add(gradeTextbox);
            Controls.Add(gradeLabel);
            Controls.Add(subjectTextbox);
            Controls.Add(subjectLabel);
            Controls.Add(examListView);
            Controls.Add(addNewEntry_Button);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimumSize = new Size(616, 645);
            Name = "myWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamManager";
            FormClosing += myWindow_FormClosing;
            Load += myWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addNewEntry_Button;
        private ColumnHeader Date;
        private ColumnHeader Subject;
        private ColumnHeader Grade;
        private ColumnHeader columnCheckboxes;
        private TextBox dateTextbox;
        private Label dateLabel;
        private TextBox gradeTextbox;
        private Label gradeLabel;
        private TextBox subjectTextbox;
        private Label subjectLabel;
        private Button calculateGrade_Button;
        private TextBox calculateResultTextbox;
        private Label calculateResultLabel;
        public ListView examListView;
        private Button removeEntry_Button;
        private Label subjectCalculateLabel;
        private Label removeLabel;
        private Label addEntryLabel;
        private Label editLabel;
        private Button editSelectedEntry_Button;
    }
}