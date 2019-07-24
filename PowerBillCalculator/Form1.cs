using System;
using CustomerData;
using System.Globalization;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PowerBillCalculator
/* A form that calculates total power bill depending on type of customer and their kWh usage.
   Created by Shanice Talan June 19, 2019. OOSD Spring 2019-CPRG 200*/
{
    public partial class MainForm : Form
    {
        List<Customer> AllCustomers; //make a list for customer objects
        int TotalCusts; //to count how may customers we have
        double AllTotal; //total bill charge for all customer types
        double TotalResidential; //total bill charge for residential customers
        double TotalCommercial; //total bill charge for commercial customers
        double TotalIndustrial; //total bill charge for industrial customers
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        //Default settings when form opens
        {
            //hide the Off-Peak label and input text box by default
            OffPeakBox.Visible = false;
            OffPeakLabel.Visible = false;
            //default values in textboxes
            InputBox.Text = "0";
            OffPeakBox.Text = "0";
            AcctBox.Text = "";
            NameBox.Text = "";
            //select Residential in combobox by default
            DropDown.SelectedItem = "Residential";
            //focus on Account number box on start
            AcctBox.Select();

            //read customer info from txt file and save it on the customer list then display it on listbox
            AllCustomers = Customer.ReadCustomers();
            DisplayCustomers();
        }

        private void DisplayCustomers()
        //Displays all customer info and totals on the form
        {
            //reset list box and all output text boxes for totals
            CustomerList.Items.Clear();
            TotalCusts = 0;
            AllTotal = 0;
            TotalResidential = 0;
            TotalCommercial = 0;
            TotalIndustrial = 0;

            //add each customer to the list box and get all totals
            foreach (Customer c in AllCustomers)
            {
                CustomerList.Items.Add(c);
                TotalCusts++;
                AllTotal += c.Charge;

                //total charges for each customer type
                if (c.Type == 'R')
                {
                    TotalResidential += c.Charge;
                }
                else if (c.Type == 'C')
                {
                    TotalCommercial += c.Charge;
                }
                else
                {
                    TotalIndustrial += c.Charge;
                }
            }

            //output all values to form text boxes
            ResidentialBox.Text = TotalResidential.ToString("c");
            CommercialBox.Text = TotalCommercial.ToString("c");
            IndustrialBox.Text = TotalIndustrial.ToString("c");
            CustomersBox.Text = TotalCusts.ToString();
            TotalBox.Text = AllTotal.ToString("c");
        }

        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        //Detects selection in combobox to show correct controls
        {
            if (DropDown.SelectedItem.ToString() == "Industrial")
            {
                /* if customer type is Industial, show the Off-Peak label and input text box,
                and change Input label text */
                OffPeakBox.Visible = true;
                OffPeakLabel.Visible = true;
                InputLabel.Text = "Peak Hours kWh";
            }
            else
            {
                /* otherwise, if customer type is Residential or Commercial,
                hide the Off-peak label and input text box, and change Input label text */
                OffPeakBox.Visible = false;
                OffPeakLabel.Visible = false;
                InputLabel.Text = "Input kWh";
            }

            //focus on Input box
            InputBox.Select();
        }

        public void CalculateBtn_Click(object sender, EventArgs e)
        /* Calculates the total bill, and shows result in Result text box
           Can also be triggered when Enter key is pressed */
        {
            //validate inputs before assigning then make new customer
            int acct = IsInt(AcctBox);
            string name = IsEmpty(NameBox);
            double kwh = IsWholePositive(InputBox);
            double offpeak = IsWholePositive(OffPeakBox);
            char type = TypeToChar();
            Customer newCust = new Customer(acct, name, type, kwh, offpeak);

            //total bill
            double Total = newCust.CalculateCharge();

            //convert result to string and show it in ResultBox as currency
            ChargeBox.Text = Total.ToString("c");
        }

        private void AddBtn_Click(object sender, EventArgs e)
        //Adds new customer to listbox and writes it on txt file
        {
            //validate inputs before assigning then make new customer
            int acct = IsInt(AcctBox);
            string name = IsEmpty(NameBox);
            double kwh = IsWholePositive(InputBox); 
            double offpeak = IsWholePositive(OffPeakBox);
            double charge = double.Parse(ChargeBox.Text, NumberStyles.Currency);
            char type = TypeToChar();
            Customer newCust = new Customer(acct, name, type, kwh, offpeak);
            newCust.Charge = charge;

            AllCustomers.Add(newCust); //add to the list
            DisplayCustomers(); //redo list box
            newCust.SaveCustomers(AllCustomers); //save info to txt file
        }

        public char TypeToChar()
        //Converts dropdown selection to char
        {
            if (DropDown.SelectedItem.ToString() == "Residential")
            {
                return 'R';
            }
            else if (DropDown.SelectedItem.ToString() == "Commercial")
            {
                return 'C';
            }
            else
            {
                return 'I';
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        //Clears the current input(s) and output
        {
            //resets to default settings as when form loads
            InputBox.Text = "0";
            OffPeakBox.Text = "0";
            AcctBox.Text = "";
            NameBox.Text = "";
            DropDown.SelectedItem = "Residential";
            AcctBox.Select();
            ChargeBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        //Closes the form, can also be triggered when Esc key is pressed
        {
            this.Close();
        }

        public double IsWholePositive(TextBox txtbox)
        /* Validates if input text box is not empty and if it's a whole positive number
        if not, return 0, if yes, return the value from the input text box
        then assign the return value to the input variable */
        {
            //if InputBox is empty or if input is not a whole positive number
            if (txtbox.Text == "" || (Convert.ToDouble(txtbox.Text) < 0) || (Convert.ToDouble(txtbox.Text)%1 !=0))
            {
                MessageBox.Show("Input kWh needs a whole positive number from 0.");
                //assign 0 in the input box and input variable
                txtbox.Text = "0";
                //focus on the box with the invalid value
                txtbox.SelectAll();
                return 0;
            }
            else
            {
                //assign the valid positive number in the input variable
                return Convert.ToDouble(txtbox.Text);
            }
        }

        public int IsInt(TextBox txtbox)
        /* Validates if input text box is not empty and if it's a positive integer
         if not, return 0, if yes, return the value from the input text box
          then assign the return value to the input variable */
        {
            if (txtbox.Text == "" || (Convert.ToDouble(txtbox.Text) < 0) || (Convert.ToDouble(txtbox.Text) % 1 != 0))
            {
                MessageBox.Show("Account Number needs a positive integer from 0.");
                //assign 0 in the input box and input variable
                txtbox.Text = "0";
                //focus on the box with the invalid value
                txtbox.SelectAll();
                return 0;
            }
            else
            {
                //assign the valid positive integer in the input variable
                return Convert.ToInt32(txtbox.Text);
            }

        }

        public string IsEmpty(TextBox txtbox)
        // Validates if input text box is not empty
        {
            if (txtbox.Text == "")
            {
                MessageBox.Show("Customer Name needs to be filled");
                //focus on the box with the invalid value
                txtbox.SelectAll();
                return "";
            }
            else
            {
                return txtbox.Text;
            }
        }
    }
}