using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamManager {

    public partial class Form2 : Form {

        public ListViewItem itemToReturn { get; set; }

        public Form2(ListViewItem parameterItem) {
            InitializeComponent();

            Region = new Region(new Rectangle(0, 0, Width, Height));
            Paint += new PaintEventHandler(setFormBackground);

            setTextboxes(parameterItem);
        }

        private void setFormBackground(Object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            Rectangle gradientRectangle = new Rectangle(0, 0, Width, Height);
            Brush b = new LinearGradientBrush(gradientRectangle, Color.FromArgb(122, 161, 230), Color.FromArgb(99, 118, 213), 45f);
            g.FillRectangle(b, gradientRectangle);
        }

        private void setTextboxes(ListViewItem parameterItem) {
            dateTextbox.Text = parameterItem.SubItems[1].Text;
            subjectTextbox.Text = parameterItem.SubItems[2].Text; ;
            gradeTextbox.Text = parameterItem.SubItems[3].Text;
        }

        private void finishEdit_Button_Click(object sender, EventArgs e) {
            string date = dateTextbox.Text;
            string subject = subjectTextbox.Text;
            string grade = gradeTextbox.Text;

            if (date.Equals("")) {
                editLabel.Text = "Date cannot be empty!";
            }
            else if (subject.Equals("")) {
                editLabel.Text = "Subject cannot be empty!";
            }
            else {
                string[] row = { "", date, subject, grade };
                itemToReturn = new ListViewItem(row);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
