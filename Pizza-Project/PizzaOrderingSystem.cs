using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class PizzaOrderingSystem : Form
    {
        public PizzaOrderingSystem()
        {
            InitializeComponent();
        }

        // --- Calculation Functions ---

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            else if (rbMeduim.Checked)
                return Convert.ToSingle(rbMeduim.Tag);
            else
                return Convert.ToSingle(rbLarg.Tag);
        }

        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);
            else
                return Convert.ToSingle(rbThickCrust.Tag);
        }

        float CalcualteToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if (chkExtraCheese.Checked) ToppingsTotalPrice += Convert.ToSingle(chkExtraCheese.Tag);
            if (chkOnion.Checked) ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            if (chckMushrooms.Checked) ToppingsTotalPrice += Convert.ToSingle(chckMushrooms.Tag);
            if (chkOlives.Checked) ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            if (chkTomatoes.Checked) ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);

            return ToppingsTotalPrice;
        }

        float CalcualteTotalPrice()
        {
            return GetSelectedSizePrice() + CalcualteToppingsPrice() + GetSelectedCrustPrice();
        }

        // --- UI Update Functions ---

        void UpdateTotalPrice()
        {
            lblTotalPriceResult.Text = "$" + CalcualteTotalPrice().ToString();
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
            {
                lblReultSize.Text = "Small";
                return;
            }
            if (rbMeduim.Checked)
            {
                lblReultSize.Text = "Meduim";
                return;
            }
            if (rbLarg.Checked)
            {
                lblReultSize.Text = "Larg";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if (chkExtraCheese.Checked) sToppings = "Extra Cheese\n";
            if (chkOnion.Checked) sToppings += ",Onion\n";
            if (chckMushrooms.Checked) sToppings += ",Mushrooms\n";
            if (chkOlives.Checked) sToppings += ",Olives\n";
            if (chkTomatoes.Checked) sToppings += ",Tomatoes\n";

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblResultToppings.Text = sToppings;
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
            {
                lblCrustTypeResult.Text = "Thin Crust";
            }
            else
            {
                lblCrustTypeResult.Text = "ThickCrust";
            }
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEatResult.Text = "Eat In";
            }
            else
            {
                lblWhereToEatResult.Text = "TakeOut";
            }
        }

        void UpdateOrderSummry()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        void ResetForm()
        {
            // Reset Groups
            grpSize.Enabled = true;
            grpToppings.Enabled = true;
            grpCrustType.Enabled = true;
            grpWhereToEat.Enabled = true;

            // Reset Defaults
            rbMeduim.Checked = true;
            rbThinCrust.Checked = true;
            rbEatIn.Checked = true;

            // Reset Toppings
            chkExtraCheese.Checked = false;
            chkOnion.Checked = false;
            chckMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatoes.Checked = false;

            btnOrderPizza.Enabled = true;
            UpdateOrderSummry();
        }

        // --- Form & Controls Events ---

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummry();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e) 
        { 
            UpdateSize();
        }
        private void rbMeduim_CheckedChanged(object sender, EventArgs e) 
        {
            UpdateSize();
        }
        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        { 
            UpdateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e) 
        { 
            UpdateCrust();
        }
        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust(); 
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e) 
        {
            UpdateToppings(); 
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e) 
        {
            UpdateToppings(); 
        }
        private void chckMushrooms_CheckedChanged(object sender, EventArgs e) 
        { 
            UpdateToppings(); 
        }
        private void chkOlives_CheckedChanged(object sender, EventArgs e) 
        {
            UpdateToppings(); 
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings(); 
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void rbTakeOut_CheckedChanged(object sender, EventArgs e) 
        {
            UpdateWhereToEat();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                grpSize.Enabled = false;
                grpToppings.Enabled = false;
                grpCrustType.Enabled = false;
                grpWhereToEat.Enabled = false;
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}