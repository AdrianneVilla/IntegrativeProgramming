using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class StudentRegistration : Form
    {
        private string gender;
        private int date;
        public StudentRegistration()
        {

            InitializeComponent();

            for(int i = 1900; i < DateTime.Today.Year; i++)
            {
                comboBox3Year.Items.Add(i);
            }
            for(int i = 1; i <= 31; i++)
            {
                comboBox1Day.Items.Add(i);
            }
            for(int i = 1;i <=12;  i++)
            {
               comboBox2Month.Items.Add(i);
            }
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName = textBox3LastName.Text;
            string firstName = textBox1FirstName.Text;
            string middleName = textBox2MiddleName.Text;

            if (radioButton1Male.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2Female.Checked)
            {
                gender = "Female";
            }

            MessageBox.Show($"Student name: {firstName+" "+middleName+ " " +lastName}\n" +
                $"Gender: {gender}\n" +
                $"Date of Birth: {comboBox1Day.Text +"/"+comboBox2Month.Text+"/"+ comboBox3Year.Text}");
            

        }

        private void textBox3LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1Day_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox2Month_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void radioButton1Male_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
