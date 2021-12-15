using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace FuelCalculator
{
    public partial class MainForm : Form
    {

        private Calculator calc;

        public MainForm(ref Calculator calc)
        {
            InitializeComponent();
            this.calc = calc;
        }
        
        private void raceTimeInput_ValueChanged(object sender, EventArgs e)
        {
            if(this.lapRaceCheckbox.Checked)
            {
                this.calc.raceLaps = (int)this.raceTimeInput.Value;
            } 
            else
            {
                this.calc.raceTime = (int)this.raceTimeInput.Value;
            }
        }

        private void lapTimeInput_TextChanged(object sender, EventArgs e)
        {
            calc.setLapTime(this.lapTimeInput.Text);
        }

        private void maxFuelInput_ValueChanged(object sender, EventArgs e)
        {
            this.calc.maxFuel = (double)this.maxFuelInput.Value;
        }

        private void usageInput_ValueChanged(object sender, EventArgs e)
        {
            this.calc.usage = (double)this.usageInput.Value;
        }

        private void paceLapDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.calc.paceLap = this.paceLapDropdown.SelectedIndex;
        }

        private void lapRaceCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.lapRaceCheckbox.Checked)
            {
                this.raceTimeLabel.Text = "Number of Laps";
            }
            else
            {
                this.raceTimeLabel.Text = "Race Time in Minutes";
            }
        }

        private void extraLapsSlider_ValueChanged(object sender, EventArgs e)
        {
            calc.extraLaps = this.extraLapsSlider.Value / 10.0;

            this.extraLapsLabel.Text = "Extra Laps: " + calc.extraLaps.ToString("0.0");
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            if (!calc.doFuelCalc()) return;

            this.pitStopsDisplay.Text = calc.numStops.ToString();
            this.lastStopFuelDisplay.Text = calc.lastStopFuel.ToString("0.00");
            this.totalFuelDisplay.Text = calc.totalFuel.ToString("0.00");
            this.lapsPerTankDisplay.Text = Math.Floor(calc.lapsPerTank).ToString();

            if(this.lapRaceCheckbox.Checked)
            {
                this.totalLapsLabel.Text = "Race Time";
                this.totalLapsDisplay.Text = calc.raceTime.ToString();
            }
            else
            {
                this.totalLapsLabel.Text = "Total Laps";
                this.totalLapsDisplay.Text = calc.raceLaps.ToString();
            }
            
        }

        
    }
}
