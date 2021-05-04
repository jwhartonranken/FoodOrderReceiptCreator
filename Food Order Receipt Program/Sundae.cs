using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    public class Sundae
    {
        const double BASE_PRICE = 4.50;
        const double TOPPING_PRICE = 0.50;

        double price { get; set; }

        string toppings = "";

        public Sundae()
        {
            this.price = BASE_PRICE;
        }

        enum sundaeToppings
        {
            SPRINKLES,
            NUTS,
            CHOCOLATE_SYRUP
        }
        public void addToppings(int index)
        {
            switch (index)
            {
                case 0:
                    toppings += " " + (sundaeToppings)index + " ";
                    this.price += TOPPING_PRICE;
                    break;
                case 1:
                    toppings += " " + (sundaeToppings)index + " ";
                    this.price += TOPPING_PRICE;
                    break;
                case 2:
                    toppings += " " + (sundaeToppings)index + " ";
                    this.price += TOPPING_PRICE;
                    break;
            }
        }

        public override string ToString()
        {
            string receiptInfo;
            if (toppings.Trim() == "")
            {
                receiptInfo = "Sundae- " + "NONE " + "- " + this.price.ToString("c");
            }
            else
            {
                receiptInfo = "Sundae- " + toppings + "- " + this.price.ToString("c");
            }
            
            return receiptInfo;
        }

        public double GetPrice() => price; 
    }
}
