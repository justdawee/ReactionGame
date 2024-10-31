using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace TypeReactionApp
{
    public partial class Form1 : Form
    {
        private readonly Random _random = new Random();
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private Timer _countdownTimer;
        private bool _isRunning;
        private int _countdownValue = 3; // Visszaszámlálási idő
        private int _measurementCount;
        private const int MaxMeasurements = 12; // Maximális mérési szám
        private bool _askBeforeOverwrite = true; // Beállítás, hogy kérjen-e megerősítést mentés előtt
        private const string DefaultFileName = "reaction_times.csv"; // Alapértelmezett fájlnév
        
        // Made by @justdawee
        // Lukács Dávid Roland (HHC62Y)
        // 2024.10.31.
        // TypeReactionApp
        // A program célja, hogy mérje a felhasználó reakcióidejét egy véletlenszerűen generált karakterre.
        // A programban lehetőség van a mérési eredmények mentésére és betöltésére is.

        public Form1()
        {
            InitializeComponent();
            InitializeCountdownTimer();
            InitializeContextMenu();
            InitializeMenuEvents();
        }
        
        private void InitializeMenuEvents()
        {
            saveToolStripMenuItem.Click += async (s, e) => await SaveToFile(DefaultFileName); // Alapértelmezett fájlba mentés
            saveAsToolStripMenuItem.Click += async (s, e) => await SaveAs(); // Mentés másként
            loadToolStripMenuItem.Click += async (s, e) => await LoadFromFile(DefaultFileName); // Alapértelmezett fájlból betöltés
            loadFromToolStripMenuItem.Click += async (s, e) => await LoadFromCustomFile(); // Fájlból betöltés
            askBeforeOverwriteToolStripMenuItem.CheckedChanged += ToggleAskBeforeOverwrite; // Megerősítés kérésének be- és kikapcsolása
        }

        private void InitializeCountdownTimer()
        {
            _countdownTimer = new Timer();
            _countdownTimer.Interval = 1000; // 1 másodperc
            _countdownTimer.Tick += CountdownTimer_Tick;
        }

        private void InitializeContextMenu()
        {
            ContextMenuStrip contextMenu = new ContextMenuStrip();
            ToolStripMenuItem deleteItem = new ToolStripMenuItem("Törlés");
            deleteItem.Click += (s, e) => DeleteSelectedItem(); // Kijelölt elem törlése
            contextMenu.Items.Add(deleteItem);
            listBox_reactionTimes.ContextMenuStrip = contextMenu;
        }

        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (_countdownValue > 0)
            {
                label_randomLetter.Text = _countdownValue.ToString();
                _countdownValue--;
            }
            else
            {
                _countdownTimer.Stop();
                label_randomLetter.Text = "Start!";
                _isRunning = true;
                _stopwatch.Start();
                txtBox_reaction.Enabled = true;
                txtBox_reaction.Focus();
                GenerateRandomLetter();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Kilépés az alkalmazásból
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (!_isRunning)
            {
                _measurementCount = 0;
                _countdownValue = 3;
                label_randomLetter.Text = "3";
                txtBox_reaction.Enabled = false;
                listBox_reactionTimes.Items.Clear();
                label_average.Text = "0 ms";
                label_std.Text = "0 ms";
                label_actualMeasurement.Text = $"0/{MaxMeasurements}";
                _stopwatch.Reset();
                btn_Start.Text = "Leállítás";
                _countdownTimer.Start();
            }
            else
            {
                StopMeasurement();
            }
        }

        private void StopMeasurement()
        {
            _isRunning = false;
            _stopwatch.Stop();
            btn_Start.Text = "Indítás";
            label_randomLetter.Text = "-";
        }

        private void GenerateRandomLetter()
        {
            char randomLetter = (char)_random.Next('A', 'Z' + 1);
            label_randomLetter.Text = randomLetter.ToString();
        }

        private void txtBox_reaction_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_measurementCount >= MaxMeasurements) return;

            if (e.KeyChar.ToString().ToUpper() == label_randomLetter.Text)
            {
                _stopwatch.Stop();
                long reactionTime = _stopwatch.ElapsedMilliseconds;
                listBox_reactionTimes.Items.Add($"{reactionTime} ms");

                _measurementCount++;
                label_actualMeasurement.Text = $"{_measurementCount}/{MaxMeasurements}";

                UpdateStatistics();

                if (_measurementCount < MaxMeasurements)
                {
                    GenerateRandomLetter();
                    txtBox_reaction.Clear();
                    _stopwatch.Restart();
                }
                else
                {
                    StopMeasurement();
                }
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

                label_average.Text = $"{average:F0} ms";
                label_std.Text = $"{stdDev:F0} ms";
            }
        }

        private void DeleteSelectedItem()
        {
            if (listBox_reactionTimes.SelectedIndex >= 0)
            {
                listBox_reactionTimes.Items.RemoveAt(listBox_reactionTimes.SelectedIndex);
                UpdateStatistics();
            }
        }

        private void ToggleAskBeforeOverwrite(object sender, EventArgs e)
        {
            _askBeforeOverwrite = !_askBeforeOverwrite;
            ((ToolStripMenuItem)sender).Checked = _askBeforeOverwrite;
        }
        
        private async Task SaveToFile(string fileName)
        {
            if (_askBeforeOverwrite && File.Exists(fileName))
            {
                var result = MessageBox.Show("Biztosan felülírja a próbálkozások listáját?", "Megerősítés", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
            }

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var item in listBox_reactionTimes.Items)
                {
                    await writer.WriteLineAsync(item.ToString());
                }
            }
        }

        private async Task SaveAs()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV fájlok (*.csv)|*.csv";
                saveFileDialog.Title = "Mentés másként";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await SaveToFile(saveFileDialog.FileName);
                }
            }
        }

        private async Task LoadFromFile(string fileName)
        {
            if (!File.Exists(fileName))
            {
                MessageBox.Show("Az alapértelmezett fájl nem található.");
                return;
            }

            listBox_reactionTimes.Items.Clear();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    listBox_reactionTimes.Items.Add(line);
                }
            }

            UpdateStatistics();
        }

        private async Task LoadFromCustomFile()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV fájlok (*.csv)|*.csv";
                openFileDialog.Title = "Fájl betöltése";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await LoadFromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
