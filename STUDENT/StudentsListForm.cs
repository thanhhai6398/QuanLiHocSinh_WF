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
    public partial class StudentsListForm : Form
    {
        public StudentsListForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        public void StudentsListForm_Load(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as ID, fname as 'First Name', lname as 'Last Name', bdate as 'Birth date', gender as Gender, phone as Phone, address as Address, picture as Picture FROM std");
            dataGridView1.ReadOnly = true;
            // xu ly hinh anh
            DataGridViewImageColumn picture = new DataGridViewImageColumn(); // doi tuong lam viec voi dang picture cua datagridview
            dataGridView1.RowTemplate.Height = 80; //co gang de pic dep, dang tim auto-size
            dataGridView1.DataSource = student.getStudents(command);
            picture = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picture.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("SELECT id as ID, fname as 'First Name', lname as 'Last Name', bdate as 'Birth date', gender as Gender, phone as Phone, address as Address, picture as Picture FROM std");
            dataGridView1.ReadOnly = true; // nap lai du lieu len datagridview
            DataGridViewImageColumn piccol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height= 80;
            dataGridView1.DataSource = student.getStudents(command);
            piccol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            piccol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false; 
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeletStdF = new UpdateDeleteStudentForm();
            //thu tu: id - fname - lname - bd - gdr - phn - adrs - pic
            updateDeletStdF.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletStdF.textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletStdF.textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletStdF.dateTimePicker.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            // gender
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Trim() == "Female")
            {
                updateDeletStdF.radioButtonFemale.Checked = true;
            }
            else
            {
                updateDeletStdF.radioButtonMale.Checked = true;
            }
            updateDeletStdF.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletStdF.textBoxAdrs.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            //xu ly hinh anh up len
            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletStdF.pictureBox.Image = Image.FromStream(picture);
            updateDeletStdF.Show();
        }
    }
}
