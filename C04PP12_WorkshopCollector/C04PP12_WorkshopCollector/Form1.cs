using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C04PP12_WorkshopCollector
{
    public partial class Form1 : Form
    {
        //declare constants for all days and fees
        private const decimal HANDLING_STRESS_DAYS = 3;
        private const decimal TIME_MANAGEMENT_DAYS = 3;
        private const decimal SUPERVISION_SKILLS_DAYS = 3;
        private const decimal NEGOTIATION_DAYS = 5;
        private const decimal HOW_INTERVIEW_DAYS = 1;

        private const decimal HANDLING_STRESS_FEE = 1000;
        private const decimal TIME_MANAGEMENT_FEE = 800;
        private const decimal SUPERVISION_SKILLS_FEE = 1500;
        private const decimal NEGOTIATION_FEE = 1300;
        private const decimal HOW_INTERVIEW_FEE = 500;

        private const decimal AUSTIN_LODGING = 150;
        private const decimal CHICAGO_LODGING = 225;
        private const decimal DALLAS_LODGING = 175;
        private const decimal ORLANDO_LODGING = 300;
        private const decimal PHOENIX_LODGING = 175;
        private const decimal RALEIGH_LODGING = 150;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateCost_Click(object sender, EventArgs e)
        {

            if (lstWorkshop.SelectedIndex != -1 && lstLocation.SelectedIndex != -1)
            {
                //get selected workshop and selected location
                string workshop = lstWorkshop.SelectedItem.ToString();
                string location = lstLocation.SelectedItem.ToString();
                decimal workshopDays, workshopFee, lodging; //variables declared to hold values determined by switch statements

                //switch on workshop to determine workshopDays and wokshopFee
                switch (workshop)
                {
                    case "Handling Stress":
                        workshopDays = HANDLING_STRESS_DAYS;
                        workshopFee = HANDLING_STRESS_FEE;
                        break;

                    case "Time Management":
                        workshopDays = TIME_MANAGEMENT_DAYS;
                        workshopFee = TIME_MANAGEMENT_FEE;
                        break;

                    case "Supervision Skills":
                        workshopDays = SUPERVISION_SKILLS_DAYS;
                        workshopFee = SUPERVISION_SKILLS_FEE;
                        break;

                    case "Negotiation":
                        workshopDays = NEGOTIATION_DAYS;
                        workshopFee = NEGOTIATION_FEE;
                        break;

                    case "How to Interview":
                        workshopDays = HOW_INTERVIEW_DAYS;
                        workshopFee = HOW_INTERVIEW_FEE;
                        break;

                    default:
                        workshopDays = 0;
                        workshopFee = 0;
                        break;
                }

                //switch on location to determine lodging
                switch (location)
                {
                    case "Austin":
                        lodging = AUSTIN_LODGING;
                        break;

                    case "Chicago":
                        lodging = CHICAGO_LODGING;
                        break;

                    case "Dallas":
                        lodging = DALLAS_LODGING;
                        break;

                    case "Orlando":
                        lodging = ORLANDO_LODGING;
                        break;

                    case "Phoenix":
                        lodging = PHOENIX_LODGING;
                        break;

                    case "Raleigh":
                        lodging = RALEIGH_LODGING;
                        break;

                    default:
                        lodging = 0;
                        break;
                }

                //calculate costs and display
                decimal lodgingTotal = lodging * workshopDays;
                decimal grandTotal = lodgingTotal + workshopFee;
                lblDisplayCost.Text = $"Registration: {workshopFee:c} \nLodging: {lodgingTotal:c} \nTotal: {grandTotal:c}";
            }
            else
            {
                lblDisplayCost.Text = "Please select a workshop and a location.";
            }
        }
    }
}
