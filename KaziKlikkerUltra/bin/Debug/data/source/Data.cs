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

        public static void Load()
        {
            Username = Launcher.Username;
            StreamReader Reader = new StreamReader("data/" + Username + "/data.kkuf");
            Money = Convert.ToDecimal(Reader.ReadLine());
            Diamonds = Convert.ToDecimal(Reader.ReadLine());
            Username = Reader.ReadLine();
            Reader.Close();
        }

        public static void Save()
        {
            Username = Launcher.Username;
            StreamWriter Writer = new StreamWriter("data/" + Username + "/data.kkuf");
            Writer.WriteLine(Money.ToString());
            Writer.WriteLine(Diamonds.ToString());
            Writer.WriteLine(Username);
            Writer.Close();
        }
    }
}
