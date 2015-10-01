using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace KaziKlikkerUltra
{
    public class ShopItem
    {
        public string Name;
        public decimal Price;
        //public decimal OrPrice;
        public decimal DiamondPrice;
        public decimal Speed;
        public decimal Amount;
        public decimal Raise;
        public Image Icon;

        public void Buy()
        {
            Price = Math.Round(Price);
            Data.Money -= Price;
            Amount += 1;
            Price += Speed * 5;
            Price = Math.Round(Price);
        }

        public void BuyWithDiamonds()
        {
            Data.Diamonds -= DiamondPrice;
            Amount += 1;
        }
    }
}
