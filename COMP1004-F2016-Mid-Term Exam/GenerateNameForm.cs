using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// /// Final Assignment
/// Author:Arezou Sohrabvand
/// Student Id:200387480
/// Date:14/04/2020
/// This application is designing for playing game character
/// </summary>

namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class GenerateNameForm : Form
    {
        

        public GenerateNameForm()
        {
            InitializeComponent();
        }


       
        //Creating method for getting random firstname and last name from listbox
        private void GenerateNames()
    {
        Random rnd = new Random();
        int x = rnd.Next(1, FirstNameListBox.Items.Count);
        FirstNameListBox.Select();
        FirstNameListBox.SelectedItem = FirstNameListBox.Items[x];
        FirstName_textbox.Text = FirstNameListBox.SelectedItem.ToString();

        Random rand = new Random();
        int y=rand.Next(1,LastName_ListBox.Items.Count);
        LastName_ListBox.Select();
        LastName_ListBox.SelectedItem = LastName_ListBox.Items[y];

        LastNameTextBox.Text = LastName_ListBox.SelectedItem.ToString();

    }



        //Generate load form with calling eventhandler
         private void GenerateNameForm_Load(object sender, EventArgs e)
         {
            GenerateNames();
            
         }



        //next buttun event handler
        private void NextButton_Click(object sender, EventArgs e)
        {   
            
            //Instantiate the abilityGeneratorForm
            AbilityGeneratorForm abilityGeneratorForm = new AbilityGeneratorForm();
            //show the abilityGeneratorForm
            abilityGeneratorForm.Show();
            //close this form
            this.Hide();
        }

       
        //Generate button generate random name with calling generate names

        private void GenerateButton_Click_1(object sender, EventArgs e)
        {
            GenerateNames();
            Character character = Program.character;

            character.FirstName = FirstName_textbox.Text;
            character.LastName =LastNameTextBox.Text;


         
        }





























        //I made mistake and use them and just comment them here thy are junk.
        //private void GenerateButton_Click(object sender, EventArgs e)
        //private void LastName_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        // private void FirstName_textbox_TextChanged_1(object sender, EventArgs e)
        //private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        //private void FirstName_Label_TextChanged(object sender, EventArgs e)

        //private void LastNameTextBox_TextChanged(object sender, EventArgs e)

    }
}
