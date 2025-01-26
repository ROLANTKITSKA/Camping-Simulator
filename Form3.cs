using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ergasia_Allilepidrasi
{
    public partial class Form3 : Form
    {
        private System.Windows.Forms.Timer energyUpdateTimer;
        private int currentEnergyGenerated;
        private int batteryLevel = 100;
        private int energyConsumption = 15;

        private Form1 parentForm;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
            energyUpdateTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };
            energyUpdateTimer.Tick += EnergyUpdateTimer_Tick;
            energyUpdateTimer.Start();
        }

        private bool messageForBattery = false;
        private bool button1Clicked = false;
        private bool button2Clicked = false;

        private void EnergyUpdateTimer_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            currentEnergyGenerated = random.Next(0, 20); // 0-20 watts 

            batteryLevel = Math.Max(0, Math.Min(100, batteryLevel + currentEnergyGenerated - energyConsumption));

            UpdateEnergyStatus();

            if (batteryLevel <= 20 && messageForBattery == false)
            {
                messageForBattery = true;
                MessageBox.Show("Battery level is low! Consider reducing energy consumption by turning off unnecessary devices or dimming the lights.", "Low Battery Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void UpdateEnergyStatus()
        {
            label2.Text = $"Energy Generated: {currentEnergyGenerated} W";
            label3.Text = $"Battery Level: {batteryLevel}%";
            label4.Text = $"Energy Consumption: {energyConsumption} W";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!button1Clicked)
            {
                energyConsumption = Math.Max(0, energyConsumption - 5);
                button1Clicked = true;
                MessageBox.Show("Unnecessary devices turned off.", "Energy Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("This action has already been performed.", "Action Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!button2Clicked)
            {
                energyConsumption = Math.Max(0, energyConsumption - 2);
                button2Clicked = true;
                MessageBox.Show("Lights dimmed to save energy.", "Energy Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);

                float dimmedIntensity = 5.0f;

                // καλεσε AdjustLightIntensity στην Form1
                parentForm.AdjustLightIntensity(dimmedIntensity);
            }
            else
            {
                MessageBox.Show("This action has already been performed.", "Action Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //οριζουμε την διαδρομη του αρχειου για το online help
                string filePath = "Παρακολούθηση και Εξοικονόμηση Ενέργειας.pdf";
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Δεν ήταν δυνατή η φόρτωση του αρχείου PDF. Σφάλμα: " + ex.Message, "Σφάλμα", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
