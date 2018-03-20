using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderThomasA
{
    public partial class frmPizzaOrder : Form
    {
        // Create all constant variables
        const double LARGE = 9.99;
        const double EXTRA_LARGE = 12.99;
        const double EXTRA_EXTRA_LARGE = 15.99;
        const double ONE_TOPPING = 0.75;
        const double TWO_TOPPING = 1.35;
        const double THREE_TOPPING = 2.15;
        const double FOUR_TOPPING = 2.75;
        const double ZERO_DRINK = 0;
        const double ONE_DRINK = 0.99;
        const double TWO_DRINK = 1.8;
        const double DELIVERY_TRUE = 5.99;
        const double DELIVERY_FALSE = 0;
        const double OTTAWA_HST = 0.13;
        const double NEWFOUNDLAND_HST = 0.15;

        // Create all variables
        double PizzaCost;
        double ToppingsCost;
        double DrinkCost;
        double DeliveryCost;
        double Subtotal;
        double HSTCost;
        double Total;

        double CityHST = 0.13;

        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            // If exit button pressed, close the program
            this.Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Set how much pizza will cost
            if (nudPizzaSizeChosen.Text == "1")
            {
                PizzaCost = LARGE;
            }
            else if (nudPizzaSizeChosen.Text == "2")
            {
                PizzaCost = EXTRA_LARGE;
            }
            else
            {
                PizzaCost = EXTRA_EXTRA_LARGE;
            }

            // Set how much the toppings will cost
            if (nudToppingNumberChosen.Text == "1")
            {
                ToppingsCost = ONE_TOPPING;
            }
            else if (nudToppingNumberChosen.Text == "2")
            {
                ToppingsCost = TWO_TOPPING;
            }
            else if (nudToppingNumberChosen.Text == "3")
            {
                ToppingsCost = THREE_TOPPING;
            }
            else
            {
                ToppingsCost = FOUR_TOPPING;
            }

            // Set how much the drinks will cost
            if (nudDrinkAmountChosen.Text == "0")
            {
                DrinkCost = ZERO_DRINK;
            }
            else if (nudDrinkAmountChosen.Text == "1")
            {
                DrinkCost = ONE_DRINK;
            }
            else
            {
                DrinkCost = TWO_DRINK;
            }

            // Set how much the delivery will cost
            if (nudDeliveryOptionChosen.Text == "0")
            {
                DeliveryCost = DELIVERY_FALSE;
            }
            else
            {
                DeliveryCost = DELIVERY_TRUE;
            }

            // Calculate Subtotal
            Subtotal = PizzaCost + ToppingsCost + DrinkCost + DeliveryCost;

            // Calculate HST
            HSTCost = Subtotal * CityHST;

            // Calculate Total
            Total = Subtotal + HSTCost;

            // Display Receipt includig Subtotal, HST, and total
            lblSubtotal.Text = "Subtotal = " + String.Format("${0:0.00}", Subtotal);
            lblHST.Text = "HST = " + String.Format("${0:0.00}", HSTCost);
            lblTotal.Text = "Total = " + String.Format("${0:0.00}", Total);
        }

        private void mniOttawaStore_Click(object sender, EventArgs e)
        {
            CityHST = OTTAWA_HST;
            lblStoreLocation.Text = "Store Location: Ottawa";
        }

        private void mniNewfoundlandStore_Click(object sender, EventArgs e)
        {
            CityHST = NEWFOUNDLAND_HST;
            lblStoreLocation.Text = "Store Location: Newfoundland";
        }
    }
}
