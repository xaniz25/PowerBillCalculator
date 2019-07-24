using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;

namespace CustomerData
/* Customer object that has methods to calculate bill charges depending on customer type,
 output customer info as string, save customer info on txt file, and read the same file*/
{
    public class Customer
    {   //public variables to store customer info
        public int AcctNo;
        public string Name;
        public char Type;
        public double Kwh;
        public double OffPeakKwh;

        //all rates for each customer type as constants
        const double BaseKwh = 1000;
        const double ResidentialFlatRate = 6;
        const double ResidentialRate = 0.052;
        const double CommercialFlatRate = 60;
        const double CommercialRate = 0.045;
        const double PeakFlatRate = 76;
        const double PeakRate = 0.065;
        const double OffPeakFlatRate = 40;
        const double OffPeakRate = 0.028;

        ///text file to store Customer info: Account Number, Name, Type & Total Charge
        const string path = "customers.txt";

        //constructors
        public Customer(int acct, string name, char type, double kwh, double offpeak)
        {
            this.AcctNo = acct;
            this.Name = name;
            this.Type = type;
            this.Kwh = kwh;
            this.OffPeakKwh = offpeak;
        }
        public double Charge { get; set; }

        //convert to string to show on listbox
        public override string ToString()
        {
            return "Account: " + AcctNo.ToString() + ", " +
                "Name: " + Name + ", " +
                "Type: " + Type + ", "
                + "Charge: " + Charge.ToString("c") + "\n";
        }

        //calculate charge depending on customer type
        public double CalculateCharge()
        {
            if (Type == 'R') //if Residential
            {
                Charge = Kwh * ResidentialRate + ResidentialFlatRate;
            }
            else if (Type == 'C') //if Commercial
            {
                if (Kwh <= BaseKwh)
                //if input Kwh is lower than 1000kWh, total is just the flat rate
                {
                    Charge = CommercialFlatRate;
                }
                else
                /* otherwise, subtract 1000kWh from input kWh and  multiply it by the Commercial rate,
                then add the Commercial flat rate*/
                {
                    Charge = (Kwh - BaseKwh) * CommercialRate + CommercialFlatRate;
                }
            }
            else if (Type == 'I') //if Industrial
            {
                /* total for Peak kWh:
                subtract 1000kWh from the Peak kWh and multiply it by the Peak rate
                then add Peak flat rate*/
                double peaktotal = (Kwh - BaseKwh) * PeakRate + PeakFlatRate;

                /* total for Off-peak kWh:
                subtract 1000kWh from the Off-peak kWh and multiply it by the Off-peak rate
                then add Off-peak flat rate*/
                double offpeaktotal = (OffPeakKwh - BaseKwh) * OffPeakRate + OffPeakFlatRate;

                if (Kwh <= BaseKwh && OffPeakKwh <= BaseKwh)
                /*if both Peak kWh & Off-peak kWh are less than 1000kWh
                Industrial total is just the peak and off-peak flat rates*/
                {
                    Charge = PeakFlatRate + OffPeakFlatRate;
                }

                else if (Kwh > BaseKwh && OffPeakKwh <= BaseKwh)
                /*if Peak kWh is greater than 1000kWh & Off-peak kWh is less than 1000kWh,
                add Peak total and Off-peak flat rate*/
                {
                    Charge = OffPeakFlatRate + peaktotal;
                }

                else if (Kwh <= BaseKwh && OffPeakKwh > BaseKwh)
                /*if Peak kWh is less than 1000kWh & Off-peak Kwh is greater than 1000kWh,
                add Off-peak total and peak flat rate*/
                {
                    Charge = PeakFlatRate + offpeaktotal;
                }

                //if both Peak kWh and Off-peak kWh is more than 1000kWh, add their totals
                else
                {
                    Charge = peaktotal + offpeaktotal;
                }
            }
            else
                Charge = 0;

            return Charge;
        }

        //read the txt file, get customer info line-by-line, and add it to list of customer objects
        public static List<Customer> ReadCustomers()
        {
            List<Customer> CustomerList = new List<Customer>(); // empty list
            FileStream fs = null;
            StreamReader sr = null;
            string line;
            string[] fields;

            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
            sr = new StreamReader(fs);

            //read each line until it ends
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                fields = line.Split(','); //removing the commas
                //assigning each data in line to each variable and make a customer object
                int account = Convert.ToInt32(fields[0]);
                string name = fields[1];
                char type = Convert.ToChar(fields[2]);
                Customer cust = new Customer(account, name, type, 0, 0);
                cust.Charge = double.Parse(fields[3], NumberStyles.Currency);
                //add customer object to the list
                CustomerList.Add(cust);
            }

            fs.Close(); // close the file
        
            return CustomerList;
        }

        //for each customer objects in the list, get all customer info and save it to txt file
        public void SaveCustomers(List<Customer> list)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            string line;

            fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            //write on txt file, if it doesn't exist create new file
            sw = new StreamWriter(fs);

            foreach (Customer c in list)     // for each product in the list
            {
                line = c.AcctNo.ToString() + "," + c.Name + "," + c.Type.ToString() + "," +
                    c.Charge;  // make a line with data
                sw.WriteLine(line);         // and write it to the file
            }

            sw.Close();
            fs.Close();
        }
    }
}
