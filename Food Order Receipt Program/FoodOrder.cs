using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: James Wharton
 * Assn: Chapter 12 Labs p2
 * This program allows the user to order a sundae and/or a soda,
 * adding toppings and displaying a receipt.
 */

namespace LB1
{
    public partial class FormFoodOrder : Form
    {
        public FormFoodOrder()
        {
            InitializeComponent();
        }
        // Initialize Globals
        string receipt = "";
        double price = 0.00;

        // Adding the selected items with toppings or mixins to order
        private void button1_Click(object sender, EventArgs e)
        {
            bool sundaeOrdered = false;
            bool sodaOrdered = false;
            bool keepGoing = true;
            string name = "";
            string transactionReceipt = "";
            // Check to see if the user left the name field empty
            if(textBoxName.Text.Trim() =="")
            {
                keepGoing = false;
                MessageBox.Show("Please enter a name for your order", "NO NAME ENTERED",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxName.Focus();

            }
            else { name = textBoxName.Text; }
            // Check to see if the user has ordered an appropriate amount of toppings
            if(keepGoing)
            {
                keepGoing = countToppings();
                keepGoing = countMixins();
            }

            // Has the user ordered a sundae, a soda, or both?
            if (keepGoing)
            {
                if(checkBoxSundae.Checked)
                {
                    
                    sundaeOrdered = true;
                }
                if(checkBoxSoda.Checked)
                {
                    sodaOrdered = true;
                }
            }
            else
            {
                return;
            }

            transactionReceipt = "\r\n" + name + "\r\n----------------------\r\n";

            // Calculate the price and string for a sundae/soda.
            if (sundaeOrdered)
            {
                transactionReceipt += sundaeInfoGet();
            }
            if (sodaOrdered)
            {
                transactionReceipt += "\r\n" + sodaInfoGet();
            }

            printNewReceipt(transactionReceipt);
        }

        private void printNewReceipt(string transactionReceipt)
        {
            receipt += transactionReceipt + "\r\n";
            labelTotal.Text = "Total: " + price.ToString("c");
            textBoxReceipt.Text = receipt;
            labelMixinError.Visible = false;
            labelToppingsError.Visible = false;
        }

        private bool countToppings()
        {
            int toppingCount = 0;
            if(checkBoxSprinkles.Checked)
            { toppingCount++; }
            if(checkBoxNuts.Checked)
            { toppingCount++; }
            if(checkBoxChocolateSyrup.Checked)
            { toppingCount++; }
            if (toppingCount == 3)
            { 
                labelToppingsError.Visible = true;
                return false;
            }
            else
            {
                return true; 
            }

        }

        private bool countMixins()
        {
            int mixinCount = 0;
            if (checkBoxLime.Checked)
            { mixinCount++; }
            if (checkBoxPeach.Checked)
            { mixinCount++; }
            if (checkBoxMango.Checked)
            { mixinCount++; }
            if (mixinCount > 1)
            {
                labelMixinError.Visible = true;
                return false;
            }
            else
            {
                return true;
            }

        }


        private string sundaeInfoGet()
        {
            Sundae customerSundae = new Sundae();

            if (checkBoxSprinkles.Checked)
            { customerSundae.addToppings(0); }
            if (checkBoxNuts.Checked)
            { customerSundae.addToppings(1); }
            if (checkBoxChocolateSyrup.Checked)
            { customerSundae.addToppings(2); }

            price += customerSundae.GetPrice();
            return customerSundae.ToString();
        }

        private string sodaInfoGet()
        {
            Soda customerSoda = new Soda();

            if (checkBoxLime.Checked)
            { customerSoda.addMixins(0); }
            if (checkBoxPeach.Checked)
            { customerSoda.addMixins(1); }
            if (checkBoxMango.Checked)
            { customerSoda.addMixins(2); }

            price += customerSoda.GetPrice();
            return customerSoda.ToString();
        }
    }
}
