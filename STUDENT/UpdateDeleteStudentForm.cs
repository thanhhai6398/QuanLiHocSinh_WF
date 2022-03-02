using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //Tim by id
        public void buttonFind_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender, phone, address, picture FROM std WHERE id =" + id);
            DataTable table = student.getStudents(command);
            if (table.Rows.Count > 0)
            {
                textBoxFname.Text = table.Rows[0]["fname"].ToString();
                textBoxLname.Text = table.Rows[0]["lname"].ToString();
                dateTimePicker.Value = (DateTime)table.Rows[0]["bdate"];
                // gender
                if (table.Rows[0]["gender"].ToString() == "Female")
                {
                    radioButtonFemale.Checked = true;
                }
                else
                {
                    radioButtonMale.Checked = true;
                }
                textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                textBoxAdrs.Text = table.Rows[0]["address"].ToString();
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox.Image = Image.FromStream(picture);
            }
            else
            {
                MessageBox.Show("not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
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
            // Tuoi 10 - 100;
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (verif())
            {
                try
                {
                    id = Convert.ToInt32(textBoxID.Text);
                    pictureBox.Image.Save(pic, pictureBox.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, adrs, pic))
                    {
                        MessageBox.Show("Student Information Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void buttonRemove_Click(object sender, EventArgs e)
        {
            // delete student
            try
            {
                int studentId =  Convert.ToInt32(textBoxID.Text);
                // message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes))
                {
                    if (student.deleteStudent(studentId))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // clear fields after delete
                        textBoxID.Text = "";
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        textBoxAdrs.Text = "";
                        textBoxPhone.Text = "";
                        dateTimePicker.Value = DateTime.Now;
                        pictureBox.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //verify data
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxFname.Text.Trim() == "")
            || (textBoxLname.Text.Trim() == "") || (textBoxAdrs.Text.Trim() == "")
            || (textBoxPhone.Text.Trim() == "") || (pictureBox.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Upload image
        public void buttonUpload_Click(object sender, EventArgs e)
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
