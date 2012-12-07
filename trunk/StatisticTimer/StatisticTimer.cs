using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using DataBase;
using System.Data.SqlClient;
using System.Configuration;

namespace StatisticTimer
{
    public partial class StatisticTimer : Form
    {

        #region Init
        public StatisticTimer()
        {
            InitializeComponent();
            Watcher_Header = new Stopwatch();
            Status = PlayStatus.Pause;
        }
        private enum PlayStatus
        {
            Start = 0,
            Pause = 1
        }
        private PlayStatus Status;
        private Stopwatch Watcher_Header;
        private Stopwatch Watcher_Detail;

        private int current_StatisticTime_Header = 0;
        private int Current_StatisticTime_Header
        {
            get
            {
                if (current_StatisticTime_Header == 0)
                {
                    current_StatisticTime_Header = Convert.ToInt32(StatisticTimer_Logic.Get_StatisticTime_Header().Rows[0]["ST_Id"].ToString());
                }
                return current_StatisticTime_Header;
            }
        }
        private void Init_Load()
        {
            string ctrl, alt, shift;
            ctrl = "0"; alt = "1"; shift = "0";
            KeyBoardLibrary.KeyBoardHotKey.UnregisterHotKey_All(this.Handle);
            KeyBoardLibrary.KeyBoardHotKey.RegisterHotKey_All(this.Handle, ctrl, alt, shift, "Space");
            current_StatisticTime_Header = 0;
            StatisticTimer_Logic.Insert_StatisticTime_Header();
        }
        private void StatisticTimer_Load(object sender, EventArgs e)
        {
            Init_Load();
        }
        #endregion


        private void Start_Pause_Timer()
        {
            switch (Status)
            {
                case PlayStatus.Start:
                    Pause_Timer();
                    break;
                case PlayStatus.Pause:
                    Start_Timer();
                    break;
            }
        }

        #region Start
        private void Start_Timer()
        {
            Start_Timer_Header();
            Start_Timer_Detail();
        }
        private void Start_Timer_Header()
        {
            Watcher_Header.Start();
            timer_Elapse.Enabled = true;
            this.Status = PlayStatus.Start;
            btn_Start.Text = "Pause";
        }
        private void Start_Timer_Detail()
        {
            this.Watcher_Detail = new Stopwatch();
            this.Watcher_Detail.Start();
        }
        #endregion

        #region Pause
        private void Pause_Timer()
        {
            Pause_Timer_Header();
            Pause_Timer_Detail();
        }
        private void Pause_Timer_Header()
        {
            this.Watcher_Header.Stop();
            timer_Elapse.Enabled = false;
            this.Status = PlayStatus.Pause;
            btn_Start.Text = "Start";
        }
        private void Pause_Timer_Detail()
        {
            StatisticTimer_Logic.Insert_StatisticTime_Detail(this.Current_StatisticTime_Header, this.Watcher_Detail.Elapsed.TotalSeconds);
            this.Watcher_Detail.Stop();
        }
        #endregion
        private void Update_HMS()
        {
            lbl_TimeElapse_Hour.Text = Watcher_Header.Elapsed.Hours.ToString();
            lbl_TimeElapse_Min.Text = Watcher_Header.Elapsed.Minutes.ToString();
            lbl_TimeElapse_Second.Text = Watcher_Header.Elapsed.Seconds.ToString();
        }
        private void Import()
        {
            Pause_Timer_Header();
            StatisticTimer_Logic.Update_StatisticTime_Header(Watcher_Header.Elapsed.Seconds, Watcher_Header.Elapsed.Minutes, Watcher_Header.Elapsed.Hours, this.Current_StatisticTime_Header);
        }


        #region Event
        private void btn_Start_Click(object sender, EventArgs e)
        {
            Start_Pause_Timer();
        }
        private void timer_Elapse_Tick(object sender, EventArgs e)
        {
            Update_HMS();
        }
        private void StatisticTimer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Close_It();
        }
        public void Close_It()
        {
            KeyBoardLibrary.KeyBoardHotKey.UnregisterHotKey_All(Handle);
            Import();
        }
        private void btn_Import_Click(object sender, EventArgs e)
        {
            Import();
        }
        //having registered a hotkey the thread that registered it receives a WM_HOTKEY message upon the keypress which has to be caught by overwriting the WndProc method
        protected override void WndProc(ref Message msg)
        {
            //Listen for operating system messages.
            switch (msg.Msg)
            {
                case KeyBoardLibrary.KeyBoardHotKey.HOTKEY_ID_1:
                    Start_Pause_Timer();
                    break;
            }
            base.WndProc(ref msg);
        }
        #endregion


    }
}
