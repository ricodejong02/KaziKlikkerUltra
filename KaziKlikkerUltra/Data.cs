using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace KaziKlikkerUltra
{
    public class Data
    {
        public static decimal Money = 5;
        public static decimal Diamonds = 10;
        public static string Username;
        public static bool IsLoaded;

        public static void Load()
        {
            IsLoaded = false;
            Username = Launcher.Username;
            StreamReader Reader = new StreamReader("data/users/" + Username + "/data.kkuf");
            Money = Convert.ToDecimal(Reader.ReadLine());
            Diamonds = Convert.ToDecimal(Reader.ReadLine());
            Username = Reader.ReadLine();
            Reader.Close();
            IsLoaded = true;
        }

        public static void Save()
        {
            if (IsLoaded)
            {
                Username = Launcher.Username;
                StreamWriter Writer = new StreamWriter("data/users/" + Username + "/data.kkuf");
                Writer.WriteLine(Money.ToString());
                Writer.WriteLine(Diamonds.ToString());
                Writer.WriteLine(Username);
                Writer.Close();
            }
        }
    }
}
