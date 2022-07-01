//Christian Lara
//000983220
//Nov/17/2020
//Nov/05/2020
/*This program Will calculate the price of donuts sold as well as keep a list of the orders made.
 The program uses a combobox to add, remove and clears donuts types.
 The program uses a menu strip foe easy navegation, parse validation and range validation is used to 
 ensure proper user input.*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3333_LaraC_Lab06
{
    public partial class Form1 : Form
    {
        List<int> varDonutList = new List<int>();
        int varTotalDonutsSold = 0;
        int varAvergeDonutsSold = 0;
        double varTotalDonutsSales = 0;
        int varNumberOfDonuts = 0;
        const double DONUT_PRICE = 0.60;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (isValidInt() == true && isValidSelection() == true)
            {
                varDonutList.Add(varNumberOfDonuts);

                varTotalDonutsSold += varNumberOfDonuts;
                totalDonutsSoldLabel.Text = varTotalDonutsSold.ToString();

                varAvergeDonutsSold = varTotalDonutsSold / varDonutList.Count();
                averageDonutsSoldLabel.Text = varAvergeDonutsSold.ToString();

                varTotalDonutsSales = varTotalDonutsSold * DONUT_PRICE;
                totalDonutsSalesLabel.Text = varTotalDonutsSales.ToString("c2");


                numberOfDonutsTextbox.Focus();
                numberOfDonutsTextbox.SelectAll();
                selectTypeComboBox.Text = "";
                selectTypeComboBox.SelectedIndex = -1;
            }
        }

        private void displayDonutListButton_Click(object sender, EventArgs e)
        {
            string listString = "";
            for (int i = 0; i < varDonutList.Count; i++)
            {
                listString += varDonutList[i].ToString() + "\n";
            }
            MessageBox.Show(listString,"Number of Donuts");

            numberOfDonutsTextbox.Text = "";
            numberOfDonutsTextbox.Focus();
        }

        private void clearDonutListButton_Click(object sender, EventArgs e)
        {
            varDonutList.Clear();
            varTotalDonutsSold = 0;
            varAvergeDonutsSold = 0;
            varTotalDonutsSales = 0;
            varNumberOfDonuts = 0;
            totalDonutsSoldLabel.Text = "";
            averageDonutsSoldLabel.Text = "";
            totalDonutsSalesLabel.Text = "";
            numberOfDonutsTextbox.Text = "";
            numberOfDonutsTextbox.Focus();
            selectTypeComboBox.Text = "";
            selectTypeComboBox.SelectedIndex = -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addDonutTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectTypeComboBox.Text == "")
            {
                MessageBox.Show("Enter the donut type");
                selectTypeComboBox.Focus();
            }
            else
            {
                selectTypeComboBox.Items.Add(selectTypeComboBox.Text);
                selectTypeComboBox.Text = "";
            }
        }

        private void removeDonutTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Select a Donut type to be removed");
                selectTypeComboBox.Focus();
            }
            else
            {
                selectTypeComboBox.Items.RemoveAt(selectTypeComboBox.SelectedIndex);
                selectTypeComboBox.Text = "";
            }
        }

        private void clearAllDonutTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectTypeComboBox.Items.Clear();
            selectTypeComboBox.Text = "";
        }

        private void displayDonutTypeCountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectTypeComboBox.Items.Count.ToString());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programmed by: Christian Lara");
        }


        private bool isValidInt()
        {
            if (int.TryParse(numberOfDonutsTextbox.Text, out varNumberOfDonuts))
            {
                if (varNumberOfDonuts > 0)
                {
                    //valid input
                    return true;
                }
                else
                {
                    MessageBox.Show("Number of Donuts must be grater than 0");
                    numberOfDonutsTextbox.Text = "";
                    numberOfDonutsTextbox.Focus();
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Number of Donuts must be numeric.");
                numberOfDonutsTextbox.Text = "";
                numberOfDonutsTextbox.Focus();
                return false;
            }
        }

        private bool isValidSelection()
        {
            if(selectTypeComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a donut type.");
                selectTypeComboBox.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
