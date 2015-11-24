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
        private Button extraBtn = new Button();
        

        Timer tracker = new Timer();

        string TrackerText = "Tracker: ";
        static int i = 0;

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
            this.extraBtn.BackColor = Color.Transparent;
            this.extraBtn.Text = " ";
            this.extraBtn.Location = new System.Drawing.Point(116, 250);
            this.extraBtn.Size = new System.Drawing.Size(23, 23);
            this.Controls.Add(extraBtn);
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
             */
            if (Tracker.Text == "Tracker: 1")
            { btnTracker_1.BackColor = Color.Red; }
            else
            {
                btnTracker_1.BackColor = Color.Transparent;
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

        private void btnTracker_1_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_2_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_3_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_4_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_5_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_6_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_7_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_8_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_9_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_10_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_11_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_12_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_13_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_14_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_15_Click(object sender, EventArgs e)
        {

        }

        private void btnTracker_16_Click(object sender, EventArgs e)
        {

        }

       

        private void btnBass01_Click(object sender, EventArgs e)
        {
            btnBass01.BackColor = Color.Yellow;
        }

        private void btnBass02_Click(object sender, EventArgs e)
        {
            btnBass02.BackColor = Color.Yellow;
        }

        private void btnBass03_Click(object sender, EventArgs e)
        {
            btnBass03.BackColor = Color.Yellow;
        }

        private void btnBass04_Click(object sender, EventArgs e)
        {
            btnBass04.BackColor = Color.Yellow;
        }

        private void btnBass05_Click(object sender, EventArgs e)
        {
            btnBass05.BackColor = Color.Yellow;
        }

        private void btnBass06_Click(object sender, EventArgs e)
        {
            btnBass06.BackColor = Color.Yellow;
        }

        private void btnBass07_Click(object sender, EventArgs e)
        {
            btnBass07.BackColor = Color.Yellow;
        }

        private void btnBass08_Click(object sender, EventArgs e)
        {
            btnBass08.BackColor = Color.Yellow;
        }

        private void btnBass09_Click(object sender, EventArgs e)
        {
            btnBass09.BackColor = Color.Yellow;
        }

        private void btnBass10_Click(object sender, EventArgs e)
        {
            btnBass10.BackColor = Color.Yellow;
        }

        private void btnBass11_Click(object sender, EventArgs e)
        {
            btnBass11.BackColor = Color.Yellow;
        }

        private void btnBass12_Click(object sender, EventArgs e)
        {
            btnBass12.BackColor = Color.Yellow;
        }

        private void btnBass13_Click(object sender, EventArgs e)
        {
            btnBass13.BackColor = Color.Yellow;
        }

        private void btnBass14_Click(object sender, EventArgs e)
        {
            btnBass14.BackColor = Color.Yellow;
        }

        private void btnBass15_Click(object sender, EventArgs e)
        {
            btnBass15.BackColor = Color.Yellow;
        }

        private void btnBass16_Click(object sender, EventArgs e)
        {
            btnBass16.BackColor = Color.Yellow;
        }

        private void btnSnare01_Click(object sender, EventArgs e)
        {
            btnSnare01.BackColor = Color.Yellow;
        }

        private void btnSnare02_Click(object sender, EventArgs e)
        {
            btnSnare02.BackColor = Color.Yellow;
        }

        private void btnSnare03_Click(object sender, EventArgs e)
        {
            btnSnare03.BackColor = Color.Yellow;
        }

        private void btnSnare04_Click(object sender, EventArgs e)
        {
            btnSnare04.BackColor = Color.Yellow;
        }

        private void btnSnare05_Click(object sender, EventArgs e)
        {
            btnSnare05.BackColor = Color.Yellow;
        }

        private void btnSnare06_Click(object sender, EventArgs e)
        {
            btnSnare06.BackColor = Color.Yellow;
        }

        private void btnSnare07_Click(object sender, EventArgs e)
        {
            btnSnare07.BackColor = Color.Yellow;
        }

        private void btnSnare08_Click(object sender, EventArgs e)
        {
            btnSnare08.BackColor = Color.Yellow;
        }

        private void btnSnare09_Click(object sender, EventArgs e)
        {
            btnSnare09.BackColor = Color.Yellow;
        }

        private void btnSnare10_Click(object sender, EventArgs e)
        {
            btnSnare10.BackColor = Color.Yellow;
        }

        private void btnSnare11_Click(object sender, EventArgs e)
        {
            btnSnare11.BackColor = Color.Yellow;
        }

        private void btnSnare12_Click(object sender, EventArgs e)
        {
            btnSnare12.BackColor = Color.Yellow;
        }

        private void btnSnare13_Click(object sender, EventArgs e)
        {
            btnSnare13.BackColor = Color.Yellow;
        }

        private void btnSnare14_Click(object sender, EventArgs e)
        {
            btnSnare14.BackColor = Color.Yellow;
        }

        private void btnSnare15_Click(object sender, EventArgs e)
        {
            btnSnare15.BackColor = Color.Yellow;
        }

        private void btnSnare16_Click(object sender, EventArgs e)
        {
            btnSnare16.BackColor = Color.Yellow;
        }

        private void btnCC01_Click(object sender, EventArgs e)
        {
            btnCC01.BackColor = Color.Yellow;
        }

        private void btnCC02_Click(object sender, EventArgs e)
        {
            btnCC02.BackColor = Color.Yellow;
        }

        private void btnCC03_Click(object sender, EventArgs e)
        {
            btnCC03.BackColor = Color.Yellow;
        }

        private void btnCC04_Click(object sender, EventArgs e)
        {
            btnCC04.BackColor = Color.Yellow;
        }

        private void btnCC05_Click(object sender, EventArgs e)
        {
            btnCC05.BackColor = Color.Yellow;
        }

        private void btnCC06_Click(object sender, EventArgs e)
        {
            btnCC06.BackColor = Color.Yellow;
        }

        private void btnCC07_Click(object sender, EventArgs e)
        {
            btnCC07.BackColor = Color.Yellow;
        }

        private void btnCC08_Click(object sender, EventArgs e)
        {
            btnCC08.BackColor = Color.Yellow;
        }

        private void btnCC09_Click(object sender, EventArgs e)
        {
            btnCC09.BackColor = Color.Yellow;
        }

        private void btnCC10_Click(object sender, EventArgs e)
        {
            btnCC10.BackColor = Color.Yellow;
        }

        private void btnCC11_Click(object sender, EventArgs e)
        {
            btnCC11.BackColor = Color.Yellow;
        }

        private void btnCC12_Click(object sender, EventArgs e)
        {
            btnCC12.BackColor = Color.Yellow;
        }

        private void btnCC13_Click(object sender, EventArgs e)
        {
            btnCC13.BackColor = Color.Yellow;
        }

        private void btnCC14_Click(object sender, EventArgs e)
        {
            btnCC14.BackColor = Color.Yellow;
        }

        private void btnCC15_Click(object sender, EventArgs e)
        {
            btnCC15.BackColor = Color.Yellow;
        }

        private void btnCC16_Click(object sender, EventArgs e)
        {
            btnCC16.BackColor = Color.Yellow;
        }

        private void btnHH01_Click(object sender, EventArgs e)
        {
            btnHH01.BackColor = Color.Yellow;
        }

        private void btnHH02_Click(object sender, EventArgs e)
        {
            btnHH02.BackColor = Color.Yellow;
        }

        private void btnHH03_Click(object sender, EventArgs e)
        {
            btnHH03.BackColor = Color.Yellow;
        }

        private void btnHH04_Click(object sender, EventArgs e)
        {
            btnHH04.BackColor = Color.Yellow;
        }

        private void btnHH05_Click(object sender, EventArgs e)
        {
            btnHH05.BackColor = Color.Yellow;
        }

        private void btnHH06_Click(object sender, EventArgs e)
        {
            btnHH06.BackColor = Color.Yellow;
        }

        private void btnHH07_Click(object sender, EventArgs e)
        {
            btnHH07.BackColor = Color.Yellow;
        }

        private void btnHH08_Click(object sender, EventArgs e)
        {
            btnHH08.BackColor = Color.Yellow;
        }

        private void btnHH09_Click(object sender, EventArgs e)
        {
            btnHH09.BackColor = Color.Yellow;
        }

        private void btnHH10_Click(object sender, EventArgs e)
        {
            btnHH10.BackColor = Color.Yellow;
        }

        private void btnHH11_Click(object sender, EventArgs e)
        {
            btnHH11.BackColor = Color.Yellow;
        }

        private void btnHH12_Click(object sender, EventArgs e)
        {
            btnHH12.BackColor = Color.Yellow;
        }

        private void btnHH13_Click(object sender, EventArgs e)
        {
            btnHH13.BackColor = Color.Yellow;
        }

        private void btnHH14_Click(object sender, EventArgs e)
        {
            btnHH14.BackColor = Color.Yellow;
        }

        private void btnHH15_Click(object sender, EventArgs e)
        {
            btnHH15.BackColor = Color.Yellow;
        }

        private void btnHH16_Click(object sender, EventArgs e)
        {
            btnHH16.BackColor = Color.Yellow;
        }

        private void btnCB01_Click(object sender, EventArgs e)
        {
            btnCB01.BackColor = Color.Yellow;
        }

        private void btnCB02_Click(object sender, EventArgs e)
        {
            btnCB02.BackColor = Color.Yellow;
        }

        private void btnCB03_Click(object sender, EventArgs e)
        {
            btnCB03.BackColor = Color.Yellow;
        }

        private void btnCB04_Click(object sender, EventArgs e)
        {
            btnCB04.BackColor = Color.Yellow;
        }

        private void btnCB05_Click(object sender, EventArgs e)
        {
            btnCB05.BackColor = Color.Yellow;
        }

        private void btnCB06_Click(object sender, EventArgs e)
        {
            btnCB06.BackColor = Color.Yellow;
        }

        private void btnCB07_Click(object sender, EventArgs e)
        {
            btnCB07.BackColor = Color.Yellow;
        }

        private void btnCB08_Click(object sender, EventArgs e)
        {
            btnCB08.BackColor = Color.Yellow;
        }

        private void btnCB09_Click(object sender, EventArgs e)
        {
            btnCB09.BackColor = Color.Yellow;
        }

        private void btnCB10_Click(object sender, EventArgs e)
        {
            btnCB10.BackColor = Color.Yellow;
        }

        private void btnCB11_Click(object sender, EventArgs e)
        {
            btnCB11.BackColor = Color.Yellow;
        }

        private void btnCB012_Click(object sender, EventArgs e)
        {
            btnCB012.BackColor = Color.Yellow;
        }

        private void btnCB13_Click(object sender, EventArgs e)
        {
            btnCB13.BackColor = Color.Yellow;
        }

        private void btnCB14_Click(object sender, EventArgs e)
        {
            btnCB14.BackColor = Color.Yellow;
        }

        private void btnCB15_Click(object sender, EventArgs e)
        {
            btnCB15.BackColor = Color.Yellow;
        }

        private void btnCB16_Click(object sender, EventArgs e)
        {
            btnCB16.BackColor = Color.Yellow;
        }

        private void btnLT01_Click(object sender, EventArgs e)
        {
            btnLT01.BackColor = Color.Yellow;
        }

        private void btnLT02_Click(object sender, EventArgs e)
        {
            btnLT02.BackColor = Color.Yellow;
        }

        private void btnLT03_Click(object sender, EventArgs e)
        {
            btnLT03.BackColor = Color.Yellow;
        }

        private void btnLT04_Click(object sender, EventArgs e)
        {
            btnLT04.BackColor = Color.Yellow;
        }

        private void btnLT05_Click(object sender, EventArgs e)
        {
            btnLT05.BackColor = Color.Yellow;
        }

        private void btnLT06_Click(object sender, EventArgs e)
        {
            btnLT06.BackColor = Color.Yellow;
        }

        private void btnLT07_Click(object sender, EventArgs e)
        {
            btnLT07.BackColor = Color.Yellow;
        }

        private void btnLT08_Click(object sender, EventArgs e)
        {
            btnLT08.BackColor = Color.Yellow;
        }

        private void btnLT09_Click(object sender, EventArgs e)
        {
            btnLT09.BackColor = Color.Yellow;
        }

        private void btnLT10_Click(object sender, EventArgs e)
        {
            btnLT10.BackColor = Color.Yellow;
        }

        private void btnLT11_Click(object sender, EventArgs e)
        {
            btnLT11.BackColor = Color.Yellow;
        }

        private void btnLT12_Click(object sender, EventArgs e)
        {
            btnLT12.BackColor = Color.Yellow;
        }

        private void btnLT13_Click(object sender, EventArgs e)
        {
            btnLT13.BackColor = Color.Yellow;
        }

        private void btnLT14_Click(object sender, EventArgs e)
        {
            btnLT14.BackColor = Color.Yellow;
        }

        private void btnLT15_Click(object sender, EventArgs e)
        {
            btnLT15.BackColor = Color.Yellow;
        }

        private void btnLT16_Click(object sender, EventArgs e)
        {
            btnLT16.BackColor = Color.Yellow;
        }

        private void btnMT01_Click(object sender, EventArgs e)
        {
            btnMT01.BackColor = Color.Yellow;
        }

        private void btnMT02_Click(object sender, EventArgs e)
        {
            btnMT02.BackColor = Color.Yellow;
        }

        private void btnMT03_Click(object sender, EventArgs e)
        {
            btnMT03.BackColor = Color.Yellow;
        }

        private void btnMT04_Click(object sender, EventArgs e)
        {
            btnMT04.BackColor = Color.Yellow;
        }

        private void btnMT05_Click(object sender, EventArgs e)
        {
            btnMT05.BackColor = Color.Yellow;
        }

        private void btnMT06_Click(object sender, EventArgs e)
        {
            btnMT06.BackColor = Color.Yellow;
        }

        private void btnMT07_Click(object sender, EventArgs e)
        {
            btnMT07.BackColor = Color.Yellow;
        }

        private void btnMT08_Click(object sender, EventArgs e)
        {
            btnMT08.BackColor = Color.Yellow;
        }

        private void btnMT09_Click(object sender, EventArgs e)
        {
            btnMT09.BackColor = Color.Yellow;
        }

        private void btnMT10_Click(object sender, EventArgs e)
        {
            btnMT10.BackColor = Color.Yellow;
        }

        private void btnMT11_Click(object sender, EventArgs e)
        {
            btnMT11.BackColor = Color.Yellow;
        }

        private void btnMT12_Click(object sender, EventArgs e)
        {
            btnMT12.BackColor = Color.Yellow;
        }

        private void btnMT13_Click(object sender, EventArgs e)
        {
            btnMT13.BackColor = Color.Yellow;
        }

        private void btnMT14_Click(object sender, EventArgs e)
        {
            btnMT14.BackColor = Color.Yellow;
        }

        private void btnMT15_Click(object sender, EventArgs e)
        {
            btnMT15.BackColor = Color.Yellow;
        }

        private void btnMT16_Click(object sender, EventArgs e)
        {
            btnMT16.BackColor = Color.Yellow;
        }

        private void btnHT01_Click(object sender, EventArgs e)
        {
            btnHT01.BackColor = Color.Yellow;
        }

        private void btnHT02_Click(object sender, EventArgs e)
        {
            btnHT02.BackColor = Color.Yellow;
        }

        private void btnHT03_Click(object sender, EventArgs e)
        {
            btnHT03.BackColor = Color.Yellow;
        }

        private void btnHT04_Click(object sender, EventArgs e)
        {
            btnHT04.BackColor = Color.Yellow;
        }

        private void btnHT05_Click(object sender, EventArgs e)
        {
            btnHT05.BackColor = Color.Yellow;
        }

        private void btnHT06_Click(object sender, EventArgs e)
        {
            btnHT06.BackColor = Color.Yellow;
        }

        private void btnHT07_Click(object sender, EventArgs e)
        {
            btnHT07.BackColor = Color.Yellow;
        }

        private void btnHT08_Click(object sender, EventArgs e)
        {
            btnHT08.BackColor = Color.Yellow;
        }

        private void btnHT09_Click(object sender, EventArgs e)
        {
            btnHT09.BackColor = Color.Yellow;
        }

        private void btnHT10_Click(object sender, EventArgs e)
        {
            btnHT10.BackColor = Color.Yellow;
        }

        private void btnHT11_Click(object sender, EventArgs e)
        {
            btnHT11.BackColor = Color.Yellow;
        }

        private void btnHT12_Click(object sender, EventArgs e)
        {
            btnHT12.BackColor = Color.Yellow;
        }

        private void btnHT13_Click(object sender, EventArgs e)
        {
            btnHT13.BackColor = Color.Yellow;
        }

        private void btnHT14_Click(object sender, EventArgs e)
        {
            btnHT14.BackColor = Color.Yellow;
        }

        private void btnHT15_Click(object sender, EventArgs e)
        {
            btnHT15.BackColor = Color.Yellow;
        }

        private void btnHT16_Click(object sender, EventArgs e)
        {
            btnHT16.BackColor = Color.Yellow;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
