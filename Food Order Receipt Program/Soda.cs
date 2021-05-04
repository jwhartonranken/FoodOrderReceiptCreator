using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1
{
    class Soda
    {
        const double BASE_PRICE = 1.75;
        const double FLAVOR_PRICE = 0.15;

        double price { get; set; }

        string mixins = "";

        public Soda()
        {
            this.price = BASE_PRICE;
        }

        enum sodaFlavor
        {
            LIME,
            PEACH,
            MANGO
        }
        public void addMixins(int index)
        {
            switch (index)
            {
                case 0:
                    mixins += " " + (sodaFlavor)index + " ";
                    this.price += FLAVOR_PRICE;
                    break;
                case 1:
                    mixins += " " + (sodaFlavor)index + " ";
                    this.price += FLAVOR_PRICE;
                    break;
                case 2:
                    mixins += " " + (sodaFlavor)index + " ";
                    this.price += FLAVOR_PRICE;
                    break;
            }
        }

        public override string ToString()
        {
            string receiptInfo;
            if (mixins.Trim() == "")
            {
                receiptInfo = "Soda- " + "NONE " + "- " + this.price.ToString("c");
            }
            else
            {
                receiptInfo = "Soda- " + mixins + "- " + this.price.ToString("c");
            }

            return receiptInfo;
        }

        public double GetPrice() => price;
    }
}
