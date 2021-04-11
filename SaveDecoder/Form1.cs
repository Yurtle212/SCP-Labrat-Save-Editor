using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleJSON;
using System.Text.Json;
using System.Timers;

namespace SaveDecoder
{
    public partial class Form1 : Form
    {
        string pathToSaves;
        List<string> allSaves;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SaveSelector.Items.Add("");
            pathToSaves = Path.GetFullPath($"{Environment.ExpandEnvironmentVariables("%APPDATA%")}\\..\\LocalLow\\Bezbro Games\\SCP Labrat\\saves");
            saveLocation.Text = pathToSaves;
            getAllSaves();
            SavedText1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string saveData = File.ReadAllText(allSaves[SaveSelector.SelectedIndex]);
            JSONNode node = JSONNode.LoadFromBinaryFile(Path.Combine(allSaves[SaveSelector.SelectedIndex], "newItems.json"));
            SaveText.Text = PrettyJson(node.ToString());
        }

        private void getAllSaves()
        {
            SaveSelector.Items.Clear();
            allSaves = Directory.GetDirectories(pathToSaves).ToList<string>();
            foreach(string save in allSaves.ToList())
            {
                if (File.Exists(Path.Combine(save, "newItems.json")))
                {
                    string tempSaveName = save.Substring(pathToSaves.Length + 1);
                    SaveSelector.Items.Add(tempSaveName);
                }
                else
                {
                    allSaves.Remove(save);
                }
            }
            SaveSelector.SelectedIndex = 0;
        }

        public string PrettyJson(string unPrettyJson)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
                
            };

            var jsonElement = JsonSerializer.Deserialize<JsonElement>(unPrettyJson);

            return JsonSerializer.Serialize(jsonElement, options);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            JSONNode node = JSON.Parse(SaveText.Text);
            node.SaveToBinaryFile(Path.Combine(allSaves[SaveSelector.SelectedIndex], "newItems.json"));
            SavedTextStuff();
        }

        void SavedTextStuff()
        {
            SavedText1.Text = "Saved...";
            wait(1000);
            SavedText1.Text = "";
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        void SaveText_TextChanged(object sender, EventArgs e)
        {

        }

        void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
