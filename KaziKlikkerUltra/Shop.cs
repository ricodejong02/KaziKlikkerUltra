using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Security.AccessControl;

namespace KaziKlikkerUltra
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        //private const int SaltSize = 8;

        ShopItem Clicker = new ShopItem() { Name = "Klikker", Price = 25, Speed = 1 , Icon = Image.FromFile(Launcher.TexturePack + "Clicker.png")};
        ShopItem Farm = new ShopItem() { Name = "Farm", Price = 100, Speed = 3, Icon = Image.FromFile(Launcher.TexturePack + "Farm.png") };
        ShopItem Mine = new ShopItem() { Name = "Mine", Price = 1000, Speed = 10 };
        ShopItem Factory = new ShopItem() { Name = "Factory", Price = 5000, Speed = 25 };
        ShopItem Company = new ShopItem() { Name = "Company", Price = 10000, Speed = 50 };
        ShopItem Village = new ShopItem() { Name = "Village", Price = 25000, Speed = 100 };
        ShopItem City = new ShopItem() { Name = "City", Price = 50000, Speed = 250, Icon = Image.FromFile(Launcher.TexturePack + "City.png")};
        ShopItem Country = new ShopItem() { Name = "Country", Price = 100000, Raise = 25000, Speed = 500, DiamondPrice = 1 };
        ShopItem Satellite = new ShopItem() { Name = "Satellite", Price = 500000, Speed = 1000, DiamondPrice = 2 };
        ShopItem Moon = new ShopItem() { Name = "Moon", Price = 1000000, Speed = 2500, DiamondPrice = 5 };
        ShopItem Planet = new ShopItem() { Name = "Planet", Price = 2500000, Speed = 5000, DiamondPrice = 10 };
        ShopItem Sun = new ShopItem() { Name = "Sun", Price = 10000000, Speed = 15000, DiamondPrice = 25 };
        ShopItem MilkyWay = new ShopItem() { Name = "Milky Way", Price = 50000000, Speed = 30000, DiamondPrice = 50 };
        ShopItem Universe = new ShopItem() { Name = "Universe", Price = 200000000, Speed = 50000, DiamondPrice = 100 };
        ShopItem Infinity = new ShopItem() { Name = "Infinity", Price = 1000000000, Speed = 100000, DiamondPrice = 200 };
        ShopItem Jesus = new ShopItem() { Name = "Jesus", Price = 5000000000, Speed = 500000, DiamondPrice = 500 };
        ShopItem God = new ShopItem() { Name = "God", Price = 20000000000, Speed = 1000000, DiamondPrice = 750 };
        ShopItem TheMatrix = new ShopItem() { Name = "The Matrix", Price = 50000000000, Speed = 2500000, DiamondPrice = 1500 };
        ShopItem TheForce = new ShopItem() { Name = "The Force", Price = 100000000000, Speed = 5000000, DiamondPrice = 3000 };
        ShopItem TheAnswer = new ShopItem() { Name = "The Answer", Price = 1000000000000, Speed = 10000000, DiamondPrice = 5000 };
        ShopItem DarkEnergy = new ShopItem() { Name = "Dark Energy", Price = 10000000000000, Speed = 100000000, DiamondPrice = 100000 };
    


        public void BuyClicker()
        {
            Clicker.Buy();
        }

        public void BuyFarm()
        {
            Farm.Buy();
        }

        public void BuyMine()
        {
            Mine.Buy();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {
            LoadData();
            //Data.Load();
            Clicker.Buy();
            Clicker.Buy();
            //Clicker.Icon = Image.FromFile(Launcher.TexturePack + "Clicker.png")
            Clicker.Buy();
        }

        public void Save()
        {
            StreamWriter DataSave = new StreamWriter("data/users/" + Launcher.Username + "/shop.kkuf");
            //File.Delete("Data.txt")
            DataSave.WriteLine(Clicker.Name);
            DataSave.WriteLine(Clicker.Price);
            DataSave.WriteLine(Clicker.Speed);
            DataSave.WriteLine(Clicker.Amount);

            DataSave.WriteLine(Farm.Name);
            DataSave.WriteLine(Farm.Price);
            DataSave.WriteLine(Farm.Speed);
            DataSave.WriteLine(Farm.Amount);

            DataSave.WriteLine(Mine.Name);
            DataSave.WriteLine(Mine.Price);
            DataSave.WriteLine(Mine.Speed);
            DataSave.WriteLine(Mine.Amount);

            DataSave.WriteLine(Factory.Name);
            DataSave.WriteLine(Factory.Price);
            DataSave.WriteLine(Factory.Speed);
            DataSave.WriteLine(Factory.Amount);

            DataSave.WriteLine(Company.Name);
            DataSave.WriteLine(Company.Price);
            DataSave.WriteLine(Company.Speed);
            DataSave.WriteLine(Company.Amount);

            DataSave.WriteLine(Village.Name);
            DataSave.WriteLine(Village.Price);
            DataSave.WriteLine(Village.Speed);
            DataSave.WriteLine(Village.Amount);

            DataSave.WriteLine(City.Name);
            DataSave.WriteLine(City.Price);
            DataSave.WriteLine(City.Speed);
            DataSave.WriteLine(City.Amount);

            DataSave.WriteLine(Country.Name);
            DataSave.WriteLine(Country.Price);
            DataSave.WriteLine(Country.Speed);
            DataSave.WriteLine(Country.Amount);

            DataSave.WriteLine(Satellite.Name);
            DataSave.WriteLine(Satellite.Price);
            DataSave.WriteLine(Satellite.Speed);
            DataSave.WriteLine(Satellite.Amount);

            DataSave.WriteLine(Moon.Name);
            DataSave.WriteLine(Moon.Price);
            DataSave.WriteLine(Moon.Speed);
            DataSave.WriteLine(Moon.Amount);

            DataSave.WriteLine(Planet.Name);
            DataSave.WriteLine(Planet.Price);
            DataSave.WriteLine(Planet.Speed);
            DataSave.WriteLine(Planet.Amount);

            DataSave.WriteLine(Sun.Name);
            DataSave.WriteLine(Sun.Price);
            DataSave.WriteLine(Sun.Speed);
            DataSave.WriteLine(Sun.Amount);

            DataSave.WriteLine(MilkyWay.Name);
            DataSave.WriteLine(MilkyWay.Price);
            DataSave.WriteLine(MilkyWay.Speed);
            DataSave.WriteLine(MilkyWay.Amount);

            DataSave.WriteLine(Universe.Name);
            DataSave.WriteLine(Universe.Price);
            DataSave.WriteLine(Universe.Speed);
            DataSave.WriteLine(Universe.Amount);

            DataSave.WriteLine(Infinity.Name);
            DataSave.WriteLine(Infinity.Price);
            DataSave.WriteLine(Infinity.Speed);
            DataSave.WriteLine(Infinity.Amount);

            DataSave.WriteLine(Jesus.Name);
            DataSave.WriteLine(Jesus.Price);
            DataSave.WriteLine(Jesus.Speed);
            DataSave.WriteLine(Jesus.Amount);

            DataSave.WriteLine(God.Name);
            DataSave.WriteLine(God.Price);
            DataSave.WriteLine(God.Speed);
            DataSave.WriteLine(God.Amount);

            DataSave.WriteLine(TheMatrix.Name);
            DataSave.WriteLine(TheMatrix.Price);
            DataSave.WriteLine(TheMatrix.Speed);
            DataSave.WriteLine(TheMatrix.Amount);

            DataSave.WriteLine(TheForce.Name);
            DataSave.WriteLine(TheForce.Price);
            DataSave.WriteLine(TheForce.Speed);
            DataSave.WriteLine(TheForce.Amount);

            DataSave.WriteLine(TheAnswer.Name);
            DataSave.WriteLine(TheAnswer.Price);
            DataSave.WriteLine(TheAnswer.Speed);
            DataSave.WriteLine(TheAnswer.Amount);

            DataSave.WriteLine(DarkEnergy.Name);
            DataSave.WriteLine(DarkEnergy.Price);
            DataSave.WriteLine(DarkEnergy.Speed);
            DataSave.WriteLine(DarkEnergy.Amount);

            // DataSave.sa
            //File.Encrypt("Data.kks");

            DataSave.Close();

        }

        public void LoadData()
        {
            if (File.Exists("data/users/" + Launcher.Username + "/shop.kkuf"))
            {
              //  File.Decrypt("Data.kks");

                StreamReader DataRead = new StreamReader("data/users/" + Launcher.Username + "/shop.kkuf");
                Clicker.Name = DataRead.ReadLine();
                Clicker.Price = Convert.ToDecimal(DataRead.ReadLine());
                Clicker.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Clicker.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Farm.Name = DataRead.ReadLine();
                Farm.Price = Convert.ToDecimal(DataRead.ReadLine());
                Farm.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Farm.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Mine.Name = DataRead.ReadLine();
                Mine.Price = Convert.ToDecimal(DataRead.ReadLine());
                Mine.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Mine.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Factory.Name = DataRead.ReadLine();
                Factory.Price = Convert.ToDecimal(DataRead.ReadLine());
                Factory.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Factory.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Company.Name = DataRead.ReadLine();
                Company.Price = Convert.ToDecimal(DataRead.ReadLine());
                Company.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Company.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Village.Name = DataRead.ReadLine();
                Village.Price = Convert.ToDecimal(DataRead.ReadLine());
                Village.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Village.Amount = Convert.ToDecimal(DataRead.ReadLine());

                City.Name = DataRead.ReadLine();
                City.Price = Convert.ToDecimal(DataRead.ReadLine());
                City.Speed = Convert.ToDecimal(DataRead.ReadLine());
                City.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Country.Name = DataRead.ReadLine();
                Country.Price = Convert.ToDecimal(DataRead.ReadLine());
                Country.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Country.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Satellite.Name = DataRead.ReadLine();
                Satellite.Price = Convert.ToDecimal(DataRead.ReadLine());
                Satellite.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Satellite.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Moon.Name = DataRead.ReadLine();
                Moon.Price = Convert.ToDecimal(DataRead.ReadLine());
                Moon.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Moon.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Planet.Name = DataRead.ReadLine();
                Planet.Price = Convert.ToDecimal(DataRead.ReadLine());
                Planet.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Planet.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Sun.Name = DataRead.ReadLine();
                Sun.Price = Convert.ToDecimal(DataRead.ReadLine());
                Sun.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Sun.Amount = Convert.ToDecimal(DataRead.ReadLine());

                MilkyWay.Name = DataRead.ReadLine();
                MilkyWay.Price = Convert.ToDecimal(DataRead.ReadLine());
                MilkyWay.Speed = Convert.ToDecimal(DataRead.ReadLine());
                MilkyWay.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Universe.Name = DataRead.ReadLine();
                Universe.Price = Convert.ToDecimal(DataRead.ReadLine());
                Universe.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Universe.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Infinity.Name = DataRead.ReadLine();
                Infinity.Price = Convert.ToDecimal(DataRead.ReadLine());
                Infinity.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Infinity.Amount = Convert.ToDecimal(DataRead.ReadLine());

                Jesus.Name = DataRead.ReadLine();
                Jesus.Price = Convert.ToDecimal(DataRead.ReadLine());
                Jesus.Speed = Convert.ToDecimal(DataRead.ReadLine());
                Jesus.Amount = Convert.ToDecimal(DataRead.ReadLine());

                God.Name = DataRead.ReadLine();
                God.Price = Convert.ToDecimal(DataRead.ReadLine());
                God.Speed = Convert.ToDecimal(DataRead.ReadLine());
                God.Amount = Convert.ToDecimal(DataRead.ReadLine());

                TheMatrix.Name = DataRead.ReadLine();
                TheMatrix.Price = Convert.ToDecimal(DataRead.ReadLine());
                TheMatrix.Speed = Convert.ToDecimal(DataRead.ReadLine());
                TheMatrix.Amount = Convert.ToDecimal(DataRead.ReadLine());

                TheForce.Name = DataRead.ReadLine();
                TheForce.Price = Convert.ToDecimal(DataRead.ReadLine());
                TheForce.Speed = Convert.ToDecimal(DataRead.ReadLine());
                TheForce.Amount = Convert.ToDecimal(DataRead.ReadLine());

                TheAnswer.Name = DataRead.ReadLine();
                TheAnswer.Price = Convert.ToDecimal(DataRead.ReadLine());
                TheAnswer.Speed = Convert.ToDecimal(DataRead.ReadLine());
                TheAnswer.Amount = Convert.ToDecimal(DataRead.ReadLine());

                DarkEnergy.Name = DataRead.ReadLine();
                DarkEnergy.Price = Convert.ToDecimal(DataRead.ReadLine());
                DarkEnergy.Speed = Convert.ToDecimal(DataRead.ReadLine());
                DarkEnergy.Amount = Convert.ToDecimal(DataRead.ReadLine());
                DataRead.Close();

               // File.Encrypt("Data.kks");

            }

            else
            {
                MessageBox.Show("shop.kkuf could not be found, don't move or delete shop.kkuf! your data might be lost.");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Launcher.TexturePack + "Clicker.png");
            Farm.Buy();
            label2.Text = Farm.Price.ToString();
            label3.Text = Farm.Amount.ToString();
            label1.Text = Farm.Name.ToString();
        }

        private void Shop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Save();
            Data.Save();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
