//Author:Arezou Sohrabvand
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_timer_Tick(object sender, EventArgs e)
        {
            //enable timer 
            SplashForm_timer.Enabled = false;
            //Instantiate Generate Name Form
            GenerateNameForm generateNameForm = new GenerateNameForm();
            //Show the generate form
            generateNameForm.Show();
            //close the generate form
            this.Hide();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
