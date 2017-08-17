using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Rafaela Silveira
 * Date: August, 17, 2017
 * StudentID: 300910503  
 * Description: PickHighestCard project - Final Test 
 * Version: 0.1 - implemented splashform
 */

namespace COMP123_S2017_FinalExam_300910503
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       
        public static PickHighestCardForm pickhighestcardform;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickhighestcardform = new PickHighestCardForm();
            Application.Run(new SplashForm());

        
        }
    }
}
