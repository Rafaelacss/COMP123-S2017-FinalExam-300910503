using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private TextBox _timeTextBox;
        private TextBox _finalScoreTextBox;
        private TextBox _scoreTextBox;

        //Properties
        public TextBox FinalScoreTextBox
        {
            get
            {
                return this._finalScoreTextBox;
            }
            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int Score
        {
            get
            {
                return this._score;
            }
            set
            {
                ScoreTextBox.Text = Convert.ToString(this._score);
                FinalScoreTextBox.Text = Convert.ToString(this._score);
            }
        }
        public TextBox ScoreTextBox
        {
            get
            {
                return this._scoreTextBox;
            }
            set
            {
                this._scoreTextBox = value;
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
                TimeTextBox.Text = Convert.ToString(this._time);
            }
        }
        public TextBox TimeTextBox
        {
            get
            {
                return this._timeTextBox;
            }
            set
            {
                this._timeTextBox = value;
            }
        }

        //Constructor
        public ScoreBoard(TextBox scoreTextBox, TextBox TimeTextBox, TextBox finalScoreTextBox)
        {

        }

        public void UpdateTime()
        {
            TimeTextBox.Text = Convert.ToInt32(TimeTextBox.Text);
            TimeTextBox.Text - 1 = TimeTextBox.Text;
            TimeTextBox.Text = Time;
        }
    }
}
