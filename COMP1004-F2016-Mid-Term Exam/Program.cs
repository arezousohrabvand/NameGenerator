using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Mid_Term_Exam
{
    public static class Program
    {
        public static SplashForm splashForm;
        public static Character character;
        public static GenerateNameForm generateNameForm;
        public static FinalForm finalForm;


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //intiate splash form
            splashForm = new SplashForm();
            //instantiate  GenerateNameForm
            generateNameForm = new GenerateNameForm();
            //instantiate FinalForm
            finalForm = new FinalForm();
            //instantiate character
            character = new Character();
            //Change the application run to splash form
            Application.Run(new SplashForm());
        }
    }
}
