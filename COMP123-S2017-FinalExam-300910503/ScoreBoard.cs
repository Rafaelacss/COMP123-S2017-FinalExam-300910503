using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name: Rafaela Silveira
 * Date: August, 17, 2017
 * StudentID: 300910503  
 * Description: PickHighestCard project - Final Test 
 * Version: 0.1 - implemented scoreboard class
 */

namespace COMP123_S2017_FinalExam_300910503
{
    public class ScoreBoard
    {
        //Private variables
        private int _score;
        private int _time;
        private object _timeTextBox;
        private object _finalScoreTextBox;
        private object _scoreTextBox;

        //Properties
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = ScoreTextBox.Text;
            }
        }

        public int Time
        {
            get
            {
                return this._time;
            }
            set
            {
                this._time = TimeTextBox.Text;
            }
        }

        public void UpdateTime()
        {
            TimeTextBox.Text = Convert.ToInt32(TimeTextBox.Text);
            TimeTextBox.Text - 1 = TimeTextBox.Text;
            TimeTextBox.Text = Time;
        }

        public 
    }
}
