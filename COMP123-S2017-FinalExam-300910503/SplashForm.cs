using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    public partial class SplashForm : Form
    {
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickhighestcardform;
            }
    }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();
            Timer.Enabled = false;
        }
    }
}
