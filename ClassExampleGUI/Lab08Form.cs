using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassExampleGUI
{
    public partial class Lab08Form : Form
    {
        public string UserName { get; set; }
        public float UserAge { get; set; }

        public Lab08Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
              float.Parse(AgeTextBox.Text);
              SubmitButton.Enabled = true;

            }
            catch (Exception)
            {

                SubmitButton.Enabled = true;
            }
        }


        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled =(NameTextBox.Text.Length >= 2 ) ? true : false;
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            //option 1
            //UserAge =  Convert.ToSingle(AgeTextBox.Text);

            //option 2 
            //recommand
            UserAge = float.Parse(AgeTextBox.Text);

            //option 3
            //float tempFloat;
            //bool result =float.TryParse(AgeTextBox.Text, out tempFloat);
            //UserAge = tempFloat;
            OutputLabel.Text = NameTextBox.Text + " " + AgeTextBox.Text;
            ClearForm();
        }
        private void ClearForm(){
            AgeTextBox.Clear();
            NameTextBox.Clear();
        }
    }
}
