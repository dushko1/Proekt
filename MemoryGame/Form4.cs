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

    public partial class Form4 : Form
    {
        PictureBox firstguess;
        PictureBox secondguess;
        int score = 0;
        bool canclick = false;
        Random rnd = new Random();
        Timer clickTimer ;
        int time = 100;
        Timer timer;
        bool hard = false;
        bool first = true;
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
        }
        private void startGameTimer()
        {
            timer = new Timer { Interval = 1000 };
            timer.Start();
            timer.Tick += delegate
            {
                time--;
                if (time == 0)
                {
                    timer.Stop();
                    MessageBox.Show("Out of time!\n"+"You lose!");
                    enableRestart();
                    var remaining = TimeSpan.FromSeconds(time);


                }
                
                label3.Text =time.ToString()+"s";

            };

        }
        private void Reset()
        {
            foreach(var p in pictureBoxes)
            {
                p.Tag = null;
                p.Enabled = true;
            }
            firstguess = secondguess = null;
            first = true;
            Randomize();
            
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
                    Properties.Resources.batman,
                    Properties.Resources.captainamerica,
                    Properties.Resources.daredevil,
                    Properties.Resources.flash,
                    Properties.Resources.joker,
                    Properties.Resources.ironman,
                    Properties.Resources.superman,
                    Properties.Resources.deathstroke,
                    Properties.Resources.loki,
                    Properties.Resources.Green_Lantern_logo,
                    Properties.Resources.spiderman,
                    Properties.Resources.wolverine,
                    Properties.Resources.blackpanther,
                    Properties.Resources.deadpool,
                    Properties.Resources.hulk,
                    Properties.Resources.teentitans,
                    Properties.Resources.thanos,
                    Properties.Resources.thor


                };
            }
        }
        private void enableRestart()
        {
            easybutton.Enabled = true;
            mediumbutton.Enabled = true;
            hardbutton.Enabled = true;
            label2.Text = "0";
            label3.Text = "0s";
            hard = false;
            disable();


        }


        private void ClickImage(object sender, EventArgs e)
        {
            if (!canclick) return;
            first = false;

            if (firstguess == null)
            {
                firstguess = (PictureBox)sender;
                firstguess.Image = (Image)firstguess.Tag;

                return;

            }
            secondguess = (PictureBox)sender;
            secondguess.Image = (Image)secondguess.Tag;


            if (secondguess.Image==firstguess.Image && secondguess!=firstguess)
            {
                this.score += 1;
                label2.Text = score.ToString();
                secondguess.Enabled = firstguess.Enabled = false;
                firstguess = secondguess = null;

            }
            else
            {
                
                canclick = false;
                clickTimer.Start();
            }
            
            if (Convert.ToInt32(label2.Text)<18) return;
            timer.Stop();
            if(hard) MessageBox.Show("Impressive!");
            else MessageBox.Show("Win");
            
            enableRestart();
            

        }
        private void disable()
        {
            foreach(var p in pictureBoxes)
            {
                p.Enabled = false;
            }
        }
        private PictureBox getEmpty()
        {
            int num;
            do
            {
                num = rnd.Next(0,pictureBoxes.Count());
            } while (pictureBoxes[num].Tag != null);
            return pictureBoxes[num];
        }
        private void Randomize()
        {
            foreach(var image in images)
            {
                getEmpty().Tag = image;
                getEmpty().Tag = image;
            }

        }
        private void tick(object sender, EventArgs e)
        {
            clickTimer.Stop();
            if (!first) firstguess.Image = secondguess.Image = Properties.Resources.riddler;
            firstguess = secondguess = null;
            canclick = true;

        }

        private void start(int time,int interval)
        {
            
            foreach (var p in pictureBoxes)
            {
                p.Image = Properties.Resources.riddler;

            }
            Reset();
            this.score = 0;
            this.time = time;
            canclick = true;
            startGameTimer();
            clickTimer = new Timer();
            clickTimer.Interval = interval;
            clickTimer.Tick += tick;

        }

        private void easyDifficulty(object sender, EventArgs e)
        {
            start(120,1500);
            easybutton.Enabled = false;
            mediumbutton.Enabled = false;
            hardbutton.Enabled = false;

        }

        private void mediumDifficulty(object sender, EventArgs e)
        {
            start(90,1000);
            mediumbutton.Enabled = false;
            easybutton.Enabled = false;
            hardbutton.Enabled = false;

        }

        private void hardDifficulty(object sender, EventArgs e)
        {
            start(60,500);
            hardbutton.Enabled = false;
            easybutton.Enabled = false;
            mediumbutton.Enabled = false;
            hard = true;

        }
    }
}

