using System;
using System.Collections;
using System.Collections.Generic;
namespace CQMS
{
    public partial class Form1 : Form
    {
        Queue<Patient> queue = new Queue<Patient>();
        public Form1()
        {
            InitializeComponent();


        }
        public class Patient
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string PatientType { get; set; }
            public string ReasonForVisit { get; set; }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtP_name.Text)
                && string.IsNullOrWhiteSpace(txtAge.Text)
                && string.IsNullOrWhiteSpace(txtPatientType.Text)
                && string.IsNullOrWhiteSpace(txtRFV.Text))
            {
                MessageBox.Show("input data");
            }
            else
            {
                queue.Enqueue(new Patient
                {

                    Name = txtP_name.Text,
                    Age = txtAge.Text,
                    PatientType = txtPatientType.Text,
                    ReasonForVisit = txtRFV.
                    Text


                });

                string info = "No: " + queue.Count + "\n" + "Patient Type: " + txtPatientType.Text + "\n Priority: " + txtPatientType.Text;
                MessageBox.Show(info);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtP_name.Clear();
            txtAge.Clear();
            txtRFV.Clear();
            
        }
    }
}
