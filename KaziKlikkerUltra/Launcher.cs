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
        public static string TexturePack = "data/texturepacks/default/";

        public Launcher()
        {
            InitializeComponent();
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            Username = UsernameTxb.Text;
            if (Directory.Exists("data/users/" + Username))
            {
                MessageBox.Show("This save already exist.");
            }

            else
            {
                Directory.CreateDirectory("data/users/" + Username);
                StreamWriter Writer = new StreamWriter("data/users/" + Username + "/user.kkuf");
                Writer.WriteLine(Username);
                Writer.Close();
                File.Create("data/users/" + Username + "/data.kkuf");
                Shop sh = new Shop();
                sh.Show();
            }

            if (TexturePackCkb.Checked == true)
            {
                TexturePack = "data/texturepacks/" + TexturePackTxb.Text + "/";
            }
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            Username = UsernameTxb.Text;
            if (File.Exists("data/users/" + Username + "/user.kkuf"))
            {
                StreamWriter Writer = new StreamWriter("data/users/latest.kkuf");
                Writer.WriteLine(Username);
                Writer.Close();
                latest = UsernameTxb.Text;
                //label3.Text = "Latest save: " + latest;
                Shop sh = new Shop();
                sh.Show();
                Data.Load();
            }

            else
            {
                MessageBox.Show("This save does not exist.");
            }

            if (TexturePackCkb.Checked == true)
            {
                TexturePack = "data/texturepacks/" + TexturePackTxb.Text + "/";
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {            
            Username = UsernameTxb.Text;
            if (File.Exists("data/users/" + Username + "/user.kkuf"))
            {
                Directory.Delete("data/users/" + Username, true);
            }

            else
            {
                MessageBox.Show("This save does not exist.");
            }
            
        }

        private void ExtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OldReleaseBtn_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StreamWriter jemudr = new StreamWriter("data/anticheat/"+ Path.GetRandomFileName());
            jemudr.WriteLine(Path.GetRandomFileName());
            jemudr.Close();
        }
    }
}

