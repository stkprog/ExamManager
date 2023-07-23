using System.Collections;
using static ExamManager.Program;
using System.Drawing.Drawing2D;

namespace ExamManager {
    public partial class myWindow : Form {

        private ListViewColumnSorter columnSorter;

        public myWindow() {
            InitializeComponent();

            columnSorter = new ListViewColumnSorter();
            examListView.ListViewItemSorter = columnSorter;

            Region = new Region(new Rectangle(0, 0, Width, Height));

            Paint += new PaintEventHandler(setFormBackground);
        }

        private void setFormBackground(Object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Rectangle gradientRectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRectangle, Color.FromArgb(122, 161, 230), Color.FromArgb(99, 118, 213), 45f);
            g.FillRectangle(b, gradientRectangle);
        }

        private void addNewEntry_Button_Click(object sender, EventArgs e) {
            string date = dateTextbox.Text;
            string subject = subjectTextbox.Text;
            string grade = gradeTextbox.Text;

            if (date.Equals("")) {
                addEntryLabel.Text = "Date cannot be empty!";
            }
            else if (subject.Equals("")) {
                addEntryLabel.Text = "Subject cannot be empty!";
            }
            else {
                string[] row = { "", date, subject, grade };
                examListView.Items.Add(new ListViewItem(row));
                addEntryLabel.Text = "";
                subjectTextbox.Text = "";
                gradeTextbox.Text = "";
            }
        }

        private void removeEntry_Button_Click(object sender, EventArgs e) {
            if (examListView.CheckedItems.Count == 0) {
                removeLabel.Text = "None selected!";
            }
            else {
                foreach (ListViewItem item in examListView.CheckedItems) {
                    examListView.Items.Remove(item);
                }
                removeLabel.Text = "";
            }
        }

        private void calculateGrade_Button_Click(object sender, EventArgs e) {
            string subject = calculateResultTextbox.Text.ToLower();

            if (subject.Equals("")) {
                calculateResultLabel.Text = "No Subject entered!";
            }
            else {
                int rowCount = 0;
                int totalGradeCount = 0;
                foreach (ListViewItem item in examListView.Items) {
                    if (item.SubItems[2].Text.ToLower().Equals(subject)) {
                        totalGradeCount += Convert.ToInt32(item.SubItems[3].Text);
                        rowCount++;
                    }
                }

                if (rowCount == 0) {
                    calculateResultLabel.Text = "Subject not in list!";
                }
                else {
                    calculateResultLabel.Text = Convert.ToString((double)totalGradeCount / rowCount);
                }
            }

        }

        private void examListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            e.Item.Selected = false;
            e.Item.Focused = false;
        }

        private void examListView_ColumnClick(object sender, ColumnClickEventArgs e) {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == columnSorter.SortColumn) {
                // Reverse the current sort direction for this column.
                if (columnSorter.Order == SortOrder.Ascending) {
                    columnSorter.Order = SortOrder.Descending;
                }
                else {
                    columnSorter.Order = SortOrder.Ascending;
                }
            }
            else {
                // Set the column number that is to be sorted; default to ascending.
                columnSorter.SortColumn = e.Column;
                columnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            examListView.Sort();
        }

        public ArrayList getExamList() {
            ArrayList exams = new ArrayList();
            foreach (ListViewItem item in examListView.Items) {
                exams.Add(new Exam(item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text));
            }
            return exams;
        }

        private void myWindow_FormClosing(object sender, FormClosingEventArgs e) {
            writeToTextFileOnClose(getExamList());
        }

        private void myWindow_Load(object sender, EventArgs e) {
            ArrayList examList = readFromTextFileOnStartup();
            foreach (Exam ex in examList) {
                string[] row = { "", ex.Date, ex.Subject, ex.Grade };
                examListView.Items.Add(new ListViewItem(row));
            }
        }

        private void editSelectedEntry_Button_Click(object sender, EventArgs e) {
            if (examListView.CheckedItems.Count == 0) {
                editLabel.Text = "None selected!";
            }
            else if (examListView.CheckedItems.Count > 1) {
                editLabel.Text = "Can only edit 1 at a time!";
            }
            else {
                editLabel.Text = "";
                using (Form2 popup = new Form2(examListView.CheckedItems[0])) {
                    var form2Result = popup.ShowDialog();
                    if (form2Result == DialogResult.OK) {
                        ListViewItem returnedItem = popup.itemToReturn;

                        for (int i = 0; i < 4; i++) {
                            examListView.CheckedItems[0].SubItems[i].Text = returnedItem.SubItems[i].Text;
                        }
                        examListView.CheckedItems[0].Checked = false;
                    }
                }
            }
        }
    }

}