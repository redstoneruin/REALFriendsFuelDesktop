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
            this.raceTimeLabel.Text = "test";
        }
        
        private void raceTimeInput_ValueChanged(object sender, EventArgs e)
        {
            calc.doFuelCalc();
        }

    }
}
