namespace beatmaker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.Tracker = new System.Windows.Forms.Label();
            this.BassDrum = new System.Windows.Forms.Label();
            this.Snare = new System.Windows.Forms.Label();
            this.CrashCymbal = new System.Windows.Forms.Label();
            this.hiHat = new System.Windows.Forms.Label();
            this.CowBell = new System.Windows.Forms.Label();
            this.lowTom = new System.Windows.Forms.Label();
            this.midTom = new System.Windows.Forms.Label();
            this.hiTom = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnTracker_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(668, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(668, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Tracker
            // 
            this.Tracker.AutoSize = true;
            this.Tracker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tracker.Location = new System.Drawing.Point(12, 12);
            this.Tracker.Name = "Tracker";
            this.Tracker.Size = new System.Drawing.Size(73, 17);
            this.Tracker.TabIndex = 5;
            this.Tracker.Text = "Tracker: 1";
            this.Tracker.Click += new System.EventHandler(this.Tracker_Click);
            // 
            // BassDrum
            // 
            this.BassDrum.AutoSize = true;
            this.BassDrum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BassDrum.Location = new System.Drawing.Point(12, 44);
            this.BassDrum.Name = "BassDrum";
            this.BassDrum.Size = new System.Drawing.Size(77, 17);
            this.BassDrum.TabIndex = 6;
            this.BassDrum.Text = "Bass Drum";
            // 
            // Snare
            // 
            this.Snare.AutoSize = true;
            this.Snare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Snare.Location = new System.Drawing.Point(12, 70);
            this.Snare.Name = "Snare";
            this.Snare.Size = new System.Drawing.Size(46, 17);
            this.Snare.TabIndex = 7;
            this.Snare.Text = "Snare";
            // 
            // CrashCymbal
            // 
            this.CrashCymbal.AutoSize = true;
            this.CrashCymbal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CrashCymbal.Location = new System.Drawing.Point(12, 101);
            this.CrashCymbal.Name = "CrashCymbal";
            this.CrashCymbal.Size = new System.Drawing.Size(95, 17);
            this.CrashCymbal.TabIndex = 8;
            this.CrashCymbal.Text = "Crash Cymbal";
            // 
            // hiHat
            // 
            this.hiHat.AutoSize = true;
            this.hiHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hiHat.Location = new System.Drawing.Point(12, 127);
            this.hiHat.Name = "hiHat";
            this.hiHat.Size = new System.Drawing.Size(48, 17);
            this.hiHat.TabIndex = 9;
            this.hiHat.Text = "Hi-Hat";
            // 
            // CowBell
            // 
            this.CowBell.AutoSize = true;
            this.CowBell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CowBell.Location = new System.Drawing.Point(12, 155);
            this.CowBell.Name = "CowBell";
            this.CowBell.Size = new System.Drawing.Size(61, 17);
            this.CowBell.TabIndex = 10;
            this.CowBell.Text = "Cow Bell";
            // 
            // lowTom
            // 
            this.lowTom.AutoSize = true;
            this.lowTom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lowTom.Location = new System.Drawing.Point(12, 182);
            this.lowTom.Name = "lowTom";
            this.lowTom.Size = new System.Drawing.Size(65, 17);
            this.lowTom.TabIndex = 11;
            this.lowTom.Text = "Low Tom";
            // 
            // midTom
            // 
            this.midTom.AutoSize = true;
            this.midTom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.midTom.Location = new System.Drawing.Point(12, 210);
            this.midTom.Name = "midTom";
            this.midTom.Size = new System.Drawing.Size(62, 17);
            this.midTom.TabIndex = 12;
            this.midTom.Text = "Mid Tom";
            // 
            // hiTom
            // 
            this.hiTom.AutoSize = true;
            this.hiTom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.hiTom.Location = new System.Drawing.Point(12, 239);
            this.hiTom.Name = "hiTom";
            this.hiTom.Size = new System.Drawing.Size(69, 17);
            this.hiTom.TabIndex = 13;
            this.hiTom.Text = "High Tom";
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(668, 67);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 146;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnTracker_
            // 
            this.btnTracker_.Location = new System.Drawing.Point(1641, 635);
            this.btnTracker_.Name = "btnTracker_";
            this.btnTracker_.Size = new System.Drawing.Size(23, 23);
            this.btnTracker_.TabIndex = 154;
            this.btnTracker_.Text = " ";
            this.btnTracker_.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(754, 428);
            this.Controls.Add(this.btnTracker_);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.hiTom);
            this.Controls.Add(this.midTom);
            this.Controls.Add(this.lowTom);
            this.Controls.Add(this.CowBell);
            this.Controls.Add(this.hiHat);
            this.Controls.Add(this.CrashCymbal);
            this.Controls.Add(this.Snare);
            this.Controls.Add(this.BassDrum);
            this.Controls.Add(this.Tracker);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label Tracker;
        private System.Windows.Forms.Label BassDrum;
        private System.Windows.Forms.Label Snare;
        private System.Windows.Forms.Label CrashCymbal;
        private System.Windows.Forms.Label hiHat;
        private System.Windows.Forms.Label CowBell;
        private System.Windows.Forms.Label lowTom;
        private System.Windows.Forms.Label midTom;
        private System.Windows.Forms.Label hiTom;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnTracker_;
    }
}

