using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeReactionApp
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Stopwatch stopwatch = new Stopwatch();
        private Timer countdownTimer;
        private int countdownValue = 3;
        private bool isRunning = false;
        
        public Form1()
        {
            InitializeComponent();
            InitializeCountdownTimer();
        }
        
        private void InitializeCountdownTimer()
        {
            countdownTimer = new Timer();
            countdownTimer.Interval = 1000; // 1 másodperc
            countdownTimer.Tick += CountdownTimer_Tick;
        }
        
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (countdownValue > 0)
            {
                label_randomLetter.Text = countdownValue.ToString();
                countdownValue--;
            }
            else
            {
                countdownTimer.Stop();
                label_randomLetter.Text = ""; // Töröljük a visszaszámláló szöveget
                GenerateRandomLetter();       // Véletlenszerű betű generálása
                isRunning = true;
                stopwatch.Start();
                txtBox_reaction.Enabled = true;
                txtBox_reaction.Focus();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                // Indítás
                countdownValue = 3;
                label_randomLetter.Text = "3";
                txtBox_reaction.Enabled = false;
                listBox_reactionTimes.Items.Clear();
                label_average.Text = "0 ms";
                label_std.Text = "0 ms";
                stopwatch.Reset();
                btn_Start.Text = "Stop";
                countdownTimer.Start();
            }
            else
            {
                // Leállítás
                isRunning = false;
                stopwatch.Stop();
                btn_Start.Text = "Start";
                label_randomLetter.Text = ""; // vagy alapértelmezett érték
            }
        }
        
        private void GenerateRandomLetter()
        {
            // Véletlenszerű betű kiválasztása A és Z között
            char randomLetter = (char)random.Next('A', 'Z' + 1);
            label_randomLetter.Text = randomLetter.ToString();
        }

        private void txtBox_reaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToUpper() == label_randomLetter.Text)
            {
                stopwatch.Stop();  // Megállítjuk az időzítőt
                long reactionTime = stopwatch.ElapsedMilliseconds;  // Reakcióidő mérése

                // Idő hozzáadása a listához
                listBox_reactionTimes.Items.Add($"{reactionTime} ms");

                UpdateStatistics();

                // Új betű generálása és időzítő újraindítása
                GenerateRandomLetter();
                stopwatch.Restart();
                txtBox_reaction.Clear();
            }
        }

        
        private void UpdateStatistics()
        {
            var times = listBox_reactionTimes.Items.Cast<string>()
                .Select(item => long.Parse(item.Replace(" ms", "")))
                .ToList();

            if (times.Count > 0)
            {
                double average = times.Average();
                double stdDev = Math.Sqrt(times.Average(v => Math.Pow(v - average, 2)));

                label_average.Text = $@"{average:F0} ms";
                label_std.Text = $@"{stdDev:F0} ms";
            }
        }
    }
}
