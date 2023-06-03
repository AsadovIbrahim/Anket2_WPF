using Microsoft.VisualBasic.ApplicationServices;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml;

namespace Anket2
{

    public partial class Form1 : Form
    {
        private List<Person> people { get; set; } = new();
        private static void Write<T>(string filePath, T obj)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static T Read<T>(string filePath)
        {
            try
            {
                string jsonString = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<T>(jsonString);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return default(T);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JSON Files|*.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                Person person = Read<Person>(filePath);
                if (person != null)
                {
                    nameTextBox.Text = person.FirstName;
                    surnameTextBox.Text = person.LastName;
                    emailTextBox.Text = person.Email;
                    phoneTextBox.Text = person.Phone;
                    dateTimePicker1.Value = person.Date;
                }
            }
        }
        private void Change_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Person person = people[listBox1.SelectedIndex];
                Name.Text = person.FirstName;
                Surname.Text = person.LastName;
                Email.Text = person.Email;
                Phone.Text = person.Phone;
                Date.Text = person.Date.ToString();
            }
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Person person = new Person(nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, dateTimePicker1.Value);
            people.Add(person);
            listBox1.Items.Add($"Name:{person.FirstName}");
            listBox1.Items.Add($"Surname:{person.LastName}");
            listBox1.Items.Add($"Email:{person.Email}");
            listBox1.Items.Add($"Phone:{person.Phone}");
            listBox1.Items.Add($"Date:{person.Date}");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folderPath = folderBrowserDialog1.SelectedPath;
                foreach (Person person in people)
                {
                    string filePath = Path.Combine(folderPath, $"{person.FirstName}.json");
                    Write(filePath, person);
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}