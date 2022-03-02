using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class AddNewStudentForm : Form
    {
        public AddNewStudentForm()
        {
            InitializeComponent();
        }

        public void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT st = new STUDENT();
            int id = Convert.ToInt32(textBoxStudentID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAdrs.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker.Value.Year;
            int this_year = DateTime.Now.Year;
            // tuoi 10-100
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                if (st.InsertStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool verif()
        {
            if ((textBoxFname.Text.Trim() == "") || (textBoxLname.Text.Trim() == "") ||
                (textBoxAdrs.Text.Trim() == "") || (textBoxPhone.Text.Trim() == "") || (pictureBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        //upoad image
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox.Image = Image.FromFile(opf.FileName);

            }
        }
    }
}
