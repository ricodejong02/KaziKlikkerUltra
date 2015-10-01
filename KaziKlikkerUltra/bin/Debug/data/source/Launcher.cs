using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace KaziKlikkerUltra
{
    public partial class Launcher : Form
    {
        public static string Username;
        public string latest;

        public Launcher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            if (Directory.Exists("data/" + Username))
            {
                MessageBox.Show("This save already exist.");
            }

            else
            {
                Directory.CreateDirectory("data/" + Username);
                StreamWriter Writer = new StreamWriter("data/" + Username + "/" + "user.kkuf");
                Writer.WriteLine(Username);
                Writer.Close();
                File.Create("data/" + Username + "data.kkuf");
                Shop sh = new Shop();
                sh.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Username = textBox1.Text;
            if (File.Exists("data/" + Username + "/user.kkuf"))
            {
                StreamWriter Writer = new StreamWriter("data/latest.kkuf");
                Writer.WriteLine(Username);
                Writer.Close();
                latest = textBox1.Text;
                //label3.Text = "Latest save: " + latest;
                Shop sh = new Shop();
                sh.Show();
                Data.Load();
            }

            else
            {
                MessageBox.Show("This save does not exist.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                Username = textBox1.Text;
                if (File.Exists("data/" + Username + "/user.kkuf"))
                {
                    Directory.Delete("data/" + Username, true);
                }

                else
                {
                    MessageBox.Show("This save does not exist.");
                }
            }
        }

        private void Launcher_Load(object sender, EventArgs e)
        {
            //if (File.Exists("data/latest.kkuf"))
            //{
            //    StreamReader Reader = new StreamReader("data/latest.kkuf");
            //    latest = Reader.ReadLine();
            //    Reader.Close();
            //    label3.Text = "Latest save: " + latest;
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Old versions may be buggy / uncomplete.");
            MessageBox.Show("To play old versions go to: data/old/");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Old versions may be buggy / uncomplete.");
            MessageBox.Show("To play old versions go to: data/old/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Old versions may be buggy / uncomplete.");
            MessageBox.Show("To play old versions go to: data/old/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Old versions may be buggy / uncomplete.");
            MessageBox.Show("To play old versions go to: data/old/");
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}

