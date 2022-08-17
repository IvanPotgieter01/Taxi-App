using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taxi_App
{
    public partial class Form1 : Form
    {

        const decimal GPTA = 15.00m;
        const decimal CATA = 14.00m; //Declaring constants
        const decimal ITA = 16.00m;
        const int CAPACITY = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            string name;
            string surname;
            int additional = 0;
            decimal cost = 0m;    //Declaring variales
            int counter = 1;
            string route = "";
            bool notValid = true;
            bool notSelected = true;
            bool notChecked = true;
            decimal totalCost = 0m;

            name = tbName.Text;
            surname = tbSurname.Text;

            if (int.TryParse(TbAdditional.Text, out additional)) //Validating inpur for "Additional Taxis"
            {
                notValid = false;
                additional = int.Parse(TbAdditional.Text);
            }
            else
            {
                notValid = true; //Flag is raised if the user did not input a valid integer
            }

            switch (lboxRoute.SelectedItem)
            {
                case "Promosa":
                    route = "Promosa";
                    notSelected = false;
                    break;
                case "Mohadin":
                    route = "Mohadin";
                    notSelected = false;       //route name is assigned according to selection from list box
                    break;
                case "Ikageng":
                    route = "Ikageng";
                    notSelected = false;
                    break;
                case "Industria":
                    route = "Industria";
                    notSelected = false;
                    break;
                default:
                    notChecked = true; //Flag is raised if route was selected
                    break;
            }

            if (rbGPTA.Checked)
            {
                cost = GPTA * CAPACITY;
                notChecked = false;
            }
            else if (rbITA.Checked)   //Trip calculation considering Taxi Association and number of seats per taxi
            {
                cost = ITA * CAPACITY;
                notChecked = false;
            }
            else if (rbCATA.Checked)
            {
                cost = CATA * CAPACITY;
                notChecked = false;
            }
            else
            {
                notChecked = true; //Flag is raised if no Taxi Association is selected
            }

            if (!notValid)
            {
                if (additional > -1 && additional < 5) //Validating the number of additinal taxis
                {
                    if (!notSelected)
                    {
                        if (!notChecked) //Only executes when the user has input a valid integer between 0 and 4 for the additinal taxis, has selected a route and and taxi association
                        {
                            lboxResult.Items.Add("Operator: " + name + " " + surname);

                            while (counter < additional + 2) //Loops through primary taxi + additional taxis
                            {
                                lboxResult.Items.Add("Varified Taxi " + counter + " on route: " + route + " @ " + cost.ToString("C") + " per trip"); //Output on listbox
                                counter++;
                            }
                            totalCost = cost * (additional + 1); //Caculating total cost
                            lboxResult.Items.Add("A total of " + (additional + 1) + " Taxis have been verified at a total of: " + totalCost.ToString("C")); //Outputting total cost
                        }
                        else
                        {
                            MessageBox.Show("Please select a Taxi Association"); //No Taxi Assiciation selected flag raised
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a route"); //No route selected flag raised
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number of additional taxis (0 - 4)"); //Invalid number of additional taxis flag raised
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid integer of additional taxis"); //Invalid integer for number of taxis flag raised
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbName.Clear();
            tbSurname.Clear();
            TbAdditional.Clear();
            lboxRoute.SelectedIndex = -1; //Clearing all user input for the next operator
            rbGPTA.Checked = true;
            lboxResult.Items.Clear();
            tbName.Focus();
        }
    }
}
