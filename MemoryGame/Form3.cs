using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryGame
{

    public partial class Form3 : Form
    {
        PictureBox firstguess;
        PictureBox secondguess;
        int score = 0;
        bool canclick = false;
        Random rnd = new Random();
        Timer clickTimer = new Timer();
        int time = 100;
        Timer timer = new Timer { Interval = 1000 };

        



        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Out of time");
                    Reset();
                }
                var remaining = TimeSpan.FromSeconds(time);
                label3.Text =time.ToString()+"s";

            };

        }
        private void Reset()
        {
            foreach(var p in pictureBoxes)
            {
                p.Tag = null;
                p.Visible = true;
            }
            hide();
            setRandom();
            time = 100;
            timer.Start();
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }

        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.retina,
                    Properties.Resources.img5,
                    Properties.Resources.img4,
                    Properties.Resources.img3,
                    Properties.Resources.img2,
                    Properties.Resources.img1

                };
            }
        }

    
    private void hide()
        {
            foreach (var p in pictureBoxes)
            {
                p.Image = Properties.Resources.brain1;
                
            }
        }

        private void ClickImage(object sender, EventArgs e)
        {
            if (!canclick) return;

            if (firstguess == null)
            {
                firstguess = (PictureBox)sender;
                firstguess.Image = (Image)firstguess.Tag;

                return;

            }
            else secondguess = (PictureBox)sender;
            secondguess.Image = (Image)secondguess.Tag;


            if (secondguess.Image==firstguess.Image && secondguess!=firstguess)
            {
                this.score += 1;
                label2.Text = score.ToString();

            }
            else
            {
                
                canclick = false;
                clickTimer.Start();
            }
            
            if (Convert.ToInt32(label2.Text)<12) return;
            MessageBox.Show("Win");
            Reset();

        }
        private PictureBox getFreeSlot()
        {
            int num;
            do
            {
                num = rnd.Next(0,pictureBoxes.Count());
            } while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }
        private void setRandom()
        {
            foreach(var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }

        }
        private void tick(object sender, EventArgs e)
        {
            
            clickTimer.Stop();
            firstguess.Image = secondguess.Image = Properties.Resources.brain1;
            firstguess = secondguess = null;
            canclick = true;




        }

        private void start(int time,int interval)
        {
            foreach (var p in pictureBoxes)
            {
                p.Image = Properties.Resources.brain1;

            }
            this.score = 0;
            this.time = time;
            canclick = true;
            setRandom();
            startGameTimer();
            clickTimer.Interval = interval;
            clickTimer.Tick += tick;



        }

        private void button4_Click(object sender, EventArgs e)
        {
            start(100,1500);
            button4.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            start(60,1000);
            button2.Enabled = false;
            button4.Enabled = false;
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            start(30,500);
            button3.Enabled = false;
            button4.Enabled = false;
            button2.Enabled = false;

        }
    }
}

