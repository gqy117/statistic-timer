namespace StatisticTimer
{
    partial class StatisticTimer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_TimeElapse_Second = new System.Windows.Forms.Label();
            this.lbl_TimeElapse_Min = new System.Windows.Forms.Label();
            this.lbl_TimeElapse_Hour = new System.Windows.Forms.Label();
            this.lbl_Hour = new System.Windows.Forms.Label();
            this.lbl_Second = new System.Windows.Forms.Label();
            this.lbl_Minute = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.timer_Elapse = new System.Windows.Forms.Timer(this.components);
            this.btn_Import = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_TimeElapse_Second
            // 
            this.lbl_TimeElapse_Second.AutoSize = true;
            this.lbl_TimeElapse_Second.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TimeElapse_Second.Location = new System.Drawing.Point(180, 67);
            this.lbl_TimeElapse_Second.Name = "lbl_TimeElapse_Second";
            this.lbl_TimeElapse_Second.Size = new System.Drawing.Size(15, 17);
            this.lbl_TimeElapse_Second.TabIndex = 0;
            this.lbl_TimeElapse_Second.Text = "0";
            // 
            // lbl_TimeElapse_Min
            // 
            this.lbl_TimeElapse_Min.AutoSize = true;
            this.lbl_TimeElapse_Min.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TimeElapse_Min.Location = new System.Drawing.Point(105, 67);
            this.lbl_TimeElapse_Min.Name = "lbl_TimeElapse_Min";
            this.lbl_TimeElapse_Min.Size = new System.Drawing.Size(15, 17);
            this.lbl_TimeElapse_Min.TabIndex = 1;
            this.lbl_TimeElapse_Min.Text = "0";
            // 
            // lbl_TimeElapse_Hour
            // 
            this.lbl_TimeElapse_Hour.AutoSize = true;
            this.lbl_TimeElapse_Hour.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_TimeElapse_Hour.Location = new System.Drawing.Point(37, 67);
            this.lbl_TimeElapse_Hour.Name = "lbl_TimeElapse_Hour";
            this.lbl_TimeElapse_Hour.Size = new System.Drawing.Size(15, 17);
            this.lbl_TimeElapse_Hour.TabIndex = 2;
            this.lbl_TimeElapse_Hour.Text = "0";
            // 
            // lbl_Hour
            // 
            this.lbl_Hour.AutoSize = true;
            this.lbl_Hour.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Hour.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Hour.Location = new System.Drawing.Point(69, 67);
            this.lbl_Hour.Name = "lbl_Hour";
            this.lbl_Hour.Size = new System.Drawing.Size(17, 17);
            this.lbl_Hour.TabIndex = 3;
            this.lbl_Hour.Text = "H";
            // 
            // lbl_Second
            // 
            this.lbl_Second.AutoSize = true;
            this.lbl_Second.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Second.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Second.Location = new System.Drawing.Point(216, 67);
            this.lbl_Second.Name = "lbl_Second";
            this.lbl_Second.Size = new System.Drawing.Size(15, 17);
            this.lbl_Second.TabIndex = 4;
            this.lbl_Second.Text = "S";
            // 
            // lbl_Minute
            // 
            this.lbl_Minute.AutoSize = true;
            this.lbl_Minute.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Minute.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_Minute.Location = new System.Drawing.Point(140, 67);
            this.lbl_Minute.Name = "lbl_Minute";
            this.lbl_Minute.Size = new System.Drawing.Size(20, 17);
            this.lbl_Minute.TabIndex = 5;
            this.lbl_Minute.Text = "M";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(108, 151);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // timer_Elapse
            // 
            this.timer_Elapse.Interval = 1000;
            this.timer_Elapse.Tick += new System.EventHandler(this.timer_Elapse_Tick);
            // 
            // btn_Import
            // 
            this.btn_Import.Location = new System.Drawing.Point(108, 220);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(75, 23);
            this.btn_Import.TabIndex = 7;
            this.btn_Import.Text = "Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // StatisticTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 284);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_Minute);
            this.Controls.Add(this.lbl_Second);
            this.Controls.Add(this.lbl_Hour);
            this.Controls.Add(this.lbl_TimeElapse_Hour);
            this.Controls.Add(this.lbl_TimeElapse_Min);
            this.Controls.Add(this.lbl_TimeElapse_Second);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "StatisticTimer";
            this.Text = "Statistic Timer";
            this.Load += new System.EventHandler(this.StatisticTimer_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatisticTimer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_TimeElapse_Second;
        private System.Windows.Forms.Label lbl_TimeElapse_Min;
        private System.Windows.Forms.Label lbl_TimeElapse_Hour;
        private System.Windows.Forms.Label lbl_Hour;
        private System.Windows.Forms.Label lbl_Second;
        private System.Windows.Forms.Label lbl_Minute;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Timer timer_Elapse;
        private System.Windows.Forms.Button btn_Import;

    }
}

