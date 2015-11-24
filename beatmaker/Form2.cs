using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beatmaker
{
    public partial class Form1 : Form
    { 
        

        /*private Button extraBtn = new Button();
        private Button extraBtn2 = new Button();*/

        Button[] btnsTracker = new Button[16];
        
        

        Timer tracker = new Timer();

        string TrackerText = "Tracker: ";
        int i = 0;

        int[] whichButton = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
        
        static int thisButton = 0;

        public Form1()
        {
            InitializeComponent();

            tracker.Tick += new EventHandler(Tracker_Click);

            tracker.Interval = (250) * (1);

        }

            

        private void Form1_Load(object sender, EventArgs e)
        {
            /*this.extraBtn.BackColor = Color.Transparent;
            this.extraBtn.Text = " ";
            this.extraBtn.Location = new System.Drawing.Point(90, 34);
            this.extraBtn.Size = new System.Drawing.Size(18, 18);
            this.Controls.Add(extraBtn);

            this.extraBtn2.BackColor = Color.Transparent;
            this.extraBtn2.Text = " ";
            this.extraBtn2.Location = new System.Drawing.Point(110, 34);
            this.extraBtn2.Size = new System.Drawing.Size(18, 18);
            this.Controls.Add(extraBtn2);*/

            int horiz = 90;
            int verti = 8;

            for (int c = 0; c < btnsTracker.Length; c++) 
            {
                btnsTracker[c] = new Button();
                btnsTracker[c].Size = new Size(18, 18);
                btnsTracker[c].Location = new Point(horiz, verti);
                btnsTracker[c].BackColor = Color.Transparent;
                horiz += 20;
                this.Controls.Add(btnsTracker[c]);

                
            }
            
        }

        private void Tracker_Click(object sender, EventArgs e)
        {
            Tracker.Text = TrackerText + whichButton[i].ToString();
            i = (i + 1) % 16;

            /* //thisButton will be replaced with different variable
             thisButton = whichButton[thisButton];
             thisButton = (i + 1) % 16;


             if(whichButton == whichButton)
             {
                 whichButton.BackColor = Red;
             }
             else
             {
                 whichButton.BackColor = Transparent;
             }
             
            if (Tracker.Text == "Tracker: 1")
            { btnTracker_1.BackColor = Color.Red; }
            else
            {
                btnTracker_1.BackColor = Color.Transparent;
            }*/

            System.Console.WriteLine(i);

            if (btnsTracker[i].BackColor == Color.Transparent)
            {
                btnsTracker[i].BackColor = Color.Red;
            }
            else
            {
                btnsTracker[i].BackColor = Color.Transparent;
            }
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tracker.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            tracker.Stop();
            Tracker.Text = "Tracker: 1";
            i = 1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btnClear_Click(object sender, EventArgs e)
        {

        }

       

   
    }
}
