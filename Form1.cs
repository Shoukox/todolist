using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace todo_list
{
    public partial class Form1 : Form
    {
        string path = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\todolist.txt";
        Dictionary<string, string[]> data { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        private void DataToListBoxes()
        {
            string[] undone = data["Undone"];
            string[] done = data["Done"];
            foreach (var item in undone) Undone.Items.Add(item);
            foreach (var item in done) Done.Items.Add(item);
        }

        private void CreateOrRewriteFileIfNotExists()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path, false))
                {
                    sw.Write("{\"Done\":[], \"Undone\": []}");
                }
            }
        }
        private void ReadFromFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                data = JsonConvert.DeserializeObject<Dictionary<string, string[]>>(sr.ReadToEnd());
            }
        }
        private void plus_Click(object sender, EventArgs e)
        {
            if (!Undone.Items.Contains(text.Text) && text.Text.Length > 1)
            {
                Undone.Items.Add(text.Text);
            }
            else
            {
                MessageBox.Show("Такой элемент уже имеется в коллекции!");
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Undone.Items.Remove(Undone.SelectedItem);
        }

        private void RightArrow_Click(object sender, EventArgs e)
        {
            try
            {
                Done.Items.Add(Undone.SelectedItem);
                Undone.Items.Remove(Undone.SelectedItem);
            }
            catch (Exception) { MessageBox.Show("Что-то произошло не так."); }
        }

        private void LeftArrow_Click(object sender, EventArgs e)
        {
            try
            {
                Undone.Items.Add(Done.SelectedItem);
                Done.Items.Remove(Done.SelectedItem);
            }
            catch (Exception) { MessageBox.Show("Что-то произошло не так."); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateOrRewriteFileIfNotExists();
            ReadFromFile();
            DataToListBoxes();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            data["Undone"] = Undone.Items.OfType<string>().ToArray();
            data["Done"] = Done.Items.OfType<string>().ToArray();
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.Write(JsonConvert.SerializeObject(data));
            }
        }
    }
}
