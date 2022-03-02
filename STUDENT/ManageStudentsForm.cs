using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ProjectQLSV
{
    public partial class ManageStudentsForm : Form
    {
        public ManageStudentsForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("SELECT id as ID, fname as 'First Name', lname as 'Last Name', bdate as 'Birth date', gender as Gender, phone as Phone, address as Address, picture as Picture FROM std"));
        }
        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            // xu ly hinh anh
            DataGridViewImageColumn picture = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView1.RowTemplate.Height = 80; //co gang de pic dep, dang tim auto-size
            dataGridView1.DataSource = student.getStudents(command);
            picture = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picture.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            //dem SV
            labelTotalStd.Text = ("Total Students: " + dataGridView1.Rows.Count);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            // gender
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAdrs.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //xu ly hinh anh up len
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as ID, fname as 'First Name', lname as 'Last Name', bdate as 'Birth date', gender as Gender, phone as Phone, address as Address, picture as Picture FROM std WHERE CONCAT(fname, lname,address) LIKE'%" + textBoxSearch.Text + "%'");
            fillGrid(command);
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(.jpg;.png;*.gif)|*.jpg;*.png;*.gif";
            if ((opf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }
        //xoa cac field
        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxAdrs.Text = "";
            textBoxPhone.Text = "";
            pictureBox1.Image = null;
            radioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
        }
        //thu chuc nang luu hinh voi SaveFile
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.FileName = ("student_" + textBoxID.Text);
            if ((pictureBox1.Image == null))
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if((svf.ShowDialog() == DialogResult.OK))
            {
                pictureBox1.Image.Save((svf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }
        //verify data
        bool verif()
        {
            if ((textBoxID.Text.Trim() == "") || (textBoxFname.Text.Trim() == "")
            || (textBoxLname.Text.Trim() == "") || (textBoxAdrs.Text.Trim() == "")
            || (textBoxPhone.Text.Trim() == "") || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            STUDENT st = new STUDENT();
            int id = Convert.ToInt32(textBoxID.Text);
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAdrs.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
            int this_year = DateTime.Now.Year;
            // tuoi 10-100
            if (((this_year - born_year) < 10) || ((this_year - born_year) > 100))
            {
                MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verif())
            {
                pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
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

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone = textBoxPhone.Text;
            string adrs = textBoxAdrs.Text;
            string gender = "Male";
            if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }
            MemoryStream pic = new MemoryStream();
            int born_year = dateTimePicker1.Value.Year;
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
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // delete student
            try
            {
                int studentId = Convert.ToInt32(textBoxID.Text);
                // message before the delete
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
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
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox1.Image = null;
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
    }
}
